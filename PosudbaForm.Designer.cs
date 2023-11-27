namespace Videoteka
{
    partial class PosudbaForm
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
            this.lblPosudba = new System.Windows.Forms.Label();
            this.btnExitPosudba = new System.Windows.Forms.Button();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.dgPosudiFilm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosudiFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosudba
            // 
            this.lblPosudba.AutoSize = true;
            this.lblPosudba.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosudba.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPosudba.Location = new System.Drawing.Point(12, 9);
            this.lblPosudba.Name = "lblPosudba";
            this.lblPosudba.Size = new System.Drawing.Size(241, 21);
            this.lblPosudba.TabIndex = 0;
            this.lblPosudba.Text = "Odaberi film za posudbu:";
            this.lblPosudba.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExitPosudba
            // 
            this.btnExitPosudba.BackColor = System.Drawing.Color.Red;
            this.btnExitPosudba.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPosudba.Location = new System.Drawing.Point(678, 407);
            this.btnExitPosudba.Name = "btnExitPosudba";
            this.btnExitPosudba.Size = new System.Drawing.Size(84, 39);
            this.btnExitPosudba.TabIndex = 3;
            this.btnExitPosudba.Text = "Exit";
            this.btnExitPosudba.UseVisualStyleBackColor = false;
            this.btnExitPosudba.Click += new System.EventHandler(this.btnExitPosudba_Click);
            // 
            // btnPosudi
            // 
            this.btnPosudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosudi.Location = new System.Drawing.Point(588, 407);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(84, 39);
            this.btnPosudi.TabIndex = 4;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // dgPosudiFilm
            // 
            this.dgPosudiFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPosudiFilm.Location = new System.Drawing.Point(28, 111);
            this.dgPosudiFilm.Name = "dgPosudiFilm";
            this.dgPosudiFilm.RowHeadersWidth = 51;
            this.dgPosudiFilm.RowTemplate.Height = 24;
            this.dgPosudiFilm.Size = new System.Drawing.Size(517, 327);
            this.dgPosudiFilm.TabIndex = 6;
            // 
            // PosudbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPosudiFilm);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.btnExitPosudba);
            this.Controls.Add(this.lblPosudba);
            this.Name = "PosudbaForm";
            this.Text = "PosudbaForm";
            this.Load += new System.EventHandler(this.PosudbaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPosudiFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosudba;
        private System.Windows.Forms.Button btnExitPosudba;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.DataGridView dgPosudiFilm;
    }
}