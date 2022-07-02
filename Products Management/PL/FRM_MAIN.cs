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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN getMainForm
        {
            get
            {
               if (frm ==null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }

        }

        private static void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            this.المخازنToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.الاعداداتToolStripMenuItem.Enabled = false;
            this.المبيعاتToolStripMenuItem.Enabled = false;
            this.المشترياتToolStripMenuItem.Enabled = false;
            this.excuteBackupToolStripMenuItem.Enabled = false;
            this.restpreBackupToolStripMenuItem.Enabled = false;


        }

        private void العملائToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }
    }
}
