namespace Softverska_kompanija
{
    partial class Form1
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
            this.ucitajZaposlenog = new System.Windows.Forms.Button();
            this.ucitajProjekat = new System.Windows.Forms.Button();
            this.oneToMany = new System.Windows.Forms.Button();
            this.manyToOne = new System.Windows.Forms.Button();
            this.zaposleniZna = new System.Windows.Forms.Button();
            this.programskiJezikZna = new System.Windows.Forms.Button();
            this.zaposleniAngazovani = new System.Windows.Forms.Button();
            this.projekatAngazovani = new System.Windows.Forms.Button();
            this.zaposleniRukovodi = new System.Windows.Forms.Button();
            this.projekatRukovodi = new System.Windows.Forms.Button();
            this.dodajProgramera = new System.Windows.Forms.Button();
            this.dodajProjektanta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucitajZaposlenog
            // 
            this.ucitajZaposlenog.Location = new System.Drawing.Point(12, 12);
            this.ucitajZaposlenog.Name = "ucitajZaposlenog";
            this.ucitajZaposlenog.Size = new System.Drawing.Size(190, 23);
            this.ucitajZaposlenog.TabIndex = 0;
            this.ucitajZaposlenog.Text = "Ucitaj zaposlenog";
            this.ucitajZaposlenog.UseVisualStyleBackColor = true;
            this.ucitajZaposlenog.Click += new System.EventHandler(this.ucitajZaposlenog_Click);
            // 
            // ucitajProjekat
            // 
            this.ucitajProjekat.Location = new System.Drawing.Point(12, 41);
            this.ucitajProjekat.Name = "ucitajProjekat";
            this.ucitajProjekat.Size = new System.Drawing.Size(190, 23);
            this.ucitajProjekat.TabIndex = 1;
            this.ucitajProjekat.Text = "Ucitaj projekat";
            this.ucitajProjekat.UseVisualStyleBackColor = true;
            this.ucitajProjekat.Click += new System.EventHandler(this.ucitajProjekat_Click);
            // 
            // oneToMany
            // 
            this.oneToMany.Location = new System.Drawing.Point(12, 70);
            this.oneToMany.Name = "oneToMany";
            this.oneToMany.Size = new System.Drawing.Size(190, 23);
            this.oneToMany.TabIndex = 2;
            this.oneToMany.Text = "One to many Zaposleni";
            this.oneToMany.UseVisualStyleBackColor = true;
            this.oneToMany.Click += new System.EventHandler(this.oneToMany_Click);
            // 
            // manyToOne
            // 
            this.manyToOne.Location = new System.Drawing.Point(12, 99);
            this.manyToOne.Name = "manyToOne";
            this.manyToOne.Size = new System.Drawing.Size(190, 23);
            this.manyToOne.TabIndex = 3;
            this.manyToOne.Text = "Many to one Spoljni saradnik";
            this.manyToOne.UseVisualStyleBackColor = true;
            this.manyToOne.Click += new System.EventHandler(this.manyToOne_Click);
            // 
            // zaposleniZna
            // 
            this.zaposleniZna.Location = new System.Drawing.Point(12, 128);
            this.zaposleniZna.Name = "zaposleniZna";
            this.zaposleniZna.Size = new System.Drawing.Size(190, 23);
            this.zaposleniZna.TabIndex = 4;
            this.zaposleniZna.Text = "Many to many Zaposleni Zna";
            this.zaposleniZna.UseVisualStyleBackColor = true;
            this.zaposleniZna.Click += new System.EventHandler(this.zaposleniZna_Click);
            // 
            // programskiJezikZna
            // 
            this.programskiJezikZna.Location = new System.Drawing.Point(12, 157);
            this.programskiJezikZna.Name = "programskiJezikZna";
            this.programskiJezikZna.Size = new System.Drawing.Size(190, 23);
            this.programskiJezikZna.TabIndex = 5;
            this.programskiJezikZna.Text = "Many to many Programski jezik Zna";
            this.programskiJezikZna.UseVisualStyleBackColor = true;
            this.programskiJezikZna.Click += new System.EventHandler(this.programskiJezikZna_Click);
            // 
            // zaposleniAngazovani
            // 
            this.zaposleniAngazovani.Location = new System.Drawing.Point(12, 186);
            this.zaposleniAngazovani.Name = "zaposleniAngazovani";
            this.zaposleniAngazovani.Size = new System.Drawing.Size(190, 23);
            this.zaposleniAngazovani.TabIndex = 6;
            this.zaposleniAngazovani.Text = "Many to many Zaposleni Angazovani";
            this.zaposleniAngazovani.UseVisualStyleBackColor = true;
            this.zaposleniAngazovani.Click += new System.EventHandler(this.zaposleniAngazovani_Click);
            // 
            // projekatAngazovani
            // 
            this.projekatAngazovani.Location = new System.Drawing.Point(13, 216);
            this.projekatAngazovani.Name = "projekatAngazovani";
            this.projekatAngazovani.Size = new System.Drawing.Size(189, 23);
            this.projekatAngazovani.TabIndex = 7;
            this.projekatAngazovani.Text = "Many to many Projekat Angazovani";
            this.projekatAngazovani.UseVisualStyleBackColor = true;
            this.projekatAngazovani.Click += new System.EventHandler(this.projekatAngazovani_Click);
            // 
            // zaposleniRukovodi
            // 
            this.zaposleniRukovodi.Location = new System.Drawing.Point(13, 246);
            this.zaposleniRukovodi.Name = "zaposleniRukovodi";
            this.zaposleniRukovodi.Size = new System.Drawing.Size(189, 23);
            this.zaposleniRukovodi.TabIndex = 8;
            this.zaposleniRukovodi.Text = "Many to many Zaposleni Rukovodi";
            this.zaposleniRukovodi.UseVisualStyleBackColor = true;
            this.zaposleniRukovodi.Click += new System.EventHandler(this.zaposleniRukovodi_Click);
            // 
            // projekatRukovodi
            // 
            this.projekatRukovodi.Location = new System.Drawing.Point(12, 275);
            this.projekatRukovodi.Name = "projekatRukovodi";
            this.projekatRukovodi.Size = new System.Drawing.Size(190, 23);
            this.projekatRukovodi.TabIndex = 9;
            this.projekatRukovodi.Text = "Many to many Projekat Rukovodi";
            this.projekatRukovodi.UseVisualStyleBackColor = true;
            this.projekatRukovodi.Click += new System.EventHandler(this.projekatRukovodi_Click);
            // 
            // dodajProgramera
            // 
            this.dodajProgramera.Location = new System.Drawing.Point(13, 305);
            this.dodajProgramera.Name = "dodajProgramera";
            this.dodajProgramera.Size = new System.Drawing.Size(189, 23);
            this.dodajProgramera.TabIndex = 10;
            this.dodajProgramera.Text = "Dodaj programera";
            this.dodajProgramera.UseVisualStyleBackColor = true;
            this.dodajProgramera.Click += new System.EventHandler(this.dodajProgramera_Click);
            // 
            // dodajProjektanta
            // 
            this.dodajProjektanta.Location = new System.Drawing.Point(12, 335);
            this.dodajProjektanta.Name = "dodajProjektanta";
            this.dodajProjektanta.Size = new System.Drawing.Size(190, 23);
            this.dodajProjektanta.TabIndex = 11;
            this.dodajProjektanta.Text = "Dodaj starijeg projektanta";
            this.dodajProjektanta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dodajProjektanta);
            this.Controls.Add(this.dodajProgramera);
            this.Controls.Add(this.projekatRukovodi);
            this.Controls.Add(this.zaposleniRukovodi);
            this.Controls.Add(this.projekatAngazovani);
            this.Controls.Add(this.zaposleniAngazovani);
            this.Controls.Add(this.programskiJezikZna);
            this.Controls.Add(this.zaposleniZna);
            this.Controls.Add(this.manyToOne);
            this.Controls.Add(this.oneToMany);
            this.Controls.Add(this.ucitajProjekat);
            this.Controls.Add(this.ucitajZaposlenog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ucitajZaposlenog;
        private System.Windows.Forms.Button ucitajProjekat;
        private System.Windows.Forms.Button oneToMany;
        private System.Windows.Forms.Button manyToOne;
        private System.Windows.Forms.Button zaposleniZna;
        private System.Windows.Forms.Button programskiJezikZna;
        private System.Windows.Forms.Button zaposleniAngazovani;
        private System.Windows.Forms.Button projekatAngazovani;
        private System.Windows.Forms.Button zaposleniRukovodi;
        private System.Windows.Forms.Button projekatRukovodi;
        private System.Windows.Forms.Button dodajProgramera;
        private System.Windows.Forms.Button dodajProjektanta;
        private System.Windows.Forms.Button button1;
    }
}

