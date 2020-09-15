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
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new System.Windows.Forms.Button();
            this.goNasaImage = new System.Windows.Forms.Button();
            this.btnSetWallpaper = new System.Windows.Forms.Button();
            this.btnGoNasaFancy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picture, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(3, 38);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(943, 501);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGoNasaFancy);
            this.panel1.Controls.Add(this.btnSetWallpaper);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.goNasaImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 29);
            this.panel1.TabIndex = 1;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(154, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 23);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(178, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(23, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(517, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(348, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd   HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(207, 3);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(49, 23);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // goNasaImage
            // 
            this.goNasaImage.Location = new System.Drawing.Point(294, 3);
            this.goNasaImage.Name = "goNasaImage";
            this.goNasaImage.Size = new System.Drawing.Size(58, 23);
            this.goNasaImage.TabIndex = 0;
            this.goNasaImage.Text = "NASA 1";
            this.goNasaImage.UseVisualStyleBackColor = true;
            this.goNasaImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetWallpaper
            // 
            this.btnSetWallpaper.Location = new System.Drawing.Point(420, 3);
            this.btnSetWallpaper.Name = "btnSetWallpaper";
            this.btnSetWallpaper.Size = new System.Drawing.Size(91, 23);
            this.btnSetWallpaper.TabIndex = 5;
            this.btnSetWallpaper.Text = "Set Wallpaper";
            this.btnSetWallpaper.UseVisualStyleBackColor = true;
            this.btnSetWallpaper.Click += new System.EventHandler(this.btnSetWallpaper_Click);
            // 
            // btnGoNasaFancy
            // 
            this.btnGoNasaFancy.Location = new System.Drawing.Point(358, 3);
            this.btnGoNasaFancy.Name = "btnGoNasaFancy";
            this.btnGoNasaFancy.Size = new System.Drawing.Size(56, 23);
            this.btnGoNasaFancy.TabIndex = 6;
            this.btnGoNasaFancy.Text = "NASA 2";
            this.btnGoNasaFancy.UseVisualStyleBackColor = true;
            this.btnGoNasaFancy.Click += new System.EventHandler(this.btnGoNasaFancy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Moon Phases";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goNasaImage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSetWallpaper;
        private System.Windows.Forms.Button btnGoNasaFancy;
    }
}

