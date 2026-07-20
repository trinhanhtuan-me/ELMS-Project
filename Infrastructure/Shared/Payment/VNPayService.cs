using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Shared.Payment;

public class VNPayService : IVNPayService
{
    private readonly IConfiguration _configuration;

    public VNPayService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string CreatePaymentUrl(string txnRef, decimal amount, string ipAddress, string returnUrl, string orderInfo)
    {
        var vnp_TmnCode = _configuration["VNPay:TmnCode"] ?? "N958PNJF";
        var vnp_HashSecret = _configuration["VNPay:HashSecret"] ?? "ASDFGHJKLQWERTYUIOPZXCVBNM";
        var vnp_Url = _configuration["VNPay:Url"] ?? "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html";

        var vnp_Params = new SortedDictionary<string, string>(StringComparer.Ordinal)
        {
            { "vnp_Version", "2.1.0" },
            { "vnp_Command", "pay" },
            { "vnp_TmnCode", vnp_TmnCode },
            { "vnp_Amount", ((long)(amount * 100)).ToString() },
            { "vnp_CurrCode", "VND" },
            { "vnp_TxnRef", txnRef },
            { "vnp_OrderInfo", orderInfo },
            { "vnp_OrderType", "billpayment" },
            { "vnp_Locale", "vn" },
            { "vnp_ReturnUrl", returnUrl },
            { "vnp_IpAddr", ipAddress },
            { "vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss") }
        };

        var rawData = string.Join("&", vnp_Params.Select(kv => $"{kv.Key}={WebUtility.UrlEncode(kv.Value)}"));
        var secureHash = HmacSha512(vnp_HashSecret, rawData);

        var query = string.Join("&", vnp_Params.Select(kv => $"{kv.Key}={WebUtility.UrlEncode(kv.Value)}")) + $"&vnp_SecureHash={secureHash}";
        return $"{vnp_Url}?{query}";
    }

    public bool VerifySignature(Dictionary<string, string> vnpayParams)
    {
        var vnp_HashSecret = _configuration["VNPay:HashSecret"] ?? "W8A7UHKZTOMPH9O8P7VPQRBWWCKTWVOU";
        
        vnpayParams.TryGetValue("vnp_SecureHash", out var vnp_SecureHash);
        if (string.IsNullOrEmpty(vnp_SecureHash)) return false;

        var sortedParams = new SortedDictionary<string, string>(StringComparer.Ordinal);
        foreach (var kv in vnpayParams)
        {
            if (kv.Key.StartsWith("vnp_") && kv.Key != "vnp_SecureHash" && kv.Key != "vnp_SecureHashType")
            {
                sortedParams.Add(kv.Key, kv.Value);
            }
        }

        var rawData = string.Join("&", sortedParams.Select(kv => $"{kv.Key}={WebUtility.UrlEncode(kv.Value)}"));
        var computedHash = HmacSha512(vnp_HashSecret, rawData);

        return computedHash.Equals(vnp_SecureHash, StringComparison.OrdinalIgnoreCase);
    }

    public (Guid OrderId, List<Guid> RequestIds) ParseTxnRef(string txnRef)
    {
        if (string.IsNullOrEmpty(txnRef) || !txnRef.StartsWith("ORD_"))
            throw new ArgumentException("Mã tham chiếu giao dịch không hợp lệ.");

        try
        {
            var core = txnRef.Substring(4); // Skip "ORD_"
            if (Guid.TryParse(core, out var orderId))
            {
                return (orderId, new List<Guid>());
            }

            var parts = core.Split("_R_");
            orderId = Guid.Parse(parts[0]);

            var reqPart = parts[1].Split('_')[0];
            var requestIds = reqPart.Split('-')
                .Select(Guid.Parse)
                .ToList();

            return (orderId, requestIds);
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Lỗi phân tích mã giao dịch.", ex);
        }
    }

    private static string HmacSha512(string key, string inputData)
    {
        var hash = new StringBuilder();
        var keyBytes = Encoding.UTF8.GetBytes(key);
        var inputBytes = Encoding.UTF8.GetBytes(inputData);
        using (var hmac = new HMACSHA512(keyBytes))
        {
            var hashValue = hmac.ComputeHash(inputBytes);
            foreach (var theByte in hashValue)
            {
                hash.Append(theByte.ToString("x2"));
            }
        }
        return hash.ToString();
    }
}
