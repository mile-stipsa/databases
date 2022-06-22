namespace Neo4jBasket.Forme
{
    partial class DodajUtakmicu
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
            this.lblProtivnik = new System.Windows.Forms.Label();
            this.txtProtivnik = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProtivnik
            // 
            this.lblProtivnik.AutoSize = true;
            this.lblProtivnik.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtivnik.Location = new System.Drawing.Point(12, 6);
            this.lblProtivnik.Name = "lblProtivnik";
            this.lblProtivnik.Size = new System.Drawing.Size(87, 17);
            this.lblProtivnik.TabIndex = 0;
            this.lblProtivnik.Text = "Protivnik:";
            // 
            // txtProtivnik
            // 
            this.txtProtivnik.Location = new System.Drawing.Point(105, 6);
            this.txtProtivnik.Name = "txtProtivnik";
            this.txtProtivnik.Size = new System.Drawing.Size(140, 20);
            this.txtProtivnik.TabIndex = 1;
            this.txtProtivnik.TextChanged += new System.EventHandler(this.txtProtivnik_TextChanged);
            this.txtProtivnik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProtivnik_KeyPress);
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(105, 35);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(140, 20);
            this.txtRezultat.TabIndex = 3;
            this.txtRezultat.TextChanged += new System.EventHandler(this.txtProtivnik_TextChanged);
            this.txtRezultat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRezultat_KeyPress);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultat.Location = new System.Drawing.Point(12, 35);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(79, 17);
            this.lblRezultat.TabIndex = 2;
            this.lblRezultat.Text = "Rezultat:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 59);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(123, 59);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(116, 23);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // DodajUtakmicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 94);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.txtProtivnik);
            this.Controls.Add(this.lblProtivnik);
            this.Name = "DodajUtakmicu";
            this.Text = "DodajUtakmicu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProtivnik;
        private System.Windows.Forms.TextBox txtProtivnik;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOtkazi;
    }
}