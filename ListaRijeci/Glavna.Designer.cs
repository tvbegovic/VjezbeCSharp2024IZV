namespace ListaRijeci
{
    partial class Glavna
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.btnDodajNaPoziciju = new System.Windows.Forms.Button();
            this.btnDodajNaKraj = new System.Windows.Forms.Button();
            this.txtJednaRijec = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajVise = new System.Windows.Forms.Button();
            this.txtViseRijeci = new System.Windows.Forms.TextBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.lstPopis = new System.Windows.Forms.ListBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPozicija);
            this.groupBox1.Controls.Add(this.btnDodajNaPoziciju);
            this.groupBox1.Controls.Add(this.btnDodajNaKraj);
            this.groupBox1.Controls.Add(this.txtJednaRijec);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(627, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jedna riječ";
            // 
            // txtPozicija
            // 
            this.txtPozicija.Location = new System.Drawing.Point(377, 54);
            this.txtPozicija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(151, 22);
            this.txtPozicija.TabIndex = 2;
            // 
            // btnDodajNaPoziciju
            // 
            this.btnDodajNaPoziciju.Location = new System.Drawing.Point(189, 49);
            this.btnDodajNaPoziciju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajNaPoziciju.Name = "btnDodajNaPoziciju";
            this.btnDodajNaPoziciju.Size = new System.Drawing.Size(165, 33);
            this.btnDodajNaPoziciju.TabIndex = 1;
            this.btnDodajNaPoziciju.Text = "Dodaj riječ na poziciju";
            this.btnDodajNaPoziciju.UseVisualStyleBackColor = true;
            this.btnDodajNaPoziciju.Click += new System.EventHandler(this.btnDodajNaPoziciju_Click);
            // 
            // btnDodajNaKraj
            // 
            this.btnDodajNaKraj.Location = new System.Drawing.Point(5, 49);
            this.btnDodajNaKraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajNaKraj.Name = "btnDodajNaKraj";
            this.btnDodajNaKraj.Size = new System.Drawing.Size(165, 33);
            this.btnDodajNaKraj.TabIndex = 1;
            this.btnDodajNaKraj.Text = "Dodaj riječ na kraj";
            this.btnDodajNaKraj.UseVisualStyleBackColor = true;
            this.btnDodajNaKraj.Click += new System.EventHandler(this.btnDodajNaKraj_Click);
            // 
            // txtJednaRijec
            // 
            this.txtJednaRijec.Location = new System.Drawing.Point(5, 21);
            this.txtJednaRijec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJednaRijec.Name = "txtJednaRijec";
            this.txtJednaRijec.Size = new System.Drawing.Size(521, 22);
            this.txtJednaRijec.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajVise);
            this.groupBox2.Controls.Add(this.txtViseRijeci);
            this.groupBox2.Location = new System.Drawing.Point(21, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(627, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Više riječi";
            // 
            // btnDodajVise
            // 
            this.btnDodajVise.Location = new System.Drawing.Point(495, 22);
            this.btnDodajVise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajVise.Name = "btnDodajVise";
            this.btnDodajVise.Size = new System.Drawing.Size(125, 36);
            this.btnDodajVise.TabIndex = 1;
            this.btnDodajVise.Text = "Dodaj";
            this.btnDodajVise.UseVisualStyleBackColor = true;
            this.btnDodajVise.Click += new System.EventHandler(this.btnDodajVise_Click);
            // 
            // txtViseRijeci
            // 
            this.txtViseRijeci.Location = new System.Drawing.Point(5, 21);
            this.txtViseRijeci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtViseRijeci.Multiline = true;
            this.txtViseRijeci.Name = "txtViseRijeci";
            this.txtViseRijeci.Size = new System.Drawing.Size(468, 98);
            this.txtViseRijeci.TabIndex = 0;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(516, 283);
            this.btnUkloni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(125, 41);
            this.btnUkloni.TabIndex = 3;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // lstPopis
            // 
            this.lstPopis.FormattingEnabled = true;
            this.lstPopis.ItemHeight = 16;
            this.lstPopis.Location = new System.Drawing.Point(26, 283);
            this.lstPopis.Name = "lstPopis";
            this.lstPopis.Size = new System.Drawing.Size(468, 180);
            this.lstPopis.TabIndex = 4;
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(516, 339);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(125, 40);
            this.btnOcisti.TabIndex = 5;
            this.btnOcisti.Text = "Očisti listu";
            this.btnOcisti.UseVisualStyleBackColor = true;
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.lstPopis);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Glavna";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJednaRijec;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.Button btnDodajNaPoziciju;
        private System.Windows.Forms.Button btnDodajNaKraj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajVise;
        private System.Windows.Forms.TextBox txtViseRijeci;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.ListBox lstPopis;
        private System.Windows.Forms.Button btnOcisti;
    }
}

