namespace barinak
{
    partial class FormEkle
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
            this.chkESaglikli = new System.Windows.Forms.CheckBox();
            this.pbEHayvan = new System.Windows.Forms.PictureBox();
            this.dtpEDogum = new System.Windows.Forms.DateTimePicker();
            this.cmbETur = new System.Windows.Forms.ComboBox();
            this.txtECins = new System.Windows.Forms.TextBox();
            this.txtEAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEHayvan)).BeginInit();
            this.SuspendLayout();
            // 
            // chkESaglikli
            // 
            this.chkESaglikli.AutoSize = true;
            this.chkESaglikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkESaglikli.Location = new System.Drawing.Point(145, 168);
            this.chkESaglikli.Name = "chkESaglikli";
            this.chkESaglikli.Size = new System.Drawing.Size(85, 24);
            this.chkESaglikli.TabIndex = 31;
            this.chkESaglikli.Text = "Sağlıklı";
            this.chkESaglikli.UseVisualStyleBackColor = true;
            // 
            // pbEHayvan
            // 
            this.pbEHayvan.Location = new System.Drawing.Point(294, 63);
            this.pbEHayvan.Name = "pbEHayvan";
            this.pbEHayvan.Size = new System.Drawing.Size(125, 142);
            this.pbEHayvan.TabIndex = 22;
            this.pbEHayvan.TabStop = false;
            // 
            // dtpEDogum
            // 
            this.dtpEDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEDogum.Location = new System.Drawing.Point(145, 142);
            this.dtpEDogum.Name = "dtpEDogum";
            this.dtpEDogum.Size = new System.Drawing.Size(121, 20);
            this.dtpEDogum.TabIndex = 30;
            // 
            // cmbETur
            // 
            this.cmbETur.FormattingEnabled = true;
            this.cmbETur.Items.AddRange(new object[] {
            "Kedi",
            "Köpek",
            "Balık",
            "Kuş",
            "Yılan"});
            this.cmbETur.Location = new System.Drawing.Point(145, 89);
            this.cmbETur.Name = "cmbETur";
            this.cmbETur.Size = new System.Drawing.Size(121, 21);
            this.cmbETur.TabIndex = 29;
            // 
            // txtECins
            // 
            this.txtECins.Location = new System.Drawing.Point(145, 116);
            this.txtECins.Name = "txtECins";
            this.txtECins.Size = new System.Drawing.Size(121, 20);
            this.txtECins.TabIndex = 28;
            // 
            // txtEAd
            // 
            this.txtEAd.Location = new System.Drawing.Point(145, 63);
            this.txtEAd.Name = "txtEAd";
            this.txtEAd.Size = new System.Drawing.Size(121, 20);
            this.txtEAd.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Doğum Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(98, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cins";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tür";
            // 
            // btnResim
            // 
            this.btnResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.Location = new System.Drawing.Point(294, 28);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(125, 29);
            this.btnResim.TabIndex = 32;
            this.btnResim.Text = "Resim Seç";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(127, 254);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(292, 67);
            this.btnKaydet.TabIndex = 33;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 409);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.chkESaglikli);
            this.Controls.Add(this.pbEHayvan);
            this.Controls.Add(this.dtpEDogum);
            this.Controls.Add(this.cmbETur);
            this.Controls.Add(this.txtECins);
            this.Controls.Add(this.txtEAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEkle";
            this.Text = "FormEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pbEHayvan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkESaglikli;
        private System.Windows.Forms.PictureBox pbEHayvan;
        private System.Windows.Forms.DateTimePicker dtpEDogum;
        private System.Windows.Forms.ComboBox cmbETur;
        private System.Windows.Forms.TextBox txtECins;
        private System.Windows.Forms.TextBox txtEAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnKaydet;
    }
}