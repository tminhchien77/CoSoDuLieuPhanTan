using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TRACNGHIEM_CSDLPT.SystemConstant;

namespace TRACNGHIEM_CSDLPT.views
{
    public partial class frmTeacher : Form
    {
        ActionType actionType = ActionType.READING;
        int indexTbl = 0;
        public frmTeacher()
        {
            InitializeComponent();
        }

       
        /*int index = 0;

        String currentTeacherID = "";
        String method = "";
        String maKhoa = "";
        public Stack st = new Stack();
        public TeacherDto dtoUndo = new TeacherDto("", "", "", "", "");
        public bool isUndo = false;

        public class TeacherDto
        {
            public String maGV;
            public String mHo;
            public String mTen;
            public String mHocVi;

            public String method;
            public int index;
            public TeacherDto(String strID, String strHo, String strTen, String strHocVi, String strMethod)
            {
                maGV = strID;
                mHo = strHo;
                mTen = strTen;
                mHocVi = strHocVi;
                method = strMethod;
            }
        }*/
        /*public String layMaCoSo()
        {
            *//*return cbbCoSo.SelectedValue.ToString();*//*
        }

        public String layMaKhoa()
        {
            *//*maKhoa = cbbKhoa.SelectedIndex >= 0 ? cbbKhoa.SelectedValue.ToString() : "";
            return maKhoa;*//*
        }*/
        public void initUIComboBoxCoSo()
        {
            cbbxBranch.DataSource = Program.bds_ListBranch;
            cbbxBranch.DisplayMember = "TENCOSO";
            cbbxBranch.ValueMember = "TENSERVER";
            cbbxBranch.SelectedIndex = Program.indexBranch;

           // initUIComboBoxKhoa();
        }
        /*public void initUIComboBoxKhoa()
        {
            String mTencoso = layMaCoSo();
            int indexStr = mTencoso.IndexOf("\\") + 1;
            mTencoso = mTencoso.Substring(indexStr);



            String strLenh = "exec SP_DanhSachKhoa'" + mTencoso + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbKhoa.SelectedIndex = -1;
                    cbbKhoa.DataSource = null;
                }
                else
                {
                    cbbKhoa.DataSource = dt;
                    cbbKhoa.DisplayMember = "TENKH";
                    cbbKhoa.ValueMember = "MAKH";
                }
                cbbKhoa.SelectedIndex = -1;
               
            }
        }*/
        /*public void updateUIUndo()
        {
            if (st.Count > 0)
            {
                btnUndo.Enabled = true;
            }
            else
            {
                btnUndo.Enabled = false;
            }
        }*/
        public void setCurrentRole()
        {
            /*if (Program.mGroup == "TRUONG")
            {
                cbbxBranch.Enabled = true;
            }
            else
            {
                cbbxBranch.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                btnGhi.Enabled = btnCancel.Enabled = false;

                if (bdsGVtheoKhoa.Count == 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = true;
                }
                if (cbbKhoa.SelectedIndex < 0)
                {
                    st.Clear();
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnUndo.Enabled = false;
                }

            }*/
            if (Program.mGroup == "TRUONG")
            {
                cbbxBranch.Enabled = true;
                btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnSave.Enabled = btnUndo.Enabled = btnRedo.Enabled = false;
            }
            else
            {
                /*cbbxBranch.Enabled = false;
                cbbLop.Visible = false;
                cbbMaMH.Visible = false;
                addBtn.Enabled = editBtn.Enabled = refreshBtn.Enabled = true;
                saveBtn.Enabled = cancelBtn.Enabled = false;*/

                if (bdsTeacher.Count == 0)
                {
                    btnEdit.Enabled = btnDelete.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = btnDelete.Enabled = true;
                }
                changeEnabledStatus();
            }

        }

        private void changeEnabledStatus()
        {
            btnSave.Enabled = groupInfo.Enabled = btnUndo.Enabled = btnRedo.Enabled = !btnAdd.Enabled;
            gcTeacher.Enabled = btnAdd.Enabled;
            if (!btnAdd.Enabled)
                btnEdit.Enabled = btnDelete.Enabled = btnAdd.Enabled;
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            this.tableAdapterDept.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDept.Fill(this.dS.KHOA);
            this.tableAdapterTeacherRegistrasion.Connection.ConnectionString = Program.connstr;
            this.tableAdapterTeacherRegistrasion.Fill(this.dS.GIAOVIEN_DANGKY);
            this.tableAdapterQuestions.Connection.ConnectionString = Program.connstr;
            this.tableAdapterQuestions.Fill(this.dS.BODE);
            initUIComboBoxCoSo();
            setCurrentRole();
            /*this.SP_DSGVTheoKhoaVaCoSoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN);*/

        }


        /*private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsGVtheoKhoa.Position;
            groupInfo.Enabled = true;
            txtMaGV.Enabled = false;
            txtHo.Enabled = txtTen.Enabled = txtHocVi.Enabled = true;
            cbbKhoa.Enabled = false;
            sP_DSGVTheoKhoaVaCoSoGridControl.Enabled = false;
            method = Program.UPDATE_METHOD;

            dtoUndo.maGV = txtMaGV.Text;
            dtoUndo.mHo = txtHo.Text;
            dtoUndo.mTen = txtTen.Text;

            dtoUndo.mHocVi = txtHocVi.Text;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsGVtheoKhoa.Position;
            method = Program.DELETE_METHOD;
            sqlDeleteMethod(txtMaGV.Text, txtHo.Text, txtTen.Text, txtHocVi.Text, Program.DELETE_METHOD);
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaGV.Enabled = txtHo.Enabled = txtTen.Enabled = txtHocVi.Enabled = true;

            if (bdsGVtheoKhoa.Count == 0) btnDelete.Enabled = false;
            else btnDelete.Enabled = true;

            if (Program.mGroup == "TRUONG")
            {
                cbbCoSo.Enabled = cbbKhoa.Enabled = true;
            }
            else
            {
                cbbCoSo.Enabled = false;
                cbbKhoa.Enabled = true;
            }

            groupInfo.Enabled = true;
            bdsGVtheoKhoa.MoveFirst();
            st.Clear();
            updateUIUndo();

    
            btnCancel.Enabled = btnSave.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = true;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupInfo.Enabled = true;
            txtMaGV.Enabled = txtHo.Enabled = txtTen.Enabled = txtHocVi.Enabled = false;
            bdsGVtheoKhoa.MoveFirst();
            getDataGVtheoKhoa(layMaKhoa());
            sP_DSGVTheoKhoaVaCoSoGridControl.Enabled = true;

            setCurrentRole();
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cbbCoSo.SelectedValue.ToString();
            if (cbbCoSo.SelectedIndex != Program.indexBranch)
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
                initUIComboBoxKhoa();
            }
        }*/

        /*private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataGVtheoKhoa(layMaKhoa());
        }*/

        /*private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isUndo = true;
            TeacherDto dataUndo = (TeacherDto)st.Pop();
            if (dataUndo.method == Program.NEW_METHOD)
            {
                int vitri = getIndexDBS(dataUndo.maGV);
                if (index > 0)
                {
                    bdsGVtheoKhoa.Position = index;
                    txtMaGV.Text = dataUndo.maGV;
                    txtHo.Text = dataUndo.mHo;
                    txtTen.Text = dataUndo.mTen;
                    txtHocVi.Text = dataUndo.mHocVi;

                    sqlUpdateMethod(dataUndo.maGV, dataUndo.mHo, dataUndo.mTen, dataUndo.mHocVi, Program.UPDATE_METHOD);
                }
                else
                {
                    bdsGVtheoKhoa.AddNew();
                    txtMaGV.Text = dataUndo.maGV;
                    txtHo.Text = dataUndo.mHo;
                    txtTen.Text = dataUndo.mTen;
                    txtHocVi.Text = dataUndo.mHocVi;

                    sqlNewMethod(dataUndo.maGV, dataUndo.mHo, dataUndo.mTen, dataUndo.mHocVi, Program.UPDATE_METHOD);
                }
                isUndo = false;
                updateUIUndo();
            }
        }*/

        /*public void sqlNewMethod(String strMaGV, String strHo, String strTen, String strHocVi, String strMethod)
        {
            String strLenh = "exec SP_KiemTraGiaoVienTheoKhoa '" + strMaGV + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Giáo viên mã " + strMaGV + "đã tồn tại !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (strMaGV.Length == 0 || strHo.Length == 0 || strTen.Length == 0 || strHocVi.Length == 0)
                {
                    MessageBox.Show("Mã GV ,Họ tên giáo viên  không được trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        this.Validate();
                        bdsGVtheoKhoa.EndEdit();
                        bdsGVtheoKhoa.ResetCurrentItem();
                       // this.SP_DSGVTheoKhoaVaCoSoTableAdapter.Insert(strMaGV, strHo, strTen, strHocVi, layMaKhoa());

                        if (isUndo == false)
                        {
                            TeacherDto dataUndo = new TeacherDto(strMaGV, strHo, strTen, strHocVi, strMethod);
                            st.Push(dataUndo);
                            updateUIUndo();

                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Thêm giáo viên không thành công! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;

                    }
                }
                Program.myReader.Close();
            }
        }
        public void sqlUpdateMethod(String strMaGV, String strHo, String strTen, String strHocVi, String strMethod)
        {
            String strLenh = "exec SP_KiemTraGiaoVienTheoKhoa '" + strMaGV + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (strHo.Length == 0)
            {
                MessageBox.Show("Họ không được trống !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (strTen.Length == 0)
            {
                MessageBox.Show("Tên không được trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    this.Validate();
                    bdsGVtheoKhoa.EndEdit();
                    bdsGVtheoKhoa.ResetCurrentItem();
                   // this.SP_DSGVTheoKhoaVaCoSoTableAdapter.Update(currentTeacherID, txtHo.Text, txtTen.Text, txtHocVi.Text);
                    TeacherDto dataUndo = new TeacherDto(dtoUndo.maGV, dtoUndo.mHo, dtoUndo.mTen, dtoUndo.mHocVi, strMethod);
                    st.Push(dataUndo);
                    updateUIUndo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update không thành công! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
        }
        *//*public void sqlDeleteMethod(String strMaGV, String strHo, String strTen, String strHocVi, String strMethod)
        {
            String sqlStr = "";
            sqlStr = "exec SP_KiemTraGiaoVienTheoKhoa'" + strMaGV + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Không thể xoá giáo viên này. Giáo viên đã có dữ liệu! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            }
            else
            {
                if (MessageBox.Show("Bạn có chắn chắn muốn xoá giáo viên này hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsGVtheoKhoa.RemoveCurrent();
                        //this.SP_DSGVTheoKhoaVaCoSoTableAdapter.Delete(txtMaGV.Text);
                        if (bdsGVtheoKhoa.Count == 0)
                        {
                            btnDelete.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
                        }
                        if (isUndo == false)
                        {
                            TeacherDto dataUndo = new TeacherDto(strMaGV, strHo, strTen, strHocVi, strMethod);
                            st.Push(dataUndo);
                            updateUIUndo();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thành công. Xin thử lại!\n" + ex.Message, "",
                           MessageBoxButtons.OK);
                        getDataGVtheoKhoa(layMaKhoa());
                        bdsGVtheoKhoa.Position = bdsGVtheoKhoa.Find("MAGV", currentTeacherID);
                        return;
                    }
                }
            }
        }*/
        /*private void cbbCoSo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbCoSo.SelectedValue != null)
            {
                if (cbbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cbbCoSo.SelectedValue.ToString();
                if (cbbCoSo.SelectedIndex != Program.indexBranch)
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
                    initUIComboBoxKhoa();
                }
            }
        }*/


        /*private void getDataGVtheoKhoa(string strKH)
        {
            try
            {
                String mServername = cbbCoSo.SelectedValue.ToString();
                int indexStr = mServername.IndexOf("\\") + 1;
                mServername = mServername.Substring(indexStr);

                this.SP_DSGVTheoKhoaVaCoSoTableAdapter.Fill(this.TN_CSDLPTDataSet.SP_DSGVTheoKhoaVaCoSo, strKH, mServername);
                this.SP_DSGVTheoKhoaVaCoSoTableAdapter.ClearBeforeFill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            setCurrentRole();
        }*/

        /*public int getIndexDBS(string strMaGV)
        {
            for (int i = 0; i < bdsGVtheoKhoa.Count; i++)
            {
                if (strMaGV.Trim() == ((DataRowView)bdsGVtheoKhoa[i])["MAGV"].ToString().Trim())
                {
                    return i;
                }
            }
            return -1;
        }*/

        private void cbbxDept_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bdsDept.Count > 0)
            {
                try
                {
                    this.tableAdapterTeacher.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterTeacher.Fill(this.dS.SP_TeacherTable, cbbxDept.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionType = ActionType.ADDING;
            cbbxDept.Enabled= btnAdd.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsTeacher.Position;
            bdsTeacher.AddNew();

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã giảng viên không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }
            if (txtFName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ giảng viên không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtFName.Focus();
                return;
            }
            if (txtLName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên giảng viên không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtLName.Focus();
                return;
            }

            if (actionType == ActionType.ADDING)
            {
                try
                {
                    if (addTeacher(txtId.Text, txtFName.Text, txtLName.Text, txtAddr.Text) > 0)
                    {
                        this.tableAdapterTeacher.Connection.ConnectionString = Program.connstr;
                        this.tableAdapterTeacher.Fill(this.dS.SP_TeacherTable, cbbxDept.SelectedValue.ToString());
                    }

                    /*else
                    {
                        regisListBindingSource.RemoveCurrent();
                        regisListBindingSource.Position = indexTbl;    
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm câu hỏi\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if (editTeacher() > 0)
                {
                    this.tableAdapterTeacher.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterTeacher.Fill(this.dS.SP_TeacherTable, cbbxDept.SelectedValue.ToString());
                }
            }
            btnAdd.Enabled = true;
            changeEnabledStatus();
            actionType = ActionType.READING;
            


            /*if (bdsGVtheoKhoa.Count != 1)
            {
                currentTeacherID = ((DataRowView)bdsGVtheoKhoa[index])["MAGV"].ToString();
            }

            if (method == Program.NEW_METHOD)
            {
                sqlNewMethod(txtMaGV.Text, txtHo.Text, txtTen.Text, txtHocVi.Text, Program.NEW_METHOD);
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlUpdateMethod(txtMaGV.Text, txtHo.Text, txtTen.Text, txtHocVi.Text, Program.UPDATE_METHOD);
            }
            groupInfo.Enabled = true;
            cbbKhoa.Enabled = true;
            sP_DSGVTheoKhoaVaCoSoGridControl.Enabled = true;
            txtMaGV.Enabled = txtHo.Enabled = txtTen.Enabled = txtHocVi.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;*/
        }

        private int editTeacher()
        {
            String str = "UPDATE dbo.GIAOVIEN " +
                            "SET HO = '"+txtFName.Text+"', " +
                            "TEN = '"+txtLName.Text+"', " +
                            "DIACHI = '"+txtAddr.Text+"' " +
                            "WHERE MAGV = '"+txtId.Text+"'";
            if (Program.execNonQuery(str) > 0) return 1;
            else return -1;
        }

        private int addTeacher(string teacherId, string fName, string lName, string addr)
        {

            String str = "INSERT INTO dbo.GIAOVIEN (MAGV, HO, TEN, DIACHI, MAKH) VALUES ('" + teacherId + "', '" + fName + "', '" + lName + "', '" + addr + "', '" + cbbxDept.SelectedValue.ToString() + "')";
            if (Program.execNonQuery(str, "Mã giảng viên đã tồn tại!") > 0) return 1;
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

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionType = ActionType.EDITING;
            cbbxDept.Enabled = txtId.Enabled = btnAdd.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsTeacher.Position;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsTeacherRegis.Count > 0)
            {
                MessageBox.Show("Giảng viên đã đăng ký bài kiểm tra\n Không thể xoá giảng viên này!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsQues.Count > 0)
            {
                MessageBox.Show("Giảng viên đã tạo câu hỏi\n Không thể xoá giảng viên này!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xoá giảng viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                string str = "DELETE FROM dbo.GIAOVIEN WHERE MAGV= '" + txtId.Text + "'";
                if (Program.execNonQuery(str) > 0)
                {
                    this.tableAdapterTeacher.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterTeacher.Fill(this.dS.SP_TeacherTable, cbbxDept.SelectedValue.ToString());
                }

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tableAdapterTeacher.Connection.ConnectionString = Program.connstr;
                this.tableAdapterTeacher.Fill(this.dS.SP_TeacherTable, cbbxDept.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload " + ex.Message, "", MessageBoxButtons.OK);
                return;
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
                this.tableAdapterDept.Connection.ConnectionString = Program.connstr;
                this.tableAdapterDept.Fill(this.dS.KHOA);
                this.tableAdapterTeacherRegistrasion.Connection.ConnectionString = Program.connstr;
                this.tableAdapterTeacherRegistrasion.Fill(this.dS.GIAOVIEN_DANGKY);
                this.tableAdapterQuestions.Connection.ConnectionString = Program.connstr;
                this.tableAdapterQuestions.Fill(this.dS.BODE);
            }
        }
    }
}
