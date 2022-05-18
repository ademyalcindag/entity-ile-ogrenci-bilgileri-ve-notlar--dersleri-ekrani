
using System;

namespace EntityOrnek
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
            this.btnogrencilistele = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnbul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFOTO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtogrenciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDERSAD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDERSID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDURUM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtORTALAMA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSINAV3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSINAV2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnnotguncelle = new System.Windows.Forms.Button();
            this.btnnothesapla = new System.Windows.Forms.Button();
            this.txtSINAV1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnderslistesi = new System.Windows.Forms.Button();
            this.btnnotlistesi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnogrencilistele
            // 
            this.btnogrencilistele.Location = new System.Drawing.Point(13, 174);
            this.btnogrencilistele.Name = "btnogrencilistele";
            this.btnogrencilistele.Size = new System.Drawing.Size(119, 38);
            this.btnogrencilistele.TabIndex = 1;
            this.btnogrencilistele.Text = "Öğrenci Listele";
            this.btnogrencilistele.UseVisualStyleBackColor = true;
            this.btnogrencilistele.Click += new System.EventHandler(this.btnogrencilistele_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(12, 217);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(119, 38);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(12, 263);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(119, 38);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(12, 307);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(119, 38);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(13, 352);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(119, 38);
            this.btnbul.TabIndex = 1;
            this.btnbul.Text = "Bul";
            this.btnbul.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFOTO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSOYAD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtogrenciID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(189, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci";
            // 
            // txtFOTO
            // 
            this.txtFOTO.Location = new System.Drawing.Point(101, 137);
            this.txtFOTO.Name = "txtFOTO";
            this.txtFOTO.Size = new System.Drawing.Size(116, 22);
            this.txtFOTO.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "FOTOGRAF:";
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(100, 103);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(116, 22);
            this.txtSOYAD.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "SOYAD:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(100, 73);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(116, 22);
            this.txtAD.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "AD:";
            // 
            // txtogrenciID
            // 
            this.txtogrenciID.Location = new System.Drawing.Point(100, 39);
            this.txtogrenciID.Name = "txtogrenciID";
            this.txtogrenciID.Size = new System.Drawing.Size(116, 22);
            this.txtogrenciID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDERSAD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDERSID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(189, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtDERSAD
            // 
            this.txtDERSAD.Location = new System.Drawing.Point(101, 61);
            this.txtDERSAD.Name = "txtDERSAD";
            this.txtDERSAD.Size = new System.Drawing.Size(116, 22);
            this.txtDERSAD.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "AD:";
            // 
            // txtDERSID
            // 
            this.txtDERSID.Location = new System.Drawing.Point(100, 23);
            this.txtDERSID.Name = "txtDERSID";
            this.txtDERSID.Size = new System.Drawing.Size(116, 22);
            this.txtDERSID.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDURUM);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtORTALAMA);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSINAV3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSINAV2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnnotguncelle);
            this.groupBox3.Controls.Add(this.btnnothesapla);
            this.groupBox3.Controls.Add(this.txtSINAV1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(484, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 312);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtDURUM
            // 
            this.txtDURUM.Location = new System.Drawing.Point(100, 172);
            this.txtDURUM.Name = "txtDURUM";
            this.txtDURUM.Size = new System.Drawing.Size(116, 22);
            this.txtDURUM.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "DURUM:";
            // 
            // txtORTALAMA
            // 
            this.txtORTALAMA.Location = new System.Drawing.Point(100, 132);
            this.txtORTALAMA.Name = "txtORTALAMA";
            this.txtORTALAMA.Size = new System.Drawing.Size(116, 22);
            this.txtORTALAMA.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "ORTALAMA:";
            // 
            // txtSINAV3
            // 
            this.txtSINAV3.Location = new System.Drawing.Point(100, 100);
            this.txtSINAV3.Name = "txtSINAV3";
            this.txtSINAV3.Size = new System.Drawing.Size(116, 22);
            this.txtSINAV3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "SINAV3";
            // 
            // txtSINAV2
            // 
            this.txtSINAV2.Location = new System.Drawing.Point(100, 70);
            this.txtSINAV2.Name = "txtSINAV2";
            this.txtSINAV2.Size = new System.Drawing.Size(116, 22);
            this.txtSINAV2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "SINAV2";
            // 
            // btnnotguncelle
            // 
            this.btnnotguncelle.Location = new System.Drawing.Point(97, 252);
            this.btnnotguncelle.Name = "btnnotguncelle";
            this.btnnotguncelle.Size = new System.Drawing.Size(119, 38);
            this.btnnotguncelle.TabIndex = 1;
            this.btnnotguncelle.Text = "Not Güncelle";
            this.btnnotguncelle.UseVisualStyleBackColor = true;
            // 
            // btnnothesapla
            // 
            this.btnnothesapla.Location = new System.Drawing.Point(97, 208);
            this.btnnothesapla.Name = "btnnothesapla";
            this.btnnothesapla.Size = new System.Drawing.Size(119, 38);
            this.btnnothesapla.TabIndex = 1;
            this.btnnothesapla.Text = "Not Hesapla";
            this.btnnothesapla.UseVisualStyleBackColor = true;
            // 
            // txtSINAV1
            // 
            this.txtSINAV1.Location = new System.Drawing.Point(100, 39);
            this.txtSINAV1.Name = "txtSINAV1";
            this.txtSINAV1.Size = new System.Drawing.Size(116, 22);
            this.txtSINAV1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "SINAV1";
            // 
            // btnderslistesi
            // 
            this.btnderslistesi.Location = new System.Drawing.Point(12, 398);
            this.btnderslistesi.Name = "btnderslistesi";
            this.btnderslistesi.Size = new System.Drawing.Size(119, 38);
            this.btnderslistesi.TabIndex = 1;
            this.btnderslistesi.Text = "Ders Listesi";
            this.btnderslistesi.UseVisualStyleBackColor = true;
            this.btnderslistesi.Click += new System.EventHandler(this.btnderslistesi_Click);
            // 
            // btnnotlistesi
            // 
            this.btnnotlistesi.Location = new System.Drawing.Point(13, 442);
            this.btnnotlistesi.Name = "btnnotlistesi";
            this.btnnotlistesi.Size = new System.Drawing.Size(119, 38);
            this.btnnotlistesi.TabIndex = 1;
            this.btnnotlistesi.Text = "Not Listesi";
            this.btnnotlistesi.UseVisualStyleBackColor = true;
            this.btnnotlistesi.Click += new System.EventHandler(this.btnnotlistesi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnnotlistesi);
            this.Controls.Add(this.btnderslistesi);
            this.Controls.Add(this.btnogrencilistele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnogrencilistele;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFOTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtogrenciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDERSAD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDERSID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDURUM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtORTALAMA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSINAV3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSINAV2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSINAV1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnderslistesi;
        private System.Windows.Forms.Button btnnotlistesi;
        private System.Windows.Forms.Button btnnotguncelle;
        private System.Windows.Forms.Button btnnothesapla;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

