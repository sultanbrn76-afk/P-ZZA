namespace Siparisekrani
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsiparisver = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.grpMalzemeler = new System.Windows.Forms.GroupBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkPeynir = new System.Windows.Forms.CheckBox();
            this.chkSosis = new System.Windows.Forms.CheckBox();
            this.chkTon = new System.Windows.Forms.CheckBox();
            this.chkMisir = new System.Windows.Forms.CheckBox();
            this.chkMantar = new System.Windows.Forms.CheckBox();
            this.chkAncuez = new System.Windows.Forms.CheckBox();
            this.chkSucuk = new System.Windows.Forms.CheckBox();
            this.chkZeytin = new System.Windows.Forms.CheckBox();
            this.chkSalam = new System.Windows.Forms.CheckBox();
            this.lstpizza = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEbat = new System.Windows.Forms.ComboBox();
            this.rdoKalin = new System.Windows.Forms.RadioButton();
            this.rdoInce = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsiparisver
            // 
            this.btnsiparisver.Location = new System.Drawing.Point(279, 519);
            this.btnsiparisver.Name = "btnsiparisver";
            this.btnsiparisver.Size = new System.Drawing.Size(97, 30);
            this.btnsiparisver.TabIndex = 35;
            this.btnsiparisver.Text = "Sipariş Ver";
            this.btnsiparisver.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(176, 519);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(97, 30);
            this.btnKapat.TabIndex = 34;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(281, 479);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(97, 22);
            this.txtToplam.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Toplam :";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(103, 479);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(84, 22);
            this.txtAdet.TabIndex = 31;
            // 
            // grpMalzemeler
            // 
            this.grpMalzemeler.Controls.Add(this.chkJambon);
            this.grpMalzemeler.Controls.Add(this.chkPeynir);
            this.grpMalzemeler.Controls.Add(this.chkSosis);
            this.grpMalzemeler.Controls.Add(this.chkTon);
            this.grpMalzemeler.Controls.Add(this.chkMisir);
            this.grpMalzemeler.Controls.Add(this.chkMantar);
            this.grpMalzemeler.Controls.Add(this.chkAncuez);
            this.grpMalzemeler.Controls.Add(this.chkSucuk);
            this.grpMalzemeler.Controls.Add(this.chkZeytin);
            this.grpMalzemeler.Controls.Add(this.chkSalam);
            this.grpMalzemeler.Location = new System.Drawing.Point(97, 252);
            this.grpMalzemeler.Name = "grpMalzemeler";
            this.grpMalzemeler.Size = new System.Drawing.Size(286, 207);
            this.grpMalzemeler.TabIndex = 30;
            this.grpMalzemeler.TabStop = false;
            this.grpMalzemeler.Text = "Malzemeler";
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(6, 34);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(78, 20);
            this.chkJambon.TabIndex = 7;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkPeynir
            // 
            this.chkPeynir.AutoSize = true;
            this.chkPeynir.Location = new System.Drawing.Point(155, 181);
            this.chkPeynir.Name = "chkPeynir";
            this.chkPeynir.Size = new System.Drawing.Size(67, 20);
            this.chkPeynir.TabIndex = 16;
            this.chkPeynir.Text = "Peynir";
            this.chkPeynir.UseVisualStyleBackColor = true;
            // 
            // chkSosis
            // 
            this.chkSosis.AutoSize = true;
            this.chkSosis.Location = new System.Drawing.Point(6, 72);
            this.chkSosis.Name = "chkSosis";
            this.chkSosis.Size = new System.Drawing.Size(63, 20);
            this.chkSosis.TabIndex = 8;
            this.chkSosis.Text = "Sosis";
            this.chkSosis.UseVisualStyleBackColor = true;
            // 
            // chkTon
            // 
            this.chkTon.AutoSize = true;
            this.chkTon.Location = new System.Drawing.Point(154, 146);
            this.chkTon.Name = "chkTon";
            this.chkTon.Size = new System.Drawing.Size(53, 20);
            this.chkTon.TabIndex = 15;
            this.chkTon.Text = "Ton";
            this.chkTon.UseVisualStyleBackColor = true;
            // 
            // chkMisir
            // 
            this.chkMisir.AutoSize = true;
            this.chkMisir.Location = new System.Drawing.Point(6, 110);
            this.chkMisir.Name = "chkMisir";
            this.chkMisir.Size = new System.Drawing.Size(57, 20);
            this.chkMisir.TabIndex = 9;
            this.chkMisir.Text = "Mısır";
            this.chkMisir.UseVisualStyleBackColor = true;
            // 
            // chkMantar
            // 
            this.chkMantar.AutoSize = true;
            this.chkMantar.Location = new System.Drawing.Point(154, 110);
            this.chkMantar.Name = "chkMantar";
            this.chkMantar.Size = new System.Drawing.Size(70, 20);
            this.chkMantar.TabIndex = 14;
            this.chkMantar.Text = "Mantar";
            this.chkMantar.UseVisualStyleBackColor = true;
            // 
            // chkAncuez
            // 
            this.chkAncuez.AutoSize = true;
            this.chkAncuez.Location = new System.Drawing.Point(6, 146);
            this.chkAncuez.Name = "chkAncuez";
            this.chkAncuez.Size = new System.Drawing.Size(73, 20);
            this.chkAncuez.TabIndex = 10;
            this.chkAncuez.Text = "Ancuez";
            this.chkAncuez.UseVisualStyleBackColor = true;
            // 
            // chkSucuk
            // 
            this.chkSucuk.AutoSize = true;
            this.chkSucuk.Location = new System.Drawing.Point(154, 72);
            this.chkSucuk.Name = "chkSucuk";
            this.chkSucuk.Size = new System.Drawing.Size(66, 20);
            this.chkSucuk.TabIndex = 13;
            this.chkSucuk.Text = "Sucuk";
            this.chkSucuk.UseVisualStyleBackColor = true;
            // 
            // chkZeytin
            // 
            this.chkZeytin.AutoSize = true;
            this.chkZeytin.Location = new System.Drawing.Point(6, 181);
            this.chkZeytin.Name = "chkZeytin";
            this.chkZeytin.Size = new System.Drawing.Size(65, 20);
            this.chkZeytin.TabIndex = 11;
            this.chkZeytin.Text = "Zeytin";
            this.chkZeytin.UseVisualStyleBackColor = true;
            // 
            // chkSalam
            // 
            this.chkSalam.AutoSize = true;
            this.chkSalam.Location = new System.Drawing.Point(152, 34);
            this.chkSalam.Name = "chkSalam";
            this.chkSalam.Size = new System.Drawing.Size(68, 20);
            this.chkSalam.TabIndex = 12;
            this.chkSalam.Text = "Salam";
            this.chkSalam.UseVisualStyleBackColor = true;
            // 
            // lstpizza
            // 
            this.lstpizza.FormattingEnabled = true;
            this.lstpizza.ItemHeight = 16;
            this.lstpizza.Items.AddRange(new object[] {
            "American Hot",
            "Calypso",
            "Turkish",
            "Pizza Italiano",
            "Extravaganza"});
            this.lstpizza.Location = new System.Drawing.Point(97, 105);
            this.lstpizza.Name = "lstpizza";
            this.lstpizza.Size = new System.Drawing.Size(286, 84);
            this.lstpizza.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Adet :";
            // 
            // cmbEbat
            // 
            this.cmbEbat.BackColor = System.Drawing.Color.White;
            this.cmbEbat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Location = new System.Drawing.Point(97, 75);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(286, 24);
            this.cmbEbat.TabIndex = 27;
            // 
            // rdoKalin
            // 
            this.rdoKalin.AutoSize = true;
            this.rdoKalin.Location = new System.Drawing.Point(288, 204);
            this.rdoKalin.Name = "rdoKalin";
            this.rdoKalin.Size = new System.Drawing.Size(95, 20);
            this.rdoKalin.TabIndex = 26;
            this.rdoKalin.Text = "Kalın Kenar";
            this.rdoKalin.UseVisualStyleBackColor = true;
            // 
            // rdoInce
            // 
            this.rdoInce.AutoSize = true;
            this.rdoInce.Location = new System.Drawing.Point(97, 204);
            this.rdoInce.Name = "rdoInce";
            this.rdoInce.Size = new System.Drawing.Size(91, 20);
            this.rdoInce.TabIndex = 25;
            this.rdoInce.Text = "İnce Kenar";
            this.rdoInce.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ebat :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 57);
            this.label1.TabIndex = 23;
            this.label1.Text = "PİZZA SİPARİŞ EKRANI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 582);
            this.Controls.Add(this.btnsiparisver);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.grpMalzemeler);
            this.Controls.Add(this.lstpizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEbat);
            this.Controls.Add(this.rdoKalin);
            this.Controls.Add(this.rdoInce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                              PİZZA";
            this.grpMalzemeler.ResumeLayout(false);
            this.grpMalzemeler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsiparisver;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.GroupBox grpMalzemeler;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkPeynir;
        private System.Windows.Forms.CheckBox chkSosis;
        private System.Windows.Forms.CheckBox chkTon;
        private System.Windows.Forms.CheckBox chkMisir;
        private System.Windows.Forms.CheckBox chkMantar;
        private System.Windows.Forms.CheckBox chkAncuez;
        private System.Windows.Forms.CheckBox chkSucuk;
        private System.Windows.Forms.CheckBox chkZeytin;
        private System.Windows.Forms.CheckBox chkSalam;
        private System.Windows.Forms.ListBox lstpizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.RadioButton rdoKalin;
        private System.Windows.Forms.RadioButton rdoInce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

