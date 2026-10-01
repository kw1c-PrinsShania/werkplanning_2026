using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using T8_Opdracht_Shania_Prins.Controllers;
using T8_Opdracht_Shania_Prins.Models;

/*
    Author:     Shania Prins
    Datum:      20-05-2026

    Subject:    Een werkplanning voor schoolopdrachten
*/

namespace T8_Opdracht_Shania_Prins.Views
{
    public partial class FrmThema : Form
    {
        public FrmThema()
        {
            InitializeComponent();

            vullenThemaOverzicht();

            LvThema.View = View.Details;
            LvThema.FullRowSelect = true;
            LvThema.Columns.Add("ThemaNaam", 150);
        }

        private void vullenThemaOverzicht()
        {
            LvThema.Items.Clear();

            ThemaController ThemaController = new ThemaController();
            List<ThemaModel> themas = ThemaController.Read();
            foreach (ThemaModel thema in themas)
            {
                ListViewItem item = new ListViewItem(thema.ThemaNaam);
                item.Tag = thema;
                LvThema.Items.Add(item);
                LvThema.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTaken frm = new FrmTaken();
            frm.Close();
            FrmModules frmmodules = new FrmModules();
            frmmodules.Close();
        }

        private void btnThema_Click(object sender, EventArgs e)
        {
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
