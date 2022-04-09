
namespace TRACNGHIEM_CSDLPT
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPtit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioTeacher = new System.Windows.Forms.RadioButton();
            this.comboboxBranches = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPtit);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.radioStudent);
            this.panel1.Controls.Add(this.radioTeacher);
            this.panel1.Controls.Add(this.comboboxBranches);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 445);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPtit
            // 
            this.btnPtit.Image = global::TRACNGHIEM_CSDLPT.Properties.Resources.download;
            this.btnPtit.Location = new System.Drawing.Point(32, 101);
            this.btnPtit.Margin = new System.Windows.Forms.Padding(2);
            this.btnPtit.Name = "btnPtit";
            this.btnPtit.Size = new System.Drawing.Size(186, 245);
            this.btnPtit.TabIndex = 12;
            this.btnPtit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(521, 350);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(385, 350);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 34);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStudent.Location = new System.Drawing.Point(513, 284);
            this.radioStudent.Margin = new System.Windows.Forms.Padding(2);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(79, 19);
            this.radioStudent.TabIndex = 9;
            this.radioStudent.Text = "Sinh Viên";
            this.radioStudent.UseVisualStyleBackColor = true;
            this.radioStudent.CheckedChanged += new System.EventHandler(this.radioStudent_CheckedChanged);
            // 
            // radioTeacher
            // 
            this.radioTeacher.AutoSize = true;
            this.radioTeacher.Checked = true;
            this.radioTeacher.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTeacher.Location = new System.Drawing.Point(368, 284);
            this.radioTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.radioTeacher.Name = "radioTeacher";
            this.radioTeacher.Size = new System.Drawing.Size(78, 19);
            this.radioTeacher.TabIndex = 8;
            this.radioTeacher.TabStop = true;
            this.radioTeacher.Text = "Giáo Viên";
            this.radioTeacher.UseVisualStyleBackColor = true;
            this.radioTeacher.CheckedChanged += new System.EventHandler(this.radioTeacher_CheckedChanged);
            // 
            // comboboxBranches
            // 
            this.comboboxBranches.FormattingEnabled = true;
            this.comboboxBranches.Location = new System.Drawing.Point(368, 98);
            this.comboboxBranches.Margin = new System.Windows.Forms.Padding(2);
            this.comboboxBranches.Name = "comboboxBranches";
            this.comboboxBranches.Size = new System.Drawing.Size(254, 21);
            this.comboboxBranches.TabIndex = 7;
            this.comboboxBranches.SelectedIndexChanged += new System.EventHandler(this.comboboxBranches_SelectedIndexChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(368, 223);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(254, 20);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(368, 155);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(254, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "MẬT KHẨU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CƠ SỞ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 465);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLogin";
            this.Text = "FormDN";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioTeacher;
        private System.Windows.Forms.ComboBox comboboxBranches;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPtit;
    }
}