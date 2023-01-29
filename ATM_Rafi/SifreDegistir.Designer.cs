
namespace ATM_Rafi
{
    partial class SifreDegistir
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Sifre2Table = new System.Windows.Forms.TextBox();
            this.Sifre1Table = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 33);
            this.label2.TabIndex = 54;
            this.label2.Text = "Şifreyi Onayla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 33);
            this.label5.TabIndex = 53;
            this.label5.Text = "Yeni Şifre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 100);
            this.panel1.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(589, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM Kontrol Sistemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 58;
            this.label3.Text = "Geri Dön";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(265, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 46);
            this.button1.TabIndex = 57;
            this.button1.Text = "Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sifre2Table
            // 
            this.Sifre2Table.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Sifre2Table.Location = new System.Drawing.Point(265, 214);
            this.Sifre2Table.Name = "Sifre2Table";
            this.Sifre2Table.Size = new System.Drawing.Size(190, 31);
            this.Sifre2Table.TabIndex = 56;
            // 
            // Sifre1Table
            // 
            this.Sifre1Table.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.Sifre1Table.Location = new System.Drawing.Point(265, 153);
            this.Sifre1Table.Name = "Sifre1Table";
            this.Sifre1Table.Size = new System.Drawing.Size(190, 31);
            this.Sifre1Table.TabIndex = 55;
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sifre2Table);
            this.Controls.Add(this.Sifre1Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Sifre2Table;
        private System.Windows.Forms.TextBox Sifre1Table;
    }
}