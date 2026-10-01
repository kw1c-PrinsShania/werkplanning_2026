namespace T8_Opdracht_Shania_Prins.Views
{
    partial class FrmModules
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
            LvModule = new ListView();
            btnModules = new Button();
            btnTaken = new Button();
            btnThema = new Button();
            btnHome = new Button();
            btnDelete = new Button();
            pbDocent = new PictureBox();
            btnDocent = new Button();
            ((System.ComponentModel.ISupportInitialize)pbDocent).BeginInit();
            SuspendLayout();
            // 
            // LvModule
            // 
            LvModule.BackColor = SystemColors.ScrollBar;
            LvModule.Location = new Point(33, 111);
            LvModule.Margin = new Padding(2);
            LvModule.Name = "LvModule";
            LvModule.Size = new Size(623, 412);
            LvModule.TabIndex = 13;
            LvModule.UseCompatibleStateImageBehavior = false;
            // 
            // btnModules
            // 
            btnModules.BackColor = SystemColors.HighlightText;
            btnModules.FlatStyle = FlatStyle.Flat;
            btnModules.Location = new Point(463, 27);
            btnModules.Margin = new Padding(2);
            btnModules.Name = "btnModules";
            btnModules.Size = new Size(169, 35);
            btnModules.TabIndex = 12;
            btnModules.Text = "Modules";
            btnModules.UseVisualStyleBackColor = false;
            btnModules.Click += btnModules_Click;
            // 
            // btnTaken
            // 
            btnTaken.BackColor = SystemColors.ScrollBar;
            btnTaken.FlatStyle = FlatStyle.Flat;
            btnTaken.Location = new Point(677, 27);
            btnTaken.Margin = new Padding(2);
            btnTaken.Name = "btnTaken";
            btnTaken.Size = new Size(169, 35);
            btnTaken.TabIndex = 11;
            btnTaken.Text = "Taken";
            btnTaken.UseVisualStyleBackColor = false;
            btnTaken.Click += btnTaken_Click;
            // 
            // btnThema
            // 
            btnThema.BackColor = SystemColors.ScrollBar;
            btnThema.FlatStyle = FlatStyle.Flat;
            btnThema.Location = new Point(249, 27);
            btnThema.Margin = new Padding(2);
            btnThema.Name = "btnThema";
            btnThema.Size = new Size(169, 35);
            btnThema.TabIndex = 10;
            btnThema.Text = "Thema‘s";
            btnThema.UseVisualStyleBackColor = false;
            btnThema.Click += btnThema_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ScrollBar;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Location = new Point(33, 27);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(169, 35);
            btnHome.TabIndex = 9;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaptionText;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(677, 111);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 35);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Verwijder";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pbDocent
            // 
            pbDocent.Location = new Point(677, 288);
            pbDocent.Margin = new Padding(2);
            pbDocent.Name = "pbDocent";
            pbDocent.Size = new Size(169, 235);
            pbDocent.SizeMode = PictureBoxSizeMode.CenterImage;
            pbDocent.TabIndex = 15;
            pbDocent.TabStop = false;
            // 
            // btnDocent
            // 
            btnDocent.BackColor = SystemColors.ActiveCaptionText;
            btnDocent.FlatStyle = FlatStyle.Flat;
            btnDocent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDocent.ForeColor = SystemColors.ButtonHighlight;
            btnDocent.Location = new Point(677, 167);
            btnDocent.Margin = new Padding(2);
            btnDocent.Name = "btnDocent";
            btnDocent.Size = new Size(169, 35);
            btnDocent.TabIndex = 16;
            btnDocent.Text = "Toon Docent";
            btnDocent.UseVisualStyleBackColor = false;
            btnDocent.Click += btnDocent_Click;
            // 
            // FrmModules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(884, 557);
            Controls.Add(btnDocent);
            Controls.Add(pbDocent);
            Controls.Add(btnDelete);
            Controls.Add(LvModule);
            Controls.Add(btnModules);
            Controls.Add(btnTaken);
            Controls.Add(btnThema);
            Controls.Add(btnHome);
            Margin = new Padding(2);
            Name = "FrmModules";
            Text = "Modules";
            ((System.ComponentModel.ISupportInitialize)pbDocent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView LvModule;
        private Button btnModules;
        private Button btnTaken;
        private Button btnThema;
        private Button btnHome;
        private Button btnDelete;
        private PictureBox pbDocent;
        private Button btnDocent;
    }
}