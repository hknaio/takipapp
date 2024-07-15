namespace WinFormsApp1
{
    partial class YolAgiTanimlama
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Ilce = new DataGridViewTextBoxColumn();
            BSK = new DataGridViewTextBoxColumn();
            Asfalt = new DataGridViewTextBoxColumn();
            Stabilize = new DataGridViewTextBoxColumn();
            KilitParke = new DataGridViewTextBoxColumn();
            BetonYol = new DataGridViewTextBoxColumn();
            Toplam = new DataGridViewTextBoxColumn();
            Guncelle = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Ilce, BSK, Asfalt, Stabilize, KilitParke, BetonYol, Toplam, Guncelle });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1273, 758);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
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
            // Ilce
            // 
            Ilce.DataPropertyName = "ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            // 
            // BSK
            // 
            BSK.DataPropertyName = "bsk";
            BSK.HeaderText = "BSK";
            BSK.MinimumWidth = 8;
            BSK.Name = "BSK";
            BSK.ReadOnly = true;
            // 
            // Asfalt
            // 
            Asfalt.DataPropertyName = "Asfalt";
            Asfalt.HeaderText = "Asfalt";
            Asfalt.MinimumWidth = 8;
            Asfalt.Name = "Asfalt";
            Asfalt.ReadOnly = true;
            // 
            // Stabilize
            // 
            Stabilize.DataPropertyName = "stabilize";
            Stabilize.HeaderText = "Stabilize";
            Stabilize.MinimumWidth = 8;
            Stabilize.Name = "Stabilize";
            Stabilize.ReadOnly = true;
            // 
            // KilitParke
            // 
            KilitParke.DataPropertyName = "KilitParke";
            KilitParke.HeaderText = "Kilit Parke";
            KilitParke.MinimumWidth = 8;
            KilitParke.Name = "KilitParke";
            KilitParke.ReadOnly = true;
            // 
            // BetonYol
            // 
            BetonYol.DataPropertyName = "BetonYol";
            BetonYol.HeaderText = "Beton Yol";
            BetonYol.MinimumWidth = 8;
            BetonYol.Name = "BetonYol";
            BetonYol.ReadOnly = true;
            // 
            // Toplam
            // 
            Toplam.DataPropertyName = "ToplamAg";
            Toplam.HeaderText = "Toplam";
            Toplam.MinimumWidth = 8;
            Toplam.Name = "Toplam";
            Toplam.ReadOnly = true;
            // 
            // Guncelle
            // 
            Guncelle.HeaderText = "Güncelle";
            Guncelle.MinimumWidth = 8;
            Guncelle.Name = "Guncelle";
            Guncelle.ReadOnly = true;
            Guncelle.Text = "Güncelle";
            Guncelle.UseColumnTextForButtonValue = true;
            // 
            // YolAgiTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 842);
            Controls.Add(dataGridView1);
            Name = "YolAgiTanimlama";
            Text = "Yol Ağı Tanımlama";
            FormClosing += YolAgiTanimlama_FormClosing;
            Load += YolAgiTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn BSK;
        private DataGridViewTextBoxColumn Asfalt;
        private DataGridViewTextBoxColumn Stabilize;
        private DataGridViewTextBoxColumn KilitParke;
        private DataGridViewTextBoxColumn BetonYol;
        private DataGridViewTextBoxColumn Toplam;
        private DataGridViewButtonColumn Guncelle;
    }
}