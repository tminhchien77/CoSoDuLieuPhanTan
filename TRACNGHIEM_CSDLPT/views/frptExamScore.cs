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
    public partial class frptExamScore : Form
    {
        public frptExamScore()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frptExamScore_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            rptExamScore rpt = new rptExamScore(cbbxSubj.SelectedValue.ToString(), Int32.Parse(cbbxTimes.SelectedItem.ToString()), cbbxClass.SelectedValue.ToString());

            rpt.lblTitle.Text = "BẢNG ĐIỂM MÔN "+cbbxSubj.Text+" LẦN "+cbbxTimes.Text+" LỚP "+cbbxClass.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}
