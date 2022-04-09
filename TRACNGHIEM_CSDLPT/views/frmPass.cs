using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM_CSDLPT.views
{
    public partial class frmPass : Form
    {
        public frmPass()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text.Trim().Length == 0 || txtNewPass.Text.Trim().Length == 0 || txtConfirmPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("VUi lòng điền đầy đủ thông tin!", "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }
            if (Program.mGroup == "SINHVIEN")
            {

            }
            else
            {
                if(txtOldPass.Text!=Program.password)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }
                if (txtNewPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }

                String str = "EXEC sp_password '"+txtOldPass.Text+"', '"+txtNewPass.Text+"', '"+Program.usernameServer+"'";
                if (Program.execNonQuery(str) > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
            }
        }
    }
}
