namespace Vista
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            panel1 = new ReaLTaiizor.Controls.Panel();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(bigLabel6);
            panel1.Controls.Add(bigLabel5);
            panel1.Controls.Add(bigLabel4);
            panel1.Controls.Add(bigLabel3);
            panel1.Controls.Add(bigLabel2);
            panel1.Controls.Add(bigLabel1);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(194, 539);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            panel1.Click += panel1_Click;
            // 
            // bigLabel6
            // 
            bigLabel6.AutoSize = true;
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            bigLabel6.ForeColor = Color.White;
            bigLabel6.Location = new Point(12, 460);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(151, 25);
            bigLabel6.TabIndex = 6;
            bigLabel6.Text = "CERRAR SESIÓN";
            // 
            // bigLabel5
            // 
            bigLabel5.AutoSize = true;
            bigLabel5.BackColor = Color.Transparent;
            bigLabel5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            bigLabel5.ForeColor = Color.White;
            bigLabel5.Location = new Point(12, 413);
            bigLabel5.Name = "bigLabel5";
            bigLabel5.Size = new Size(74, 25);
            bigLabel5.TabIndex = 5;
            bigLabel5.Text = "AYUDA";
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            bigLabel4.ForeColor = Color.White;
            bigLabel4.Location = new Point(12, 228);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(100, 25);
            bigLabel4.TabIndex = 4;
            bigLabel4.Text = "DEPÓSITO";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            bigLabel3.ForeColor = Color.White;
            bigLabel3.Location = new Point(12, 174);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(71, 25);
            bigLabel3.TabIndex = 3;
            bigLabel3.Text = "VENTA";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(12, 117);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(99, 25);
            bigLabel2.TabIndex = 2;
            bigLabel2.Text = "MAESTRO";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(8, 56);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(172, 25);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "ADMINISTRACIÓN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(453, -92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 290);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(939, 535);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Menu_Principal";
            Text = "Menu_Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private PictureBox pictureBox1;
    }
}