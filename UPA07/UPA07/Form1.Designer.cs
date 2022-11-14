namespace UPA07
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
            this.bVytvorit = new System.Windows.Forms.Button();
            this.lNazev = new System.Windows.Forms.Label();
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.lVykon = new System.Windows.Forms.Label();
            this.tbVykon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lStav = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbVykonUpravenehoAuta = new System.Windows.Forms.TextBox();
            this.lVykonUpravenehoAuta = new System.Windows.Forms.Label();
            this.bChip = new System.Windows.Forms.Button();
            this.bTurbo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bVytvorit
            // 
            this.bVytvorit.Location = new System.Drawing.Point(32, 114);
            this.bVytvorit.Name = "bVytvorit";
            this.bVytvorit.Size = new System.Drawing.Size(168, 63);
            this.bVytvorit.TabIndex = 0;
            this.bVytvorit.Text = "Nové auto";
            this.bVytvorit.UseVisualStyleBackColor = true;
            this.bVytvorit.Click += new System.EventHandler(this.bVytvorit_Click);
            // 
            // lNazev
            // 
            this.lNazev.AutoSize = true;
            this.lNazev.Location = new System.Drawing.Point(29, 36);
            this.lNazev.Name = "lNazev";
            this.lNazev.Size = new System.Drawing.Size(65, 13);
            this.lNazev.TabIndex = 1;
            this.lNazev.Text = "Název auta:";
            // 
            // tbNazev
            // 
            this.tbNazev.Location = new System.Drawing.Point(100, 33);
            this.tbNazev.Name = "tbNazev";
            this.tbNazev.Size = new System.Drawing.Size(100, 20);
            this.tbNazev.TabIndex = 2;
            // 
            // lVykon
            // 
            this.lVykon.AutoSize = true;
            this.lVykon.Location = new System.Drawing.Point(4, 77);
            this.lVykon.Name = "lVykon";
            this.lVykon.Size = new System.Drawing.Size(90, 13);
            this.lVykon.TabIndex = 4;
            this.lVykon.Text = "Výkon auta (kW):";
            this.lVykon.Click += new System.EventHandler(this.lVykon_Click);
            // 
            // tbVykon
            // 
            this.tbVykon.Location = new System.Drawing.Point(100, 74);
            this.tbVykon.Name = "tbVykon";
            this.tbVykon.Size = new System.Drawing.Size(100, 20);
            this.tbVykon.TabIndex = 6;
            this.tbVykon.TextChanged += new System.EventHandler(this.tbVykon_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lStav);
            this.groupBox1.Controls.Add(this.tbVykon);
            this.groupBox1.Controls.Add(this.lVykon);
            this.groupBox1.Controls.Add(this.tbNazev);
            this.groupBox1.Controls.Add(this.lNazev);
            this.groupBox1.Controls.Add(this.bVytvorit);
            this.groupBox1.Location = new System.Drawing.Point(62, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 259);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vytvoření auta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lStav
            // 
            this.lStav.AutoSize = true;
            this.lStav.Location = new System.Drawing.Point(29, 199);
            this.lStav.Name = "lStav";
            this.lStav.Size = new System.Drawing.Size(32, 13);
            this.lStav.TabIndex = 7;
            this.lStav.Text = "Stav:";
            this.lStav.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbVykonUpravenehoAuta);
            this.groupBox2.Controls.Add(this.lVykonUpravenehoAuta);
            this.groupBox2.Controls.Add(this.bChip);
            this.groupBox2.Controls.Add(this.bTurbo);
            this.groupBox2.Location = new System.Drawing.Point(399, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 259);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Úprava auta";
            // 
            // tbVykonUpravenehoAuta
            // 
            this.tbVykonUpravenehoAuta.Location = new System.Drawing.Point(162, 212);
            this.tbVykonUpravenehoAuta.Name = "tbVykonUpravenehoAuta";
            this.tbVykonUpravenehoAuta.Size = new System.Drawing.Size(100, 20);
            this.tbVykonUpravenehoAuta.TabIndex = 7;
            // 
            // lVykonUpravenehoAuta
            // 
            this.lVykonUpravenehoAuta.AutoSize = true;
            this.lVykonUpravenehoAuta.Location = new System.Drawing.Point(12, 215);
            this.lVykonUpravenehoAuta.Name = "lVykonUpravenehoAuta";
            this.lVykonUpravenehoAuta.Size = new System.Drawing.Size(150, 13);
            this.lVykonUpravenehoAuta.TabIndex = 5;
            this.lVykonUpravenehoAuta.Text = "Výkon upraveného auta (kW):";
            // 
            // bChip
            // 
            this.bChip.Enabled = false;
            this.bChip.Location = new System.Drawing.Point(20, 92);
            this.bChip.Name = "bChip";
            this.bChip.Size = new System.Drawing.Size(227, 46);
            this.bChip.TabIndex = 2;
            this.bChip.Text = "Chipnout auto";
            this.bChip.UseVisualStyleBackColor = true;
            this.bChip.Click += new System.EventHandler(this.button1_Click);
            // 
            // bTurbo
            // 
            this.bTurbo.Enabled = false;
            this.bTurbo.Location = new System.Drawing.Point(20, 33);
            this.bTurbo.Name = "bTurbo";
            this.bTurbo.Size = new System.Drawing.Size(227, 46);
            this.bTurbo.TabIndex = 1;
            this.bTurbo.Text = "Přidat turbo";
            this.bTurbo.UseVisualStyleBackColor = true;
            this.bTurbo.Click += new System.EventHandler(this.bTurbo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Auta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bVytvorit;
        private System.Windows.Forms.Label lNazev;
        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.Label lVykon;
        private System.Windows.Forms.TextBox tbVykon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lStav;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbVykonUpravenehoAuta;
        private System.Windows.Forms.Label lVykonUpravenehoAuta;
        private System.Windows.Forms.Button bChip;
        private System.Windows.Forms.Button bTurbo;
    }
}

