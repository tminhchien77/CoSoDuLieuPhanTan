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

namespace TRACNGHIEM_CSDLPT.views
{
    public partial class frmSubject : Form
    {

        int index = 0;
        String mMaMH = "";
        String mTenMH = "";

        private static SqlDataReader myReader;
        private SqlConnection conn_publisher = new SqlConnection();
        public String method = "";
        // Stack Undo
        public Stack st = new Stack();
        public ClassDto dtoUndo = new ClassDto("", "", "");
        public bool isUndo = false;



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
        public frmSubject()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPTDataSet);

        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            TN_CSDLPTDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.BODE' table. You can move, or remove it, as needed.
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.TN_CSDLPTDataSet.BANGDIEM);
            setCurrentRole();
        }
        public void setCurrentRole()
        {
            if (Program.mGroup == "TRUONG")
            {
               
            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                btnGhi.Enabled = btnCancel.Enabled = false;

            }
        }
        public void updateUIUndo()
        {
            if (st.Count > 0)
            {
                btnUndo.Enabled = true;
            }
            else
            {
                btnUndo.Enabled = false;
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsMonHoc.Position;
            bdsMonHoc.AddNew();

            groupThongTin.Enabled = true;
            txtMaMon.Enabled = txtTenMon.Enabled = true;
            
            method = Program.NEW_METHOD;

            btnCancel.Enabled = btnGhi.Enabled = true;
            btnRefresh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            txtMaMon.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsMonHoc.Position;
            groupThongTin.Enabled = true;
            txtMaMon.Enabled = false;

            btnCancel.Enabled = btnGhi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsMonHoc.Position;
            mMaMH = ((DataRowView)bdsMonHoc[index])["MAMH"].ToString();
            mTenMH = ((DataRowView)bdsMonHoc[index])["TENMH"].ToString();

            if (bdsBoDe.Count > 0 || bdsBangDiem.Count > 0 || bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xoá môn " + mTenMH + " .\n Môn học này đã có dữ liệu liên quan! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xoá môn  " + mTenMH + " này?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdsMonHoc.RemoveCurrent();
                    this.MONHOCTableAdapter.Update(this.TN_CSDLPTDataSet.MONHOC);
                    if (bdsMonHoc.Count == 0)
                    {
                        btnCancel.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá không thành công. Xin thử lại!\n" + ex.Message, "",
                       MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", mMaMH);
                    return;
                }
            }
            btnCancel.Enabled = btnGhi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtMaMon.Text.Length == 0 || txtTenMon.Text.Length == 0)
            {
                MessageBox.Show("Mã và tên môn học không thể trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                try
                {
                    this.Validate();
                    bdsMonHoc.EndEdit();
                    bdsMonHoc.ResetCurrentItem();
                    this.MONHOCTableAdapter.Update(this.TN_CSDLPTDataSet.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update môn học không thành công! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            groupThongTin.Enabled = false;
            
            btnCancel.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupThongTin.Enabled = false;          
            bdsMonHoc.MoveFirst();
            this.MONHOCTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            btnCancel.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupThongTin.Enabled = false;         
            bdsMonHoc.CancelEdit();

            btnCancel.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
        }
    }
}
