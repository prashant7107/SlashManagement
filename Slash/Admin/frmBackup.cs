using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.Admin
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if(comDrive.SelectedIndex==-1)
            {
                lblStatus.Text = "Status : Select Drive"; 
                return;
            }

            if (txtPassword.Text != "dbslash")
            {
                lblStatus.Text = "Status : Invalid Password";
                return;
            }

                String getdatetime = System.DateTime.Now.ToString("yyyyMMddHHmmss");
                pgProgressBar.Value = 0;
            if (!Directory.Exists(drive + @"\SlashManagemtnSystem_Data"))
            {
                Directory.CreateDirectory(drive + @"\SlashManagemtnSystem_Data");
            }
            try
                {

                    Server dbServer = new Server(new ServerConnection("", "sa", "sa123"));
                    Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = "SEF" };
                   
                    string address = String.Format(drive+@"\SlashManagemtnSystem_Data\dbSef" + getdatetime + ".bak", drive);
                    dbBackup.Devices.AddDevice(address, DeviceType.File);
                    dbBackup.Initialize = true;
                    dbBackup.PercentComplete += dbBackup_percentcomplete;
                    dbBackup.Complete += dbBackup_Complete;
                    dbBackup.SqlBackupAsync(dbServer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }

        private void dbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null) {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void dbBackup_percentcomplete(object sender, PercentCompleteEventArgs e)
        {
            pgProgressBar.Invoke((MethodInvoker)delegate
            {
                pgProgressBar.Value = e.Percent;
                pgProgressBar.Update();
            }
            );
            lblPercentage.Invoke((MethodInvoker)delegate
            {
                lblPercentage.Text = $"{e.Percent}%";
            }
            );
        }

        private string drive;
        private void comDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            drive = comDrive.GetItemText(this.comDrive.SelectedItem);
        }
    }
}
