namespace T8_Opdracht_Shania_Prins.Views
{
    partial class FrmThema
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
            btnModules = new Button();
            btnTaken = new Button();
            btnThema = new Button();
            btnHome = new Button();
            LvThema = new ListView();
            SuspendLayout();
            // 
            // btnModules
            // 
            btnModules.BackColor = SystemColors.ScrollBar;
            btnModules.FlatStyle = FlatStyle.Flat;
            btnModules.Location = new Point(445, 31);
            btnModules.Margin = new Padding(2, 2, 2, 2);
            btnModules.Name = "btnModules";
            btnModules.Size = new Size(169, 35);
            btnModules.TabIndex = 7;
            btnModules.Text = "Modules";
            btnModules.UseVisualStyleBackColor = false;
            btnModules.Click += btnModules_Click;
            // 
            // btnTaken
            // 
            btnTaken.BackColor = SystemColors.ScrollBar;
            btnTaken.FlatStyle = FlatStyle.Flat;
            btnTaken.Location = new Point(651, 31);
            btnTaken.Margin = new Padding(2, 2, 2, 2);
            btnTaken.Name = "btnTaken";
            btnTaken.Size = new Size(169, 35);
            btnTaken.TabIndex = 6;
            btnTaken.Text = "Taken";
            btnTaken.UseVisualStyleBackColor = false;
            btnTaken.Click += btnTaken_Click;
            // 
            // btnThema
            // 
            btnThema.BackColor = SystemColors.HighlightText;
            btnThema.FlatStyle = FlatStyle.Flat;
            btnThema.Location = new Point(236, 31);
            btnThema.Margin = new Padding(2, 2, 2, 2);
            btnThema.Name = "btnThema";
            btnThema.Size = new Size(169, 35);
            btnThema.TabIndex = 5;
            btnThema.Text = "Thema‘s";
            btnThema.UseVisualStyleBackColor = false;
            btnThema.Click += btnThema_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ScrollBar;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Location = new Point(31, 31);
            btnHome.Margin = new Padding(2, 2, 2, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(169, 35);
            btnHome.TabIndex = 4;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // LvThema
            // 
            LvThema.BackColor = SystemColors.ScrollBar;
            LvThema.Location = new Point(31, 119);
            LvThema.Margin = new Padding(2, 2, 2, 2);
            LvThema.Name = "LvThema";
            LvThema.Size = new Size(789, 412);
            LvThema.TabIndex = 8;
            LvThema.UseCompatibleStateImageBehavior = false;
            // 
            // FrmThema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(855, 557);
            Controls.Add(LvThema);
            Controls.Add(btnModules);
            Controls.Add(btnTaken);
            Controls.Add(btnThema);
            Controls.Add(btnHome);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmThema";
            Text = "Thema's";
            ResumeLayout(false);
        }

        #endregion

        private Button btnModules;
        private Button btnTaken;
        private Button btnThema;
        private Button btnHome;
        private ListView LvThema;
    }
}