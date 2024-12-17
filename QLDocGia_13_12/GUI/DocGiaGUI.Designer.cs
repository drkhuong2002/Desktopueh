namespace GUI
{
    partial class DocGiaGUI
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
            this.GridViewDocGia = new System.Windows.Forms.DataGridView();
            this.btnXemGocGia = new System.Windows.Forms.Button();
            this.btnXemLoaiDocGia = new System.Windows.Forms.Button();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewDocGia
            // 
            this.GridViewDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDocGia.Location = new System.Drawing.Point(228, 249);
            this.GridViewDocGia.Name = "GridViewDocGia";
            this.GridViewDocGia.RowHeadersWidth = 82;
            this.GridViewDocGia.RowTemplate.Height = 33;
            this.GridViewDocGia.Size = new System.Drawing.Size(1149, 594);
            this.GridViewDocGia.TabIndex = 0;
            this.GridViewDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDocGia_CellContentClick);
            // 
            // btnXemGocGia
            // 
            this.btnXemGocGia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXemGocGia.Location = new System.Drawing.Point(228, 176);
            this.btnXemGocGia.Name = "btnXemGocGia";
            this.btnXemGocGia.Size = new System.Drawing.Size(177, 67);
            this.btnXemGocGia.TabIndex = 1;
            this.btnXemGocGia.Text = "Độc giả";
            this.btnXemGocGia.UseVisualStyleBackColor = false;
            this.btnXemGocGia.Click += new System.EventHandler(this.btnXemGocGia_Click);
            // 
            // btnXemLoaiDocGia
            // 
            this.btnXemLoaiDocGia.Location = new System.Drawing.Point(411, 176);
            this.btnXemLoaiDocGia.Name = "btnXemLoaiDocGia";
            this.btnXemLoaiDocGia.Size = new System.Drawing.Size(177, 67);
            this.btnXemLoaiDocGia.TabIndex = 2;
            this.btnXemLoaiDocGia.Text = "Loại độc giả";
            this.btnXemLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnXemLoaiDocGia.Click += new System.EventHandler(this.btnXemLoaiDocGia_Click);
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Location = new System.Drawing.Point(1146, 176);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(231, 67);
            this.btnThemDocGia.TabIndex = 3;
            this.btnThemDocGia.Text = "+ Thêm độc giả";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // DocGiaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 855);
            this.Controls.Add(this.btnThemDocGia);
            this.Controls.Add(this.btnXemLoaiDocGia);
            this.Controls.Add(this.btnXemGocGia);
            this.Controls.Add(this.GridViewDocGia);
            this.Name = "DocGiaGUI";
            this.Text = "DocGiaGUI";
            this.Load += new System.EventHandler(this.DocGiaGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewDocGia;
        private System.Windows.Forms.Button btnXemGocGia;
        private System.Windows.Forms.Button btnXemLoaiDocGia;
        private System.Windows.Forms.Button btnThemDocGia;
    }
}