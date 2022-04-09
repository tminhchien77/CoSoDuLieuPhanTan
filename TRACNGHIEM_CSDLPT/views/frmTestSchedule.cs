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
    public partial class frmTestSchedule : Form
    {
        public frmTestSchedule()
        {
            InitializeComponent();
        }

        private void frmTestSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                this.sP_TestScheduleTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_TestScheduleTableAdapter.Fill(this.dS.SP_TestSchedule, Program.mId);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnStartExam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmTest frmTest = new frmTest();
            frmTest.Activate();
            frmTest.Sender(gridViewTestSchedule.GetFocusedDataRow());
            frmTest.Show();
            this.Hide();
        }

        /*private void gridViewTestSchedule_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "BTN")
            {
                DateTime time = Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, "NGAYTHI").ToString());
                if (true)
                    e.RepositoryItem = btnStartExam;

            }
        }*/
    }
}
