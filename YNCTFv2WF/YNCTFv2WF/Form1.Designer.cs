namespace YNCTFv2WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DHatasi = new System.Windows.Forms.Button();
            this.CHatasi = new System.Windows.Forms.Button();
            this.AHatasi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BHatasi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DHatasi
            // 
            this.DHatasi.Location = new System.Drawing.Point(46, 165);
            this.DHatasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DHatasi.Name = "DHatasi";
            this.DHatasi.Size = new System.Drawing.Size(109, 30);
            this.DHatasi.TabIndex = 17;
            this.DHatasi.Text = "D Hatası";
            this.DHatasi.UseVisualStyleBackColor = true;
            this.DHatasi.Click += new System.EventHandler(this.DHatasi_Click);
            // 
            // CHatasi
            // 
            this.CHatasi.Location = new System.Drawing.Point(46, 120);
            this.CHatasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CHatasi.Name = "CHatasi";
            this.CHatasi.Size = new System.Drawing.Size(109, 30);
            this.CHatasi.TabIndex = 18;
            this.CHatasi.Text = "C Hatası";
            this.CHatasi.UseVisualStyleBackColor = true;
            this.CHatasi.Click += new System.EventHandler(this.CHatasi_Click);
            // 
            // AHatasi
            // 
            this.AHatasi.Location = new System.Drawing.Point(46, 30);
            this.AHatasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AHatasi.Name = "AHatasi";
            this.AHatasi.Size = new System.Drawing.Size(109, 30);
            this.AHatasi.TabIndex = 20;
            this.AHatasi.Text = "A Hatası";
            this.AHatasi.UseVisualStyleBackColor = true;
            this.AHatasi.Click += new System.EventHandler(this.AHatasi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCreateClass);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(515, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(332, 143);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Location = new System.Drawing.Point(115, 103);
            this.btnCreateClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(117, 36);
            this.btnCreateClass.TabIndex = 0;
            this.btnCreateClass.Text = "Yeni Sınıf Ekle";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Yeni Hata Sınıfının Adı:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // BHatasi
            // 
            this.BHatasi.Location = new System.Drawing.Point(46, 75);
            this.BHatasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BHatasi.Name = "BHatasi";
            this.BHatasi.Size = new System.Drawing.Size(109, 30);
            this.BHatasi.TabIndex = 19;
            this.BHatasi.Text = "B Hatası";
            this.BHatasi.UseVisualStyleBackColor = true;
            this.BHatasi.Click += new System.EventHandler(this.BHatasi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eklenen Veri Sayısı: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Eklenen Veri Sayısı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Eklenen Veri Sayısı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eklenen Veri Sayısı: ";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(620, 101);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(144, 41);
            this.btnTrain.TabIndex = 21;
            this.btnTrain.Text = "Eğitimi Başlat!";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 322);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.DHatasi);
            this.Controls.Add(this.CHatasi);
            this.Controls.Add(this.AHatasi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BHatasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DHatasi;
        private System.Windows.Forms.Button CHatasi;
        private System.Windows.Forms.Button AHatasi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BHatasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrain;
    }
}
