using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TRACNGHIEM_CSDLPT.views
{
    public partial class frmTest : Form
    {
        private DataRow drInfor;
        private DataTable dtExam;
        private DataTable dtAns;
        private int _curQues;
        private Button btnCurQues;

        //#1
        public event System.EventHandler CurQuesChanged;

        //#2
        protected virtual void OnCurQuesChanged()
        {
            if (CurQuesChanged != null) CurQuesChanged(this, EventArgs.Empty);
        }

        public int curQues
        {
            get
            {
                return _curQues;
            }

            set
            {
                //#3
                _curQues = value;
                OnCurQuesChanged();
            }
        }
        System.Timers.Timer timer;
        int _m, s;
        //#1
        /*public event System.EventHandler MinuteChanged;

        //#2
        protected virtual void OnMinuteChanged()
        {
            if (MinuteChanged != null) MinuteChanged(this, EventArgs.Empty);
        }*/

        public int m
        {
            get
            {
                return _m;
            }

            set
            {
                //#3
                _m = value;
                if (_m == 0 && s==0)
                {
                    if (dtExam == null) startExam();
                    else endExam();
                }
            }
        }

        private void endExam()
        {
            /*string a = drInfor["MAMH"].ToString();
            string b = Program.mId;
            int i = Convert.ToInt32(drInfor["LAN"]);*/
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.SqlDbType = SqlDbType.Structured;
            sqlParameter.TypeName = "dbo.AnswerType";
            sqlParameter.ParameterName = "@Ans";
            sqlParameter.Value = dtAns;
            string str = "EXECUTE SP_Score ";
            //'" + drInfor["MAMH"].ToString() + "', '" + Program.mId + "', " + Convert.ToInt32(drInfor["LAN"]) + ", " + dtAns;


            Program.ConnectDB();

            SqlCommand command = new SqlCommand("SP_Score ", Program.conn);
            command.Parameters.Clear();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@subjId", drInfor["MAMH"].ToString());
            command.Parameters.AddWithValue("@studentId", Program.mId);
            command.Parameters.AddWithValue("@times", Convert.ToInt32(drInfor["LAN"]));
            command.Parameters.Add(sqlParameter);
            try
            {
                Program.myReader = command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return;
            }

            if (Program.myReader == null) return;
            Program.myReader.Read();
            groupContentQuest.Visible=groupOptions.Visible=false;
            lbl.Visible=lblScore.Visible=true;
            lblScore.Text= Program.myReader.GetDouble(0).ToString();
            Program.myReader.Close();
        }

        private void startExam()
        {
            String str = "EXECUTE SP_GetExam '" + Program.mId + "','" + drInfor["MAMH"].ToString() + "', '" + drInfor["MALOP"].ToString() + "', " + Convert.ToInt32(drInfor["LAN"]);
            dtExam = Program.ExecSqlDataTable(str);
            if (dtExam == null) return;
            initFlpnlQues();
            initDataTableAnswers(dtExam.Rows.Count);
            btnSubmit.Enabled = true;
            exitBtn.Enabled = false;
            timer.Stop();
            m = Convert.ToInt32(drInfor["THOIGIAN"]);
            s = 0;
            
            timer.Start();
        }

        public delegate void SendInfor(DataRow dataRow);
        /*public SendImgList Sender;*/
        public SendInfor Sender;
        private void GetInfo(DataRow dataRow)
        {
            drInfor = dataRow;
            lblSubjId.Text = drInfor["MAMH"].ToString();
            lblSubjName.Text = drInfor["TENMH"].ToString();
            lblClass.Text = drInfor["MALOP"].ToString()+" - "+ drInfor["TENLOP"].ToString();
            lblTeacher.Text = drInfor["GV"].ToString();
            lblLevel.Text = drInfor["TRINHDO"].ToString();
            lblTimes.Text = drInfor["LAN"].ToString();
            lblExamDate.Text = drInfor["NGAYTHI"].ToString();
            lblNumQues.Text = drInfor["SOCAUTHI"].ToString();
            lblExamTime.Text = drInfor["THOIGIAN"].ToString();
        }
        public frmTest()
        {
            InitializeComponent();
            Sender = new SendInfor(GetInfo);
            CurQuesChanged += delegate (object sender, EventArgs arg)
            {
                groupContentQuest.Text = btnCurQues.Text;
                if(dtAns.Rows[curQues]["ans"] is DBNull)
                {
                    aOption.Checked = false;
                    bOption.Checked = false;
                    cOption.Checked = false;
                    dOption.Checked = false;
                }
                else
                {
                    char ans = (char)dtAns.Rows[curQues]["ans"];
                    switch (ans)
                    {
                        case 'A':
                            aOption.Checked = true;
                            break;
                        case 'B':
                            bOption.Checked = true;
                            break;
                        case 'C':
                            cOption.Checked = true;
                            break;
                        case 'D':
                            dOption.Checked = true;
                            break;
                    };
                }
                
                
            };
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            //DateTime lastTime = ((DateTime)drInfor["THOIGIAN"]).AddMinutes(5);
            
            DateTime lastTime = Convert.ToDateTime(drInfor["NGAYTHI"].ToString()).AddMinutes(5);
            m = (lastTime - DateTime.Now).Minutes;
            s = (lastTime - DateTime.Now).Seconds;
            lblTimer.Text = $"{lastTime - DateTime.Now:mm\\:ss}";
            timer =new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            timer.Start(); 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startExam();
        }

        private void initDataTableAnswers(int count)
        {
            dtAns = new DataTable();
            dtAns.Columns.Add("quesId", typeof(int));
            dtAns.Columns.Add("ques", typeof(int));
            dtAns.Columns.Add("ans", typeof(char));
            for(int i = 0; i < count; i++)
            {
                dtAns.Rows.Add(dtExam.Rows[i]["MACAUHOI"], i, DBNull.Value);
            }
        }

        private void initFlpnlQues()
        {
            flPnlQues.Controls.Clear();
            for(int i = 0; i < dtExam.Rows.Count; )
            {
                Button btn = new Button();
                
                btn.Tag = i;
                btn.Name = "btnQues"+(++i);
                btn.Text = "Câu " + i;
                btn.Click+=new EventHandler(btn_Click);
                flPnlQues.Controls.Add(btn);
            }
            groupContentQuest.Visible = true;
            groupOptions.Visible = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            btnCurQues = button;
            curQues = (int)button.Tag;
            loadQues(curQues);
        }

        private void loadQues(int numQues)
        {
            DataRow r = dtExam.Rows[numQues];
            txtContentQues.Text =r["NOIDUNG"].ToString();
            aOption.Text= r["A"].ToString();
            bOption.Text = r["B"].ToString();
            cOption.Text = r["C"].ToString();
            dOption.Text = r["D"].ToString();
        }

        private void aOption_CheckedChanged(object sender, EventArgs e)
        {
            if (aOption.Checked)
            {
                if (dtAns.Rows[curQues]["ans"] is DBNull)
                    btnCurQues.BackColor = Color.FromArgb(255, 255, 128);
                dtAns.Rows[curQues]["ans"] = 'A';
            }
                
        }

        private void bOption_CheckedChanged(object sender, EventArgs e)
        {
            if (bOption.Checked)
            {
                if (dtAns.Rows[curQues]["ans"] is DBNull)
                    btnCurQues.BackColor = Color.FromArgb(255, 255, 128);
                dtAns.Rows[curQues]["ans"] = 'B';
            }
        }

        private void cOption_CheckedChanged(object sender, EventArgs e)
        {
            if (cOption.Checked)
            {
                if (dtAns.Rows[curQues]["ans"] is DBNull)
                    btnCurQues.BackColor = Color.FromArgb(255, 255, 128);
                dtAns.Rows[curQues]["ans"] = 'C';
            }
        }

        private void dOption_CheckedChanged(object sender, EventArgs e)
        {
            if (dOption.Checked)
            {
                if (dtAns.Rows[curQues]["ans"] is DBNull)
                    btnCurQues.BackColor = Color.FromArgb(255, 255, 128);
                dtAns.Rows[curQues]["ans"] = 'D';
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            endExam();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s == -1)
                {
                    s = 59;
                    m -= 1;
                }
                lblTimer.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
    }
}
