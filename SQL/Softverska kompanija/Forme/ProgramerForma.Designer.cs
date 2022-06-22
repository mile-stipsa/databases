namespace Softverska_kompanija
{
    partial class ProgramerForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramerForma));
            this.dgvProjekti = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dgvSaradnici = new System.Windows.Forms.DataGridView();
            this.btnAngazuj = new System.Windows.Forms.Button();
            this.btnOtpusti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaradnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjekti
            // 
            this.dgvProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekti.Location = new System.Drawing.Point(12, 35);
            this.dgvProjekti.Name = "dgvProjekti";
            this.dgvProjekti.Size = new System.Drawing.Size(398, 104);
            this.dgvProjekti.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(398, 23);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Projekti na kojima ste angazovani";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 158);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(398, 23);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Spoljni saradnici koje angazujete";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSaradnici
            // 
            this.dgvSaradnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaradnici.Location = new System.Drawing.Point(12, 184);
            this.dgvSaradnici.Name = "dgvSaradnici";
            this.dgvSaradnici.Size = new System.Drawing.Size(395, 104);
            this.dgvSaradnici.TabIndex = 3;
            this.dgvSaradnici.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSaradnici_RowHeaderMouseDoubleClick);
            // 
            // btnAngazuj
            // 
            this.btnAngazuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngazuj.Location = new System.Drawing.Point(12, 294);
            this.btnAngazuj.Name = "btnAngazuj";
            this.btnAngazuj.Size = new System.Drawing.Size(395, 31);
            this.btnAngazuj.TabIndex = 4;
            this.btnAngazuj.Text = "Angazuj spoljnog saradnika";
            this.btnAngazuj.UseVisualStyleBackColor = true;
            this.btnAngazuj.Click += new System.EventHandler(this.btnAngazuj_Click);
            // 
            // btnOtpusti
            // 
            this.btnOtpusti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtpusti.Location = new System.Drawing.Point(12, 332);
            this.btnOtpusti.Name = "btnOtpusti";
            this.btnOtpusti.Size = new System.Drawing.Size(395, 31);
            this.btnOtpusti.TabIndex = 5;
            this.btnOtpusti.Text = "Otpusti spoljnog saradnika";
            this.btnOtpusti.UseVisualStyleBackColor = true;
            this.btnOtpusti.Click += new System.EventHandler(this.btnOtpusti_Click);
            // 
            // ProgramerForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 375);
            this.Controls.Add(this.btnOtpusti);
            this.Controls.Add(this.btnAngazuj);
            this.Controls.Add(this.dgvSaradnici);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvProjekti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramerForma";
            this.Text = "Programer";
            this.Load += new System.EventHandler(this.ProgramerForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaradnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjekti;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DataGridView dgvSaradnici;
        private System.Windows.Forms.Button btnAngazuj;
        private System.Windows.Forms.Button btnOtpusti;
    }
}