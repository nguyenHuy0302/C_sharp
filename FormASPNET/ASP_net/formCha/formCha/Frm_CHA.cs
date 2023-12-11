using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formCha
{
    public partial class Frm_CHA : Form
    {
        public Frm_CHA()
        {
            InitializeComponent();
        }

        private void btn_CON_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Frm_CON"] == null)
            {
                Frm_CON CON = new Frm_CON();
                CON.MdiParent = this;
                CON.Show();
            }
            else Application.OpenForms["Frm_CON"].Activate();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFormConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CON CON = new Frm_CON();
            CON.MdiParent = this;
            CON.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void btn_CHAU_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Frm_CHAU1"] == null)
            {
                Frm_CHAU chau = new Frm_CHAU();
                chau.MdiParent = this;
                chau.Show();
            }
            else Application.OpenForms["Frm_CHAU1"].Activate();
        }

        private void oenFrmCHAUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CHAU chau = new Frm_CHAU();
            chau.MdiParent = this;
            chau.Show();
        }
    }
}
