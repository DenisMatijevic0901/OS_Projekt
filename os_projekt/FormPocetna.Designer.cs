namespace os_projekt
{
    partial class FormPocetna
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
            this.lbOdaberiteDatoteku = new System.Windows.Forms.Label();
            this.btnOdaberiDatoteku = new System.Windows.Forms.Button();
            this.lbProcitaniTekst = new System.Windows.Forms.Label();
            this.openFileDialogOdaberiDatoteku = new System.Windows.Forms.OpenFileDialog();
            this.tbUcitaniTekst = new System.Windows.Forms.TextBox();
            this.btnGenerirajKljuceve = new System.Windows.Forms.Button();
            this.rbRSA = new System.Windows.Forms.RadioButton();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.lbOdaberiteAlgoritam = new System.Windows.Forms.Label();
            this.btnKriptiraj = new System.Windows.Forms.Button();
            this.btnDekriptiraj = new System.Windows.Forms.Button();
            this.tbKriptiraniTekst = new System.Windows.Forms.TextBox();
            this.tbDekriptiraniTekst = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIzracunajSazetak = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbSazetak = new System.Windows.Forms.Label();
            this.tbSazetak = new System.Windows.Forms.TextBox();
            this.btnIzracunajDigitalniPotpis = new System.Windows.Forms.Button();
            this.lbDigitalniPotpis = new System.Windows.Forms.Label();
            this.tbDigitalniPotpis = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnProvjeriDigitalniPotpis = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOdaberiteDatoteku
            // 
            this.lbOdaberiteDatoteku.AutoSize = true;
            this.lbOdaberiteDatoteku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbOdaberiteDatoteku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOdaberiteDatoteku.Location = new System.Drawing.Point(14, 16);
            this.lbOdaberiteDatoteku.Name = "lbOdaberiteDatoteku";
            this.lbOdaberiteDatoteku.Size = new System.Drawing.Size(156, 18);
            this.lbOdaberiteDatoteku.TabIndex = 0;
            this.lbOdaberiteDatoteku.Text = "Odaberite datoteku:";
            // 
            // btnOdaberiDatoteku
            // 
            this.btnOdaberiDatoteku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberiDatoteku.Location = new System.Drawing.Point(199, 8);
            this.btnOdaberiDatoteku.Name = "btnOdaberiDatoteku";
            this.btnOdaberiDatoteku.Size = new System.Drawing.Size(155, 35);
            this.btnOdaberiDatoteku.TabIndex = 2;
            this.btnOdaberiDatoteku.Text = "Odaberi datoteku";
            this.btnOdaberiDatoteku.UseVisualStyleBackColor = true;
            this.btnOdaberiDatoteku.Click += new System.EventHandler(this.btnOdaberiDatoteku_Click);
            // 
            // lbProcitaniTekst
            // 
            this.lbProcitaniTekst.AutoSize = true;
            this.lbProcitaniTekst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbProcitaniTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbProcitaniTekst.Location = new System.Drawing.Point(25, 63);
            this.lbProcitaniTekst.Name = "lbProcitaniTekst";
            this.lbProcitaniTekst.Size = new System.Drawing.Size(200, 20);
            this.lbProcitaniTekst.TabIndex = 3;
            this.lbProcitaniTekst.Text = "Tekst iz učitane datoteke:";
            // 
            // openFileDialogOdaberiDatoteku
            // 
            this.openFileDialogOdaberiDatoteku.FileName = "openFileDialogOdaberiDatoteku";
            // 
            // tbUcitaniTekst
            // 
            this.tbUcitaniTekst.Location = new System.Drawing.Point(29, 87);
            this.tbUcitaniTekst.Multiline = true;
            this.tbUcitaniTekst.Name = "tbUcitaniTekst";
            this.tbUcitaniTekst.Size = new System.Drawing.Size(337, 53);
            this.tbUcitaniTekst.TabIndex = 4;
            // 
            // btnGenerirajKljuceve
            // 
            this.btnGenerirajKljuceve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerirajKljuceve.Location = new System.Drawing.Point(29, 161);
            this.btnGenerirajKljuceve.Name = "btnGenerirajKljuceve";
            this.btnGenerirajKljuceve.Size = new System.Drawing.Size(337, 35);
            this.btnGenerirajKljuceve.TabIndex = 5;
            this.btnGenerirajKljuceve.Text = "GENERIRAJ KLJUČEVE";
            this.btnGenerirajKljuceve.UseVisualStyleBackColor = true;
            this.btnGenerirajKljuceve.Click += new System.EventHandler(this.btnGenerirajKljuceve_Click);
            // 
            // rbRSA
            // 
            this.rbRSA.AutoSize = true;
            this.rbRSA.Location = new System.Drawing.Point(112, 43);
            this.rbRSA.Name = "rbRSA";
            this.rbRSA.Size = new System.Drawing.Size(56, 20);
            this.rbRSA.TabIndex = 6;
            this.rbRSA.TabStop = true;
            this.rbRSA.Text = "RSA";
            this.rbRSA.UseVisualStyleBackColor = true;
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(207, 43);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(55, 20);
            this.rbAES.TabIndex = 7;
            this.rbAES.TabStop = true;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            // 
            // lbOdaberiteAlgoritam
            // 
            this.lbOdaberiteAlgoritam.AutoSize = true;
            this.lbOdaberiteAlgoritam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOdaberiteAlgoritam.Location = new System.Drawing.Point(27, 10);
            this.lbOdaberiteAlgoritam.Name = "lbOdaberiteAlgoritam";
            this.lbOdaberiteAlgoritam.Size = new System.Drawing.Size(271, 20);
            this.lbOdaberiteAlgoritam.TabIndex = 8;
            this.lbOdaberiteAlgoritam.Text = "Odaberite algoritam kriptiranja:";
            // 
            // btnKriptiraj
            // 
            this.btnKriptiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKriptiraj.Location = new System.Drawing.Point(17, 13);
            this.btnKriptiraj.Name = "btnKriptiraj";
            this.btnKriptiraj.Size = new System.Drawing.Size(165, 43);
            this.btnKriptiraj.TabIndex = 9;
            this.btnKriptiraj.Text = "KRIPTIRAJ";
            this.btnKriptiraj.UseVisualStyleBackColor = true;
            this.btnKriptiraj.Click += new System.EventHandler(this.btnKriptiraj_Click);
            // 
            // btnDekriptiraj
            // 
            this.btnDekriptiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDekriptiraj.Location = new System.Drawing.Point(188, 13);
            this.btnDekriptiraj.Name = "btnDekriptiraj";
            this.btnDekriptiraj.Size = new System.Drawing.Size(166, 43);
            this.btnDekriptiraj.TabIndex = 10;
            this.btnDekriptiraj.Text = "DEKRIPTIRAJ";
            this.btnDekriptiraj.UseVisualStyleBackColor = true;
            this.btnDekriptiraj.Click += new System.EventHandler(this.btnDekriptiraj_Click);
            // 
            // tbKriptiraniTekst
            // 
            this.tbKriptiraniTekst.Location = new System.Drawing.Point(17, 77);
            this.tbKriptiraniTekst.Multiline = true;
            this.tbKriptiraniTekst.Name = "tbKriptiraniTekst";
            this.tbKriptiraniTekst.Size = new System.Drawing.Size(165, 182);
            this.tbKriptiraniTekst.TabIndex = 11;
            // 
            // tbDekriptiraniTekst
            // 
            this.tbDekriptiraniTekst.Location = new System.Drawing.Point(188, 77);
            this.tbDekriptiraniTekst.Multiline = true;
            this.tbDekriptiraniTekst.Name = "tbDekriptiraniTekst";
            this.tbDekriptiraniTekst.Size = new System.Drawing.Size(166, 182);
            this.tbDekriptiraniTekst.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnOdaberiDatoteku);
            this.panel1.Controls.Add(this.lbOdaberiteDatoteku);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 134);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(12, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 52);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lbOdaberiteAlgoritam);
            this.panel3.Controls.Add(this.rbRSA);
            this.panel3.Controls.Add(this.rbAES);
            this.panel3.Location = new System.Drawing.Point(12, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 75);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnDekriptiraj);
            this.panel4.Controls.Add(this.tbDekriptiraniTekst);
            this.panel4.Controls.Add(this.btnKriptiraj);
            this.panel4.Controls.Add(this.tbKriptiraniTekst);
            this.panel4.Location = new System.Drawing.Point(12, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 272);
            this.panel4.TabIndex = 16;
            // 
            // btnIzracunajSazetak
            // 
            this.btnIzracunajSazetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunajSazetak.Location = new System.Drawing.Point(88, 8);
            this.btnIzracunajSazetak.Name = "btnIzracunajSazetak";
            this.btnIzracunajSazetak.Size = new System.Drawing.Size(198, 71);
            this.btnIzracunajSazetak.TabIndex = 17;
            this.btnIzracunajSazetak.Text = "IZRAČUNAJ SAŽETAK";
            this.btnIzracunajSazetak.UseVisualStyleBackColor = true;
            this.btnIzracunajSazetak.Click += new System.EventHandler(this.btnIzracunajSazetak_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.lbSazetak);
            this.panel5.Controls.Add(this.tbSazetak);
            this.panel5.Controls.Add(this.btnIzracunajSazetak);
            this.panel5.Location = new System.Drawing.Point(394, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 192);
            this.panel5.TabIndex = 16;
            // 
            // lbSazetak
            // 
            this.lbSazetak.AutoSize = true;
            this.lbSazetak.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSazetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSazetak.Location = new System.Drawing.Point(13, 89);
            this.lbSazetak.Name = "lbSazetak";
            this.lbSazetak.Size = new System.Drawing.Size(142, 20);
            this.lbSazetak.TabIndex = 17;
            this.lbSazetak.Text = "Sažetak datoteke:";
            // 
            // tbSazetak
            // 
            this.tbSazetak.Location = new System.Drawing.Point(17, 117);
            this.tbSazetak.Multiline = true;
            this.tbSazetak.Name = "tbSazetak";
            this.tbSazetak.Size = new System.Drawing.Size(325, 52);
            this.tbSazetak.TabIndex = 17;
            // 
            // btnIzracunajDigitalniPotpis
            // 
            this.btnIzracunajDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunajDigitalniPotpis.Location = new System.Drawing.Point(88, 17);
            this.btnIzracunajDigitalniPotpis.Name = "btnIzracunajDigitalniPotpis";
            this.btnIzracunajDigitalniPotpis.Size = new System.Drawing.Size(198, 71);
            this.btnIzracunajDigitalniPotpis.TabIndex = 18;
            this.btnIzracunajDigitalniPotpis.Text = "IZRAČUNAJ DIGITALNI POTPIS";
            this.btnIzracunajDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnIzracunajDigitalniPotpis.Click += new System.EventHandler(this.btnIzracunajDigitalniPotpis_Click);
            // 
            // lbDigitalniPotpis
            // 
            this.lbDigitalniPotpis.AutoSize = true;
            this.lbDigitalniPotpis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDigitalniPotpis.Location = new System.Drawing.Point(407, 320);
            this.lbDigitalniPotpis.Name = "lbDigitalniPotpis";
            this.lbDigitalniPotpis.Size = new System.Drawing.Size(193, 20);
            this.lbDigitalniPotpis.TabIndex = 18;
            this.lbDigitalniPotpis.Text = "Digitalni potpis datoteke:";
            // 
            // tbDigitalniPotpis
            // 
            this.tbDigitalniPotpis.Location = new System.Drawing.Point(411, 348);
            this.tbDigitalniPotpis.Multiline = true;
            this.tbDigitalniPotpis.Name = "tbDigitalniPotpis";
            this.tbDigitalniPotpis.Size = new System.Drawing.Size(325, 108);
            this.tbDigitalniPotpis.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.btnIzracunajDigitalniPotpis);
            this.panel6.Location = new System.Drawing.Point(394, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(355, 250);
            this.panel6.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(646, 486);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 71);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnProvjeriDigitalniPotpis
            // 
            this.btnProvjeriDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProvjeriDigitalniPotpis.Location = new System.Drawing.Point(17, 8);
            this.btnProvjeriDigitalniPotpis.Name = "btnProvjeriDigitalniPotpis";
            this.btnProvjeriDigitalniPotpis.Size = new System.Drawing.Size(201, 71);
            this.btnProvjeriDigitalniPotpis.TabIndex = 20;
            this.btnProvjeriDigitalniPotpis.Text = "PROVJERI DIGITALNI POTPIS";
            this.btnProvjeriDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnProvjeriDigitalniPotpis.Click += new System.EventHandler(this.btnProvjeriDigitalniPotpis_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.btnProvjeriDigitalniPotpis);
            this.panel7.Location = new System.Drawing.Point(394, 478);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 92);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Location = new System.Drawing.Point(631, 478);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(118, 92);
            this.panel8.TabIndex = 16;
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 595);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lbDigitalniPotpis);
            this.Controls.Add(this.tbDigitalniPotpis);
            this.Controls.Add(this.btnGenerirajKljuceve);
            this.Controls.Add(this.tbUcitaniTekst);
            this.Controls.Add(this.lbProcitaniTekst);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Name = "FormPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt - Digitalni potpis";
            this.Load += new System.EventHandler(this.FormPocetna_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOdaberiteDatoteku;
        private System.Windows.Forms.Button btnOdaberiDatoteku;
        private System.Windows.Forms.Label lbProcitaniTekst;
        private System.Windows.Forms.OpenFileDialog openFileDialogOdaberiDatoteku;
        private System.Windows.Forms.TextBox tbUcitaniTekst;
        private System.Windows.Forms.Button btnGenerirajKljuceve;
        private System.Windows.Forms.RadioButton rbRSA;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.Label lbOdaberiteAlgoritam;
        private System.Windows.Forms.Button btnKriptiraj;
        private System.Windows.Forms.Button btnDekriptiraj;
        private System.Windows.Forms.TextBox tbKriptiraniTekst;
        private System.Windows.Forms.TextBox tbDekriptiraniTekst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnIzracunajSazetak;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbSazetak;
        private System.Windows.Forms.TextBox tbSazetak;
        private System.Windows.Forms.Button btnIzracunajDigitalniPotpis;
        private System.Windows.Forms.Label lbDigitalniPotpis;
        private System.Windows.Forms.TextBox tbDigitalniPotpis;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnProvjeriDigitalniPotpis;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}

