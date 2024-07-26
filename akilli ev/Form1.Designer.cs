namespace akilli_ev
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKlima = new System.Windows.Forms.CheckBox();
            this.cbLambalar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDolar = new System.Windows.Forms.Label();
            this.tbEuro = new System.Windows.Forms.Label();
            this.tbMiktar = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.btnCevir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbPara = new System.Windows.Forms.TextBox();
            this.rbTlDolar = new System.Windows.Forms.RadioButton();
            this.rbEuroDolar = new System.Windows.Forms.RadioButton();
            this.rbTlEuro = new System.Windows.Forms.RadioButton();
            this.rbEuroTl = new System.Windows.Forms.RadioButton();
            this.rbDolarTl = new System.Windows.Forms.RadioButton();
            this.rbDolarEuro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbLambalar);
            this.groupBox1.Controls.Add(this.cbKlima);
            this.groupBox1.Location = new System.Drawing.Point(70, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbKlima
            // 
            this.cbKlima.AutoSize = true;
            this.cbKlima.Location = new System.Drawing.Point(19, 34);
            this.cbKlima.Name = "cbKlima";
            this.cbKlima.Size = new System.Drawing.Size(80, 17);
            this.cbKlima.TabIndex = 0;
            this.cbKlima.Text = "checkBox1";
            this.cbKlima.UseVisualStyleBackColor = true;
            // 
            // cbLambalar
            // 
            this.cbLambalar.AutoSize = true;
            this.cbLambalar.Location = new System.Drawing.Point(19, 66);
            this.cbLambalar.Name = "cbLambalar";
            this.cbLambalar.Size = new System.Drawing.Size(80, 17);
            this.cbLambalar.TabIndex = 1;
            this.cbLambalar.Text = "checkBox2";
            this.cbLambalar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(114, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDolarEuro);
            this.groupBox2.Controls.Add(this.rbDolarTl);
            this.groupBox2.Controls.Add(this.rbEuroTl);
            this.groupBox2.Controls.Add(this.rbTlEuro);
            this.groupBox2.Controls.Add(this.rbEuroDolar);
            this.groupBox2.Controls.Add(this.rbTlDolar);
            this.groupBox2.Controls.Add(this.tbPara);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnCevir);
            this.groupBox2.Controls.Add(this.lbSonuc);
            this.groupBox2.Controls.Add(this.tbMiktar);
            this.groupBox2.Controls.Add(this.tbEuro);
            this.groupBox2.Controls.Add(this.tbDolar);
            this.groupBox2.Location = new System.Drawing.Point(104, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbDolar
            // 
            this.tbDolar.AutoSize = true;
            this.tbDolar.Location = new System.Drawing.Point(7, 30);
            this.tbDolar.Name = "tbDolar";
            this.tbDolar.Size = new System.Drawing.Size(32, 13);
            this.tbDolar.TabIndex = 0;
            this.tbDolar.Text = "Dolar";
            // 
            // tbEuro
            // 
            this.tbEuro.AutoSize = true;
            this.tbEuro.Location = new System.Drawing.Point(7, 52);
            this.tbEuro.Name = "tbEuro";
            this.tbEuro.Size = new System.Drawing.Size(29, 13);
            this.tbEuro.TabIndex = 1;
            this.tbEuro.Text = "Euro";
            // 
            // tbMiktar
            // 
            this.tbMiktar.AutoSize = true;
            this.tbMiktar.Location = new System.Drawing.Point(2, 90);
            this.tbMiktar.Name = "tbMiktar";
            this.tbMiktar.Size = new System.Drawing.Size(63, 13);
            this.tbMiktar.TabIndex = 2;
            this.tbMiktar.Text = "Para Miktari";
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(77, 112);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(38, 13);
            this.lbSonuc.TabIndex = 3;
            this.lbSonuc.Text = "Sonuc";
            // 
            // btnCevir
            // 
            this.btnCevir.Location = new System.Drawing.Point(62, 126);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(75, 23);
            this.btnCevir.TabIndex = 4;
            this.btnCevir.Text = "Cevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 6;
            // 
            // tbPara
            // 
            this.tbPara.Location = new System.Drawing.Point(71, 87);
            this.tbPara.Name = "tbPara";
            this.tbPara.Size = new System.Drawing.Size(64, 20);
            this.tbPara.TabIndex = 7;
            // 
            // rbTlDolar
            // 
            this.rbTlDolar.AutoSize = true;
            this.rbTlDolar.Location = new System.Drawing.Point(136, 20);
            this.rbTlDolar.Name = "rbTlDolar";
            this.rbTlDolar.Size = new System.Drawing.Size(60, 17);
            this.rbTlDolar.TabIndex = 8;
            this.rbTlDolar.TabStop = true;
            this.rbTlDolar.Text = "Tl dolar";
            this.rbTlDolar.UseVisualStyleBackColor = true;
            // 
            // rbEuroDolar
            // 
            this.rbEuroDolar.AutoSize = true;
            this.rbEuroDolar.Location = new System.Drawing.Point(136, 66);
            this.rbEuroDolar.Name = "rbEuroDolar";
            this.rbEuroDolar.Size = new System.Drawing.Size(73, 17);
            this.rbEuroDolar.TabIndex = 9;
            this.rbEuroDolar.TabStop = true;
            this.rbEuroDolar.Text = "Euro dolar";
            this.rbEuroDolar.UseVisualStyleBackColor = true;
            // 
            // rbTlEuro
            // 
            this.rbTlEuro.AutoSize = true;
            this.rbTlEuro.Location = new System.Drawing.Point(136, 43);
            this.rbTlEuro.Name = "rbTlEuro";
            this.rbTlEuro.Size = new System.Drawing.Size(59, 17);
            this.rbTlEuro.TabIndex = 9;
            this.rbTlEuro.TabStop = true;
            this.rbTlEuro.Text = "Tl Euro";
            this.rbTlEuro.UseVisualStyleBackColor = true;
            // 
            // rbEuroTl
            // 
            this.rbEuroTl.AutoSize = true;
            this.rbEuroTl.Location = new System.Drawing.Point(237, 43);
            this.rbEuroTl.Name = "rbEuroTl";
            this.rbEuroTl.Size = new System.Drawing.Size(59, 17);
            this.rbEuroTl.TabIndex = 10;
            this.rbEuroTl.TabStop = true;
            this.rbEuroTl.Text = "Euro Tl";
            this.rbEuroTl.UseVisualStyleBackColor = true;
            // 
            // rbDolarTl
            // 
            this.rbDolarTl.AutoSize = true;
            this.rbDolarTl.Location = new System.Drawing.Point(237, 20);
            this.rbDolarTl.Name = "rbDolarTl";
            this.rbDolarTl.Size = new System.Drawing.Size(58, 17);
            this.rbDolarTl.TabIndex = 10;
            this.rbDolarTl.TabStop = true;
            this.rbDolarTl.Text = "Dolar tl";
            this.rbDolarTl.UseVisualStyleBackColor = true;
            // 
            // rbDolarEuro
            // 
            this.rbDolarEuro.AutoSize = true;
            this.rbDolarEuro.Location = new System.Drawing.Point(237, 66);
            this.rbDolarEuro.Name = "rbDolarEuro";
            this.rbDolarEuro.Size = new System.Drawing.Size(75, 17);
            this.rbDolarEuro.TabIndex = 11;
            this.rbDolarEuro.TabStop = true;
            this.rbDolarEuro.Text = "Dolar Euro";
            this.rbDolarEuro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbLambalar;
        private System.Windows.Forms.CheckBox cbKlima;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDolarEuro;
        private System.Windows.Forms.RadioButton rbDolarTl;
        private System.Windows.Forms.RadioButton rbEuroTl;
        private System.Windows.Forms.RadioButton rbTlEuro;
        private System.Windows.Forms.RadioButton rbEuroDolar;
        private System.Windows.Forms.RadioButton rbTlDolar;
        private System.Windows.Forms.TextBox tbPara;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.Label tbMiktar;
        private System.Windows.Forms.Label tbEuro;
        private System.Windows.Forms.Label tbDolar;
    }
}

