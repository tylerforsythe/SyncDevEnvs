using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyncDevEnvs.AppCode;

namespace SyncDevEnvs
{
    public partial class frmMain : Form
    {
        public frmMain() {
            InitializeComponent();
        }

        private void btnOverlordGo_Click(object sender, EventArgs e) {
            var overlord = new OverlordCtrl();
            overlord.PerformTasks();
        }
    }
}
