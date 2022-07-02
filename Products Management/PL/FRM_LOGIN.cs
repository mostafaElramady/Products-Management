using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_LOGIN : Form
    {

        BL.CLS_LOGIN log = new BL.CLS_LOGIN(); 
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txt_ID.Text, txt_PW.Text);
            if (Dt.Rows.Count > 0)
            {
                FRM_MAIN.getMainForm.المخازنToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.المبيعاتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.المشترياتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.الاعداداتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.fileToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.excuteBackupToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.restpreBackupToolStripMenuItem.Enabled = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
