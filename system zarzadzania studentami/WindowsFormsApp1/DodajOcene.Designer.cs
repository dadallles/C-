namespace WindowsFormsApp1
{
    partial class DodajOcene
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.przedmiot = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.wartosc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przedmiot;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wartosc:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // przedmiot
            // 
            this.przedmiot.Location = new System.Drawing.Point(98, 29);
            this.przedmiot.Name = "przedmiot";
            this.przedmiot.Size = new System.Drawing.Size(291, 20);
            this.przedmiot.TabIndex = 6;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(98, 79);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(291, 20);
            this.data.TabIndex = 7;
            // 
            // wartosc
            // 
            this.wartosc.Location = new System.Drawing.Point(98, 130);
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(291, 20);
            this.wartosc.TabIndex = 8;
            // 
            // DodajOcene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 237);
            this.Controls.Add(this.wartosc);
            this.Controls.Add(this.data);
            this.Controls.Add(this.przedmiot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajOcene";
            this.Text = "DodajOcene";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox przedmiot;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox wartosc;
    }
}