namespace Videoteka
{
    partial class WelcomeForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnPosudiFilm = new System.Windows.Forms.Button();
            this.dgListaZaduzenja = new System.Windows.Forms.DataGridView();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnExitPosudba = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaZaduzenja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(153, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Dobrodošao/la";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnPosudiFilm
            // 
            this.btnPosudiFilm.BackColor = System.Drawing.Color.White;
            this.btnPosudiFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosudiFilm.Location = new System.Drawing.Point(17, 37);
            this.btnPosudiFilm.Name = "btnPosudiFilm";
            this.btnPosudiFilm.Size = new System.Drawing.Size(115, 43);
            this.btnPosudiFilm.TabIndex = 1;
            this.btnPosudiFilm.Text = "Posudi film";
            this.btnPosudiFilm.UseVisualStyleBackColor = false;
            this.btnPosudiFilm.Click += new System.EventHandler(this.btnPosudiFilm_Click);
            // 
            // dgListaZaduzenja
            // 
            this.dgListaZaduzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaZaduzenja.Location = new System.Drawing.Point(12, 105);
            this.dgListaZaduzenja.Name = "dgListaZaduzenja";
            this.dgListaZaduzenja.RowHeadersWidth = 51;
            this.dgListaZaduzenja.RowTemplate.Height = 24;
            this.dgListaZaduzenja.Size = new System.Drawing.Size(776, 270);
            this.dgListaZaduzenja.TabIndex = 2;
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(626, 406);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(77, 32);
            this.btnNazad.TabIndex = 4;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnExitPosudba
            // 
            this.btnExitPosudba.BackColor = System.Drawing.Color.Red;
            this.btnExitPosudba.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPosudba.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitPosudba.Location = new System.Drawing.Point(711, 406);
            this.btnExitPosudba.Name = "btnExitPosudba";
            this.btnExitPosudba.Size = new System.Drawing.Size(77, 32);
            this.btnExitPosudba.TabIndex = 5;
            this.btnExitPosudba.Text = "Exit";
            this.btnExitPosudba.UseVisualStyleBackColor = false;
            this.btnExitPosudba.Click += new System.EventHandler(this.btnExitPosudba_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitPosudba);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgListaZaduzenja);
            this.Controls.Add(this.btnPosudiFilm);
            this.Controls.Add(this.lblWelcome);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaZaduzenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPosudiFilm;
        private System.Windows.Forms.DataGridView dgListaZaduzenja;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnExitPosudba;
    }
}