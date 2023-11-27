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
            this.btnNazad = new System.Windows.Forms.Button();
            this.CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(588, 407);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(84, 39);
            this.btnNazad.TabIndex = 4;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // CheckedListBox
            // 
            this.CheckedListBox.FormattingEnabled = true;
            this.CheckedListBox.Location = new System.Drawing.Point(47, 97);
            this.CheckedListBox.Name = "CheckedListBox";
            this.CheckedListBox.Size = new System.Drawing.Size(406, 55);
            this.CheckedListBox.TabIndex = 5;
            this.CheckedListBox.SelectedIndexChanged += new System.EventHandler(this.chBoxListaFilmova_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 266);
            this.dataGridView1.TabIndex = 6;
            // 
            // PosudbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CheckedListBox);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnExitPosudba);
            this.Controls.Add(this.lblPosudba);
            this.Name = "PosudbaForm";
            this.Text = "PosudbaForm";
            this.Load += new System.EventHandler(this.PosudbaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosudba;
        private System.Windows.Forms.Button btnExitPosudba;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.CheckedListBox CheckedListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}