namespace TRACNGHIEM_CSDLPT.views
{
    partial class frmPass
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
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.txtConfirmPass = new DevExpress.XtraEditors.TextEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(123, 26);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.UseSystemPasswordChar = true;
            this.txtOldPass.Size = new System.Drawing.Size(156, 20);
            this.txtOldPass.TabIndex = 0;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(123, 64);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.UseSystemPasswordChar = true;
            this.txtNewPass.Size = new System.Drawing.Size(156, 20);
            this.txtNewPass.TabIndex = 1;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(123, 103);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Properties.UseSystemPasswordChar = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(156, 20);
            this.txtConfirmPass.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(151, 146);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Đổi mật khẩu";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mật khẩu cũ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nhập lại mật khẩu:";
            // 
            // frmPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 190);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Name = "frmPass";
            this.Text = "frmPass";
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.TextEdit txtConfirmPass;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}