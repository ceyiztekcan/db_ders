namespace IZSUformsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBoxAboneBilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdoneNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxAboneTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBoxFaturaBilgileri = new System.Windows.Forms.GroupBox();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFaturaAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGuncel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOnceki = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFaturaAboneNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBas = new System.Windows.Forms.Button();
            this.GroupBoxAboneBilgileri.SuspendLayout();
            this.GroupBoxFaturaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxAboneBilgileri
            // 
            this.GroupBoxAboneBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBoxAboneBilgileri.Controls.Add(this.label5);
            this.GroupBoxAboneBilgileri.Controls.Add(this.cBoxAboneTuru);
            this.GroupBoxAboneBilgileri.Controls.Add(this.txtAdSoyad);
            this.GroupBoxAboneBilgileri.Controls.Add(this.label4);
            this.GroupBoxAboneBilgileri.Controls.Add(this.btnKaydet);
            this.GroupBoxAboneBilgileri.Controls.Add(this.txtAdoneNo);
            this.GroupBoxAboneBilgileri.Controls.Add(this.label1);
            this.GroupBoxAboneBilgileri.Location = new System.Drawing.Point(13, 81);
            this.GroupBoxAboneBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBoxAboneBilgileri.Name = "GroupBoxAboneBilgileri";
            this.GroupBoxAboneBilgileri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBoxAboneBilgileri.Size = new System.Drawing.Size(267, 185);
            this.GroupBoxAboneBilgileri.TabIndex = 0;
            this.GroupBoxAboneBilgileri.TabStop = false;
            this.GroupBoxAboneBilgileri.Text = "Abone Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone No";
            // 
            // txtAdoneNo
            // 
            this.txtAdoneNo.Location = new System.Drawing.Point(111, 26);
            this.txtAdoneNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdoneNo.Name = "txtAdoneNo";
            this.txtAdoneNo.Size = new System.Drawing.Size(148, 23);
            this.txtAdoneNo.TabIndex = 0;
            this.txtAdoneNo.Leave += new System.EventHandler(this.txtAdoneNo_Leave);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Location = new System.Drawing.Point(8, 131);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(248, 38);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(111, 57);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(148, 23);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ad Soyad";
            // 
            // cBoxAboneTuru
            // 
            this.cBoxAboneTuru.FormattingEnabled = true;
            this.cBoxAboneTuru.Location = new System.Drawing.Point(110, 91);
            this.cBoxAboneTuru.Name = "cBoxAboneTuru";
            this.cBoxAboneTuru.Size = new System.Drawing.Size(148, 24);
            this.cBoxAboneTuru.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Abone Türü";
            // 
            // GroupBoxFaturaBilgileri
            // 
            this.GroupBoxFaturaBilgileri.BackColor = System.Drawing.Color.Azure;
            this.GroupBoxFaturaBilgileri.Controls.Add(this.Tarih);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.label7);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.button2);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.txtFaturaAdSoyad);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.label9);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.button3);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.txtGuncel);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.label10);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.txtOnceki);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.label11);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.txtFaturaAboneNo);
            this.GroupBoxFaturaBilgileri.Controls.Add(this.label12);
            this.GroupBoxFaturaBilgileri.Location = new System.Drawing.Point(13, 274);
            this.GroupBoxFaturaBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxFaturaBilgileri.Name = "GroupBoxFaturaBilgileri";
            this.GroupBoxFaturaBilgileri.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxFaturaBilgileri.Size = new System.Drawing.Size(267, 238);
            this.GroupBoxFaturaBilgileri.TabIndex = 14;
            this.GroupBoxFaturaBilgileri.TabStop = false;
            this.GroupBoxFaturaBilgileri.Text = "Fatura Bilgileri";
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(111, 87);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(148, 23);
            this.Tarih.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tarih";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(141, 185);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "GETİR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtFaturaAdSoyad
            // 
            this.txtFaturaAdSoyad.Enabled = false;
            this.txtFaturaAdSoyad.Location = new System.Drawing.Point(111, 57);
            this.txtFaturaAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaturaAdSoyad.Name = "txtFaturaAdSoyad";
            this.txtFaturaAdSoyad.Size = new System.Drawing.Size(148, 23);
            this.txtFaturaAdSoyad.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ad Soyad";
            // 
            // txtGuncel
            // 
            this.txtGuncel.Location = new System.Drawing.Point(111, 145);
            this.txtGuncel.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuncel.Name = "txtGuncel";
            this.txtGuncel.Size = new System.Drawing.Size(147, 23);
            this.txtGuncel.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 151);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Güncel Sayaç";
            // 
            // txtOnceki
            // 
            this.txtOnceki.Location = new System.Drawing.Point(111, 114);
            this.txtOnceki.Margin = new System.Windows.Forms.Padding(4);
            this.txtOnceki.Name = "txtOnceki";
            this.txtOnceki.Size = new System.Drawing.Size(148, 23);
            this.txtOnceki.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Önceki Sayaç";
            // 
            // txtFaturaAboneNo
            // 
            this.txtFaturaAboneNo.Enabled = false;
            this.txtFaturaAboneNo.Location = new System.Drawing.Point(111, 26);
            this.txtFaturaAboneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaturaAboneNo.Name = "txtFaturaAboneNo";
            this.txtFaturaAboneNo.Size = new System.Drawing.Size(148, 23);
            this.txtFaturaAboneNo.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Abone No";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(8, 185);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "EKLE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBas
            // 
            this.btnBas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBas.BackgroundImage")));
            this.btnBas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBas.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBas.FlatAppearance.BorderSize = 0;
            this.btnBas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBas.Location = new System.Drawing.Point(13, 12);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(61, 51);
            this.btnBas.TabIndex = 15;
            this.btnBas.UseVisualStyleBackColor = false;
            this.btnBas.Click += new System.EventHandler(this.btnBas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(846, 537);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.GroupBoxFaturaBilgileri);
            this.Controls.Add(this.GroupBoxAboneBilgileri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxAboneBilgileri.ResumeLayout(false);
            this.GroupBoxAboneBilgileri.PerformLayout();
            this.GroupBoxFaturaBilgileri.ResumeLayout(false);
            this.GroupBoxFaturaBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxAboneBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdoneNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxAboneTuru;
        private System.Windows.Forms.GroupBox GroupBoxFaturaBilgileri;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFaturaAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtGuncel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOnceki;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFaturaAboneNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBas;
    }
}

