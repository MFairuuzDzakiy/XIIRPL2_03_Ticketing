namespace XIIRPL2_03_Ticketing.MasterForm
{
    partial class FormMasterKodePromo
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
            label12 = new Label();
            txtMaksimumDiskon = new NumericUpDown();
            txtBerlakuSampai = new DateTimePicker();
            label9 = new Label();
            button2 = new Button();
            btnSimpan = new Button();
            txtKodePromo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtPersentaseDiskon = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 418);
            label12.Name = "label12";
            label12.Size = new Size(111, 15);
            label12.TabIndex = 64;
            label12.Text = "Persentase Diskon : ";
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(131, 456);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(233, 23);
            txtMaksimumDiskon.TabIndex = 63;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(131, 368);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(233, 23);
            txtBerlakuSampai.TabIndex = 58;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 374);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 57;
            label9.Text = "Berlaku Sampai  :";
            // 
            // button2
            // 
            button2.Location = new Point(546, 498);
            button2.Name = "button2";
            button2.Size = new Size(92, 32);
            button2.TabIndex = 54;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(656, 498);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 32);
            btnSimpan.TabIndex = 53;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(131, 325);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(233, 23);
            txtKodePromo.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 327);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 48;
            label3.Text = "Kode Promo : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(284, 17);
            label2.TabIndex = 46;
            label2.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 45;
            label1.Text = "Master Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(734, 258);
            dataGridView1.TabIndex = 44;
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
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(494, 326);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(252, 63);
            txtDeskripsi.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(394, 326);
            label8.Name = "label8";
            label8.Size = new Size(76, 17);
            label8.TabIndex = 67;
            label8.Text = "Deskripsi  : ";
            // 
            // txtPersentaseDiskon
            // 
            txtPersentaseDiskon.Location = new Point(131, 416);
            txtPersentaseDiskon.Name = "txtPersentaseDiskon";
            txtPersentaseDiskon.Size = new Size(233, 23);
            txtPersentaseDiskon.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 458);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 69;
            label4.Text = "Maksimum Diskon : ";
            // 
            // FormMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 598);
            Controls.Add(label4);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtPersentaseDiskon);
            Controls.Add(label12);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(btnSimpan);
            Controls.Add(txtKodePromo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormMasterKodePromo";
            Text = "FormMasterKodePromo";
            Load += FormMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private NumericUpDown txtMaksimumDiskon;
        private DateTimePicker txtBerlakuSampai;
        private Label label9;
        private Button button2;
        private Button btnSimpan;
        private TextBox txtKodePromo;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtDeskripsi;
        private Label label8;
        private NumericUpDown txtPersentaseDiskon;
        private Label label4;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}