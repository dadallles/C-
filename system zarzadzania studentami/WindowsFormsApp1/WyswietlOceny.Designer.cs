namespace WindowsFormsApp1
{
    partial class WyswietlOceny
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
            this.labelStudent = new System.Windows.Forms.Label();
            this.wys_dataGridView = new System.Windows.Forms.DataGridView();
            this.wys_przedmiot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wys_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wys_ocena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wys_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(12, 23);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(35, 13);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = "label1";
            // 
            // wys_dataGridView
            // 
            this.wys_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wys_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wys_przedmiot,
            this.wys_data,
            this.wys_ocena});
            this.wys_dataGridView.Location = new System.Drawing.Point(12, 49);
            this.wys_dataGridView.Name = "wys_dataGridView";
            this.wys_dataGridView.Size = new System.Drawing.Size(344, 255);
            this.wys_dataGridView.TabIndex = 1;
            // 
            // wys_przedmiot
            // 
            this.wys_przedmiot.HeaderText = "Przedmiot";
            this.wys_przedmiot.Name = "wys_przedmiot";
            // 
            // wys_data
            // 
            this.wys_data.HeaderText = "Data";
            this.wys_data.Name = "wys_data";
            // 
            // wys_ocena
            // 
            this.wys_ocena.HeaderText = "Ocena";
            this.wys_ocena.Name = "wys_ocena";
            // 
            // WyswietlOceny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 316);
            this.Controls.Add(this.wys_dataGridView);
            this.Controls.Add(this.labelStudent);
            this.Name = "WyswietlOceny";
            this.Text = "WyswietlOceny";
            ((System.ComponentModel.ISupportInitialize)(this.wys_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.DataGridView wys_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn wys_przedmiot;
        private System.Windows.Forms.DataGridViewTextBoxColumn wys_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn wys_ocena;
    }
}