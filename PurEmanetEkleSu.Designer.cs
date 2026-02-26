namespace WinFormsApp1
{
    partial class PurEmanetEkleSu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtTarih = new DateTimePicker();
            cmbIlce = new ComboBox();
            cmbKoy = new ComboBox();
            cmbImalat = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtMiktar = new MaskedTextBox();
            cmbSpiral = new ComboBox();
            txtBoruMetre = new MaskedTextBox();
            label6 = new Label();
            chkMezra = new CheckBox();
            chkMezraList = new CheckedListBox();
            cmbTalepEden = new ComboBox();
            label7 = new Label();
            cmbIsMakinesi = new ComboBox();
            label8 = new Label();
            cmbOperator = new ComboBox();
            label9 = new Label();
            btnBoruEkle = new Button();
            dgBoru = new DataGridView();
            Cap = new DataGridViewTextBoxColumn();
            Isim = new DataGridViewTextBoxColumn();
            PN = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgBoru).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Tarih : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "İlçe : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 74);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Köy : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 115);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "İmalat :";
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(79, 13);
            dtTarih.Margin = new Padding(2);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(211, 23);
            dtTarih.TabIndex = 4;
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(79, 44);
            cmbIlce.Margin = new Padding(2);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(211, 23);
            cmbIlce.TabIndex = 5;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Location = new Point(79, 74);
            cmbKoy.Margin = new Padding(2);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(211, 23);
            cmbKoy.TabIndex = 6;
            cmbKoy.SelectedIndexChanged += cmbKoy_SelectedIndexChanged;
            // 
            // cmbImalat
            // 
            cmbImalat.FormattingEnabled = true;
            cmbImalat.Location = new Point(85, 115);
            cmbImalat.Margin = new Padding(2);
            cmbImalat.Name = "cmbImalat";
            cmbImalat.Size = new Size(234, 23);
            cmbImalat.TabIndex = 7;
            cmbImalat.SelectedIndexChanged += cmbImalat_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 150);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 8;
            label5.Text = "Miktar : ";
            // 
            // button1
            // 
            button1.Location = new Point(714, 467);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(836, 467);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(85, 31);
            button2.TabIndex = 11;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(85, 150);
            txtMiktar.Margin = new Padding(2);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(106, 23);
            txtMiktar.TabIndex = 12;
            // 
            // cmbSpiral
            // 
            cmbSpiral.FormattingEnabled = true;
            cmbSpiral.Location = new Point(157, 290);
            cmbSpiral.Margin = new Padding(2);
            cmbSpiral.Name = "cmbSpiral";
            cmbSpiral.Size = new Size(103, 23);
            cmbSpiral.TabIndex = 13;
            // 
            // txtBoruMetre
            // 
            txtBoruMetre.Location = new Point(295, 289);
            txtBoruMetre.Margin = new Padding(2);
            txtBoruMetre.Name = "txtBoruMetre";
            txtBoruMetre.Size = new Size(101, 23);
            txtBoruMetre.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 292);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 15;
            label6.Text = "Boru Çap / Miktar :";
            // 
            // chkMezra
            // 
            chkMezra.AutoSize = true;
            chkMezra.Location = new Point(319, 76);
            chkMezra.Margin = new Padding(2);
            chkMezra.Name = "chkMezra";
            chkMezra.Size = new Size(58, 19);
            chkMezra.TabIndex = 16;
            chkMezra.Text = "Mezra";
            chkMezra.UseVisualStyleBackColor = true;
            chkMezra.CheckedChanged += chkMezra_CheckedChanged;
            // 
            // chkMezraList
            // 
            chkMezraList.FormattingEnabled = true;
            chkMezraList.Location = new Point(398, 74);
            chkMezraList.Margin = new Padding(2);
            chkMezraList.Name = "chkMezraList";
            chkMezraList.Size = new Size(220, 148);
            chkMezraList.TabIndex = 17;
            // 
            // cmbTalepEden
            // 
            cmbTalepEden.FormattingEnabled = true;
            cmbTalepEden.Items.AddRange(new object[] { "--" });
            cmbTalepEden.Location = new Point(441, 14);
            cmbTalepEden.Margin = new Padding(2);
            cmbTalepEden.Name = "cmbTalepEden";
            cmbTalepEden.Size = new Size(178, 23);
            cmbTalepEden.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 16);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 22;
            label7.Text = "Talep Eden :";
            // 
            // cmbIsMakinesi
            // 
            cmbIsMakinesi.FormattingEnabled = true;
            cmbIsMakinesi.Items.AddRange(new object[] { "--" });
            cmbIsMakinesi.Location = new Point(441, 44);
            cmbIsMakinesi.Margin = new Padding(2);
            cmbIsMakinesi.Name = "cmbIsMakinesi";
            cmbIsMakinesi.Size = new Size(178, 23);
            cmbIsMakinesi.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 46);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 24;
            label8.Text = "İş Makinesi :";
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "--" });
            cmbOperator.Location = new Point(738, 14);
            cmbOperator.Margin = new Padding(2);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(152, 23);
            cmbOperator.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(651, 16);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 26;
            label9.Text = "Operatör :";
            // 
            // btnBoruEkle
            // 
            btnBoruEkle.Location = new Point(413, 287);
            btnBoruEkle.Margin = new Padding(2);
            btnBoruEkle.Name = "btnBoruEkle";
            btnBoruEkle.Size = new Size(148, 26);
            btnBoruEkle.TabIndex = 28;
            btnBoruEkle.Text = "Listeye Ekle";
            btnBoruEkle.UseVisualStyleBackColor = true;
            btnBoruEkle.Click += btnBoruEkle_Click;
            // 
            // dgBoru
            // 
            dgBoru.AllowUserToAddRows = false;
            dgBoru.AllowUserToDeleteRows = false;
            dgBoru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBoru.Columns.AddRange(new DataGridViewColumn[] { Cap, Isim, PN, Miktar, Sil });
            dgBoru.Location = new Point(41, 326);
            dgBoru.Margin = new Padding(2);
            dgBoru.Name = "dgBoru";
            dgBoru.ReadOnly = true;
            dgBoru.RowHeadersVisible = false;
            dgBoru.RowHeadersWidth = 62;
            dgBoru.Size = new Size(655, 249);
            dgBoru.TabIndex = 29;
            dgBoru.CellClick += dgBoru_CellClick;
            // 
            // Cap
            // 
            Cap.DataPropertyName = "cap";
            Cap.HeaderText = "Cap";
            Cap.MinimumWidth = 8;
            Cap.Name = "Cap";
            Cap.ReadOnly = true;
            Cap.Width = 150;
            // 
            // Isim
            // 
            Isim.DataPropertyName = "Isim";
            Isim.HeaderText = "Isim";
            Isim.Name = "Isim";
            Isim.ReadOnly = true;
            // 
            // PN
            // 
            PN.DataPropertyName = "PN";
            PN.HeaderText = "PN";
            PN.Name = "PN";
            PN.ReadOnly = true;
            // 
            // Miktar
            // 
            Miktar.DataPropertyName = "miktar";
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            Miktar.Width = 150;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Listeden Sil";
            Sil.ToolTipText = "Listeden Sil";
            Sil.UseColumnTextForButtonValue = true;
            Sil.Width = 150;
            // 
            // PurEmanetEkleSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 593);
            Controls.Add(dgBoru);
            Controls.Add(btnBoruEkle);
            Controls.Add(cmbOperator);
            Controls.Add(label9);
            Controls.Add(cmbIsMakinesi);
            Controls.Add(label8);
            Controls.Add(cmbTalepEden);
            Controls.Add(label7);
            Controls.Add(chkMezraList);
            Controls.Add(chkMezra);
            Controls.Add(label6);
            Controls.Add(txtBoruMetre);
            Controls.Add(cmbSpiral);
            Controls.Add(txtMiktar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(cmbImalat);
            Controls.Add(cmbKoy);
            Controls.Add(cmbIlce);
            Controls.Add(dtTarih);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "PurEmanetEkleSu";
            Text = "Pür Emanet Ekle";
            Load += PurEmanetEkleSu_Load;
            ((System.ComponentModel.ISupportInitialize)dgBoru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtTarih;
        private ComboBox cmbIlce;
        private ComboBox cmbKoy;
        private ComboBox cmbImalat;
        private Label label5;
        private Button button1;
        private Button button2;
        private MaskedTextBox txtMiktar;
        private ComboBox cmbSpiral;
        private MaskedTextBox txtBoruMetre;
        private Label label6;
        private CheckBox chkMezra;
        private CheckedListBox chkMezraList;
        private ComboBox cmbTalepEden;
        private Label label7;
        private ComboBox cmbIsMakinesi;
        private Label label8;
        private ComboBox cmbOperator;
        private Label label9;
        private Button btnBoruEkle;
        private DataGridView dgBoru;
        private DataGridViewTextBoxColumn Cap;
        private DataGridViewTextBoxColumn Isim;
        private DataGridViewTextBoxColumn PN;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewButtonColumn Sil;
    }
}