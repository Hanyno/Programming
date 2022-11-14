namespace SpolecnyDelitel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCislo1 = new System.Windows.Forms.TextBox();
            this.vypocet = new System.Windows.Forms.Button();
            this.tbCislo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVysledek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lPrvniCislo = new System.Windows.Forms.Label();
            this.lDruheCislo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "První číslo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCislo1
            // 
            this.tbCislo1.Location = new System.Drawing.Point(168, 96);
            this.tbCislo1.Name = "tbCislo1";
            this.tbCislo1.Size = new System.Drawing.Size(92, 20);
            this.tbCislo1.TabIndex = 1;
            // 
            // vypocet
            // 
            this.vypocet.Location = new System.Drawing.Point(168, 188);
            this.vypocet.Name = "vypocet";
            this.vypocet.Size = new System.Drawing.Size(92, 23);
            this.vypocet.TabIndex = 2;
            this.vypocet.Text = "Vypočítat";
            this.vypocet.UseVisualStyleBackColor = true;
            this.vypocet.Click += new System.EventHandler(this.vypocet_Click);
            // 
            // tbCislo2
            // 
            this.tbCislo2.Location = new System.Drawing.Point(168, 143);
            this.tbCislo2.Name = "tbCislo2";
            this.tbCislo2.Size = new System.Drawing.Size(92, 20);
            this.tbCislo2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Druhé číslo:";
            // 
            // tbVysledek
            // 
            this.tbVysledek.Location = new System.Drawing.Point(473, 119);
            this.tbVysledek.Name = "tbVysledek";
            this.tbVysledek.Size = new System.Drawing.Size(92, 20);
            this.tbVysledek.TabIndex = 5;
            this.tbVysledek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Největší společný dělitel:";
            // 
            // lPrvniCislo
            // 
            this.lPrvniCislo.AutoSize = true;
            this.lPrvniCislo.Location = new System.Drawing.Point(266, 99);
            this.lPrvniCislo.Name = "lPrvniCislo";
            this.lPrvniCislo.Size = new System.Drawing.Size(0, 13);
            this.lPrvniCislo.TabIndex = 7;
            // 
            // lDruheCislo
            // 
            this.lDruheCislo.AutoSize = true;
            this.lDruheCislo.Location = new System.Drawing.Point(266, 146);
            this.lDruheCislo.Name = "lDruheCislo";
            this.lDruheCislo.Size = new System.Drawing.Size(0, 13);
            this.lDruheCislo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(39, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zadejte dvě přirozená čísla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lDruheCislo);
            this.Controls.Add(this.lPrvniCislo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVysledek);
            this.Controls.Add(this.tbCislo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vypocet);
            this.Controls.Add(this.tbCislo1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Největší společný dělitel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCislo1;
        private System.Windows.Forms.Button vypocet;
        private System.Windows.Forms.TextBox tbCislo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVysledek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lPrvniCislo;
        private System.Windows.Forms.Label lDruheCislo;
        private System.Windows.Forms.Label label4;
    }
}

