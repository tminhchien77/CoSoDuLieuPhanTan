using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TRACNGHIEM_CSDLPT.views
{
    public partial class rptExamScore : DevExpress.XtraReports.UI.XtraReport
    {
        public rptExamScore()
        {
            
        }
        public rptExamScore(string subjId, int times, string classId)
        {
            InitializeComponent();
            this.dsExamScore.Connection.ConnectionString = Program.connstr;
            this.dsExamScore.Queries[0].Parameters[0].Value = subjId;
            this.dsExamScore.Queries[0].Parameters[1].Value = times;
            this.dsExamScore.Queries[0].Parameters[2].Value = classId;
            this.dsExamScore.Fill();

        }

    }
}
