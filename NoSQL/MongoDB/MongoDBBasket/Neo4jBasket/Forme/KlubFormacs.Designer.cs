namespace MongoDBBasket
{
    partial class KlubFormacs
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
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.lblRoster = new System.Windows.Forms.Label();
            this.lblTrener = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.btnTimovi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblUtakmice = new System.Windows.Forms.Label();
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.btnDodajUtakmicu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.BackgroundColor = System.Drawing.Color.White;
            this.dgvIgraci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Location = new System.Drawing.Point(12, 33);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            this.dgvIgraci.Size = new System.Drawing.Size(444, 358);
            this.dgvIgraci.TabIndex = 0;
            this.dgvIgraci.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIgraci_RowHeaderMouseDoubleClick);
            // 
            // lblRoster
            // 
            this.lblRoster.AutoSize = true;
            this.lblRoster.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoster.Location = new System.Drawing.Point(126, 9);
            this.lblRoster.Name = "lblRoster";
            this.lblRoster.Size = new System.Drawing.Size(162, 21);
            this.lblRoster.TabIndex = 1;
            this.lblRoster.Text = "Trenutni roster";
            // 
            // lblTrener
            // 
            this.lblTrener.AutoSize = true;
            this.lblTrener.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrener.Location = new System.Drawing.Point(606, 9);
            this.lblTrener.Name = "lblTrener";
            this.lblTrener.Size = new System.Drawing.Size(83, 24);
            this.lblTrener.TabIndex = 2;
            this.lblTrener.Text = "Trener";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(563, 46);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(41, 17);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(563, 63);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(74, 17);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodina.Location = new System.Drawing.Point(563, 80);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(140, 17);
            this.lblGodina.TabIndex = 5;
            this.lblGodina.Text = "Godina rodjenja: ";
            // 
            // btnTimovi
            // 
            this.btnTimovi.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimovi.Location = new System.Drawing.Point(522, 100);
            this.btnTimovi.Name = "btnTimovi";
            this.btnTimovi.Size = new System.Drawing.Size(239, 23);
            this.btnTimovi.TabIndex = 6;
            this.btnTimovi.Text = "Pogledaj prethodne timove trenera";
            this.btnTimovi.UseVisualStyleBackColor = true;
            this.btnTimovi.Click += new System.EventHandler(this.btnTimovi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 398);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(198, 40);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj igraca u roster";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(216, 398);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(240, 40);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Otpusti igraca iz rostera";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblUtakmice
            // 
            this.lblUtakmice.AutoSize = true;
            this.lblUtakmice.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtakmice.Location = new System.Drawing.Point(563, 147);
            this.lblUtakmice.Name = "lblUtakmice";
            this.lblUtakmice.Size = new System.Drawing.Size(164, 17);
            this.lblUtakmice.TabIndex = 9;
            this.lblUtakmice.Text = "Prethodne utakmice";
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.BackgroundColor = System.Drawing.Color.White;
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmice.Location = new System.Drawing.Point(462, 167);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.Size = new System.Drawing.Size(343, 224);
            this.dgvUtakmice.TabIndex = 10;
            // 
            // btnDodajUtakmicu
            // 
            this.btnDodajUtakmicu.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUtakmicu.Location = new System.Drawing.Point(566, 397);
            this.btnDodajUtakmicu.Name = "btnDodajUtakmicu";
            this.btnDodajUtakmicu.Size = new System.Drawing.Size(161, 40);
            this.btnDodajUtakmicu.TabIndex = 11;
            this.btnDodajUtakmicu.Text = "Dodaj utakmicu";
            this.btnDodajUtakmicu.UseVisualStyleBackColor = true;
            this.btnDodajUtakmicu.Click += new System.EventHandler(this.btnDodajUtakmicu_Click);
            // 
            // KlubFormacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.btnDodajUtakmicu);
            this.Controls.Add(this.dgvUtakmice);
            this.Controls.Add(this.lblUtakmice);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnTimovi);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblTrener);
            this.Controls.Add(this.lblRoster);
            this.Controls.Add(this.dgvIgraci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KlubFormacs";
            this.Text = "Klub INFO";
            this.Load += new System.EventHandler(this.KlubFormacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.Label lblRoster;
        private System.Windows.Forms.Label lblTrener;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Button btnTimovi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblUtakmice;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.Button btnDodajUtakmicu;
    }
}