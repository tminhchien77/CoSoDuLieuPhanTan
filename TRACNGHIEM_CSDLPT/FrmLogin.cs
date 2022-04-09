using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM_CSDLPT
{
    public partial class FrmLogin : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public FrmLogin()
        {
            InitializeComponent();
            initTextBox(true);
        }
        private void initTextBox(Boolean isEnable)
        {
            this.txtUsername.Enabled = isEnable;
            this.txtPass.Enabled = isEnable;
        }
        private void txtUsername_Load(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" )
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu đăng nhập không được rỗng.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }    
            try
            {
                if (radioTeacher.Checked == true)
                {
                    Program.servername = comboboxBranches.SelectedValue.ToString();
                    Program.loginFromLogin = Program.usernameServer = txtUsername.Text;
                    Program.passFromLogin = Program.password = txtPass.Text;
                    
                }
                else if (radioStudent.Checked == true)
                {
                    if (ConnectPublisher() == 0) return;
                    if (checkLoginStudent() < 0) return;
                    Program.servername = comboboxBranches.SelectedValue.ToString();
                    Program.usernameServer = SystemConstant.usernameServerStudent;
                    Program.password = SystemConstant.passServerStudent;
                }
                if (Program.ConnectDB() == 0) return;

                Program.indexBranch = comboboxBranches.SelectedIndex;
                /*Program.loginFromLogin = Program.mlogin;
                Program.passFromLogin = Program.password;*/
                String strLenh = "";
                if(radioTeacher.Checked==true)
                {
                    strLenh = "exec SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.usernameServer+ "'";
                }
                else if (radioStudent.Checked == true)
                {

                    strLenh = "exec SP_Lay_Thong_Tin_SV_Tu_Login '" + txtUsername.Text + "'";
                }
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                if (radioTeacher.Checked == true)
                {
                    Program.usernameDB = Program.myReader.GetString(0);
                }
                else if (radioStudent.Checked == true)
                {

                    Program.usernameDB = SystemConstant.usernameServerStudent;
                }
                
                if(Convert.IsDBNull(Program.usernameDB))
                {
                    MessageBox.Show("Login bạn nhập bị sai không có quyền truy cập dữ liệu\n Bạn xem lại Username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mId = Program.myReader.GetString(0);
                Program.mName = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                Program.frmMain = new FrmMain();
                Program.frmMain.initFrmMain();
                Hide();

                Program.frmMain.ShowDialog();
                txtUsername.Text = "";
                txtPass.Text = "";
                Show();

            }
              catch
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  

        }
        private int checkLoginStudent()
        {
            DataRowView drv = (DataRowView)comboboxBranches.SelectedItem;
            string branchId = (string)drv.Row["TENCOSO"];
            String str = "EXEC SP_CheckLoginStudent @BranchId = N'"
                + branchId + "', @USERNAME = '"
                + txtUsername.Text + "', @PASSWORD = N'" + txtPass.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(str, conn_publisher);
            /*SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);*/
            sqlCommand.CommandType = CommandType.Text;
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            try
            {
                sqlCommand.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn_publisher.Close();
                return -1;
            }
            /*da.Fill(dt);
            conn_publisher.Close();
            Program.bds_ListBranch.DataSource = dt;
            comboboxBranches.DataSource = Program.bds_ListBranch;
            comboboxBranches.DisplayMember = "TENCOSO";
            comboboxBranches.ValueMember = "TENSERVER";

            
            SqlCommand sqlCommand = new SqlCommand(str, Program.conn);
            sqlCommand.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlCommand.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return -1;
            }*/
        }
        private int ConnectPublisher()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            { 
                conn_publisher.Close();
            }
            try
            {
                Program.servername = "DESKTOP-R6465LG";
                Program.usernameServer = "sa"; Program.password = "123";
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                   Program.database + ";User ID=" +
                   Program.usernameServer + ";password=" + Program.password;
                conn_publisher.ConnectionString = Program.connstr;
                conn_publisher.Open();
                //MessageBox.Show("kết nối cơ sở dữ liệu gốc thành công." );
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu gốc.\n Bạn xem lại uername và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }

        }

        private void GetBranches(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_ListBranch.DataSource = dt;
            comboboxBranches.DataSource = Program.bds_ListBranch;
            comboboxBranches.DisplayMember = "TENCOSO";
            comboboxBranches.ValueMember = "TENSERVER";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            Program.frmMain.Close();
        }

        private void radioTeacher_CheckedChanged(object sender, EventArgs e)
        {
            initTextBox(true);
        }

        private void radioStudent_CheckedChanged(object sender, EventArgs e)
        {
            initTextBox(true);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (ConnectPublisher() == 0) return;
            radioBtnGroup_Load();
            GetBranches("SELECT * FROM Get_Subscribes");
            comboboxBranches.SelectedIndex = 0;

        }
        

        private void comboboxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = comboboxBranches.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioBtnGroup_Load()
        {
            radioStudent.Tag = "SV";
            radioTeacher.Tag = "GV";
        }
    }
}
