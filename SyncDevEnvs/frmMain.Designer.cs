namespace SyncDevEnvs
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnOverlordGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnOverlordGo
            // 
            this.btnOverlordGo.Location = new System.Drawing.Point(148, 140);
            this.btnOverlordGo.Name = "btnOverlordGo";
            this.btnOverlordGo.Size = new System.Drawing.Size(108, 23);
            this.btnOverlordGo.TabIndex = 0;
            this.btnOverlordGo.Text = "Overlord GO";
            this.btnOverlordGo.UseVisualStyleBackColor = true;
            this.btnOverlordGo.Click += new System.EventHandler(this.btnOverlordGo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 273);
            this.Controls.Add(this.btnOverlordGo);
            this.Name = "frmMain";
            this.Text = "Sync Dev Envs - Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnOverlordGo;
    }
}

