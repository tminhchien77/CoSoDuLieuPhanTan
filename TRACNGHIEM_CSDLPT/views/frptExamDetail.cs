using DevExpress.XtraReports.UI;
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
    public partial class frptExamDetail : Form
    {
        public frptExamDetail()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frptExamDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            dS.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            initBranchCombobox();
            setCurrentRole();

        }
        public void initBranchCombobox()
        {
            cbbxBranch.DataSource = Program.bds_ListBranch;
            cbbxBranch.DisplayMember = "TENCOSO";
            cbbxBranch.ValueMember = "TENSERVER";
            cbbxBranch.SelectedIndex = Program.indexBranch;
        }
        public void setCurrentRole()
        {
            if (Program.mGroup == "TRUONG")
            {
                cbbxBranch.Enabled = true;
            }
            else
            {
                cbbxBranch.Enabled = false;
            }
        }

        private void cbbxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbxBranch.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cbbxBranch.SelectedValue.ToString();
            if (cbbxBranch.SelectedIndex != Program.indexBranch)
            {
                Program.usernameServer = Program.remotelogin;
                Program.password = Program.remotepassword;

            }
            else
            {
                Program.usernameServer = Program.loginFromLogin;
                Program.password = Program.passFromLogin;
            }

            if (Program.ConnectDB() == 0)
                MessageBox.Show("Lỗi kết nối về cơ sở mới ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dS.EnforceConstraints = false;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            rptExamDetail rpt = new rptExamDetail(cbbxStudent.SelectedValue.ToString(), cbbxSubj.SelectedValue.ToString(), Int32.Parse(cbbxTimes.SelectedItem.ToString()));

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
