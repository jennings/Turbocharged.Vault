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

        public static string UnsealKey =
            Environment.GetEnvironmentVariable("VAULT_UNSEAL_KEY")
            ?? ConfigurationManager.AppSettings["Vault.UnsealKey"];

        public static string Token =
            Environment.GetEnvironmentVariable("VAULT_TOKEN")
            ?? ConfigurationManager.AppSettings["Vault.Token"];

        public static string AppId =
            Environment.GetEnvironmentVariable("VAULT_APPID_APPID")
            ?? ConfigurationManager.AppSettings["Vault.AppId"];

        public static string UserId =
            Environment.GetEnvironmentVariable("VAULT_APPID_USERID")
            ?? ConfigurationManager.AppSettings["Vault.UserId"];
    }
}
