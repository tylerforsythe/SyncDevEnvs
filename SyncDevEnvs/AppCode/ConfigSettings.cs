using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDevEnvs.AppCode
{
    public class ConfigSettings
    {
        public static void ReadConfig() {
            GetSyncDirectoryPath();
            GetTempDirectoryPath();
            IsOverlord();
            IsMinion();
        }

        public static string GetSyncDirectoryPath() {
            var rawValue = GetRawAppSetting("SYNC_DIRECTORY_PATH");
            if (string.IsNullOrEmpty(rawValue))
                throw new Exception("Unable to read config setting SYNC_DIRECTORY_PATH");
            if (!Directory.Exists(rawValue))
                throw new Exception("SYNC_DIRECTORY_PATH does not exist! You must create all levels of " + rawValue);
            return rawValue;
        }

        public static string GetTempDirectoryPath() {
            var rawValue = GetRawAppSetting("TEMP_DIRECTORY_PATH");
            if (string.IsNullOrEmpty(rawValue))
                throw new Exception("Unable to read config setting TEMP_DIRECTORY_PATH");
            if (!Directory.Exists(rawValue))
                throw new Exception("TEMP_DIRECTORY_PATH does not exist! You must create all levels of " + rawValue);
            return rawValue;
        }

        private static string GetRawAppSetting(string keyName) {
            return ConfigurationManager.AppSettings[GetAppSettingKeyFor(keyName)];
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
