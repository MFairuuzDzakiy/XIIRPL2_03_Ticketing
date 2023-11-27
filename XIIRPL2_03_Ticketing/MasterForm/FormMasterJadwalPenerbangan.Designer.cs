namespace XIIRPL2_03_Ticketing.MasterForm
{
    partial class FormMasterJadwalPenerbangan
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
            btnBatal = new Button();
            btnSimpan = new Button();
            txtKodePenerbangan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtKe = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtDari = new ComboBox();
            txtMaskapai = new ComboBox();
            txtTanggalKeberangkatan = new DateTimePicker();
            label9 = new Label();
            txtDurasiPenerbangan = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtHargaPerTiket = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            SuspendLayout();
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(548, 514);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(92, 32);
            btnBatal.TabIndex = 33;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(656, 514);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 32);
            btnSimpan.TabIndex = 32;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(149, 326);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(215, 23);
            txtKodePenerbangan.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 458);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 25;
            label6.Text = "Maskapai : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 418);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 23;
            label5.Text = "Ke : ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 374);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 22;
            label4.Text = "Dari : ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 327);
            label3.Name = "label3";
            label3.Size = new Size(131, 17);
            label3.TabIndex = 21;
            label3.Text = "Kode Penerbangan : ";
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(149, 417);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(215, 23);
            txtKe.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(288, 17);
            label2.TabIndex = 19;
            label2.Text = "Semua  jadwal penerbangan akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 18;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(734, 258);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(149, 373);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(215, 23);
            txtDari.TabIndex = 34;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(149, 455);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(215, 23);
            txtMaskapai.TabIndex = 35;
            // 
            // txtTanggalKeberangkatan
            // 
            txtTanggalKeberangkatan.Location = new Point(513, 326);
            txtTanggalKeberangkatan.Name = "txtTanggalKeberangkatan";
            txtTanggalKeberangkatan.Size = new Size(233, 23);
            txtTanggalKeberangkatan.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(370, 329);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 36;
            label9.Text = "Tanggal Keberangkatan :";
            label9.Click += label9_Click;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(513, 373);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(233, 23);
            txtDurasiPenerbangan.TabIndex = 41;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(370, 374);
            label11.Name = "label11";
            label11.Size = new Size(137, 17);
            label11.TabIndex = 40;
            label11.Text = "Durasi Penerbangan : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(372, 420);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 43;
            label12.Text = "Harga per Tiket : ";
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(513, 418);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(233, 23);
            txtHargaPerTiket.TabIndex = 42;
            // 
            // FormMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 635);
            Controls.Add(label12);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(label11);
            Controls.Add(txtTanggalKeberangkatan);
            Controls.Add(label9);
            Controls.Add(txtMaskapai);
            Controls.Add(txtDari);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtKe);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormMasterJadwalPenerbangan";
            Text = "FormMasterJadwalPenerbangan";
            Load += FormMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBatal;
        private Button btnSimpan;
        private TextBox txtKodePenerbangan;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox txtKe;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox txtDari;
        private ComboBox txtMaskapai;
        private DateTimePicker txtTanggalKeberangkatan;
        private Label label9;
        private TextBox txtDurasiPenerbangan;
        private Label label11;
        private Label label12;
        private NumericUpDown txtHargaPerTiket;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}