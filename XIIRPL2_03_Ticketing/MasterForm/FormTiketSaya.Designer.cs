namespace XIIRPL2_03_Ticketing.MasterForm
{
    partial class FormTiketSaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiketSaya));
            button1 = new Button();
            label1 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(33, 32);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 12);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 6;
            label1.Text = "Tiket Saya";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 51);
            label5.Name = "label5";
            label5.Size = new Size(283, 17);
            label5.TabIndex = 33;
            label5.Text = "Semua tiket Anda yang aktif akan muncul di sini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 342);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormTiketSaya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormTiketSaya";
            Text = "FormTiketSaya";
            Load += FormTiketSaya_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label5;
        private DataGridView dataGridView1;
    }
}