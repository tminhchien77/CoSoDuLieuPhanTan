using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmTeacherPermission : Form
    {
        public frmTeacherPermission()
        {
            InitializeComponent();
        }


        private void frmTeacherPermission_Load(object sender, EventArgs e)
        {
            this.tblAdapterDept.Connection.ConnectionString = Program.connstr;
            this.tblAdapterDept.Fill(this.dS.KHOA);
            initBranchCombobox();

        }

        private void initBranchCombobox()
        {
            cbbxBranch.DataSource = Program.bds_ListBranch;
            cbbxBranch.DisplayMember = "TENCOSO";
            cbbxBranch.ValueMember = "TENSERVER";
            cbbxBranch.SelectedIndex = Program.indexBranch;
        }

        private void cbbxDept_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bdsDept.Count > 0)
            {
                try
                {
                    this.sP_TeacherPermissionListTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_TeacherPermissionListTableAdapter.Fill(this.dS.SP_TeacherPermissionList, cbbxDept.SelectedValue.ToString(), Program.mGroup);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                /*for(int i=0; i<bdsTeacherPermission.Count; i++)
                {
                    DataRowView r = (DataRowView)bdsTeacherPermission[i];
                    if (r["QUYEN"] != null)
                    {
                         string btn= (string)grvTeacherPermission.GetRowCellValue(i,"BTN");
                        //string x = btn.Text;
                    }
                }
                foreach (DataRowView r in bdsTeacherPermission)
                {
                    if(r["QUYEN"] != null)
                    {
                        
                    }
                }*/
            }
                
                
        }

        private void grvTeacherPermission_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "QUYEN")
            {
                string value = view.GetRowCellValue(e.RowHandle, "QUYEN").ToString();
                if (value.Length == 0)
                    e.RepositoryItem = btnPermission;
                else
                {
                    view.SetRowCellValue(e.RowHandle,"QUYEN", value);
                }
                    
            }
            
        }

        private void btnPermission_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = grvTeacherPermission.GetFocusedDataRow();
            frmTeacherPermissionChild frm  = new frmTeacherPermissionChild();
            frm.id = (string)dr["MAGV"];
            frm.name = (string)dr["HO"]+" "+ (string)dr["TEN"];
            frm.ShowDialog();

        }
    }
}
