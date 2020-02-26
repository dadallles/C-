namespace generator_hasel
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.hasla = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.CheckBox();
            this.duze = new System.Windows.Forms.CheckBox();
            this.cyfry = new System.Windows.Forms.CheckBox();
            this.interp = new System.Windows.Forms.CheckBox();
            this.specjalne = new System.Windows.Forms.CheckBox();
            this.bez_podobnych = new System.Windows.Forms.CheckBox();
            this.ile_znakow = new System.Windows.Forms.NumericUpDown();
            this.ile_hasel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ile_znakow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ile_hasel)).BeginInit();
            this.SuspendLayout();
            // 
            // hasla
            // 
            this.hasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasla.Location = new System.Drawing.Point(12, 153);
            this.hasla.Multiline = true;
            this.hasla.Name = "hasla";
            this.hasla.ReadOnly = true;
            this.hasla.Size = new System.Drawing.Size(691, 485);
            this.hasla.TabIndex = 12;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.CheckState = System.Windows.Forms.CheckState.Checked;
            this.male.Location = new System.Drawing.Point(12, 15);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(74, 17);
            this.male.TabIndex = 1;
            this.male.Text = "małe litery";
            this.male.UseVisualStyleBackColor = true;
            // 
            // duze
            // 
            this.duze.AutoSize = true;
            this.duze.Checked = true;
            this.duze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.duze.Location = new System.Drawing.Point(12, 38);
            this.duze.Name = "duze";
            this.duze.Size = new System.Drawing.Size(73, 17);
            this.duze.TabIndex = 2;
            this.duze.Text = "duze litery";
            this.duze.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            this.cyfry.AutoSize = true;
            this.cyfry.Checked = true;
            this.cyfry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cyfry.Location = new System.Drawing.Point(12, 61);
            this.cyfry.Name = "cyfry";
            this.cyfry.Size = new System.Drawing.Size(48, 17);
            this.cyfry.TabIndex = 3;
            this.cyfry.Text = "cyfry";
            this.cyfry.UseVisualStyleBackColor = true;
            // 
            // interp
            // 
            this.interp.AutoSize = true;
            this.interp.Location = new System.Drawing.Point(12, 84);
            this.interp.Name = "interp";
            this.interp.Size = new System.Drawing.Size(123, 17);
            this.interp.TabIndex = 4;
            this.interp.Text = "znaki interpunkcyjne";
            this.interp.UseVisualStyleBackColor = true;
            // 
            // specjalne
            // 
            this.specjalne.AutoSize = true;
            this.specjalne.Checked = true;
            this.specjalne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.specjalne.Location = new System.Drawing.Point(12, 107);
            this.specjalne.Name = "specjalne";
            this.specjalne.Size = new System.Drawing.Size(99, 17);
            this.specjalne.TabIndex = 5;
            this.specjalne.Text = "znaki specjalne";
            this.specjalne.UseVisualStyleBackColor = true;
            // 
            // bez_podobnych
            // 
            this.bez_podobnych.AutoSize = true;
            this.bez_podobnych.Checked = true;
            this.bez_podobnych.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bez_podobnych.Location = new System.Drawing.Point(12, 130);
            this.bez_podobnych.Name = "bez_podobnych";
            this.bez_podobnych.Size = new System.Drawing.Size(189, 17);
            this.bez_podobnych.TabIndex = 6;
            this.bez_podobnych.Text = "bez znaków podobnych (np.: O, 0)";
            this.bez_podobnych.UseVisualStyleBackColor = true;
            // 
            // ile_znakow
            // 
            this.ile_znakow.Location = new System.Drawing.Point(397, 29);
            this.ile_znakow.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.ile_znakow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ile_znakow.Name = "ile_znakow";
            this.ile_znakow.Size = new System.Drawing.Size(120, 20);
            this.ile_znakow.TabIndex = 7;
            this.ile_znakow.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // ile_hasel
            // 
            this.ile_hasel.Location = new System.Drawing.Point(397, 78);
            this.ile_hasel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ile_hasel.Name = "ile_hasel";
            this.ile_hasel.Size = new System.Drawing.Size(120, 20);
            this.ile_hasel.TabIndex = 8;
            this.ile_hasel.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ile znaków:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ile haseł:";
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(317, 124);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(200, 23);
            this.generuj.TabIndex = 11;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(715, 650);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ile_hasel);
            this.Controls.Add(this.ile_znakow);
            this.Controls.Add(this.bez_podobnych);
            this.Controls.Add(this.specjalne);
            this.Controls.Add(this.interp);
            this.Controls.Add(this.cyfry);
            this.Controls.Add(this.duze);
            this.Controls.Add(this.male);
            this.Controls.Add(this.hasla);
            this.Name = "Form1";
            this.Text = "Generator haseł";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ile_znakow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ile_hasel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hasla;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.CheckBox duze;
        private System.Windows.Forms.CheckBox cyfry;
        private System.Windows.Forms.CheckBox interp;
        private System.Windows.Forms.CheckBox specjalne;
        private System.Windows.Forms.CheckBox bez_podobnych;
        private System.Windows.Forms.NumericUpDown ile_znakow;
        private System.Windows.Forms.NumericUpDown ile_hasel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generuj;
    }
}

