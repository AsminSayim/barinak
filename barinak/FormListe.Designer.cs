namespace barinak
{
    partial class FormListe
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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.pbHayvan = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSaglikli = new System.Windows.Forms.CheckBox();
            this.dtpDogum = new System.Windows.Forms.DateTimePicker();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saglikli = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.resim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHayvan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ad,
            this.tur,
            this.cins,
            this.dogumyil,
            this.saglikli,
            this.resim});
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvListe.Location = new System.Drawing.Point(0, 0);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(759, 174);
            this.dgvListe.TabIndex = 0;
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(86, 188);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(664, 20);
            this.txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(2, 188);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(78, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            
            // 
            // pbHayvan
            // 
            this.pbHayvan.Location = new System.Drawing.Point(282, 32);
            this.pbHayvan.Name = "pbHayvan";
            this.pbHayvan.Size = new System.Drawing.Size(111, 142);
            this.pbHayvan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHayvan.TabIndex = 3;
            this.pbHayvan.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSaglikli);
            this.groupBox1.Controls.Add(this.pbHayvan);
            this.groupBox1.Controls.Add(this.dtpDogum);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.txtCins);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 211);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hayvan Bilgileri";
            // 
            // chkSaglikli
            // 
            this.chkSaglikli.AutoSize = true;
            this.chkSaglikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSaglikli.Location = new System.Drawing.Point(127, 162);
            this.chkSaglikli.Name = "chkSaglikli";
            this.chkSaglikli.Size = new System.Drawing.Size(85, 24);
            this.chkSaglikli.TabIndex = 21;
            this.chkSaglikli.Text = "Sağlıklı";
            this.chkSaglikli.UseVisualStyleBackColor = true;
            // 
            // dtpDogum
            // 
            this.dtpDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogum.Location = new System.Drawing.Point(127, 130);
            this.dtpDogum.Name = "dtpDogum";
            this.dtpDogum.Size = new System.Drawing.Size(121, 26);
            this.dtpDogum.TabIndex = 20;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Kedi",
            "Köpek",
            "Balık",
            "Kuş",
            "Yılan",
            ""});
            this.cmbTur.Location = new System.Drawing.Point(127, 64);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 28);
            this.cmbTur.TabIndex = 19;
            // 
            // txtCins
            // 
            this.txtCins.Location = new System.Drawing.Point(127, 98);
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(121, 26);
            this.txtCins.TabIndex = 18;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(127, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 26);
            this.txtAd.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Doğum Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cins";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tür";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Location = new System.Drawing.Point(455, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 211);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Lime;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(145, 64);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 75);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(24, 64);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 75);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ad
            // 
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "Adı";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // tur
            // 
            this.tur.DataPropertyName = "tur";
            this.tur.HeaderText = "Türü";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            this.tur.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cins
            // 
            this.cins.DataPropertyName = "cins";
            this.cins.HeaderText = "Cinsi";
            this.cins.Name = "cins";
            this.cins.ReadOnly = true;
            // 
            // dogumyil
            // 
            this.dogumyil.DataPropertyName = "dogumyil";
            this.dogumyil.HeaderText = "Doğum Yılı";
            this.dogumyil.Name = "dogumyil";
            this.dogumyil.ReadOnly = true;
            // 
            // saglikli
            // 
            this.saglikli.DataPropertyName = "saglikli";
            this.saglikli.HeaderText = "Sağlıklı";
            this.saglikli.Name = "saglikli";
            this.saglikli.ReadOnly = true;
            // 
            // resim
            // 
            this.resim.DataPropertyName = "resim";
            this.resim.HeaderText = "Resmi";
            this.resim.Name = "resim";
            this.resim.ReadOnly = true;
            this.resim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.resim.Visible = false;
            // 
            // FormListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgvListe);
            this.Name = "FormListe";
            this.Text = "FormListe";
            this.Load += new System.EventHandler(this.FormListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHayvan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.PictureBox pbHayvan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSaglikli;
        private System.Windows.Forms.DateTimePicker dtpDogum;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cins;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyil;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saglikli;
        private System.Windows.Forms.DataGridViewTextBoxColumn resim;
    }
}