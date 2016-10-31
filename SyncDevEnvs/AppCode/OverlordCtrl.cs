namespace SyncDevEnvs.AppCode
{
    public class OverlordCtrl
    {
        public void PerformTasks() {
            // perform SQL back
            // wait for it to finish
            // 7z the file to a BT Sync directory
            // output a final "done" file

            // delete original bak file

            CliExecute.ExecuteScript(@"OverlordCommands.bat", "");
        }
    }
}
