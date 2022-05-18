namespace AS2122_4E_INF_SheqiXhoni_GestioneArticoli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblPrezzo;
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblUnitaMisura = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbUnitaMisura = new System.Windows.Forms.ComboBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblArticoliNumerati = new System.Windows.Forms.Label();
            this.cmdVisualizzaArticoli = new System.Windows.Forms.ComboBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            lblPrezzo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(75, 63);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(44, 15);
            this.lblCodice.TabIndex = 0;
            this.lblCodice.Text = "Codice";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(75, 102);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(67, 15);
            this.lblDescrizione.TabIndex = 1;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblUnitaMisura
            // 
            this.lblUnitaMisura.AutoSize = true;
            this.lblUnitaMisura.Location = new System.Drawing.Point(75, 143);
            this.lblUnitaMisura.Name = "lblUnitaMisura";
            this.lblUnitaMisura.Size = new System.Drawing.Size(88, 15);
            this.lblUnitaMisura.TabIndex = 2;
            this.lblUnitaMisura.Text = "Unità Di Misura";
            // 
            // lblPrezzo
            // 
            lblPrezzo.AutoSize = true;
            lblPrezzo.Location = new System.Drawing.Point(75, 185);
            lblPrezzo.Name = "lblPrezzo";
            lblPrezzo.Size = new System.Drawing.Size(41, 15);
            lblPrezzo.TabIndex = 3;
            lblPrezzo.Text = "Prezzo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aggiungi/modifica articolo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbUnitaMisura
            // 
            this.cmbUnitaMisura.FormattingEnabled = true;
            this.cmbUnitaMisura.Location = new System.Drawing.Point(166, 135);
            this.cmbUnitaMisura.Name = "cmbUnitaMisura";
            this.cmbUnitaMisura.Size = new System.Drawing.Size(46, 23);
            this.cmbUnitaMisura.TabIndex = 5;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(166, 60);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 23);
            this.txtCodice.TabIndex = 6;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(166, 99);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtDescrizione.TabIndex = 7;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(166, 177);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 23);
            this.txtPrezzo.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.lblCodice);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.lblDescrizione);
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Controls.Add(this.lblUnitaMisura);
            this.groupBox1.Controls.Add(this.cmbUnitaMisura);
            this.groupBox1.Controls.Add(lblPrezzo);
            this.groupBox1.Location = new System.Drawing.Point(62, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 343);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dettagli Articolo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblArticoliNumerati
            // 
            this.lblArticoliNumerati.AutoSize = true;
            this.lblArticoliNumerati.Location = new System.Drawing.Point(62, 514);
            this.lblArticoliNumerati.Name = "lblArticoliNumerati";
            this.lblArticoliNumerati.Size = new System.Drawing.Size(16, 15);
            this.lblArticoliNumerati.TabIndex = 10;
            this.lblArticoliNumerati.Text = "...";
            // 
            // cmdVisualizzaArticoli
            // 
            this.cmdVisualizzaArticoli.FormattingEnabled = true;
            this.cmdVisualizzaArticoli.Location = new System.Drawing.Point(730, 106);
            this.cmdVisualizzaArticoli.Name = "cmdVisualizzaArticoli";
            this.cmdVisualizzaArticoli.Size = new System.Drawing.Size(121, 23);
            this.cmdVisualizzaArticoli.TabIndex = 11;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(857, 106);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(37, 23);
            this.btnVisualizza.TabIndex = 12;
            this.btnVisualizza.Text = "...";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(730, 170);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(265, 319);
            this.lstVisualizza.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 647);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.cmdVisualizzaArticoli);
            this.Controls.Add(this.lblArticoliNumerati);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCodice;
        private Label lblDescrizione;
        private Label lblUnitaMisura;
        private Label lblPrezzo;
        private Button button1;
        private ComboBox cmbUnitaMisura;
        private TextBox txtCodice;
        private TextBox txtDescrizione;
        private TextBox txtPrezzo;
        private GroupBox groupBox1;
        private Label lblArticoliNumerati;
        private ComboBox cmdVisualizzaArticoli;
        private Button btnVisualizza;
        private ListBox lstVisualizza;
    }
}