namespace XIIRPL2_03_Ticketing.MasterForm
{
    partial class FormMasterBandara
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNegara = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtJmlTerminal = new NumericUpDown();
            label6 = new Label();
            txtNama = new TextBox();
            txtIATA = new TextBox();
            txtKota = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtAlamat = new TextBox();
            btnSimpan = new Button();
            button2 = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(701, 258);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(301, 17);
            label2.TabIndex = 2;
            label2.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(98, 455);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(215, 23);
            txtNegara.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 327);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 4;
            label3.Text = "Nama : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 374);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 5;
            label4.Text = "Kode IATA : ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 418);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 6;
            label5.Text = "Kota : ";
            // 
            // txtJmlTerminal
            // 
            txtJmlTerminal.Location = new Point(461, 332);
            txtJmlTerminal.Name = "txtJmlTerminal";
            txtJmlTerminal.Size = new Size(252, 23);
            txtJmlTerminal.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 458);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 8;
            label6.Text = "Negara : ";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(98, 326);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(215, 23);
            txtNama.TabIndex = 9;
            // 
            // txtIATA
            // 
            txtIATA.Location = new Point(98, 373);
            txtIATA.Name = "txtIATA";
            txtIATA.Size = new Size(215, 23);
            txtIATA.TabIndex = 10;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(98, 417);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(215, 23);
            txtKota.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(343, 332);
            label7.Name = "label7";
            label7.Size = new Size(112, 17);
            label7.TabIndex = 12;
            label7.Text = "Jumlah Terminal : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(343, 379);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 13;
            label8.Text = "Alamat : ";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(461, 373);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(252, 129);
            txtAlamat.TabIndex = 14;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(623, 531);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 32);
            btnSimpan.TabIndex = 15;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button2
            // 
            button2.Location = new Point(513, 531);
            button2.Name = "button2";
            button2.Size = new Size(92, 32);
            button2.TabIndex = 16;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
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
            // FormMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 629);
            Controls.Add(button2);
            Controls.Add(btnSimpan);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtKota);
            Controls.Add(txtIATA);
            Controls.Add(txtNama);
            Controls.Add(label6);
            Controls.Add(txtJmlTerminal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNegara);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormMasterBandara";
            Text = "FormMasterBandara";
            Load += FormMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private ComboBox txtNegara;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown txtJmlTerminal;
        private Label label6;
        private TextBox txtNama;
        private TextBox txtIATA;
        private TextBox txtKota;
        private Label label7;
        private Label label8;
        private TextBox txtAlamat;
        private Button btnSimpan;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}