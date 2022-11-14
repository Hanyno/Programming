namespace cv07
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bKouzelnik = new System.Windows.Forms.Button();
            this.bAlfa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblZlato = new System.Windows.Forms.Label();
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.bVytvorit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPocetProtonu = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStav = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPocetProtonu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::cv07.Properties.Resources.zlato;
            this.pictureBox.Location = new System.Drawing.Point(12, 69);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(274, 129);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // bKouzelnik
            // 
            this.bKouzelnik.Location = new System.Drawing.Point(12, 28);
            this.bKouzelnik.Margin = new System.Windows.Forms.Padding(2);
            this.bKouzelnik.Name = "bKouzelnik";
            this.bKouzelnik.Size = new System.Drawing.Size(74, 37);
            this.bKouzelnik.TabIndex = 5;
            this.bKouzelnik.Text = "Kouzelník";
            this.bKouzelnik.UseVisualStyleBackColor = true;
            this.bKouzelnik.Click += new System.EventHandler(this.bKouzelnik_Click);
            // 
            // bAlfa
            // 
            this.bAlfa.Location = new System.Drawing.Point(90, 28);
            this.bAlfa.Margin = new System.Windows.Forms.Padding(2);
            this.bAlfa.Name = "bAlfa";
            this.bAlfa.Size = new System.Drawing.Size(74, 37);
            this.bAlfa.TabIndex = 6;
            this.bAlfa.Text = "Alfa zářič";
            this.bAlfa.UseVisualStyleBackColor = true;
            this.bAlfa.Click += new System.EventHandler(this.bAlfa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblZlato);
            this.groupBox1.Controls.Add(this.bAlfa);
            this.groupBox1.Controls.Add(this.bKouzelnik);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(377, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(290, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Úprava prvku";
            // 
            // lblZlato
            // 
            this.lblZlato.AutoSize = true;
            this.lblZlato.Location = new System.Drawing.Point(209, 40);
            this.lblZlato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZlato.Name = "lblZlato";
            this.lblZlato.Size = new System.Drawing.Size(61, 13);
            this.lblZlato.TabIndex = 7;
            this.lblZlato.Text = "Je to zlato?";
            // 
            // tbNazev
            // 
            this.tbNazev.Location = new System.Drawing.Point(93, 31);
            this.tbNazev.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazev.Name = "tbNazev";
            this.tbNazev.Size = new System.Drawing.Size(74, 20);
            this.tbNazev.TabIndex = 1;
            this.tbNazev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bVytvorit
            // 
            this.bVytvorit.Location = new System.Drawing.Point(93, 80);
            this.bVytvorit.Margin = new System.Windows.Forms.Padding(2);
            this.bVytvorit.Name = "bVytvorit";
            this.bVytvorit.Size = new System.Drawing.Size(74, 37);
            this.bVytvorit.TabIndex = 0;
            this.bVytvorit.Text = "Nový prvek";
            this.bVytvorit.UseVisualStyleBackColor = true;
            this.bVytvorit.Click += new System.EventHandler(this.bVytvorit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název prvku:";
            // 
            // nudPocetProtonu
            // 
            this.nudPocetProtonu.Location = new System.Drawing.Point(93, 56);
            this.nudPocetProtonu.Margin = new System.Windows.Forms.Padding(2);
            this.nudPocetProtonu.Name = "nudPocetProtonu";
            this.nudPocetProtonu.Size = new System.Drawing.Size(74, 20);
            this.nudPocetProtonu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Počet protonů:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStav);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudPocetProtonu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bVytvorit);
            this.groupBox2.Controls.Add(this.tbNazev);
            this.groupBox2.Location = new System.Drawing.Point(34, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(298, 150);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Založení prvku";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblStav
            // 
            this.lblStav.AutoSize = true;
            this.lblStav.Location = new System.Drawing.Point(40, 124);
            this.lblStav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStav.Name = "lblStav";
            this.lblStav.Size = new System.Drawing.Size(35, 13);
            this.lblStav.TabIndex = 9;
            this.lblStav.Text = "Stav: ";
            this.lblStav.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Prvky";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPocetProtonu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bKouzelnik;
        private System.Windows.Forms.Button bAlfa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.Button bVytvorit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPocetProtonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblZlato;
        private System.Windows.Forms.Label lblStav;
    }
}

