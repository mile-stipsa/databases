namespace MongoDBBasket.Forme
{
    partial class Dostignuca
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
            this.dgvEvroligaPobednik = new System.Windows.Forms.DataGridView();
            this.btnEvroligaPobednik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvroligaPobednik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvroligaPobednik
            // 
            this.dgvEvroligaPobednik.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvroligaPobednik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvroligaPobednik.Location = new System.Drawing.Point(12, 12);
            this.dgvEvroligaPobednik.Name = "dgvEvroligaPobednik";
            this.dgvEvroligaPobednik.Size = new System.Drawing.Size(240, 371);
            this.dgvEvroligaPobednik.TabIndex = 0;
            // 
            // btnEvroligaPobednik
            // 
            this.btnEvroligaPobednik.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvroligaPobednik.Location = new System.Drawing.Point(12, 398);
            this.btnEvroligaPobednik.Name = "btnEvroligaPobednik";
            this.btnEvroligaPobednik.Size = new System.Drawing.Size(240, 40);
            this.btnEvroligaPobednik.TabIndex = 6;
            this.btnEvroligaPobednik.Text = "Dodaj godinu";
            this.btnEvroligaPobednik.UseVisualStyleBackColor = true;
            this.btnEvroligaPobednik.Click += new System.EventHandler(this.btnEvroligaPobednik_Click);
            // 
            // Dostignuca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.btnEvroligaPobednik);
            this.Controls.Add(this.dgvEvroligaPobednik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dostignuca";
            this.Text = "Dostignuca";
            this.Load += new System.EventHandler(this.Dostignuca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvroligaPobednik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvroligaPobednik;
        private System.Windows.Forms.Button btnEvroligaPobednik;
    }
}