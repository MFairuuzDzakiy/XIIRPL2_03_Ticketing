namespace XIIRPL2_03_Ticketing.MasterForm
{
    partial class FormListPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPenerbangan));
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 23);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 0;
            label1.Text = "List penerbangan ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 23);
            button1.Name = "button1";
            button1.Size = new Size(34, 30);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(963, 182);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // button2
            // 
            button2.Location = new Point(735, 135);
            button2.Name = "button2";
            button2.Size = new Size(194, 33);
            button2.TabIndex = 8;
            button2.Text = "Terapkan Filter";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 23);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 93);
            label4.Name = "label4";
            label4.Size = new Size(129, 17);
            label4.TabIndex = 6;
            label4.Text = "Urutkan Berdasarkan";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(394, 48);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(103, 19);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "18 : 00 - 24 : 00";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(273, 48);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(103, 19);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "12 : 00 - 18 : 00";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(152, 48);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(103, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "06 : 00 - 12 : 00";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(18, 46);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 21);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "00 : 00 - 06 : 00";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 19);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 1;
            label3.Text = "Waktu keberangkatan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 17);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(963, 342);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 61);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 6;
            label5.Text = "Juanda (SUB)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 63);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(165, 61);
            label7.Name = "label7";
            label7.Size = new Size(136, 17);
            label7.TabIndex = 8;
            label7.Text = "Soekarno-Hatta (CGK)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(338, 61);
            label8.Name = "label8";
            label8.Size = new Size(117, 17);
            label8.TabIndex = 9;
            label8.Text = "Mon, 22 May 2023";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(507, 61);
            label9.Name = "label9";
            label9.Size = new Size(88, 17);
            label9.TabIndex = 10;
            label9.Text = "1 Penumpang";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 16);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(307, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(474, 63);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // FormListPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(987, 660);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormListPenerbangan";
            Text = "FormListPenerbangan";
            Load += FormListPenerbangan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private Label label3;
        private Label label2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Button button2;
        private ComboBox comboBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}