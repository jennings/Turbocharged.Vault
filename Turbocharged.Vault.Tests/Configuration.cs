using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbocharged.Vault.Tests
{
    static class Configuration
    {
        public static Uri VaultUri =
            new Uri(Environment.GetEnvironmentVariable("VAULT_ADDR")
                ?? ConfigurationManager.AppSettings["Vault.Uri"]);

        public static string UnsealKey = ConfigurationManager.AppSettings["Vault.UnsealKey"];
        public static string Token = ConfigurationManager.AppSettings["Vault.Token"];
        public static string AppId = ConfigurationManager.AppSettings["Vault.AppId"];
        public static string UserId = ConfigurationManager.AppSettings["Vault.UserId"];
    }
}
