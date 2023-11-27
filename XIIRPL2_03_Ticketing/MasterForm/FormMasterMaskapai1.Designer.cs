namespace XIIRPL2_03_Ticketing.MasterForm
{
    partial class FormMasterMaskapai1
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
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            btnSimpan = new Button();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label6 = new Label();
            txtJmlKru = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlKru).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(538, 188);
            dataGridView1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 4);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Master Maskapai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 27);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(444, 467);
            button2.Name = "button2";
            button2.Size = new Size(92, 32);
            button2.TabIndex = 30;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            button2.TextChanged += b;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(558, 467);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 32);
            btnSimpan.TabIndex = 29;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(406, 262);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(242, 147);
            txtDeskripsi.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(324, 263);
            label8.Name = "label8";
            label8.Size = new Size(76, 17);
            label8.TabIndex = 27;
            label8.Text = "Deskripsi  : ";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(98, 309);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(215, 23);
            txtPerusahaan.TabIndex = 24;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(98, 262);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(215, 23);
            txtNama.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 364);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 22;
            label6.Text = "Jumlah Kru : ";
            // 
            // txtJmlKru
            // 
            txtJmlKru.Location = new Point(93, 362);
            txtJmlKru.Name = "txtJmlKru";
            txtJmlKru.Size = new Size(220, 23);
            txtJmlKru.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 310);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 19;
            label4.Text = "Perusahaan : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 263);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 18;
            label3.Text = "Nama : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 24);
            label5.Name = "label5";
            label5.Size = new Size(307, 17);
            label5.TabIndex = 31;
            label5.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // FormMasterMaskapai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 567);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(btnSimpan);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label6);
            Controls.Add(txtJmlKru);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormMasterMaskapai1";
            Text = "FormMasterMaskapai1";
            Load += FormMasterMaskapai1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button btnSimpan;
        private TextBox txtDeskripsi;
        private Label label8;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Label label6;
        private NumericUpDown txtJmlKru;
        private Label label4;
        private Label label3;
        private Label label5;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}