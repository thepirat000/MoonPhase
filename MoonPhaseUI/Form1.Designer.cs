namespace MoonPhase
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbIncrement = new System.Windows.Forms.ComboBox();
            this.cmbNasaType = new System.Windows.Forms.ComboBox();
            this.btnSetWallpaper = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkPicture = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picture, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(3, 38);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1017, 481);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbIncrement);
            this.panel1.Controls.Add(this.cmbNasaType);
            this.panel1.Controls.Add(this.btnSetWallpaper);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 29);
            this.panel1.TabIndex = 1;
            // 
            // cmbIncrement
            // 
            this.cmbIncrement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncrement.FormattingEnabled = true;
            this.cmbIncrement.Items.AddRange(new object[] {
            "Hour",
            "Day",
            "Month"});
            this.cmbIncrement.Location = new System.Drawing.Point(275, 4);
            this.cmbIncrement.Name = "cmbIncrement";
            this.cmbIncrement.Size = new System.Drawing.Size(74, 21);
            this.cmbIncrement.TabIndex = 7;
            // 
            // cmbNasaType
            // 
            this.cmbNasaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNasaType.FormattingEnabled = true;
            this.cmbNasaType.Items.AddRange(new object[] {
            "Local",
            "Moon",
            "Fancy",
            "Plain",
            "Globe",
            "Orbit",
            "FancyMini",
            "MoonMini"});
            this.cmbNasaType.Location = new System.Drawing.Point(9, 4);
            this.cmbNasaType.Name = "cmbNasaType";
            this.cmbNasaType.Size = new System.Drawing.Size(110, 21);
            this.cmbNasaType.TabIndex = 6;
            this.cmbNasaType.SelectedIndexChanged += new System.EventHandler(this.cmbNasaType_SelectedIndexChanged);
            // 
            // btnSetWallpaper
            // 
            this.btnSetWallpaper.Location = new System.Drawing.Point(569, 3);
            this.btnSetWallpaper.Name = "btnSetWallpaper";
            this.btnSetWallpaper.Size = new System.Drawing.Size(91, 23);
            this.btnSetWallpaper.TabIndex = 5;
            this.btnSetWallpaper.Text = "Set Wallpaper";
            this.btnSetWallpaper.UseVisualStyleBackColor = true;
            this.btnSetWallpaper.Click += new System.EventHandler(this.btnSetWallpaper_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(355, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(24, 23);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(461, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(24, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(431, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(24, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Location = new System.Drawing.Point(675, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(348, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd   HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(385, 3);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(40, 23);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Now";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lnkPicture);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 20);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lnkPicture
            // 
            this.lnkPicture.AutoSize = true;
            this.lnkPicture.Location = new System.Drawing.Point(3, 4);
            this.lnkPicture.Name = "lnkPicture";
            this.lnkPicture.Size = new System.Drawing.Size(0, 13);
            this.lnkPicture.TabIndex = 0;
            this.lnkPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPicture_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Moon Phases";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSetWallpaper;
        private System.Windows.Forms.ComboBox cmbNasaType;
        private System.Windows.Forms.ComboBox cmbIncrement;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lnkPicture;
    }
}

