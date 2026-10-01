namespace T8_Opdracht_Shania_Prins.Views
{
    partial class FrmTaken
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new Button();
            btnModules = new Button();
            btnTaken = new Button();
            btnThema = new Button();
            btnHome = new Button();
            btnFilter = new Button();
            LvTaken = new ListView();
            cbStatus = new ComboBox();
            dtpStartdatum = new DateTimePicker();
            dtpInleverdatum = new DateTimePicker();
            lStatus = new Label();
            label1 = new Label();
            lStartdatum = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(664, 476);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(235, 35);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModules
            // 
            btnModules.BackColor = SystemColors.ScrollBar;
            btnModules.FlatStyle = FlatStyle.Flat;
            btnModules.Location = new Point(506, 36);
            btnModules.Margin = new Padding(2, 2, 2, 2);
            btnModules.Name = "btnModules";
            btnModules.Size = new Size(169, 35);
            btnModules.TabIndex = 18;
            btnModules.Text = "Modules";
            btnModules.UseVisualStyleBackColor = false;
            btnModules.Click += btnModules_Click;
            // 
            // btnTaken
            // 
            btnTaken.BackColor = SystemColors.HighlightText;
            btnTaken.FlatStyle = FlatStyle.Flat;
            btnTaken.Location = new Point(730, 36);
            btnTaken.Margin = new Padding(2, 2, 2, 2);
            btnTaken.Name = "btnTaken";
            btnTaken.Size = new Size(169, 35);
            btnTaken.TabIndex = 17;
            btnTaken.Text = "Taken";
            btnTaken.UseVisualStyleBackColor = false;
            // 
            // btnThema
            // 
            btnThema.BackColor = SystemColors.ScrollBar;
            btnThema.FlatStyle = FlatStyle.Flat;
            btnThema.Location = new Point(273, 36);
            btnThema.Margin = new Padding(2, 2, 2, 2);
            btnThema.Name = "btnThema";
            btnThema.Size = new Size(169, 35);
            btnThema.TabIndex = 16;
            btnThema.Text = "Thema‘s";
            btnThema.UseVisualStyleBackColor = false;
            btnThema.Click += btnThema_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ScrollBar;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Location = new Point(37, 36);
            btnHome.Margin = new Padding(2, 2, 2, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(169, 35);
            btnHome.TabIndex = 15;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = SystemColors.ActiveCaptionText;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = SystemColors.ButtonHighlight;
            btnFilter.Location = new Point(664, 333);
            btnFilter.Margin = new Padding(2, 2, 2, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(235, 35);
            btnFilter.TabIndex = 24;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click_1;
            // 
            // LvTaken
            // 
            LvTaken.BackColor = SystemColors.ScrollBar;
            LvTaken.Location = new Point(37, 111);
            LvTaken.Margin = new Padding(2, 2, 2, 2);
            LvTaken.Name = "LvTaken";
            LvTaken.Size = new Size(603, 400);
            LvTaken.TabIndex = 25;
            LvTaken.UseCompatibleStateImageBehavior = false;
            LvTaken.View = View.Details;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(664, 133);
            cbStatus.Margin = new Padding(2, 2, 2, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(235, 28);
            cbStatus.TabIndex = 26;
            // 
            // dtpStartdatum
            // 
            dtpStartdatum.Location = new Point(664, 199);
            dtpStartdatum.Margin = new Padding(2, 2, 2, 2);
            dtpStartdatum.Name = "dtpStartdatum";
            dtpStartdatum.Size = new Size(235, 27);
            dtpStartdatum.TabIndex = 27;
            // 
            // dtpInleverdatum
            // 
            dtpInleverdatum.Location = new Point(664, 272);
            dtpInleverdatum.Margin = new Padding(2, 2, 2, 2);
            dtpInleverdatum.Name = "dtpInleverdatum";
            dtpInleverdatum.Size = new Size(235, 27);
            dtpInleverdatum.TabIndex = 28;
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.Location = new Point(664, 111);
            lStatus.Margin = new Padding(2, 0, 2, 0);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(49, 20);
            lStatus.TabIndex = 29;
            lStatus.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(701, 208);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 30;
            // 
            // lStartdatum
            // 
            lStartdatum.AutoSize = true;
            lStartdatum.Location = new Point(664, 177);
            lStartdatum.Margin = new Padding(2, 0, 2, 0);
            lStartdatum.Name = "lStartdatum";
            lStartdatum.Size = new Size(83, 20);
            lStartdatum.TabIndex = 31;
            lStartdatum.Text = "Startdatum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(664, 250);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 32;
            label2.Text = "Inleverdatum";
            // 
            // FrmTaken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(934, 557);
            Controls.Add(label2);
            Controls.Add(lStartdatum);
            Controls.Add(label1);
            Controls.Add(lStatus);
            Controls.Add(dtpInleverdatum);
            Controls.Add(dtpStartdatum);
            Controls.Add(cbStatus);
            Controls.Add(LvTaken);
            Controls.Add(btnFilter);
            Controls.Add(btnDelete);
            Controls.Add(btnModules);
            Controls.Add(btnTaken);
            Controls.Add(btnThema);
            Controls.Add(btnHome);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmTaken";
            Text = "Taken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnModules;
        private Button btnTaken;
        private Button btnThema;
        private Button btnHome;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnFilter;
        private ListView LvTaken;
        private ComboBox cbStatus;
        private ComboBox cb;
        private DateTimePicker dtpStartdatum;
        private DateTimePicker dtpInleverdatum;
        private Label lStatus;
        private Label label1;
        private Label lStartdatum;
        private Label label2;
    }
}