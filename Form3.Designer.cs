namespace quanlydocgia
{
    partial class Form3
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
            this.dgvLichSuMuonTra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuMuonTra
            // 
            this.dgvLichSuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuMuonTra.Location = new System.Drawing.Point(127, 192);
            this.dgvLichSuMuonTra.Name = "dgvLichSuMuonTra";
            this.dgvLichSuMuonTra.RowHeadersWidth = 62;
            this.dgvLichSuMuonTra.RowTemplate.Height = 28;
            this.dgvLichSuMuonTra.Size = new System.Drawing.Size(669, 294);
            this.dgvLichSuMuonTra.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 618);
            this.Controls.Add(this.dgvLichSuMuonTra);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuonTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuMuonTra;
    }
}