using System;
using System.Diagnostics;
using System.IO;

namespace SyncDevEnvs.AppCode
{
    public static class CliExecute
    {
        public static void ExecuteScript(string scriptName, string fileTimestamp) {
            string targetDir = Path.Combine(Environment.CurrentDirectory, @"CommandScripts");

            var tmpOutFileName = scriptName.Replace(".bat", "_currently-executing.bat");
            var tmpOutFileFull = Path.Combine(targetDir, tmpOutFileName);
            //File.Copy(Path.Combine(targetDir, scriptName), tmpOutFileFull);

            var dateStamp = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}";
            var dateTimeStamp = $"{dateStamp}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}";
            var allText = File.ReadAllText(Path.Combine(targetDir, scriptName));
            if (!string.IsNullOrEmpty(fileTimestamp))
                allText = allText.Replace("{FILE_TIMESTAMP}", fileTimestamp);
            allText = allText.Replace("{DATE}", dateStamp);
            allText = allText.Replace("{DATETIME}", dateTimeStamp);
            allText = allText.Replace("{SYNC_DIR_PATH}", ConfigSettings.GetSyncDirectoryPath());
            allText = allText.Replace("{TEMP_DIR_PATH}", ConfigSettings.GetTempDirectoryPath());
            File.WriteAllText(tmpOutFileFull, allText);

            var proc = new Process();
            proc.StartInfo.WorkingDirectory = targetDir;
            proc.StartInfo.FileName = tmpOutFileName;
            proc.StartInfo.Arguments = "";
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();


            File.Delete(tmpOutFileFull);
        }
    }
}
