namespace DocGia
{
    partial class frmDocGia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtBirthDate = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            btnEdit = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 228);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "AVATAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 154);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 204);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 254);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 304);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 92);
            label3.Name = "label3";
            label3.Size = new Size(243, 30);
            label3.TabIndex = 6;
            label3.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // txtName
            // 
            txtName.Location = new Point(463, 156);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 7;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(463, 204);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(150, 31);
            txtBirthDate.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(463, 254);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(463, 304);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(150, 31);
            txtSDT.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(307, 370);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Chỉnh sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(501, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // frmDocGia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 450);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtBirthDate);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDocGia";
            Text = "Độc giả";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox txtName;
        private TextBox txtBirthDate;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private Button btnEdit;
        private Button btnSave;
    }
}
