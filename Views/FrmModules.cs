using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
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
    public partial class FrmModules : Form
    {
        public FrmModules()
        {
            InitializeComponent();

            LvModule.View = View.Details;
            LvModule.FullRowSelect = true;
            LvModule.Columns.Add("ModuleNaam", 150);
            LvModule.Columns.Add("ThemaNaam", 150);
            LvModule.Columns.Add("Voornaam", 150);
            LvModule.Columns.Add("Tussenvoegsel", 150);
            LvModule.Columns.Add("Achternaam", 150);

            vullenModuleOverzicht();
        }

        private void vullenModuleOverzicht()
        {
            LvModule.Items.Clear();

            ModuleController moduleController = new ModuleController();
            List<ModuleModel> modules = moduleController.Read();
            foreach (ModuleModel module in modules)
            {
                ListViewItem item = new ListViewItem(module.ModuleNaam);
                item.SubItems.Add(module.Thema.ThemaNaam);
                item.SubItems.Add(module.Docent.Voornaam);
                item.SubItems.Add(module.Docent.Tussenvoegsel);
                item.SubItems.Add(module.Docent.Achternaam);
                item.SubItems.Add(module.Docent.Afbeelding);
                item.Tag = module;
                LvModule.Items.Add(item);
                LvModule.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTaken frm = new FrmTaken();
            frm.Close();
            FrmThema frmthema = new FrmThema();
            frmthema.Close();
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LvModule.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een module.");
                return;
            }

            ModuleModel module = (ModuleModel)LvModule.SelectedItems[0].Tag;

            DialogResult result = MessageBox.Show(
                "Weet je zeker dat je deze module wilt verwijderen?",
                "Bevestigen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ModuleController moduleController = new ModuleController();
                    int rows = moduleController.Delete(module);

                    if (rows > 0)
                    {
                        MessageBox.Show("Module verwijderd.");
                        vullenModuleOverzicht();
                    }
                    else
                    {
                        MessageBox.Show("Module niet gevonden.");
                    }
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    // Foreign key constraint (meest voorkomend)
                    if (ex.Number == 547)
                    {
                        MessageBox.Show(
                            "Deze module kan niet verwijderd worden omdat er nog gekoppelde gegevens bestaan.",
                            "Verwijderen niet mogelijk",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database fout: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Onverwachte fout: " + ex.Message);
                }
            }
        }

        private void btnDocent_Click(object sender, EventArgs e)
        {
            if (LvModule.SelectedItems.Count > 0)
            {
                pbDocent.Image = null;

                pbDocent.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "DocentAfbeeldingen/" + (LvModule.SelectedItems[0].SubItems[5].Text)));
            }
            else
            {
                MessageBox.Show("Selecteer eerst een docent");
            }
        }
    }
}
