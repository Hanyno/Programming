namespace UPA009
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPocetCisel = new System.Windows.Forms.TextBox();
            this.tbCislo = new System.Windows.Forms.TextBox();
            this.lPocetCisel = new System.Windows.Forms.Label();
            this.lCislo = new System.Windows.Forms.Label();
            this.bUlozPocetCisel = new System.Windows.Forms.Button();
            this.bUlozCislo = new System.Windows.Forms.Button();
            this.lNejcetnejsiCislo = new System.Windows.Forms.Label();
            this.bNejcetnejsiCislo = new System.Windows.Forms.Button();
            this.lZadaneCisla = new System.Windows.Forms.Label();
            this.tbZadaneCisla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPocetCisel
            // 
            this.tbPocetCisel.Location = new System.Drawing.Point(82, 31);
            this.tbPocetCisel.Name = "tbPocetCisel";
            this.tbPocetCisel.Size = new System.Drawing.Size(52, 20);
            this.tbPocetCisel.TabIndex = 0;
            this.tbPocetCisel.TextChanged += new System.EventHandler(this.tbPocetCisel_TextChanged);
            // 
            // tbCislo
            // 
            this.tbCislo.Enabled = false;
            this.tbCislo.Location = new System.Drawing.Point(82, 57);
            this.tbCislo.Name = "tbCislo";
            this.tbCislo.Size = new System.Drawing.Size(52, 20);
            this.tbCislo.TabIndex = 1;
            // 
            // lPocetCisel
            // 
            this.lPocetCisel.AutoSize = true;
            this.lPocetCisel.Location = new System.Drawing.Point(12, 34);
            this.lPocetCisel.Name = "lPocetCisel";
            this.lPocetCisel.Size = new System.Drawing.Size(64, 13);
            this.lPocetCisel.TabIndex = 2;
            this.lPocetCisel.Text = "Počet čísel:";
            // 
            // lCislo
            // 
            this.lCislo.AutoSize = true;
            this.lCislo.Location = new System.Drawing.Point(42, 60);
            this.lCislo.Name = "lCislo";
            this.lCislo.Size = new System.Drawing.Size(34, 13);
            this.lCislo.TabIndex = 3;
            this.lCislo.Text = "Číslo:";
            // 
            // bUlozPocetCisel
            // 
            this.bUlozPocetCisel.Location = new System.Drawing.Point(165, 29);
            this.bUlozPocetCisel.Name = "bUlozPocetCisel";
            this.bUlozPocetCisel.Size = new System.Drawing.Size(108, 23);
            this.bUlozPocetCisel.TabIndex = 4;
            this.bUlozPocetCisel.Text = "Uložit počet čísel";
            this.bUlozPocetCisel.UseVisualStyleBackColor = true;
            this.bUlozPocetCisel.Click += new System.EventHandler(this.bUlozPocetCisel_Click);
            // 
            // bUlozCislo
            // 
            this.bUlozCislo.Enabled = false;
            this.bUlozCislo.Location = new System.Drawing.Point(165, 55);
            this.bUlozCislo.Name = "bUlozCislo";
            this.bUlozCislo.Size = new System.Drawing.Size(108, 23);
            this.bUlozCislo.TabIndex = 5;
            this.bUlozCislo.Text = "Uložit číslo";
            this.bUlozCislo.UseVisualStyleBackColor = true;
            this.bUlozCislo.Click += new System.EventHandler(this.bUlozCislo_Click);
            // 
            // lNejcetnejsiCislo
            // 
            this.lNejcetnejsiCislo.AutoSize = true;
            this.lNejcetnejsiCislo.Location = new System.Drawing.Point(140, 133);
            this.lNejcetnejsiCislo.Name = "lNejcetnejsiCislo";
            this.lNejcetnejsiCislo.Size = new System.Drawing.Size(101, 13);
            this.lNejcetnejsiCislo.TabIndex = 6;
            this.lNejcetnejsiCislo.Text = "Nejčetnější číslo je:";
            // 
            // bNejcetnejsiCislo
            // 
            this.bNejcetnejsiCislo.Location = new System.Drawing.Point(15, 128);
            this.bNejcetnejsiCislo.Name = "bNejcetnejsiCislo";
            this.bNejcetnejsiCislo.Size = new System.Drawing.Size(119, 23);
            this.bNejcetnejsiCislo.TabIndex = 7;
            this.bNejcetnejsiCislo.Text = "Zjisti nejčetnější číslo";
            this.bNejcetnejsiCislo.UseVisualStyleBackColor = true;
            this.bNejcetnejsiCislo.Click += new System.EventHandler(this.bNejcetnejsiCislo_Click);
            // 
            // lZadaneCisla
            // 
            this.lZadaneCisla.AutoSize = true;
            this.lZadaneCisla.Location = new System.Drawing.Point(22, 98);
            this.lZadaneCisla.Name = "lZadaneCisla";
            this.lZadaneCisla.Size = new System.Drawing.Size(73, 13);
            this.lZadaneCisla.TabIndex = 8;
            this.lZadaneCisla.Text = "Zadané čísla:";
            // 
            // tbZadaneCisla
            // 
            this.tbZadaneCisla.Location = new System.Drawing.Point(101, 95);
            this.tbZadaneCisla.Name = "tbZadaneCisla";
            this.tbZadaneCisla.Size = new System.Drawing.Size(172, 20);
            this.tbZadaneCisla.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 168);
            this.Controls.Add(this.tbZadaneCisla);
            this.Controls.Add(this.lZadaneCisla);
            this.Controls.Add(this.bNejcetnejsiCislo);
            this.Controls.Add(this.lNejcetnejsiCislo);
            this.Controls.Add(this.bUlozCislo);
            this.Controls.Add(this.bUlozPocetCisel);
            this.Controls.Add(this.lCislo);
            this.Controls.Add(this.lPocetCisel);
            this.Controls.Add(this.tbCislo);
            this.Controls.Add(this.tbPocetCisel);
            this.Name = "Form1";
            this.Text = "Nejčetnější číslo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPocetCisel;
        private System.Windows.Forms.TextBox tbCislo;
        private System.Windows.Forms.Label lPocetCisel;
        private System.Windows.Forms.Label lCislo;
        private System.Windows.Forms.Button bUlozPocetCisel;
        private System.Windows.Forms.Button bUlozCislo;
        private System.Windows.Forms.Label lNejcetnejsiCislo;
        private System.Windows.Forms.Button bNejcetnejsiCislo;
        private System.Windows.Forms.Label lZadaneCisla;
        private System.Windows.Forms.TextBox tbZadaneCisla;
    }
}

