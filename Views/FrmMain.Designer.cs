namespace FrmMain
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnThema = new Button();
            btnTaken = new Button();
            btnModules = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnThema
            // 
            btnThema.BackColor = SystemColors.ScrollBar;
            btnThema.FlatStyle = FlatStyle.Flat;
            btnThema.Location = new Point(25, 247);
            btnThema.Margin = new Padding(2);
            btnThema.Name = "btnThema";
            btnThema.Size = new Size(189, 35);
            btnThema.TabIndex = 1;
            btnThema.Text = "Thema‘s";
            btnThema.UseVisualStyleBackColor = false;
            btnThema.Click += btnThema_Click;
            // 
            // btnTaken
            // 
            btnTaken.BackColor = SystemColors.ScrollBar;
            btnTaken.FlatStyle = FlatStyle.Flat;
            btnTaken.Location = new Point(27, 247);
            btnTaken.Margin = new Padding(2);
            btnTaken.Name = "btnTaken";
            btnTaken.Size = new Size(189, 35);
            btnTaken.TabIndex = 2;
            btnTaken.Text = "Taken";
            btnTaken.UseVisualStyleBackColor = false;
            btnTaken.Click += btnTaken_Click;
            // 
            // btnModules
            // 
            btnModules.BackColor = SystemColors.ScrollBar;
            btnModules.FlatStyle = FlatStyle.Flat;
            btnModules.Location = new Point(26, 247);
            btnModules.Margin = new Padding(2);
            btnModules.Name = "btnModules";
            btnModules.Size = new Size(189, 35);
            btnModules.TabIndex = 3;
            btnModules.Text = "Modules";
            btnModules.UseVisualStyleBackColor = false;
            btnModules.Click += btnModules_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 60);
            label1.Name = "label1";
            label1.Size = new Size(288, 54);
            label1.TabIndex = 4;
            label1.Text = "Werkplanning";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModules);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(321, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 307);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "modules";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(btnThema);
            groupBox2.Location = new Point(51, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(239, 307);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "thema's";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(btnTaken);
            groupBox3.Location = new Point(592, 158);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(239, 307);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "taken";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 189);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 189);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(884, 557);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FrmMain";
            Text = "Takenlijst";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnThema;
        private Button btnTaken;
        private Button btnModules;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox3;
    }
}
