using System;
using System.IO;

namespace SyncDevEnvs.AppCode
{
    public class MinionCtrl
    {
        public void PerformTasks() {
            // monitor for final "done" file
            // unzip bak file to temp dir
            // perform sql restore
            // grant permissions in SQL

            // delete temp extracted file

            // Look for STATUS file
            // Read contents and strip the COMPLETE portion to get the timestamp name

            var dateStamp = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}";
            var statusFilePath = Path.Combine(@"D:\Sync\BT-GT\SyncDevEnvs_SYNC\", $"STATUS_{dateStamp}.txt");
            if (!File.Exists(statusFilePath))
                return;

            var contents = File.ReadAllText(statusFilePath);
            var fileTimeStamp = contents.Replace("COMPLETE ", "");
            fileTimeStamp = fileTimeStamp.Trim();

            CliExecute.ExecuteScript($"MinionCommands.{Environment.MachineName.ToUpper()}.bat", fileTimeStamp);
        }
    }
}
