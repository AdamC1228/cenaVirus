namespace cenaVirus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbCARD = new System.Windows.Forms.TextBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.tbCrn = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cenaTimer = new System.Windows.Forms.Timer(this.components);
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbFeature = new System.Windows.Forms.PictureBox();
            this.pbVirus = new System.Windows.Forms.PictureBox();
            this.pbDante = new System.Windows.Forms.PictureBox();
            this.pbRedDude = new System.Windows.Forms.PictureBox();
            this.pbFontendo = new System.Windows.Forms.PictureBox();
            this.greenCena = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFontendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCena)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(1373, 741);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(73, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCARD
            // 
            this.tbCARD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCARD.Location = new System.Drawing.Point(1267, 744);
            this.tbCARD.Name = "tbCARD";
            this.tbCARD.Size = new System.Drawing.Size(100, 20);
            this.tbCARD.TabIndex = 1;
            this.tbCARD.Text = "card number";
            // 
            // lbMoney
            // 
            this.lbMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(1095, 744);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(166, 20);
            this.lbMoney.TabIndex = 2;
            this.lbMoney.Text = "Give us all your money";
            // 
            // tbCrn
            // 
            this.tbCrn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCrn.Location = new System.Drawing.Point(1267, 770);
            this.tbCrn.Name = "tbCrn";
            this.tbCrn.Size = new System.Drawing.Size(100, 20);
            this.tbCrn.TabIndex = 3;
            this.tbCrn.Text = "crn";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(1267, 796);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Cardholder name";
            // 
            // cenaTimer
            // 
            this.cenaTimer.Interval = 8000;
            this.cenaTimer.Tick += new System.EventHandler(this.cenaTimer_Tick);
            // 
            // formTimer
            // 
            this.formTimer.Enabled = true;
            this.formTimer.Interval = 10000;
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::cenaVirus.Properties.Resources.JOHNCENA;
            this.pictureBox6.Location = new System.Drawing.Point(-421, 170);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pbFeature
            // 
            this.pbFeature.Image = global::cenaVirus.Properties.Resources.FEATURINGtext;
            this.pbFeature.Location = new System.Drawing.Point(1123, 589);
            this.pbFeature.Name = "pbFeature";
            this.pbFeature.Size = new System.Drawing.Size(100, 50);
            this.pbFeature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFeature.TabIndex = 10;
            this.pbFeature.TabStop = false;
            // 
            // pbVirus
            // 
            this.pbVirus.Image = global::cenaVirus.Properties.Resources.sonicvirustext1;
            this.pbVirus.Location = new System.Drawing.Point(423, 283);
            this.pbVirus.Name = "pbVirus";
            this.pbVirus.Size = new System.Drawing.Size(800, 300);
            this.pbVirus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbVirus.TabIndex = 9;
            this.pbVirus.TabStop = false;
            // 
            // pbDante
            // 
            this.pbDante.Image = ((System.Drawing.Image)(resources.GetObject("pbDante.Image")));
            this.pbDante.Location = new System.Drawing.Point(870, 125);
            this.pbDante.Name = "pbDante";
            this.pbDante.Size = new System.Drawing.Size(106, 106);
            this.pbDante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDante.TabIndex = 8;
            this.pbDante.TabStop = false;
            // 
            // pbRedDude
            // 
            this.pbRedDude.BackColor = System.Drawing.Color.Transparent;
            this.pbRedDude.Image = global::cenaVirus.Properties.Resources.tinyandknuckles1;
            this.pbRedDude.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbRedDude.InitialImage")));
            this.pbRedDude.Location = new System.Drawing.Point(167, 254);
            this.pbRedDude.Name = "pbRedDude";
            this.pbRedDude.Size = new System.Drawing.Size(250, 74);
            this.pbRedDude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRedDude.TabIndex = 6;
            this.pbRedDude.TabStop = false;
            // 
            // pbFontendo
            // 
            this.pbFontendo.Image = ((System.Drawing.Image)(resources.GetObject("pbFontendo.Image")));
            this.pbFontendo.Location = new System.Drawing.Point(129, 149);
            this.pbFontendo.Name = "pbFontendo";
            this.pbFontendo.Size = new System.Drawing.Size(867, 128);
            this.pbFontendo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFontendo.TabIndex = 7;
            this.pbFontendo.TabStop = false;
            // 
            // greenCena
            // 
            this.greenCena.Image = global::cenaVirus.Properties.Resources.JOHNCENA;
            this.greenCena.Location = new System.Drawing.Point(-259, -1);
            this.greenCena.Name = "greenCena";
            this.greenCena.Size = new System.Drawing.Size(1874, 910);
            this.greenCena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenCena.TabIndex = 13;
            this.greenCena.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1627, 921);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pbFeature);
            this.Controls.Add(this.pbVirus);
            this.Controls.Add(this.pbDante);
            this.Controls.Add(this.pbRedDude);
            this.Controls.Add(this.pbFontendo);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCrn);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.tbCARD);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.greenCena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Are you Ready?";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFontendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbCARD;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.TextBox tbCrn;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbRedDude;
        private System.Windows.Forms.PictureBox pbFontendo;
        private System.Windows.Forms.PictureBox pbDante;
        private System.Windows.Forms.PictureBox pbVirus;
        private System.Windows.Forms.PictureBox pbFeature;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox greenCena;
        private System.Windows.Forms.Timer cenaTimer;
        private System.Windows.Forms.Timer formTimer;
    }
}

