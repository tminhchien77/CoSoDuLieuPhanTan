using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TRACNGHIEM_CSDLPT.views;

namespace TRACNGHIEM_CSDLPT
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void initFrmMain()
        {


            userMa.Text = "MaID :" + Program.mId;
            userName.Text = "Họ tên :" + Program.mName;
            userGroup.Text = "Nhóm :" + Program.mGroup;

            btnLogin.Enabled = false;
            btnLogout.Enabled = true;

            if (Program.mGroup == "GIANGVIEN")
            {
                /*initRibGroup(true);
                Program.frmMain.ribManager.Visible = false;
                Program.frmMain.ribReport.Visible = false;
                Program.frmMain.ribStudent.Visible = false;*/
                ribTeacher.Visible = true;


            }
            else if (Program.mGroup == "SINHVIEN")
            {
                ribSchedule.Visible = true;
            }
            else if (Program.mGroup == "TRUONG")
            {
                /*initRibGroup(true);*/
                /*btnTry.Enabled = false;
                ribStudent.Visible = false;*/
                ribReport.Visible = true;
                ribManager.Visible = true;
            }
            else if (Program.mGroup == "COSO")
            {
                /*initRibGroup(true);*/
                ribReport.Visible = true;
                ribManager.Visible = true;
            }
            ribbonControl.Minimized = true;

        }



        public void initRibGroup(Boolean isEnable)
        {
            ribbonGroupThanhVien.Enabled = isEnable;
            ribbonGVGroup.Enabled = isEnable;
            ribbonBaoCaoGroup.Enabled = isEnable;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        //không dùng
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        ///
        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmLogin));
            if (frm != null) frm.Activate();
            else
            {
               FrmLogin f = new FrmLogin();
                f.Show();
                this.Close();
            }
        }
        /*public void initRibGroup(Boolean isEnable)
        {
            ribbonToChucGroup.Enabled = isEnable;
            ribbonSVGroup.Enabled = isEnable;
            ribbonBaoCaoGroup.Enabled = isEnable;
            ribbonToChucGroup.Enabled = isEnable;
        }*/

        public void initRib(Boolean isVisible)
        {
            ribTeacher.Visible = isVisible;
            ribManager.Visible = isVisible;
            ribReport.Visible = isVisible;
        }


        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;

            userMa.Text = "MaID";
            userName.Text = "Họ tên";
            userGroup.Text = "Nhóm";
            initRib(true);
            initRibGroup(false);

            foreach (Form form in this.MdiChildren)
            {
                this.Close();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            Program.frmMain.Close();
        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDept));
            if (frm != null) frm.Activate();
            else
            {
                frmDept f = new frmDept();
                f.MdiParent = this;
                f.Show();
               
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmClass));
            if (frm != null) frm.Activate();
            else
            {
                frmClass f = new frmClass();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmStudent));
            if (frm != null) frm.Activate();
            else
            {
                frmStudent f = new frmStudent();
                f.MdiParent = this;
                f.Show();

            }
        }
        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTeacher));
            if (frm != null) frm.Activate();
            else
            {
                frmTeacher f = new frmTeacher();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmStudent));
            if (frm != null) frm.Activate();
            else
            {
                frmStudent f = new frmStudent();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(views.Teacher.frmRegisTest));
            if (frm != null) frm.Activate();
            else
            {
                views.Teacher.frmRegisTest f = new views.Teacher.frmRegisTest();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnRegisTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(views.Teacher.frmRegisTest));
            if (frm != null) frm.Activate();
            else
            {
                views.Teacher.frmRegisTest f = new views.Teacher.frmRegisTest();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(views.Teacher.frmRegisTest));
            if (frm != null) frm.Activate();
            else
            {
                views.Teacher.frmRegisTest f = new views.Teacher.frmRegisTest();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnSchedule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(views.frmTestSchedule));
            if (frm != null) frm.Activate();
            else
            {
                views.frmTestSchedule f = new views.frmTestSchedule();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnTeacherPermission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(views.frmTeacherPermission));
            if (frm != null) frm.Activate();
            else
            {
                views.frmTeacherPermission f = new views.frmTeacherPermission();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTeacher));
            if (frm != null) frm.Activate();
            else
            {
                frmTeacher f = new frmTeacher();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnQues_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmQuestion));
            if (frm != null) frm.Activate();
            else
            {
                frmQuestion f = new frmQuestion();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmStudent));
            if (frm != null) frm.Activate();
            else
            {
                frmStudent f = new frmStudent();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmClass));
            if (frm != null) frm.Activate();
            else
            {
                frmClass f = new frmClass();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnDept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDept));
            if (frm != null) frm.Activate();
            else
            {
                frmDept f = new frmDept();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPass));
            if (frm != null) frm.Activate();
            else
            {
                frmPass f = new frmPass();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnExamScore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptExamScore));
            if (frm != null) frm.Activate();
            else
            {
                frptExamScore f = new frptExamScore();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void btnExamDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptExamDetail));
            if (frm != null) frm.Activate();
            else
            {
                frptExamDetail f = new frptExamDetail();
                f.MdiParent = this;
                f.Show();

            }
        }
    }
}
