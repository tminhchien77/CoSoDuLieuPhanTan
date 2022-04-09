using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TRACNGHIEM_CSDLPT.SystemConstant;

namespace TRACNGHIEM_CSDLPT.views.Teacher
{
    public partial class frmRegisTest : Form
    {
        int indexTbl = 0;
        String maMH;
        String maLop;
        String method;
        ActionType actionType = ActionType.READING;
        public frmRegisTest()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            
            DS.EnforceConstraints=false;
            this.deptTableAdapter.Connection.ConnectionString = Program.connstr;
            this.deptTableAdapter.Fill(this.dsKhoa.KHOA);
            this.sP_SubjListTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_SubjListTableAdapter.Fill(this.DS.SP_SubjList);
            /*this.teacherRegisTableAdapter.Connection.ConnectionString = Program.connstr;
            this.teacherRegisTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);*/

            initBranchCombobox();
            

            /*cbbLop.Enabled = cbbMaMH.Enabled = false;
            txtLevel.Enabled = NgayThiDate.Enabled = txtTime.Enabled = txtLan.Enabled = txtSoCau.Enabled = false;*/
            setCurrentRole();
/*            teacherIdComboBox.DataBindings.Add(new Binding("SelectedValue", regisListGridControl.DataSource, "MAGV"));
*/            /*new Binding()*/
            /*teacherIdComboBox.ValueMember*/

        }
        private void getDataLoptheoKhoa()
        {
            try
            {
                String currentServerName = cbbxBranch.SelectedValue.ToString();
                int indexStr = currentServerName.IndexOf("\\") + 1;
                currentServerName = currentServerName.Substring(indexStr);
                /*this.SP_DanhSachGVDKTheoCoSoTableAdapter.Fill(this.TN_CSDLPTDataSet.SP_DanhSachGVDKTheoCoSo, currentServerName);
                this.SP_DanhSachGVDKTheoCoSoTableAdapter.ClearBeforeFill = true;*/
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            setCurrentRole();
        }
        public String layMaMH()
        {
            /*maMH = cbbMaMH.SelectedValue.ToString();*/
            return maMH;
        }
        public String layMaLop()
        {
            /*maLop = cbbLop.SelectedValue.ToString();*/
            return maLop;
        }
        public void initBranchCombobox()
        {
            cbbxBranch.DataSource = Program.bds_ListBranch;
            cbbxBranch.DisplayMember = "TENCOSO";
            cbbxBranch.ValueMember = "TENSERVER";
            cbbxBranch.SelectedIndex = Program.indexBranch;

            /*initUIComboBoxLop();
            initUIComboBoxMonHoc();*/
        }
        public void initUIComboBoxLop()
        {
            String mServerName = cbbxBranch.SelectedValue.ToString();
            int indexStr = mServerName.IndexOf("\\") + 1;
            mServerName = mServerName.Substring(indexStr);

            String strLenh = "exec SP_DanhSachLopTheoKhoaVaCoSo " + "NULL" + ",'" + mServerName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                /*if (dt.Rows.Count == 0)
                {
                    cbbLop.DataSource = null;
                }
                else
                {
                    cbbLop.DataSource = dt;
                    cbbLop.DisplayMember = "TENLOP";
                    cbbLop.ValueMember = "MALOP";
                }
                cbbLop.SelectedIndex = -1;*/
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp! ", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void initUIComboBoxMonHoc()
        {
            String mServerName = cbbxBranch.SelectedValue.ToString();
            int indexStr = mServerName.IndexOf("\\") + 1;
            mServerName = mServerName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachMonHoc '" + mServerName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                /*if (dt.Rows.Count == 0)
                {
                    cbbMaMH.DataSource = null;
                }
                else
                {
                    cbbMaMH.DataSource = dt;
                    cbbMaMH.DisplayMember = "TENMH";
                    cbbMaMH.ValueMember = "MAMH";
                }
                cbbMaMH.SelectedIndex = -1;*/
            }
            else
            {
                MessageBox.Show("Không tìm thấy danh sách môn học !", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void setCurrentRole()
        {
            if (Program.mGroup == "TRUONG")
            {
                cbbxBranch.Enabled = true;
                

                /*cbbLop.Visible = false;
                cbbMaMH.Visible = false;
                addBtn.Enabled = editBtn.Enabled = deleteBtn.Enabled = saveBtn.Enabled = refreshBtn.Enabled = false;*/
            }
            else
            {
                cbbxBranch.Enabled = false;
                /*cbbCoSo.Visible = false;
                cbbLop.Visible = false;
                cbbMaMH.Visible = false;
                addBtn.Enabled = editBtn.Enabled = refreshBtn.Enabled = true;
                saveBtn.Enabled = cancelBtn.Enabled = false;*/

                if (bdsRegis.Count == 0)
                {
                    editBtn.Enabled = deleteBtn.Enabled = false;
                }
                else
                {
                    editBtn.Enabled = deleteBtn.Enabled = true;
                }
                changeEnabledStatus();
            }
        }

        private void saveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (examDateEdit.DateTime<DateTime.Now.AddDays(1))
            {
                MessageBox.Show("Thời gian thi tối thiểu phải sau hiện tại một ngày!", "Thông báo lỗi", MessageBoxButtons.OK);
                examDateEdit.Focus();
                return;
            }
            if (txtNumQues.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số câu hỏi thi không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtNumQues.Focus();
                return;
            }
            if (txtExamTime.Text.Trim().Length == 0)
            {
                MessageBox.Show("Thời gian thi không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtNumQues.Focus();
                return;
            }

            if (actionType == ActionType.ADDING)
            {
                try
                {
                    if (addRegistration(teacherIdComboBox.SelectedValue.ToString(), cbbxClass.SelectedValue.ToString(),
                        cbbxSubj.SelectedValue.ToString(), levelComboBox.SelectedItem.ToString(), examDateEdit.DateTime.ToString(),
                        Int32.Parse(cbbxTimes.SelectedItem.ToString()), Int32.Parse(txtNumQues.Text),
                        Int32.Parse(txtExamTime.Text)) > 0)
                    {
                        this.sP_RegisListTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_RegisListTableAdapter.Fill(this.DS.SP_RegisList, cbbxDept.SelectedValue.ToString());

                        addBtn.Enabled = true;
                        
                    }
                    /*else
                    {
                        regisListBindingSource.RemoveCurrent();
                        regisListBindingSource.Position = indexTbl;    
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm đăng ký\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if (editRegistration() > 0)
                {
                    this.sP_RegisListTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_RegisListTableAdapter.Fill(this.DS.SP_RegisList, cbbxDept.SelectedValue.ToString());

                    addBtn.Enabled = editBtn.Enabled= deleteBtn.Enabled= true;
                }
            }
            changeEnabledStatus();
            actionType = ActionType.READING;



            /*regisListBindingSource.EndEdit();
            regisListBindingSource.ResetCurrentItem();*/

        }

        private int editRegistration()
        {
            String str = "EXECUTE SP_UpdateRegistration '" 
                + teacherIdComboBox.SelectedValue.ToString() + "', '"
                + cbbxClass.SelectedValue.ToString() + "', '" 
                + cbbxSubj.SelectedValue.ToString() + "', '" 
                + levelComboBox.SelectedItem.ToString() + "', '"
                + examDateEdit.DateTime.ToString() + "', " 
                + Int32.Parse(cbbxTimes.SelectedItem.ToString()) + ", " 
                + Int32.Parse(txtNumQues.Text) + ", " + Int32.Parse(txtExamTime.Text);
            if (Program.execNonQuery(str) > 0) return 1;
            else return -1;
        }
        

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*groupThongTin.Enabled = true;
            txtMaGV.Enabled = txtLevel.Enabled = txtTime.Enabled = NgayThiDate.Enabled = txtSoCau.Enabled = txtLan.Enabled = false;

            getDataLoptheoKhoa();
            regisListBds.MoveFirst();
            txtMaMon.Visible = txtMaLop.Visible = true;
            cbbMaMH.Visible = cbbLop.Visible = false;

            setCurrentRole();*/
        }
       

        private void cbbMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Boolean compareDates(DateTime currentDate, DateTime selectedDate)
        {
            int different = (int)((currentDate - selectedDate).TotalDays);

            if (different < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            /*this.teacherRegisBindingSource.EndEdit();*/
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
/*            this.teacherRegisBindingSource.EndEdit();
*/            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void branchCombobox_EnabledChanged(object sender, EventArgs e)
        {
            addBtn.Enabled = editBtn.Enabled = deleteBtn.Enabled = saveBtn.Enabled = undoBtn.Enabled = redoBtn.Enabled = !cbbxBranch.Enabled;
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionType = ActionType.ADDING;
            addBtn.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsRegis.Position;
            bdsRegis.AddNew();
            
        }

        private int addRegistration(string teacherId, string classId, string subId, string level, string examDate, int times, int numQues, int examTime)
        {
            String str = "EXECUTE SP_AddRegistration '" + teacherId + "', '" 
                + classId + "', '" + subId + "', '" + level + "', '" 
                + examDate + "', " + times + ", " + numQues + ", " + examTime;
            if (Program.execNonQuery(str) > 0) return 1;
            else return -1;
            /*try
            {
                Program.execNonQuery(str);
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đăng ký thi\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return -1;
            }*/
        }

        private void changeEnabledStatus()
        {
            saveBtn.Enabled = regisInforGroup.Enabled = undoBtn.Enabled = redoBtn.Enabled= !addBtn.Enabled;
            cbbxDept.Enabled= btnRefresh.Enabled = cbbxDept.Enabled = regisListGridControl.Enabled=addBtn.Enabled;
            if(!addBtn.Enabled)
                editBtn.Enabled = deleteBtn.Enabled = addBtn.Enabled;
            
        }

        private void deptComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(deptBindingSource.Count>0) loadImportantData();
        }

        private void loadImportantData()
        {
            string idDept = (string)cbbxDept.SelectedValue;
            try
            {
                this.sP_RegisListTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_RegisListTableAdapter.Fill(this.DS.SP_RegisList, idDept);
                this.sP_TeacherListTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_TeacherListTableAdapter.Fill(this.DS.SP_TeacherList, idDept);
                this.sP_ClassListTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_ClassListTableAdapter.Fill(this.DS.SP_ClassList, idDept);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void regisListgridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (regisListgridView.GetFocusedDataRow()==null) return;
            if (regisListgridView.GetFocusedDataRow()["MAGV"].ToString().Length == 0)
            {
                teacherIdComboBox.SelectedIndex = 0;
                cbbxClass.SelectedIndex = 0;
                cbbxSubj.SelectedIndex = 0;
                levelComboBox.SelectedIndex = 0;
                cbbxTimes.SelectedIndex = 0;   
            }
            else if(regisListgridView.GetFocusedDataRow()["MAGV"].ToString().Length > 0 && actionType!= ActionType.ADDING)
            {
                string teacherId = (string)regisListgridView.GetFocusedDataRow()["MAGV"];
                teacherIdComboBox.SelectedIndex = teacherIdComboBox.FindString(teacherId);
                string classId = (string)regisListgridView.GetFocusedDataRow()["MALOP"];
                cbbxClass.SelectedIndex = cbbxClass.FindString(classId);
                string subId = (string)regisListgridView.GetFocusedDataRow()["MAMH"];
                cbbxSubj.SelectedIndex = cbbxSubj.FindString(subId);
            }
            
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String str = "EXECUTE [dbo].[SP_CheckExistScore] '"+cbbxClass.SelectedValue.ToString()+"', '"+cbbxSubj.SelectedValue.ToString()+"', "+cbbxTimes.SelectedItem;
            if (Program.execNonQuery(str) < 0) return;
            actionType = ActionType.EDITING;
            cbbxClass.Enabled= cbbxSubj.Enabled= cbbxTimes.Enabled= addBtn.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsRegis.Position;
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String str = "EXECUTE [dbo].[SP_CheckExistScore] '" + cbbxClass.SelectedValue.ToString() + "', '" + cbbxSubj.SelectedValue.ToString() + "', " + cbbxTimes.SelectedItem;
            if (Program.execNonQuery(str) < 0) return;
            if(MessageBox.Show("Bạn có thực sự muốn xoá bài kiểm tra này?","Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                str = "DELETE FROM dbo.GIAOVIEN_DANGKY WHERE MALOP = '"+ cbbxClass.SelectedValue.ToString() + "' AND MAMH = '" + cbbxSubj.SelectedValue.ToString() + "' AND LAN = " + cbbxTimes.SelectedItem;
                if (Program.execNonQuery(str) > 0)
                {
                    this.sP_RegisListTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_RegisListTableAdapter.Fill(this.DS.SP_RegisList, cbbxDept.SelectedValue.ToString());
                }
                
            }
            /*index = regisListBds.Position;
            if (MessageBox.Show("Bạn chắc chắn muốn xoá đăng ký này?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    regisListBds.RemoveCurrent();
                   // this.SP_DanhSachGVDKTheoCoSoTableAdapter.Delete(txtSubject.Text, txtClass.Text, Int32.Parse(txtTime.Text));
                    if (regisListBds.Count == 0)
                    {
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        btnRefresh.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failure. Please delete again!\n" + ex.Message, "",
                       MessageBoxButtons.OK);
                    return;
                }

                groupThongTin.Enabled = true;
                cbbCoSo.Enabled = cbbMaMH.Enabled = cbbLop.Enabled = false;
                   
                txtLevel.Enabled = NgayThiDate.Enabled = txtTime.Enabled = txtLan.Enabled = txtSoCau.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                btnGhi.Enabled = btnCancel.Enabled = false;
            }*/
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sP_RegisListTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_RegisListTableAdapter.Fill(this.DS.SP_RegisList, cbbxDept.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cbbxBranch_SelectedIndexChanged(object sender, EventArgs e)
        //{
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
                DS.EnforceConstraints = false;
                this.deptTableAdapter.Connection.ConnectionString = Program.connstr;
                this.deptTableAdapter.Fill(this.dsKhoa.KHOA);
                this.sP_SubjListTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_SubjListTableAdapter.Fill(this.DS.SP_SubjList);
            }
        }
    }
}
