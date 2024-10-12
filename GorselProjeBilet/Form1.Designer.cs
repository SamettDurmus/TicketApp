namespace GorselProjeBilet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNerden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(519, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 488);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs";
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Items.AddRange(new object[] {
            "SDTurizm",
            "GÜTruzim",
            "GSTurizm"});
            this.cmbOtobus.Location = new System.Drawing.Point(405, 34);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(101, 21);
            this.cmbOtobus.TabIndex = 2;
            this.cmbOtobus.SelectedIndexChanged += new System.EventHandler(this.cmbOtobus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(405, 178);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(104, 20);
            this.dtpTarih.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bilet Fiyatı";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(405, 217);
            this.nudFiyat.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudFiyat.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(104, 20);
            this.nudFiyat.TabIndex = 10;
            this.nudFiyat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(434, 252);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kayıt";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNereye);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbNerden);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(399, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ŞEHİR";
            // 
            // cmbNereye
            // 
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "İSTANBUL",
            "ANKARA",
            "HATAY",
            "ANTALYA",
            "ORDU",
            "BOLU",
            "BURSA",
            "ADANA",
            "ÇORUM",
            "TOKAT"});
            this.cmbNereye.Location = new System.Drawing.Point(6, 70);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(104, 21);
            this.cmbNereye.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nereye:";
            // 
            // cmbNerden
            // 
            this.cmbNerden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNerden.FormattingEnabled = true;
            this.cmbNerden.Items.AddRange(new object[] {
            "İSTANBUL",
            "ANKARA",
            "HATAY",
            "ANTALYA",
            "ORDU",
            "BOLU",
            "BURSA",
            "ADANA",
            "ÇORUM",
            "TOKAT"});
            this.cmbNerden.Location = new System.Drawing.Point(6, 30);
            this.cmbNerden.Name = "cmbNerden";
            this.cmbNerden.Size = new System.Drawing.Size(104, 21);
            this.cmbNerden.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nereden:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            this.rezerveEtToolStripMenuItem.Click += new System.EventHandler(this.rezerveEtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOtobus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNerden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
    }
}

