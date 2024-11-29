namespace Klase
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(741, 18);
            this.btnUnesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(163, 39);
            this.btnUnesi.TabIndex = 48;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(76, 62);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(235, 63);
            this.txtOpis.TabIndex = 43;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(457, 102);
            this.txtIzdavac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(235, 22);
            this.txtIzdavac.TabIndex = 47;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(457, 62);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(235, 22);
            this.txtCijena.TabIndex = 46;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(457, 12);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(235, 22);
            this.txtDatum.TabIndex = 45;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(76, 12);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(235, 22);
            this.txtNaziv.TabIndex = 42;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(76, 139);
            this.txtVrsta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(235, 22);
            this.txtVrsta.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Izdavač:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Datum izdavanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Vrsta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Naziv:";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Glavna";
            this.Text = "Popis igara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

