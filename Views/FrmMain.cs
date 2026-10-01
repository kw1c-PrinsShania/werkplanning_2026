using System.Drawing.Drawing2D;
using T8_Opdracht_Shania_Prins.Models;
using T8_Opdracht_Shania_Prins.Views;

/*
    Author:     Shania Prins
    Datum:      20-05-2026

    Subject:    Een werkplanning voor schoolopdrachten
*/

namespace FrmMain
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnThema_Click(object sender, EventArgs e)
        {
            FrmThema frm = new FrmThema();
            frm.Show();
        }

        private void btnTaken_Click(object sender, EventArgs e)
        {
            FrmTaken frm = new FrmTaken();
            frm.Show();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            FrmModules frm = new FrmModules();
            frm.Show();
        }

    }
}
