namespace Program_Renmor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmotor = new System.Windows.Forms.ComboBox();
            this.tmpinjam = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tmkembali = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdurasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni Bd BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "RENMOR PREMIUM BIKE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilih motor";
            // 
            // cbmotor
            // 
            this.cbmotor.BackColor = System.Drawing.Color.Gray;
            this.cbmotor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbmotor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmotor.FormattingEnabled = true;
            this.cbmotor.Items.AddRange(new object[] {
            "CBR1000rr",
            "RSV4",
            "R1",
            "er6-n",
            "ZX-25r"});
            this.cbmotor.Location = new System.Drawing.Point(12, 203);
            this.cbmotor.Name = "cbmotor";
            this.cbmotor.Size = new System.Drawing.Size(195, 25);
            this.cbmotor.TabIndex = 3;
            this.cbmotor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tmpinjam
            // 
            this.tmpinjam.CalendarMonthBackground = System.Drawing.Color.SlateGray;
            this.tmpinjam.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.tmpinjam.Location = new System.Drawing.Point(574, 151);
            this.tmpinjam.Name = "tmpinjam";
            this.tmpinjam.Size = new System.Drawing.Size(200, 20);
            this.tmpinjam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Waktu Peminjaman";
            // 
            // tmkembali
            // 
            this.tmkembali.CalendarMonthBackground = System.Drawing.Color.White;
            this.tmkembali.Location = new System.Drawing.Point(576, 196);
            this.tmkembali.Name = "tmkembali";
            this.tmkembali.Size = new System.Drawing.Size(200, 20);
            this.tmkembali.TabIndex = 7;
            this.tmkembali.ValueChanged += new System.EventHandler(this.tmkembali_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sampai";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nama";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-571, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 11;
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.Color.Gray;
            this.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(14, 151);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(193, 25);
            this.nama.TabIndex = 12;
            this.nama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Harga per hari";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtharga
            // 
            this.txtharga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtharga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtharga.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga.Location = new System.Drawing.Point(12, 260);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(195, 25);
            this.txtharga.TabIndex = 14;
            this.txtharga.TextChanged += new System.EventHandler(this.txtharga_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Klik tombol dibawah ini untuk memproses pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(572, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Durasi Peminjaman";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtdurasi
            // 
            this.txtdurasi.BackColor = System.Drawing.Color.Gray;
            this.txtdurasi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdurasi.Location = new System.Drawing.Point(576, 260);
            this.txtdurasi.Name = "txtdurasi";
            this.txtdurasi.Size = new System.Drawing.Size(194, 25);
            this.txtdurasi.TabIndex = 19;
            this.txtdurasi.TextChanged += new System.EventHandler(this.txtdurasi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 492);
            this.Controls.Add(this.txtdurasi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tmkembali);
            this.Controls.Add(this.tmpinjam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbmotor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmotor;
        private System.Windows.Forms.DateTimePicker tmpinjam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tmkembali;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdurasi;
    }
}

