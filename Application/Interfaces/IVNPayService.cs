using System;
using System.Collections.Generic;

namespace Application.Interfaces;

public interface IVNPayService
{
    string CreatePaymentUrl(string txnRef, decimal amount, string ipAddress, string returnUrl, string orderInfo);
    bool VerifySignature(Dictionary<string, string> vnpayParams);
    (Guid OrderId, List<Guid> RequestIds) ParseTxnRef(string txnRef);
}
