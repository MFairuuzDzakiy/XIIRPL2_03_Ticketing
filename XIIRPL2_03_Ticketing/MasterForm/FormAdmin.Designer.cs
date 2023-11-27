namespace XIIRPL2_03_Ticketing.MasterForm
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 78);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(-1, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 449);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(230, 49);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 8);
            button2.Name = "button2";
            button2.Size = new Size(194, 44);
            button2.TabIndex = 0;
            button2.Text = "Master Bandara";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 69);
            button3.Name = "button3";
            button3.Size = new Size(194, 38);
            button3.TabIndex = 1;
            button3.Text = "Master Maskapai";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 123);
            button4.Name = "button4";
            button4.Size = new Size(252, 44);
            button4.TabIndex = 2;
            button4.Text = "Master Jadwal Penerbangan";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 184);
            button5.Name = "button5";
            button5.Size = new Size(211, 39);
            button5.TabIndex = 3;
            button5.Text = "Master Kode Promo";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 238);
            button6.Name = "button6";
            button6.Size = new Size(243, 48);
            button6.TabIndex = 4;
            button6.Text = "Ubah Status Penerbangan";
            button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 397);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 38);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(48, 408);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 523);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Name = "AdminForm";
            Text = "FormAdmin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}