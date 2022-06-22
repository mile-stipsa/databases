namespace CassandraMusicBand.Forme
{
    partial class PesmeNaAlbumu
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
            this.dgvPesme = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesme
            // 
            this.dgvPesme.BackgroundColor = System.Drawing.Color.White;
            this.dgvPesme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesme.Location = new System.Drawing.Point(13, 26);
            this.dgvPesme.Name = "dgvPesme";
            this.dgvPesme.Size = new System.Drawing.Size(339, 353);
            this.dgvPesme.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj pesmu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PesmeNaAlbumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPesme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PesmeNaAlbumu";
            this.Text = "PesmeNaAlbumu";
            this.Load += new System.EventHandler(this.PesmeNaAlbumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesme;
        private System.Windows.Forms.Button button1;
    }
}