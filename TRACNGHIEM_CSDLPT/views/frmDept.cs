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
    public partial class frmDept : Form
    {
        ActionType actionType = ActionType.READING;
        int indexTbl = 0;
        /*int index = 0;
        public String maCS;
        public String maKhoaHT;
        public String tenKhoaHT;
        private SqlConnection conn_publisher = new SqlConnection();
        String method = "";

        // Stack Undo
        public Stack stUndo = new Stack();
        public Stack stRedo = new Stack();
        public DepDto dtoUndo = new DepDto("", "", "");
        public bool isUndo = false;
        public bool isRedo = false;


        public class DepDto
        {
            public String strKhoaID;
            public String strTenKH;
            public String method;
            public int index;
            public DepDto(String depID, String depName, String strMethod)
            {
                strKhoaID = depID;
                strTenKH = depName;
                method = strMethod;
            }
        }*/
        public frmDept()
        {
            InitializeComponent();
        }

        /*private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPTDataSet);

        }*/

        private void frmDep_Load(object sender, EventArgs e)
        {
            this.tableAdapterDept.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDept.Fill(this.dS.KHOA);
            initUIComboBoxCoSo();
            setCurrentRole();
            //updateUIUndo();

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

                if (bdsDept.Count == 0)
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
            gcDept.Enabled = btnAdd.Enabled;
            if (!btnAdd.Enabled)
                btnEdit.Enabled = btnDelete.Enabled = btnAdd.Enabled;
        }

       /* public void updateUIUndo()
        {
            if (stUndo.Count > 0)
            {
                btnUndo.Enabled = true;
            }
            else
            {
                btnUndo.Enabled = false;
            }

            if (stRedo.Count > 0)
            {
                btnRedo.Enabled = true;
            }
            else
            {
                btnRedo.Enabled = false;
            }
        }*/

        /*private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsKhoa.Position;
            bdsKhoa.AddNew();

            txtMaKhoa.Enabled = txtTenKhoa.Enabled = true;
            //txtMaCS.Text = maCS; 
            cbbCoSo.Enabled = false;

            method = Program.NEW_METHOD;
            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnAdd.Enabled = btnEdit.Enabled = false;

            txtMaKhoa.Focus();
        }*/

        /*private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsKhoa.Position;
           
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = true;
            cbbCoSo.Enabled = false;
            method = Program.UPDATE_METHOD;
            maCS = ((DataRowView)bdsKhoa[0])["MACS"].ToString();

            maKhoaHT = ((DataRowView)bdsKhoa[index])["MAKH"].ToString();
            tenKhoaHT = ((DataRowView)bdsKhoa[index])["TENKH"].ToString();

            dtoUndo.strKhoaID = maKhoaHT;
            dtoUndo.strTenKH = tenKhoaHT;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnAdd.Enabled = btnRefresh.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
        }*/

        /*private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsKhoa.Position;
            method = Program.DELETE_METHOD;
            
            btnCancel.Enabled = btnSave.Enabled = false;
            btnAdd.Enabled = btnRefresh.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
            sqlDeleteMethod(maKhoaHT, tenKhoaHT, method);
        }*/
        /*private void sqlDeleteMethod(string strKhoaID, string strTenKH, string method)
        {
            String sqlStr = "exec SP_KiemTraKhoa '" + strKhoaID + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Không thể xoá Khoa này. \nKhoa đã có dữ liệu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá khoa " + strTenKH + " này?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsKhoa.RemoveCurrent();
                        this.KHOATableAdapter.Update(this.TN_CSDLPTDataSet.KHOA);
                        if (isUndo == false)
                        {
                            DepDto dataUndo = new DepDto(dtoUndo.strKhoaID, dtoUndo.strTenKH, method);
                            stUndo.Push(dataUndo);
                            updateUIUndo();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xoá không thành công! Xin hãy kiểm tra lại!" + ex.Message, "",
                            MessageBoxButtons.OK);

                        Program.myReader.Close();
                        this.KHOATableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
                        bdsKhoa.Position = bdsKhoa.Find("MAKH", strKhoaID);
                    }
                }
            }
        }*/
        /*private void sqlUpdateMethod(string strKhoaID, string strTenKH, string method)
        {
            String sqlStr = "exec SP_KiemTraKhoa '" + strKhoaID + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            tenKhoaHT = ((DataRowView)bdsKhoa[index])["TENKH"].ToString();
            if (txtTenKhoa.Text == tenKhoaHT)
            {
                MessageBox.Show("Bạn cần nhập tên khoa khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (txtTenKhoa.Text.Length == 0)
                {
                    MessageBox.Show("Tên Khoa không được trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        this.Validate();
                        bdsKhoa.EndEdit();
                        bdsKhoa.ResetCurrentItem();
                        this.KHOATableAdapter.Update(this.TN_CSDLPTDataSet.KHOA);
                        if (isUndo == false)
                        {
                            DepDto dataUndo = new DepDto(dtoUndo.strKhoaID, dtoUndo.strTenKH, method);
                            stUndo.Push(dataUndo);
                            updateUIUndo();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa KHOA không thành công! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
            }
        }*/

        /*private void sqlNewMethod(string strKhoaID, string strTenKH, string method)
        {
            String sqlStr = "exec SP_KiemTraKhoa '" + strKhoaID + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("The " + strKhoaID + " has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (strKhoaID.Length == 0 || strTenKH.Length == 0)
                {
                    MessageBox.Show("KhoaID hoặc TenKhoa không được trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    try
                    {
                        bdsKhoa.EndEdit();
                        bdsKhoa.ResetCurrentItem();
                        this.KHOATableAdapter.Update(this.TN_CSDLPTDataSet.KHOA);
                        if (isUndo == false)
                        {
                            DepDto dataUndo = new DepDto(strKhoaID, strTenKH, method);
                            stUndo.Push(dataUndo);
                            updateUIUndo();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể thêm Khoa mới! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }*/


        /*private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (method == Program.NEW_METHOD)
            {
                sqlNewMethod(txtMaKhoa.Text, txtTenKhoa.Text, method);
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlUpdateMethod(txtMaKhoa.Text, txtTenKhoa.Text, method);
            }
           
            btnCancel.Enabled = btnSave.Enabled = false;
            btnAdd.Enabled = btnRefresh.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
        }*/

        /*private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = false;
            if (Program.mGroup == "TRUONG")
            {
                cbbCoSo.Enabled = true;
            }
            else
            {
                cbbCoSo.Enabled = false;
            }
            bdsKhoa.MoveFirst();
            stUndo.Clear();
            stRedo.Clear();
            updateUIUndo();
            this.KHOATableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }*/

        /*private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //đang bị lỗi 
            isUndo = true;

            DepDto dataUndo = (DepDto)stUndo.Pop();
            int vitri = getIndexDBS(dataUndo.strKhoaID);
            if (dataUndo.method == Program.NEW_METHOD)
            {
                stRedo.Push(dataUndo);

                if (vitri >= 0)
                {
                    bdsKhoa.Position = vitri;
                    sqlDeleteMethod(dataUndo.strKhoaID, dataUndo.strTenKH, method);
                }
            }
            else if (dataUndo.method == Program.UPDATE_METHOD)
            {
                if (vitri >= 0)
                {
                    DepDto dataRedo = new DepDto(txtMaKhoa.Text, txtTenKhoa.Text, method);
                    stRedo.Push(dataRedo);
                    bdsKhoa.Position = vitri;
                    txtMaKhoa.Text = dataRedo.strKhoaID;
                    txtTenKhoa.Text = dataRedo.strTenKH;
                    sqlUpdateMethod(dataRedo.strKhoaID, dataRedo.strTenKH, method);
                }
            }
            else if (dataUndo.method == Program.DELETE_METHOD)
            {
                stRedo.Push(dataUndo);
                bdsKhoa.AddNew();
                txtMaKhoa.Text = dataUndo.strKhoaID;
                txtTenKhoa.Text = dataUndo.strTenKH;
                sqlNewMethod(dataUndo.strKhoaID, dataUndo.strTenKH, method);
            }

            isUndo = false;
            updateUIUndo();
        }*/
        private int getIndexDBS(string strKhoaID)
        {
            for (int i = 0; i < bdsKhoa.Count; i++)
            {
                if (strKhoaID.Trim() == ((DataRowView)bdsKhoa[i])["MAKH"].ToString().Trim())
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã khoa không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }
            if (txtDept.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên khoa không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtDept.Focus();
                return;
            }

            if (actionType == ActionType.ADDING)
            {
                string str = "EXECUTE [dbo].[SP_CheckExistDept] '"+txtId.Text+"', N'"+txtDept.Text+"'";
                Program.myReader = Program.ExecSqlDataReader(str);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                if(Program.myReader.GetInt32(0)>0)
                try
                {
                    bdsDept.EndEdit();
                    bdsDept.ResetCurrentItem();
                    this.tableAdapterDept.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterDept.Update(this.dS.KHOA);
                    MessageBox.Show("Thêm thành công");
                    
                    btnAdd.Enabled = true;
                    changeEnabledStatus();
                    actionType = ActionType.READING;
                    

                    /*else
                    {
                        regisListBindingSource.RemoveCurrent();
                        regisListBindingSource.Position = indexTbl;    
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm khoa\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
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

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionType = ActionType.ADDING;
            btnAdd.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsDept.Position;
            
            bdsDept.AddNew();
            DataRowView drv = (DataRowView)cbbxBranch.SelectedItem;
            txtBranchId.Text = (string)drv.Row["TENCOSO"];
        }

        /*private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            isRedo = true;

            DepDto dataRedo = (DepDto)stRedo.Pop();
            int vitri = getIndexDBS(dataRedo.strKhoaID);
            if (dataRedo.method == Program.NEW_METHOD)
            {

                stRedo.Push(dataRedo);
                bdsKhoa.AddNew();
                txtMaKhoa.Text = dataRedo.strKhoaID;
                txtTenKhoa.Text = dataRedo.strTenKH;
                sqlNewMethod(dataRedo.strKhoaID, dataRedo.strTenKH, method);
            }
            else if (dataRedo.method == Program.UPDATE_METHOD)
            {
                if (vitri >= 0)
                {
                    DepDto dataUndo = new DepDto(txtMaKhoa.Text, txtTenKhoa.Text, method);
                    stUndo.Push(dataUndo);
                    bdsKhoa.Position = vitri;
                    txtMaKhoa.Text = dataRedo.strKhoaID;
                    txtTenKhoa.Text = dataRedo.strTenKH;
                    sqlUpdateMethod(dataRedo.strKhoaID, dataRedo.strTenKH, method);
                }
            }
            else if (dataRedo.method == Program.DELETE_METHOD)
            {
                stRedo.Push(dataRedo);

                if (vitri >= 0)
                {
                    bdsKhoa.Position = vitri;
                    sqlDeleteMethod(dataRedo.strKhoaID, dataRedo.strTenKH, method);
                }
            }

            isRedo = isUndo = false;
            updateUIUndo();
        }*/

        /*private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            txtMaKhoa.Enabled = txtTenKhoa.Enabled = false;
            cbbCoSo.Enabled = true;
            index = bdsKhoa.Position;
            setCurrentRole();
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

                // TODO: This line of code loads data into the 'dsKhoa.KHOA' table. You can move, or remove it, as needed.
                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
                // TODO: This line of code loads data into the 'dsKhoa.LOP' table. You can move, or remove it, as needed.
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
                // TODO: This line of code loads data into the 'dsKhoa.GIAOVIEN' table. You can move, or remove it, as needed.
               
                maCS = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            }
        }*/
    }
}
