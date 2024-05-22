namespace WinFormsApp1
{
    partial class UCAsfaltSantiye
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
            label1 = new Label();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            Koy1 = new DataGridViewTextBoxColumn();
            Koy2 = new DataGridViewTextBoxColumn();
            Koy3 = new DataGridViewTextBoxColumn();
            Ton = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(252, 45);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(16, 15);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(181, 94);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Asfalt Şantiye Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Tarih, Koy1, Koy2, Koy3, Ton, Sil });
            dataGridView1.Location = new Point(16, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1265, 530);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 150;
            // 
            // Tarih
            // 
            Tarih.DataPropertyName = "Tarih";
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 8;
            Tarih.Name = "Tarih";
            Tarih.ReadOnly = true;
            Tarih.Width = 150;
            // 
            // Koy1
            // 
            Koy1.DataPropertyName = "Koy1";
            Koy1.HeaderText = "Koy1";
            Koy1.MinimumWidth = 8;
            Koy1.Name = "Koy1";
            Koy1.ReadOnly = true;
            Koy1.Width = 150;
            // 
            // Koy2
            // 
            Koy2.DataPropertyName = "Koy2";
            Koy2.HeaderText = "Koy2";
            Koy2.MinimumWidth = 8;
            Koy2.Name = "Koy2";
            Koy2.ReadOnly = true;
            Koy2.Width = 150;
            // 
            // Koy3
            // 
            Koy3.DataPropertyName = "Koy3";
            Koy3.HeaderText = "Koy3";
            Koy3.MinimumWidth = 8;
            Koy3.Name = "Koy3";
            Koy3.ReadOnly = true;
            Koy3.Width = 150;
            // 
            // Ton
            // 
            Ton.DataPropertyName = "Ton";
            Ton.HeaderText = "Ton";
            Ton.MinimumWidth = 8;
            Ton.Name = "Ton";
            Ton.ReadOnly = true;
            Ton.Width = 150;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            Sil.Width = 150;
            // 
            // UCAsfaltSantiye
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Name = "UCAsfaltSantiye";
            Size = new Size(1296, 661);
            Load += UCAsfaltSantiye_Load;
            Leave += UCAsfaltSantiye_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn Koy1;
        private DataGridViewTextBoxColumn Koy2;
        private DataGridViewTextBoxColumn Koy3;
        private DataGridViewTextBoxColumn Ton;
        private DataGridViewButtonColumn Sil;
    }
}
