using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
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
    public partial class FrmTaken : Form
    {
        private TakenController takenController = new TakenController();
        private List<TakenModel> allTaken = new List<TakenModel>();

        public FrmTaken()
        {
            InitializeComponent();

            SetupListView();
            SetupControls();
            LoadTaken();
        }


        // ======================
        // LISTVIEW SETUP
        // ======================
        private void SetupListView()
        {
            LvTaken.View = View.Details;
            LvTaken.FullRowSelect = true;
            LvTaken.GridLines = true;

            LvTaken.Columns.Clear();
            LvTaken.Columns.Add("Taaknaam", 150);
            LvTaken.Columns.Add("Omschrijving", 200);
            LvTaken.Columns.Add("Startdatum", 120);
            LvTaken.Columns.Add("Inleverdatum", 120);
            LvTaken.Columns.Add("Status", 120);
        }

        // ======================
        // CONTROLS SETUP
        // ======================
        private void SetupControls()
        {
            dtpStartdatum.ShowCheckBox = true;
            dtpInleverdatum.ShowCheckBox = true;

            cbStatus.Items.Clear();
            cbStatus.Items.Add("Alle");
            cbStatus.Items.Add("Open");
            cbStatus.Items.Add("Bezig");
            cbStatus.Items.Add("Afgerond");
            cbStatus.SelectedIndex = 0;
        }

        // ======================
        // DATA LOAD (1x DB)
        // ======================
        private void LoadTaken()
        {
            allTaken = takenController.Read();
            ShowTaken(allTaken);
        }

        // ======================
        // LISTVIEW FILL
        // ======================
        private void ShowTaken(List<TakenModel> list)
        {
            LvTaken.Items.Clear();

            foreach (TakenModel taak in list)
            {
                ListViewItem item = new ListViewItem(taak.Taaknaam);
                item.SubItems.Add(taak.Omschrijving);
                item.SubItems.Add(taak.Startdatum.ToShortDateString());
                item.SubItems.Add(taak.Inleverdatum.ToShortDateString());
                item.SubItems.Add(taak.Status);
                item.Tag = taak;

                LvTaken.Items.Add(item);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        { 
        }

        // ======================
        // DELETE
        // ======================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LvTaken.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een taak.");
                return;
            }

            TakenModel taak = (TakenModel)LvTaken.SelectedItems[0].Tag;

            DialogResult result = MessageBox.Show(
                "Weet je zeker dat je deze taak wilt verwijderen?",
                "Bevestigen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                takenController.Delete(taak);
                LoadTaken();
            }
        }

        // ======================
        // NAVIGATION
        // ======================
        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            new FrmModules().Show();
        }

        private void btnThema_Click(object sender, EventArgs e)
        {
            new FrmThema().Show();
        }

        // ======================
        // FILTER (WERKEND)
        // ======================
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            var filtered = allTaken.Where(taak =>
            {
                bool statusMatch =
                    cbStatus.Text == "Alle" ||
                    taak.Status == cbStatus.Text;

                bool startMatch =
                    !dtpStartdatum.Checked ||
                    taak.Startdatum.Date >= dtpStartdatum.Value.Date;

                bool endMatch =
                    !dtpInleverdatum.Checked ||
                    taak.Inleverdatum.Date <= dtpInleverdatum.Value.Date;

                return statusMatch && startMatch && endMatch;
            }).ToList();

            ShowTaken(filtered);
        }
    }
}