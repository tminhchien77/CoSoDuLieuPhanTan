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
    public partial class frmTeacherPermissionChild : Form
    {
        public string id;
        public string name;

        public frmTeacherPermissionChild()
        {
            InitializeComponent();
            //this.Text ="Cấp quyền cho giảng viên"
        }

        private void frmTeacherPermissionChild_Load(object sender, EventArgs e)
        {
            lblId.Text = id;
            lblName.Text = name;
            lblPermission.Text = Program.mGroup;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            string str = "EXECUTE [dbo].[SP_AddNewLogin] '" + txtLoginName.Text + "', '" + txtPassword.Text + "', '" + lblId.Text + "', '" + lblPermission.Text + "'";
            if (Program.execNonQuery(str) < 0) return;
            else
            {
                MessageBox.Show("Thành công!", "", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
