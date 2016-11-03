using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDevEnvs.AppCode
{
    public class ConfigSettings
    {
        public static void ReadConfig() {
            GetStatusFileDirectoryPath();
            IsOverlord();
            IsMinion();
        }

        public static string GetStatusFileDirectoryPath() {
            var rawValue = GetRawAppSetting("SYNC_DIRECTORY_PATH");
            if (string.IsNullOrEmpty(rawValue))
                throw new Exception("Unable to read config setting SYNC_DIRECTORY_PATH");
            return rawValue;
        }

        private static string GetRawAppSetting(string keyName) {
            return ConfigurationSettings.AppSettings[GetAppSettingKeyFor(keyName)];
        }
        private static string GetAppSettingKeyFor(string statusFileDirectoryPath) {
            return $"{Environment.MachineName.ToUpper()}.{statusFileDirectoryPath}";
        }

        public static bool IsOverlord() {
            var rawValue = GetRawAppSetting("ROLE");
            if (string.IsNullOrEmpty(rawValue))
                throw new Exception("Unable to read config setting ROLE (overlord)");
            return rawValue == OVERLORD_CONFIG_VALUE;
        }

        public static bool IsMinion() {
            var rawValue = GetRawAppSetting("ROLE");
            if (string.IsNullOrEmpty(rawValue))
                throw new Exception("Unable to read config setting ROLE (minion)");
            return rawValue == MINION_CONFIG_VALUE;
        }

        public const string OVERLORD_CONFIG_VALUE = "OVERLORD";
        public const string MINION_CONFIG_VALUE = "MINION";
    }
}
