namespace WinFormsApp1
{
    partial class UCPurEmanetSanat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            cmbIlce = new ComboBox();
            label1 = new Label();
            dtTarih = new DateTimePicker();
            label2 = new Label();
            btnGetir = new Button();
            Tarih = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            IlceId = new DataGridViewTextBoxColumn();
            KoyId = new DataGridViewTextBoxColumn();
            ImalatId = new DataGridViewTextBoxColumn();
            Ilce = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Tutar = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            Detay = new DataGridViewButtonColumn();
            SpiralBoruId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Image = YatirimTakip.Properties.Resources.icons8_add_64;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(356, 74);
            button1.TabIndex = 0;
            button1.Text = "Pür Emanet Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tarih, ID, IlceId, KoyId, ImalatId, Ilce, Koy, Imalat, Birim, Tutar, Miktar, Sil, Detay, SpiralBoruId });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(3, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1435, 620);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(491, 25);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(182, 33);
            cmbIlce.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 2;
            label1.Text = "İlçe :";
            // 
            // dtTarih
            // 
            dtTarih.Format = DateTimePickerFormat.Custom;
            dtTarih.Location = new Point(764, 27);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(300, 31);
            dtTarih.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(696, 27);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 5;
            label2.Text = "Tarih : ";
            // 
            // btnGetir
            // 
            btnGetir.BackColor = SystemColors.GradientActiveCaption;
            btnGetir.ForeColor = SystemColors.ControlText;
            btnGetir.Location = new Point(1089, 3);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(224, 74);
            btnGetir.TabIndex = 7;
            btnGetir.Text = "Getir";
            btnGetir.UseVisualStyleBackColor = false;
            btnGetir.Click += btnGetir_Click;
            // 
            // Tarih
            // 
            Tarih.DataPropertyName = "Tarih";
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 8;
            Tarih.Name = "Tarih";
            Tarih.ReadOnly = true;
            Tarih.Resizable = DataGridViewTriState.True;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // IlceId
            // 
            IlceId.DataPropertyName = "IlceId";
            IlceId.HeaderText = "IlceId";
            IlceId.MinimumWidth = 8;
            IlceId.Name = "IlceId";
            IlceId.ReadOnly = true;
            IlceId.Visible = false;
            // 
            // KoyId
            // 
            KoyId.DataPropertyName = "KoyId";
            KoyId.HeaderText = "KoyId";
            KoyId.MinimumWidth = 8;
            KoyId.Name = "KoyId";
            KoyId.ReadOnly = true;
            KoyId.Visible = false;
            // 
            // ImalatId
            // 
            ImalatId.DataPropertyName = "ImalatId";
            ImalatId.HeaderText = "ImalatId";
            ImalatId.MinimumWidth = 8;
            ImalatId.Name = "ImalatId";
            ImalatId.ReadOnly = true;
            ImalatId.Visible = false;
            // 
            // Ilce
            // 
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            // 
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Köy";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            // 
            // Imalat
            // 
            Imalat.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Imalat.DataPropertyName = "Imalat";
            Imalat.HeaderText = "İmalat";
            Imalat.MinimumWidth = 8;
            Imalat.Name = "Imalat";
            Imalat.ReadOnly = true;
            Imalat.Width = 122;
            // 
            // Birim
            // 
            Birim.DataPropertyName = "Birim";
            Birim.HeaderText = "Birim";
            Birim.MinimumWidth = 8;
            Birim.Name = "Birim";
            Birim.ReadOnly = true;
            // 
            // Tutar
            // 
            Tutar.DataPropertyName = "Tutar";
            Tutar.HeaderText = "Tutar";
            Tutar.MinimumWidth = 8;
            Tutar.Name = "Tutar";
            Tutar.ReadOnly = true;
            // 
            // Miktar
            // 
            Miktar.DataPropertyName = "Miktar";
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            // 
            // Sil
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Tomato;
            dataGridViewCellStyle2.ForeColor = Color.White;
            Sil.DefaultCellStyle = dataGridViewCellStyle2;
            Sil.FlatStyle = FlatStyle.Flat;
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            // 
            // Detay
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LimeGreen;
            dataGridViewCellStyle3.ForeColor = Color.White;
            Detay.DefaultCellStyle = dataGridViewCellStyle3;
            Detay.FlatStyle = FlatStyle.Flat;
            Detay.HeaderText = "Detay";
            Detay.MinimumWidth = 8;
            Detay.Name = "Detay";
            Detay.ReadOnly = true;
            Detay.Text = "Detay";
            Detay.UseColumnTextForButtonValue = true;
            // 
            // SpiralBoruId
            // 
            SpiralBoruId.DataPropertyName = "SpiralBoruId";
            SpiralBoruId.HeaderText = "SpiralBoruId";
            SpiralBoruId.MinimumWidth = 8;
            SpiralBoruId.Name = "SpiralBoruId";
            SpiralBoruId.ReadOnly = true;
            SpiralBoruId.Visible = false;
            // 
            // UCPurEmanetSanat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnGetir);
            Controls.Add(dtTarih);
            Controls.Add(label2);
            Controls.Add(cmbIlce);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "UCPurEmanetSanat";
            Size = new Size(1441, 706);
            Load += UCPurEmanet_Load;
            Leave += UCPurEmanet_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cins;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IlceId;
        private DataGridViewTextBoxColumn KoyId;
        private DataGridViewTextBoxColumn ImalatId;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Tutar;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewButtonColumn Sil;
        private DataGridViewButtonColumn Detay;
        private ComboBox cmbIlce;
        private Label label1;
        private DateTimePicker dtTarih;
        private Label label2;
        private Button btnGetir;
        private DataGridViewTextBoxColumn SpiralBoruId;
    }
}
