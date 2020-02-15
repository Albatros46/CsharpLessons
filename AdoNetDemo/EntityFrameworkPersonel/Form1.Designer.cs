namespace EntityFrameworkPersonel
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
            this.gbxPersonelEkle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyadEkle = new System.Windows.Forms.TextBox();
            this.txtBirimEkle = new System.Windows.Forms.TextBox();
            this.txtCepTlfEkle = new System.Windows.Forms.TextBox();
            this.txtEPostaEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.gbxGuncelle = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtEPostaGuncelle = new System.Windows.Forms.TextBox();
            this.txtCepTlfGuncelle = new System.Windows.Forms.TextBox();
            this.txtBirimGuncelle = new System.Windows.Forms.TextBox();
            this.txtAdSoyadGuncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdSoyadAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBirimAra = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.gbxPersonelEkle.SuspendLayout();
            this.gbxGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPersonelEkle
            // 
            this.gbxPersonelEkle.Controls.Add(this.btnEkle);
            this.gbxPersonelEkle.Controls.Add(this.txtEPostaEkle);
            this.gbxPersonelEkle.Controls.Add(this.txtCepTlfEkle);
            this.gbxPersonelEkle.Controls.Add(this.txtBirimEkle);
            this.gbxPersonelEkle.Controls.Add(this.txtAdSoyadEkle);
            this.gbxPersonelEkle.Controls.Add(this.label4);
            this.gbxPersonelEkle.Controls.Add(this.label3);
            this.gbxPersonelEkle.Controls.Add(this.label2);
            this.gbxPersonelEkle.Controls.Add(this.label1);
            this.gbxPersonelEkle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxPersonelEkle.Location = new System.Drawing.Point(12, 12);
            this.gbxPersonelEkle.Name = "gbxPersonelEkle";
            this.gbxPersonelEkle.Size = new System.Drawing.Size(295, 186);
            this.gbxPersonelEkle.TabIndex = 0;
            this.gbxPersonelEkle.TabStop = false;
            this.gbxPersonelEkle.Text = "Personel Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cep Telefonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-Posta";
            // 
            // txtAdSoyadEkle
            // 
            this.txtAdSoyadEkle.Location = new System.Drawing.Point(83, 19);
            this.txtAdSoyadEkle.Name = "txtAdSoyadEkle";
            this.txtAdSoyadEkle.Size = new System.Drawing.Size(206, 26);
            this.txtAdSoyadEkle.TabIndex = 5;
            // 
            // txtBirimEkle
            // 
            this.txtBirimEkle.Location = new System.Drawing.Point(57, 51);
            this.txtBirimEkle.Name = "txtBirimEkle";
            this.txtBirimEkle.Size = new System.Drawing.Size(232, 26);
            this.txtBirimEkle.TabIndex = 6;
            // 
            // txtCepTlfEkle
            // 
            this.txtCepTlfEkle.Location = new System.Drawing.Point(102, 83);
            this.txtCepTlfEkle.Name = "txtCepTlfEkle";
            this.txtCepTlfEkle.Size = new System.Drawing.Size(185, 26);
            this.txtCepTlfEkle.TabIndex = 7;
            // 
            // txtEPostaEkle
            // 
            this.txtEPostaEkle.Location = new System.Drawing.Point(66, 118);
            this.txtEPostaEkle.Name = "txtEPostaEkle";
            this.txtEPostaEkle.Size = new System.Drawing.Size(221, 26);
            this.txtEPostaEkle.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(102, 150);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 30);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gbxGuncelle
            // 
            this.gbxGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxGuncelle.Controls.Add(this.txtEPostaGuncelle);
            this.gbxGuncelle.Controls.Add(this.txtCepTlfGuncelle);
            this.gbxGuncelle.Controls.Add(this.txtBirimGuncelle);
            this.gbxGuncelle.Controls.Add(this.txtAdSoyadGuncelle);
            this.gbxGuncelle.Controls.Add(this.label5);
            this.gbxGuncelle.Controls.Add(this.label6);
            this.gbxGuncelle.Controls.Add(this.label7);
            this.gbxGuncelle.Controls.Add(this.label8);
            this.gbxGuncelle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxGuncelle.Location = new System.Drawing.Point(493, 12);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Size = new System.Drawing.Size(295, 186);
            this.gbxGuncelle.TabIndex = 1;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "Personel Güncelle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(102, 150);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 30);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtEPostaGuncelle
            // 
            this.txtEPostaGuncelle.Location = new System.Drawing.Point(66, 118);
            this.txtEPostaGuncelle.Name = "txtEPostaGuncelle";
            this.txtEPostaGuncelle.Size = new System.Drawing.Size(221, 26);
            this.txtEPostaGuncelle.TabIndex = 8;
            // 
            // txtCepTlfGuncelle
            // 
            this.txtCepTlfGuncelle.Location = new System.Drawing.Point(102, 83);
            this.txtCepTlfGuncelle.Name = "txtCepTlfGuncelle";
            this.txtCepTlfGuncelle.Size = new System.Drawing.Size(185, 26);
            this.txtCepTlfGuncelle.TabIndex = 7;
            // 
            // txtBirimGuncelle
            // 
            this.txtBirimGuncelle.Location = new System.Drawing.Point(57, 51);
            this.txtBirimGuncelle.Name = "txtBirimGuncelle";
            this.txtBirimGuncelle.Size = new System.Drawing.Size(232, 26);
            this.txtBirimGuncelle.TabIndex = 6;
            // 
            // txtAdSoyadGuncelle
            // 
            this.txtAdSoyadGuncelle.Location = new System.Drawing.Point(83, 19);
            this.txtAdSoyadGuncelle.Name = "txtAdSoyadGuncelle";
            this.txtAdSoyadGuncelle.Size = new System.Drawing.Size(206, 26);
            this.txtAdSoyadGuncelle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cep Telefonu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Birimi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adı Soyadı";
            // 
            // txtAdSoyadAra
            // 
            this.txtAdSoyadAra.Location = new System.Drawing.Point(316, 48);
            this.txtAdSoyadAra.Name = "txtAdSoyadAra";
            this.txtAdSoyadAra.Size = new System.Drawing.Size(171, 20);
            this.txtAdSoyadAra.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ad Soyad-Ara";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Birim-Ara";
            // 
            // txtBirimAra
            // 
            this.txtBirimAra.Location = new System.Drawing.Point(316, 97);
            this.txtBirimAra.Name = "txtBirimAra";
            this.txtBirimAra.Size = new System.Drawing.Size(171, 20);
            this.txtBirimAra.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(361, 162);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 30);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Location = new System.Drawing.Point(12, 204);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.Size = new System.Drawing.Size(776, 254);
            this.dgvPersonel.TabIndex = 11;
            this.dgvPersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBirimAra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdSoyadAra);
            this.Controls.Add(this.gbxGuncelle);
            this.Controls.Add(this.gbxPersonelEkle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntityFramework Personel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPersonelEkle.ResumeLayout(false);
            this.gbxPersonelEkle.PerformLayout();
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersonelEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEPostaEkle;
        private System.Windows.Forms.TextBox txtCepTlfEkle;
        private System.Windows.Forms.TextBox txtBirimEkle;
        private System.Windows.Forms.TextBox txtAdSoyadEkle;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtEPostaGuncelle;
        private System.Windows.Forms.TextBox txtCepTlfGuncelle;
        private System.Windows.Forms.TextBox txtBirimGuncelle;
        private System.Windows.Forms.TextBox txtAdSoyadGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdSoyadAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBirimAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvPersonel;
    }
}

