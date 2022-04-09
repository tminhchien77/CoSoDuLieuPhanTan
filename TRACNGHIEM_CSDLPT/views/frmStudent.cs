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
    public partial class frmStudent : Form
    {
        ActionType actionType = ActionType.READING;
        int indexTbl = 0;
        public frmStudent()
        {
            InitializeComponent();
        }

        int index;
        String method = "";
        public String maCS;
        public String maKhoa;
        public String maLop;
        public String mMaSV;
        private static SqlDataReader myReader;
        private SqlConnection conn_publisher = new SqlConnection();

        // Stack Undo
        public Stack stUndo = new Stack();
        public Stack stRedo = new Stack();
        public DepDto dtoUndo = new DepDto("", "", "");
        public bool isUndo = false;
        public bool isRedo = false;


        public class DepDto
        {
            public String strDepID;
            public String strDepName;
            public String method;
            public int index;

            public DepDto(String depID, String depName, String strMethod)
            {
                strDepID = depID;
                strDepName = depName;
                method = strMethod;
            }
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
            
            dS.EnforceConstraints = false;
            this.tableAdapterDept.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDept.Fill(this.dS.KHOA);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            /*dateNgaySinh.MinDate = DateTime.Now;
            dateNgaySinh.Format = DateTimePickerFormat.Custom;*/
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
                getDataSVFromLopID("TH01");
                initUIComboBoxLop();
            }
        }*/

        /*private void initUIComboBoxLop()
        {
            String mTenLop = layMaKhoa();

            String strLenh = "exec SP_DanhSachLopTheoKhoa'" + mTenLop + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbLop.SelectedIndex = -1;
                    cbbLop.DataSource = null;
                }
                else
                {
                    cbbLop.DataSource = dt;
                    cbbLop.DisplayMember = "MALOP";
                    cbbLop.ValueMember = "MALOP";
                }
                cbbLop.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Không thể hiện danh sách lớp!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/

        /*private void getDataSVFromLopID(string maLop)
        {
            try
            {
                String mServername = cbbCoSo.SelectedValue.ToString();
                int indexStr = mServername.IndexOf("\\") + 1;
                mServername = mServername.Substring(indexStr);

                this.SP_DSSVTheoLopTableAdapter.Fill(this.TN_CSDLPTDataSet.SP_DSSVTheoLop, maLop);
                this.SP_DSSVTheoLopTableAdapter.ClearBeforeFill = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            setCurrentRole();
        }*/
        /*public String layMaCoSo()
        {
            return cbbCoSo.SelectedValue.ToString();
        }*/

        /*public String layMaKhoa()
        {
            maKhoa = cbbKhoa.SelectedIndex >= 0 ? cbbKhoa.SelectedValue.ToString() : "";
            return maKhoa;
        }*/

        /*public String layMaLop()
        {
            maLop = cbbLop.SelectedIndex >= 0 ? cbbLop.SelectedValue.ToString() : "";
            return maLop;
        }*/
        public void setCurrentRole()
        {
            if (Program.mGroup == "TRUONG")
            {
                cbbxBranch.Enabled = true;
                btnAdd.Enabled = btnEdit.Enabled= btnDelete.Enabled=btnSave.Enabled=btnUndo.Enabled=btnRedo.Enabled = false;
            }
            else
            {
                cbbxBranch.Enabled = false;

                if (bdsStudent.Count == 0)
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
            cbbxDept.Enabled= cbbxClass.Enabled = gcStudent.Enabled = btnAdd.Enabled;
            if (!btnAdd.Enabled)
                btnEdit.Enabled = btnDelete.Enabled = btnAdd.Enabled;
        }

        /*public void updateUIUndo()
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

        /*private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsSVtheoLOP.Position;
            groupThongTin.Enabled = true;

            txtMaSV.Enabled = false; 
            txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = true;
            dateNgaySinh.Format = DateTimePickerFormat.Custom;
            dateNgaySinh.CustomFormat = " ";

            cbbCoSo.Enabled = cbbKhoa.Enabled = cbbLop.Enabled = false;
         
            txtMaSV.Focus();
            method = Program.UPDATE_METHOD;
            btnCancel.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
        }*/

        /*private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsSVtheoLOP.Position;
            method = Program.DELETE_METHOD;
            mMaSV = ((DataRowView)bdsSVtheoLOP[index])["MASV"].ToString();
            String strLenh = "exec SP_KiemTraSinhVienTheoLop '" + mMaSV + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Không thể xoá sinh viên này. Sinh viên đã có thông tin bài thi! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xoá sinh viên này!", " Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsSVtheoLOP.RemoveCurrent();
                       // this.SP_DSSVTheoLopTableAdapter.Delete(mMaSV);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Không thành công. Xin thử lại!\n" + ex.Message, "",
                           MessageBoxButtons.OK);
                        getDataSVFromLopID(layMaLop());
                        bdsSVtheoLOP.Position = bdsSVtheoLOP.Find("MASV", mMaSV);
                        return;
                    }
                }
            }
        }*/

        /*private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSVtheoLOP.Count != 1)
            {
                mMaSV = ((DataRowView)bdsSVtheoLOP[index])["MASV"].ToString();

            }

            else
            {
                String strLenh = "";
                if (method == Program.NEW_METHOD)
                {
                    strLenh = "exec SP_KiemTraSinhVienTheoLop '" + txtMaSV.Text + "','" + method + "'";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();

                    if (Program.myReader.FieldCount > 0)
                    {
                        MessageBox.Show("Đã tồn tại sinh viên có mã  " + txtMaSV.Text + " !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        if (txtMaSV.Text.Length == 0 || txtHo.Text.Length == 0 || txtTen.Text.Length == 0)
                        {

                            MessageBox.Show("Teacher ID or Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            try
                            {
                                this.Validate();
                                bdsSVtheoLOP.EndEdit();
                                bdsSVtheoLOP.ResetCurrentItem();
                               //this.SP_DSSVTheoLopTableAdapter.Insert(txtMaSV.Text, txtHo.Text, txtTen.Text, dateNgaySinh.Value.Date, txtDiaChi.Text, layMaLop());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Create student failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                                Program.myReader.Close();
                                return;

                            }
                        }
                        Program.myReader.Close();

                    }


                }
                else if (method == Program.UPDATE_METHOD)
                {
                    if (txtHo.Text.Length == 0)
                    {
                        MessageBox.Show("Họ không được trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtTen.Text.Length == 0)
                    {
                        MessageBox.Show("First Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                    }

                }
                Program.myReader.Close();
            }
        }*/

        /*private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            txtMaSV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = dateNgaySinh.Enabled = false;
            if (bdsSVtheoLOP.Count == 0) btnXoa.Enabled = false;
            else btnXoa.Enabled = true;

            if (Program.mGroup == "TRUONG")
            {
                cbbCoSo.Enabled = cbbKhoa.Enabled = cbbLop.Enabled = true;
            }
            else
            {
                cbbCoSo.Enabled = false;
                cbbKhoa.Enabled = cbbLop.Enabled = true;
            }
            groupThongTin.Enabled = true;
            bdsSVtheoLOP.MoveFirst();
            getDataSVFromLopID(layMaLop());

            btnCancel.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
        }*/

        /*private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            txtMaSV.Enabled = txtHo.Enabled = txtTen.Enabled = txtDiaChi.Enabled = dateNgaySinh.Enabled = false;
            bdsSVtheoLOP.MoveFirst();
            getDataSVFromLopID(layMaLop());
            groupThongTin.Enabled = true;

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
                initUIComboBoxKhoa();
            }
        }*/

        private void cbbxDept_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bdsDept.Count > 0)
            {
                try
                {
                    this.tableAdapterClass.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterClass.Fill(this.dS.SP_ClassList, cbbxDept.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbbxClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bdsClass.Count > 0)
            {
                try
                {
                    this.tableAdapterStudent.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterStudent.Fill(this.dS.SP_StudentTable, cbbxClass.SelectedValue.ToString());
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
            indexTbl = bdsStudent.Position;
            bdsStudent.AddNew();
            Program.myReader = Program.ExecSqlDataReader("EXEC dbo.SP_NextStudentId");
            if (Program.myReader == null) return;
            Program.myReader.Read();
            txtId.Text = Program.myReader.GetString(0);
            Program.myReader.Close();
            dateEditDOB.EditValue = null;
            txtFName.Focus();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã sinh viên không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }
            if (txtFName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ sinh viên không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtFName.Focus();
                return;
            }
            if (txtLName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên sinh viên không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtLName.Focus();
                return;
            }
            if(dateEditDOB.EditValue == null)
            {
                MessageBox.Show("Ngày sinh sinh viên không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                dateEditDOB.Focus();
                return;
            }

            if (actionType == ActionType.ADDING)
            {
                try
                {
                    if (addStudent() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        this.tableAdapterStudent.Connection.ConnectionString = Program.connstr;
                        this.tableAdapterStudent.Fill(this.dS.SP_StudentTable, cbbxClass.SelectedValue.ToString());
                    }

                    /*else
                    {
                        regisListBindingSource.RemoveCurrent();
                        regisListBindingSource.Position = indexTbl;    
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm sinh viên\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if (editStudent() > 0)
                {
                    this.tableAdapterStudent.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterStudent.Fill(this.dS.SP_StudentTable, cbbxClass.SelectedValue.ToString());
                }
            }
            btnAdd.Enabled = true;
            changeEnabledStatus();
            actionType = ActionType.READING;
        }

        private int editStudent()
        {
            String str = "UPDATE dbo.SINHVIEN " +
                            "SET HO = '"+txtFName.Text.Trim()+"'," +
                                "TEN = '" + txtLName.Text.Trim() + "'," +
                                "NGAYSINH = '" + dateEditDOB.DateTime + "'," +
                                "DIACHI = '" + txtAddr.Text.Trim() + "' " +
                                "WHERE MASV = '" + txtId.Text.Trim() + "'";
            if (Program.execNonQuery(str) > 0) return 1;
            else return -1;
        }

        private int addStudent()
        {
            String str = "EXECUTE [dbo].[SP_AddStudent] '" + txtId.Text + "', " +
                "'" + txtFName.Text + "', '" + txtLName.Text + "', " +
                "'" + dateEditDOB.DateTime + "', '" + txtAddr.Text + "', " +
                "'" + cbbxClass.SelectedValue.ToString() + "'";
            if (Program.execNonQuery(str, "Mã sinh viên đã tồn tại!") > 0) return 1;
            else return -1;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionType = ActionType.EDITING;
            cbbxClass.Enabled = cbbxDept.Enabled = txtId.Enabled = btnAdd.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsStudent.Position;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsScore.Count > 0)
            {
                MessageBox.Show("Sinh viên đã tham gia làm bài kiểm tra\n Không thể xoá sinh viên này!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xoá sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                string str = "DELETE FROM dbo.SINHVIEN WHERE MASV= '" + txtId.Text + "'";
                if (Program.execNonQuery(str) > 0)
                {
                    this.tableAdapterStudent.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterStudent.Fill(this.dS.SP_StudentTable, cbbxClass.SelectedValue.ToString());
                }

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tableAdapterStudent.Connection.ConnectionString = Program.connstr;
                this.tableAdapterStudent.Fill(this.dS.SP_StudentTable, cbbxClass.SelectedValue.ToString());
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
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            }
        }
    }
}
