namespace Softverska_kompanija
{
    partial class AdministratorForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForma));
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvProgrameri = new System.Windows.Forms.DataGridView();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dgvProjektanti = new System.Windows.Forms.DataGridView();
            this.btnObrisiProgramera = new System.Windows.Forms.Button();
            this.btnDodajProgramera = new System.Windows.Forms.Button();
            this.btnDodajProjektanta = new System.Windows.Forms.Button();
            this.btnObrisiProjektanta = new System.Windows.Forms.Button();
            this.btnDodajProjekat = new System.Windows.Forms.Button();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.dgvProjekti = new System.Windows.Forms.DataGridView();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cxbOutsourcing = new System.Windows.Forms.CheckBox();
            this.cxbFirma = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgrameri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjektanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(9, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(335, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Programeri";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProgrameri
            // 
            this.dgvProgrameri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgrameri.Location = new System.Drawing.Point(12, 35);
            this.dgvProgrameri.Name = "dgvProgrameri";
            this.dgvProgrameri.Size = new System.Drawing.Size(332, 144);
            this.dgvProgrameri.TabIndex = 1;
            this.dgvProgrameri.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProgrameri_RowHeaderMouseDoubleClick);
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(9, 277);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(335, 23);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Stariji projektanti";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProjektanti
            // 
            this.dgvProjektanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjektanti.Location = new System.Drawing.Point(12, 303);
            this.dgvProjektanti.Name = "dgvProjektanti";
            this.dgvProjektanti.Size = new System.Drawing.Size(332, 144);
            this.dgvProjektanti.TabIndex = 3;
            this.dgvProjektanti.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProjektanti_RowHeaderMouseDoubleClick);
            // 
            // btnObrisiProgramera
            // 
            this.btnObrisiProgramera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiProgramera.Location = new System.Drawing.Point(12, 224);
            this.btnObrisiProgramera.Name = "btnObrisiProgramera";
            this.btnObrisiProgramera.Size = new System.Drawing.Size(332, 33);
            this.btnObrisiProgramera.TabIndex = 4;
            this.btnObrisiProgramera.Text = "Obrisi programera";
            this.btnObrisiProgramera.UseVisualStyleBackColor = true;
            this.btnObrisiProgramera.Click += new System.EventHandler(this.btnObrisiProgramera_Click);
            // 
            // btnDodajProgramera
            // 
            this.btnDodajProgramera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProgramera.Location = new System.Drawing.Point(12, 185);
            this.btnDodajProgramera.Name = "btnDodajProgramera";
            this.btnDodajProgramera.Size = new System.Drawing.Size(332, 33);
            this.btnDodajProgramera.TabIndex = 5;
            this.btnDodajProgramera.Text = "Dodaj programera";
            this.btnDodajProgramera.UseVisualStyleBackColor = true;
            this.btnDodajProgramera.Click += new System.EventHandler(this.btnDodajProgramera_Click);
            // 
            // btnDodajProjektanta
            // 
            this.btnDodajProjektanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProjektanta.Location = new System.Drawing.Point(12, 453);
            this.btnDodajProjektanta.Name = "btnDodajProjektanta";
            this.btnDodajProjektanta.Size = new System.Drawing.Size(332, 33);
            this.btnDodajProjektanta.TabIndex = 7;
            this.btnDodajProjektanta.Text = "Dodaj projektanta";
            this.btnDodajProjektanta.UseVisualStyleBackColor = true;
            this.btnDodajProjektanta.Click += new System.EventHandler(this.btnDodajProjektanta_Click);
            // 
            // btnObrisiProjektanta
            // 
            this.btnObrisiProjektanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiProjektanta.Location = new System.Drawing.Point(12, 492);
            this.btnObrisiProjektanta.Name = "btnObrisiProjektanta";
            this.btnObrisiProjektanta.Size = new System.Drawing.Size(332, 33);
            this.btnObrisiProjektanta.TabIndex = 6;
            this.btnObrisiProjektanta.Text = "Obrisi projektanta";
            this.btnObrisiProjektanta.UseVisualStyleBackColor = true;
            this.btnObrisiProjektanta.Click += new System.EventHandler(this.btnObrisiProjektanta_Click);
            // 
            // btnDodajProjekat
            // 
            this.btnDodajProjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProjekat.Location = new System.Drawing.Point(372, 480);
            this.btnDodajProjekat.Name = "btnDodajProjekat";
            this.btnDodajProjekat.Size = new System.Drawing.Size(332, 33);
            this.btnDodajProjekat.TabIndex = 11;
            this.btnDodajProjekat.Text = "Dodaj novi projekat";
            this.btnDodajProjekat.UseVisualStyleBackColor = true;
            this.btnDodajProjekat.Click += new System.EventHandler(this.btnDodajProjekat_Click);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZavrsi.Location = new System.Drawing.Point(372, 519);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(332, 33);
            this.btnZavrsi.TabIndex = 10;
            this.btnZavrsi.Text = "Zavrsi postojeci projekat";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // dgvProjekti
            // 
            this.dgvProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekti.Location = new System.Drawing.Point(372, 35);
            this.dgvProjekti.Name = "dgvProjekti";
            this.dgvProjekti.Size = new System.Drawing.Size(332, 412);
            this.dgvProjekti.TabIndex = 9;
            this.dgvProjekti.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProjekti_RowHeaderMouseDoubleClick);
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(369, 3);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(335, 34);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Projekti";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cxbOutsourcing
            // 
            this.cxbOutsourcing.AutoSize = true;
            this.cxbOutsourcing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbOutsourcing.Location = new System.Drawing.Point(372, 453);
            this.cxbOutsourcing.Name = "cxbOutsourcing";
            this.cxbOutsourcing.Size = new System.Drawing.Size(109, 20);
            this.cxbOutsourcing.TabIndex = 12;
            this.cxbOutsourcing.Text = "Outsourcing";
            this.cxbOutsourcing.UseVisualStyleBackColor = true;
            this.cxbOutsourcing.Click += new System.EventHandler(this.cxbOutsourcing_Click);
            // 
            // cxbFirma
            // 
            this.cxbFirma.AutoSize = true;
            this.cxbFirma.Checked = true;
            this.cxbFirma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cxbFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbFirma.Location = new System.Drawing.Point(503, 454);
            this.cxbFirma.Name = "cxbFirma";
            this.cxbFirma.Size = new System.Drawing.Size(201, 20);
            this.cxbFirma.TabIndex = 13;
            this.cxbFirma.Text = "Projekat se razvija u firmi";
            this.cxbFirma.UseVisualStyleBackColor = true;
            this.cxbFirma.Click += new System.EventHandler(this.cxbFirma_Click);
            // 
            // AdministratorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 587);
            this.Controls.Add(this.cxbFirma);
            this.Controls.Add(this.cxbOutsourcing);
            this.Controls.Add(this.btnDodajProjekat);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.dgvProjekti);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnDodajProjektanta);
            this.Controls.Add(this.btnObrisiProjektanta);
            this.Controls.Add(this.btnDodajProgramera);
            this.Controls.Add(this.btnObrisiProgramera);
            this.Controls.Add(this.dgvProjektanti);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dgvProgrameri);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministratorForma";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.AdministratorForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgrameri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjektanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvProgrameri;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DataGridView dgvProjektanti;
        private System.Windows.Forms.Button btnObrisiProgramera;
        private System.Windows.Forms.Button btnDodajProgramera;
        private System.Windows.Forms.Button btnDodajProjektanta;
        private System.Windows.Forms.Button btnObrisiProjektanta;
        private System.Windows.Forms.Button btnDodajProjekat;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.DataGridView dgvProjekti;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.CheckBox cxbOutsourcing;
        private System.Windows.Forms.CheckBox cxbFirma;
    }
}