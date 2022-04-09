using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static TRACNGHIEM_CSDLPT.SystemConstant;

namespace TRACNGHIEM_CSDLPT.views
{
    public partial class frmQuestion : Form
    {
        ActionType actionType = ActionType.READING;
        char lastChar;
        int indexTbl = 0;
        public frmQuestion()
        {
            InitializeComponent();
        }


        private void frmQuestion_Load(object sender, EventArgs e)
        {
            this.tableAdapterSubj.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSubj.Fill(this.dS.MONHOC);
            changeEnabledStatus();
        }

        private void tENMHComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bdsSubj.Count > 0)
                try
                {
                    this.tableAdapterQues.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterQues.Fill(this.dS.SP_QuestionTable, cbbxSubj.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
        }
        private void changeEnabledStatus()
        {
            btnSave.Enabled = groupInfo.Enabled = btnUndo.Enabled = btnRedo.Enabled = !btnAdd.Enabled;
            txtQuesId.Enabled = lblTeacherId.Enabled = lblTeacherName.Enabled = gcQues.Enabled = btnAdd.Enabled;
            if (!btnAdd.Enabled)
                btnEdit.Enabled = btnDelete.Enabled = btnAdd.Enabled;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionType = ActionType.ADDING;
            btnAdd.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsQues.Position;
            bdsQues.AddNew();
            Program.myReader = Program.ExecSqlDataReader("SELECT MAX(CAUHOI) FROM dbo.BODE");
            if (Program.myReader == null) return;
            Program.myReader.Read();
            txtQuesId.Text = (Program.myReader.GetInt32(0)+1).ToString();
            Program.myReader.Close();


        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtContent.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nội dung câu hỏi không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtContent.Focus();
                return;
            }
            if (txtA.Text.Trim().Length == 0 || txtB.Text.Trim().Length == 0 || txtC.Text.Trim().Length == 0 || txtD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Các lựa chọn không được rỗng!", "Thông báo lỗi", MessageBoxButtons.OK);
                if (txtA.Text.Trim().Length == 0) txtA.Focus();
                else if (txtB.Text.Trim().Length == 0) txtB.Focus();
                else if (txtC.Text.Trim().Length == 0) txtC.Focus();
                else txtD.Focus();
                return;
            }
            if (checkDupdlicateOption(txtA.Text.Trim(), txtB.Text.Trim(), txtC.Text.Trim(), txtD.Text.Trim()))
            {
                MessageBox.Show("Các lựa chọn không được trùng nhau!", "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }
            if (actionType == ActionType.ADDING)
            {
                try
                {
                    if (addQues() > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        this.tableAdapterQues.Connection.ConnectionString = Program.connstr;
                        this.tableAdapterQues.Fill(this.dS.SP_QuestionTable, cbbxSubj.SelectedValue.ToString());

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
                    MessageBox.Show("Lỗi thêm câu hỏi\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                /*if (editQues() > 0)
                {
                    this.tableAdapterStudent.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterStudent.Fill(this.dS.SP_StudentTable, cbbxClass.SelectedValue.ToString());
                }*/
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

        /*private int editQues()
        {
            
        }*/

        private bool checkDupdlicateOption(string v1, string v2, string v3, string v4)
        {
            string[] array = { v1, v2, v3, v4 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) == 0) return true;
                }
            }
            return false;
        }

        private int addQues()
        {
            String str = "INSERT INTO dbo.BODE " +
                "(CAUHOI, MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) " +
                "VALUES " +
                "("+Convert.ToInt32(txtQuesId.Text)+", '"+ cbbxSubj.SelectedValue.ToString() + "', '"
                + cbbxLevel.SelectedItem.ToString() + "', N'"+ txtContent.Text + "', N'"+ 
                txtA.Text + "', N'"+ txtB.Text + "', N'"+ txtC.Text + "', N'"+ txtD.Text +
                "', '"+cbbxResult.SelectedItem.ToString()+ "', '"+ Program.mId + "')";
            if (Program.execNonQuery(str, "Nội dung câu hỏi đã tồn tại!") > 0) return 1;
            else return -1;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            actionType = ActionType.EDITING;
            cbbxSubj.Enabled = txtQuesId.Enabled = btnAdd.Enabled = false;
            changeEnabledStatus();
            indexTbl = bdsQues.Position;
        }

        /*private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                if (txtA.Text.LastOrDefault() == ' ')
                    txtA.Text =txtA.Text.TrimEnd();
        }*/

        private void txtA_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.mId!= lblTeacherId.Text.TrimEnd())
            {
                MessageBox.Show("Bạn không được xoá câu hỏi của giảng viên khác!");
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xoá câu hỏi này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                string str = "DELETE FROM dbo.BODE WHERE CAUHOI= '" + txtQuesId.Text + "'";
                if (Program.execNonQuery(str) > 0)
                {
                    this.tableAdapterQues.Connection.ConnectionString = Program.connstr;
                    this.tableAdapterQues.Fill(this.dS.SP_QuestionTable, cbbxSubj.SelectedValue.ToString());
                }

            }
        }
    }
}
