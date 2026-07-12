using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;

namespace Web.Services
{
    public interface ILocalizationService
    {
        string GetString(string key);
        string this[string key] { get; }
    }

    public class LocalizationService : ILocalizationService
    {
        private readonly string _resourcesPath;
        private readonly Dictionary<string, Dictionary<string, string>> _cache = new();

        public LocalizationService(IWebHostEnvironment env)
        {
            _resourcesPath = Path.Combine(env.ContentRootPath, "Resources");
        }

        public string GetString(string key)
        {
            var culture = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLower();
            if (culture != "vi" && culture != "en")
            {
                culture = "vi"; // Default fallback language
            }

            if (!_cache.TryGetValue(culture, out var dictionary))
            {
                dictionary = LoadLanguageFile(culture);
                _cache[culture] = dictionary;
            }

            if (dictionary.TryGetValue(key, out var value))
            {
                return value;
            }

            return key;
        }

        public string this[string key] => GetString(key);

        private Dictionary<string, string> LoadLanguageFile(string culture)
        {
            var filePath = Path.Combine(_resourcesPath, $"{culture}.json");
            if (!File.Exists(filePath))
            {
                return new Dictionary<string, string>();
            }

            try
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
            }
            catch
            {
                return new Dictionary<string, string>();
            }
        }
    }
}
