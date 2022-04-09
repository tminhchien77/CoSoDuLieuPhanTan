using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TRACNGHIEM_CSDLPT.SystemConstant;

namespace TRACNGHIEM_CSDLPT.views
{
    public partial class frmClass : Form
    {
        ActionType actionType = ActionType.READING;
        int indexTbl = 0;
        /*public int index;
        public String maKH;
        public String maLop;
        public String tenLop;
        private static SqlDataReader myReader;
        private SqlConnection conn_publisher = new SqlConnection();
        public String method = "";
        // Stack Undo
        public Stack st = new Stack();
        public ClassDto dtoUndo = new ClassDto("", "", "");
        public bool isUndo = false;*/



        public class ClassDto
        {
            public String strClassID;
            public String strClassName;
            public String method;
            public int index;

            public ClassDto(String ClassID, String ClassName, String strMethod)
            {
                strClassID = ClassID;
                strClassName = ClassName;
                method = strMethod;
            }
        }

        public frmClass()
        {
            InitializeComponent();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            this.tableAdapterDept.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDept.Fill(this.dS.KHOA);
            initUIComboBoxCoSo();
            setCurrentRole();
            /*updateUIUndo();*/

        }
        public void initUIComboBoxCoSo()
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

                if (bdsClass.Count == 0)
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
            btnSave.Enabled = groupInfor.Enabled = btnUndo.Enabled = btnRedo.Enabled = !btnAdd.Enabled;
            cbbxDept.Enabled =gcClass.Enabled = btnAdd.Enabled;
            if (!btnAdd.Enabled)
                btnEdit.Enabled = btnDelete.Enabled = btnAdd.Enabled;
        }

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

        /*private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsLOPtheoKHOA.Position;
            bdsLOPtheoKHOA.AddNew();

            groupInfo.Enabled = true;
            txtMaLop.Enabled = txtTenLop.Enabled = true;
            cbbMaKH.Enabled = true;

            method = Program.NEW_METHOD;

            btnCancel.Enabled = btnGhi.Enabled = true;
            btnRefresh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            txtMaLop.Focus();
        }*/

        /*private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsLOPtheoKHOA.Position;
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = true;
            groupInfo.Enabled = false;
            cbbMaKH.Enabled = false;
            method = Program.UPDATE_METHOD;
            maLop = ((DataRowView)bdsLOPtheoKHOA[index])["MALOP"].ToString();
            tenLop = ((DataRowView)bdsLOPtheoKHOA[index])["TENLOP"].ToString();
            sqlUpdateMethod(maLop, tenLop, method);

            dtoUndo.strClassID = maLop;
            dtoUndo.strClassName = tenLop;
            btnCancel.Enabled = btnGhi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
        }*/

        /*private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLOPtheoKHOA.Count == 0) btnXoa.Enabled = false;
            index = bdsLOPtheoKHOA.Position;
            method = Program.DELETE_METHOD;
            maLop = ((DataRowView)bdsLOPtheoKHOA[index])["MALOP"].ToString();
            tenLop = ((DataRowView)bdsLOPtheoKHOA[index])["TENLOP"].ToString();
            sqlDeleteMethod(maLop, tenLop, method);

        }*/

        /*private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsLOPtheoKHOA.Count != 1)
            {
                maLop = ((DataRowView)bdsLOPtheoKHOA[index])["MALOP"].ToString();
                tenLop = ((DataRowView)bdsLOPtheoKHOA[index])["TENLOP"].ToString();
            }
            else if (method == Program.NEW_METHOD)
            {
                sqlNewMethod(txtMaLop.Text, txtTenLop.Text, method);
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlUpdateMethod(txtMaLop.Text, txtTenLop.Text, method);
            }
            

            txtMaLop.Enabled = txtTenLop.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThem.Enabled = true;
            btnGhi.Enabled = btnCancel.Enabled = false;
        }*/

        /*private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            txtMaLop.Enabled = txtTenLop.Enabled = true;

            if (bdsLOPtheoKHOA.Count == 0) btnXoa.Enabled = false;
            else btnXoa.Enabled = true;

            if (Program.mGroup == "TRUONG")
            {
                cbbCoSo.Enabled = cbbMaKH.Enabled = true;
            }
            else
            {
                cbbCoSo.Enabled = false;
                cbbMaKH.Enabled = true;
            }

            groupInfo.Enabled = true;
            bdsLOPtheoKHOA.MoveFirst();
            st.Clear();
            updateUIUndo();

            getDataClassFromDep(getMaKhoaSelected());

            btnCancel.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
        }*/

        /*private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaLop.Enabled = txtTenLop.Enabled = false;
            bdsLOPtheoKHOA.MoveFirst();
            getDataClassFromDep(getMaKhoaSelected());
        }*/

        /*private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isUndo = true;
            ClassDto dataUndo = (ClassDto)st.Pop();
            if (dataUndo.method == Program.NEW_METHOD)
            {
                int index = getIndexDBS(dataUndo.strClassID);
                if (index >= 0)
                {
                    bdsLOPtheoKHOA.Position = index;
                    sqlDeleteMethod(dataUndo.strClassID, dataUndo.strClassName, Program.DELETE_METHOD);
                }
            }
            else if (dataUndo.method == Program.UPDATE_METHOD)
            {
                int index = getIndexDBS(dataUndo.strClassID);
                if (index >= 0)
                {
                    bdsLOPtheoKHOA.Position = index;
                    txtTenLop.Text = dataUndo.strClassName;
                    txtMaLop.Text = dataUndo.strClassID;
                    sqlUpdateMethod(dataUndo.strClassID, dataUndo.strClassName, method);
                }

            }
            else if (dataUndo.method == Program.DELETE_METHOD)
            {
                bdsLOPtheoKHOA.AddNew();
                txtTenLop.Text = dataUndo.strClassName;
                txtMaLop.Text = dataUndo.strClassID;
                sqlNewMethod(dataUndo.strClassID, dataUndo.strClassName, Program.NEW_METHOD);
            }
            isUndo = false;
            updateUIUndo();
        }*/

        /*private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }*/
        /*public int getIndexDBS(string strID)
        {
            for (int i = 0; i < bdsLOPtheoKHOA.Count; i++)
            {
                if (strID.Trim() == ((DataRowView)bdsLOPtheoKHOA[i])["MALOP"].ToString().Trim())
                {
                    return i;
                }
            }
            return -1;
        }*/

        /*private void sqlNewMethod(string maLop, string tenLop, string method)
        {
            String strLenh = "exec SP_KiemTraLopTheoKhoa '" + maLop + ",'" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("The " + txtMaLop.Text + " đã tồn tại!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (maLop.Length == 0 || tenLop.Length == 0)
                {
                    MessageBox.Show("Mã lớp và tên lớp không được trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {

                        bdsLOPtheoKHOA.EndEdit();
                        bdsLOPtheoKHOA.ResetCurrentItem();
                       // this.SP_DanhSachLopTheoKhoaVaCoSoTableAdapter.Insert(maLop, tenLop, getMaKhoaSelected());
                        if (isUndo == false)
                        {
                            ClassDto dataUndo = new ClassDto(maLop, tenLop, method);
                            st.Push(dataUndo);
                            updateUIUndo();
                            MessageBox.Show("Thêm lớp  thành công ! \n", "Error", MessageBoxButtons.OK);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm lớp không thành công ! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
                Program.myReader.Close();
            }

        }*/
        /*private void sqlUpdateMethod(string maLop, string tenLop, string method)
        {
            String strLenh = "exec SP_KiemTraLopTheoKhoa '" + maLop + "'" + ",'" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("The " + txtMaLop.Text + " đã tồn tại!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (tenLop.Length == 0)
                {
                    MessageBox.Show("Mã lớp và tên lớp không được trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        this.Validate();
                        bdsLOPtheoKHOA.EndEdit();
                        bdsLOPtheoKHOA.ResetCurrentItem();
                        //this.SP_DanhSachLopTheoKhoaVaCoSoTableAdapter.Update(maLop, tenLop);
                        if (isUndo == false)
                        {
                            ClassDto dataUndo = new ClassDto(maLop, tenLop, method);
                            st.Push(dataUndo);
                            updateUIUndo();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm lớp không thành công ! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
                Program.myReader.Close();
            }
        }*/

        /*private void sqlDeleteMethod(string maLop, string tenLop, string method)
        {
            String strLenh = "exec SP_KiemTraLopTheoKhoa '" + maLop + "'" + ",'" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("" + txtMaLop.Text + " không thể xoá !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (MessageBox.Show("bạn có chắc chắn muốn xoá lớp  " + tenLop + " không ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        bdsLOPtheoKHOA.RemoveCurrent();
                       // this.SP_DanhSachLopTheoKhoaVaCoSoTableAdapter.Delete(maLop);
                        if (isUndo == false)
                        {
                            ClassDto dataUndo = new ClassDto(maLop, tenLop, method);
                            st.Push(dataUndo);
                            updateUIUndo();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xoá không thành công! Xin hãy kiểm tra lại!" + ex.Message, "",
                           MessageBoxButtons.OK);

                        Program.myReader.Close();
                        String currentServerName = cbbCoSo.SelectedValue.ToString();
                        maKH = cbbMaKH.SelectedValue.ToString();
                        this.SP_DanhSachLopTheoKhoaVaCoSoTableAdapter.Fill(this.TN_CSDLPTDataSet.SP_DanhSachLopTheoKhoaVaCoSo, maKH, currentServerName);
                        this.SP_DanhSachLopTheoKhoaVaCoSoTableAdapter.ClearBeforeFill = true;
                        bdsLOPtheoKHOA.Position = bdsLOPtheoKHOA.Find("MALOP", maLop);
                    }
                }
                Program.myReader.Close();
            }
        }*/

        /*private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
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
                String maCN = "CS" + (cbbCoSo.SelectedIndex + 1).ToString();
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
                loadComboboxKHOA(Program.servername, maCN);
            }

        }*/

        /*private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }*/

        private void cbbxDept_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (bdsDept.Count > 0)
            {
                try
                {
                    this.tableAdapterClass.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterClass.Fill(this.dS.SP_ClassTable, cbbxDept.SelectedValue.ToString());
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
            btnAdd.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsClass.Position;
            bdsClass.AddNew();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã lớp không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }
            if (txtClass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên lớp không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtClass.Focus();
                return;
            }

            if (actionType == ActionType.ADDING)
            {
                try
                {
                    if (addClass() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        this.tableAdapterClass.Connection.ConnectionString = Program.connstr;
                        this.tableAdapterClass.Fill(this.dS.SP_ClassTable, cbbxDept.SelectedValue.ToString());

                        btnAdd.Enabled = true;
                        changeEnabledStatus();
                        actionType = ActionType.READING;
                    }

                    /*else
                    {
                        regisListBindingSource.RemoveCurrent();
                        regisListBindingSource.Position = indexTbl;    
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm lớp\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                /*int indexSelection = quesGridView.GetSelectedRows().FirstOrDefault();
                DataRowView selRow = (DataRowView)(((GridView)quesGridControl.MainView).GetRow(indexSelection));
                int idQues = (int)selRow["MaCauHoi"];
                try
                {
                    *//*quesBindingSource.RemoveCurrent();*//*
                    updateQues(idQues);
                    this.quesTableAdapter.Fill(this.kiemTraHSDataSet.SP_GetAllQuesByLesson, idLesson);
                    quesBindingSource.Position = quesBindingSource.Find("MaCauHoi", idQues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiệu chỉnh câu hỏi\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
                    this.quesTableAdapter.Fill(this.kiemTraHSDataSet.SP_GetAllQuesByLesson, idLesson);
                    quesBindingSource.Position = quesBindingSource.Find("MaCauHoi", idQues);
                    return;
                }*/
            }
        }

        private int addClass()
        {
            String str = "EXECUTE [dbo].[SP_AddClass] '" + txtId.Text + "', " +
                "'" + txtClass.Text + "', '" + cbbxDept.SelectedValue.ToString() + "'";
            if (Program.execNonQuery(str) > 0) return 1;
            else return -1;
        }
    }
}
