using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TRACNGHIEM_CSDLPT.views
{
    public partial class rptExamDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public rptExamDetail()
        {
            InitializeComponent();
        }
        public rptExamDetail(string studentId, string subjId, int times)
        {
            InitializeComponent();
            this.dsExamDetail.Connection.ConnectionString = Program.connstr;
            this.dsExamDetail.Queries[0].Parameters[0].Value = studentId;
            this.dsExamDetail.Queries[0].Parameters[1].Value = subjId;
            this.dsExamDetail.Queries[0].Parameters[2].Value = times;
            this.dsExamDetail.Fill();

        }
    }
}
