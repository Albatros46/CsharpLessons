namespace EntityFrameworkDemo
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
            this.btnSil = new System.Windows.Forms.Button();
            this.gbxGuncelle = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockAmountGuncelle = new System.Windows.Forms.TextBox();
            this.txtUnitPriceGuncelle = new System.Windows.Forms.TextBox();
            this.txtNameGuncelle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdFiltre = new System.Windows.Forms.TextBox();
            this.txtFiyatFiltre = new System.Windows.Forms.TextBox();
            this.txtMinFiltre = new System.Windows.Forms.TextBox();
            this.txtMaxFiltre = new System.Windows.Forms.TextBox();
            this.gbxGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbxProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSil.Location = new System.Drawing.Point(692, 133);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(52, 32);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gbxGuncelle
            // 
            this.gbxGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxGuncelle.Controls.Add(this.label5);
            this.gbxGuncelle.Controls.Add(this.txtStockAmountGuncelle);
            this.gbxGuncelle.Controls.Add(this.txtUnitPriceGuncelle);
            this.gbxGuncelle.Controls.Add(this.txtNameGuncelle);
            this.gbxGuncelle.Controls.Add(this.label6);
            this.gbxGuncelle.Controls.Add(this.label7);
            this.gbxGuncelle.Controls.Add(this.label8);
            this.gbxGuncelle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxGuncelle.Location = new System.Drawing.Point(352, 12);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Size = new System.Drawing.Size(334, 157);
            this.gbxGuncelle.TabIndex = 11;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "Ürün Bilgileri";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuncelle.Location = new System.Drawing.Point(99, 121);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 32);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(266, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "TL";
            // 
            // txtStockAmountGuncelle
            // 
            this.txtStockAmountGuncelle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStockAmountGuncelle.Location = new System.Drawing.Point(99, 89);
            this.txtStockAmountGuncelle.Name = "txtStockAmountGuncelle";
            this.txtStockAmountGuncelle.Size = new System.Drawing.Size(221, 26);
            this.txtStockAmountGuncelle.TabIndex = 5;
            // 
            // txtUnitPriceGuncelle
            // 
            this.txtUnitPriceGuncelle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitPriceGuncelle.Location = new System.Drawing.Point(99, 50);
            this.txtUnitPriceGuncelle.Name = "txtUnitPriceGuncelle";
            this.txtUnitPriceGuncelle.Size = new System.Drawing.Size(161, 26);
            this.txtUnitPriceGuncelle.TabIndex = 4;
            // 
            // txtNameGuncelle
            // 
            this.txtNameGuncelle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNameGuncelle.Location = new System.Drawing.Point(99, 18);
            this.txtNameGuncelle.Name = "txtNameGuncelle";
            this.txtNameGuncelle.Size = new System.Drawing.Size(221, 26);
            this.txtNameGuncelle.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Stok Miktarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ürün Adı";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 204);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(815, 250);
            this.dgvProducts.TabIndex = 10;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.btnEkle);
            this.gbxProduct.Controls.Add(this.label4);
            this.gbxProduct.Controls.Add(this.txtStockAmount);
            this.gbxProduct.Controls.Add(this.txtUnitPrice);
            this.gbxProduct.Controls.Add(this.txtName);
            this.gbxProduct.Controls.Add(this.label3);
            this.gbxProduct.Controls.Add(this.label2);
            this.gbxProduct.Controls.Add(this.label1);
            this.gbxProduct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxProduct.Location = new System.Drawing.Point(12, 12);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(334, 157);
            this.gbxProduct.TabIndex = 9;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürün Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEkle.Location = new System.Drawing.Point(99, 121);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 32);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(266, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "TL";
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStockAmount.Location = new System.Drawing.Point(99, 89);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(221, 26);
            this.txtStockAmount.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitPrice.Location = new System.Drawing.Point(99, 50);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(161, 26);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(99, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(692, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanında Ara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Location = new System.Drawing.Point(692, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datagridviewden Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(6, 19);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(117, 20);
            this.txtAra.TabIndex = 15;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fiyata Göre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "İki Fiyat Arasında";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Id Göre";
            // 
            // txtIdFiltre
            // 
            this.txtIdFiltre.Location = new System.Drawing.Point(63, 175);
            this.txtIdFiltre.Name = "txtIdFiltre";
            this.txtIdFiltre.Size = new System.Drawing.Size(100, 20);
            this.txtIdFiltre.TabIndex = 20;
            this.txtIdFiltre.TextChanged += new System.EventHandler(this.txtIdFiltre_TextChanged);
            // 
            // txtFiyatFiltre
            // 
            this.txtFiyatFiltre.Location = new System.Drawing.Point(232, 175);
            this.txtFiyatFiltre.Name = "txtFiyatFiltre";
            this.txtFiyatFiltre.Size = new System.Drawing.Size(100, 20);
            this.txtFiyatFiltre.TabIndex = 21;
            // 
            // txtMinFiltre
            // 
            this.txtMinFiltre.Location = new System.Drawing.Point(436, 175);
            this.txtMinFiltre.Name = "txtMinFiltre";
            this.txtMinFiltre.Size = new System.Drawing.Size(100, 20);
            this.txtMinFiltre.TabIndex = 22;
            // 
            // txtMaxFiltre
            // 
            this.txtMaxFiltre.Location = new System.Drawing.Point(543, 174);
            this.txtMaxFiltre.Name = "txtMaxFiltre";
            this.txtMaxFiltre.Size = new System.Drawing.Size(100, 20);
            this.txtMaxFiltre.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 463);
            this.Controls.Add(this.txtMaxFiltre);
            this.Controls.Add(this.txtMinFiltre);
            this.Controls.Add(this.txtFiyatFiltre);
            this.Controls.Add(this.txtIdFiltre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gbxGuncelle);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gbxProduct);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntityFramework Ürün Ekleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStockAmountGuncelle;
        private System.Windows.Forms.TextBox txtUnitPriceGuncelle;
        private System.Windows.Forms.TextBox txtNameGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdFiltre;
        private System.Windows.Forms.TextBox txtFiyatFiltre;
        private System.Windows.Forms.TextBox txtMinFiltre;
        private System.Windows.Forms.TextBox txtMaxFiltre;
    }
}

