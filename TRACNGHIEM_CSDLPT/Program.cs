using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TRACNGHIEM_CSDLPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher= "Data Source=DESKTOP-R6465LG;Initial Catalog=TN_CSDLPT;Integrated Security=True";
        public static SqlDataReader myReader;
        public static String servername = "";
        //username chứa mã GV
        public static String usernameDB = "";
        public static String usernameServer = "";
        public static String password = "";
        public static int indexBranch = 0;

        public static String database = "TN_CSDLPT";
        public static String remotelogin = "htkn";
        public static String remotepassword = "123";
        
        
        public static String loginFromLogin = "";
        public static String passFromLogin = "";
        public static String mGroup = "";
        public static String mName = "";
        public static String mId = "";


        public static String UPDATE_METHOD = "UPDATE";
        public static String DELETE_METHOD = "DELETE";
        public static String NEW_METHOD = "NEW";
        public static String studentCode = String.Empty;
        public static BindingSource bds_ListBranch = new BindingSource();
        public static FrmMain frmMain;
        public static int ConnectDB()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
                try
                {
                    Program.connstr = "Data Source=" + Program.servername +" ;Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.usernameServer + ";password=" + Program.password;
                    Program.conn.ConnectionString = Program.connstr;
                    Program.conn.Open();
                    return 1;
                }
                catch(Exception e)
                {
                    MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu.\n Bạn xem lại uername và password.\n "+e.Message,"",MessageBoxButtons.OK);
                    return 0;
                }
            
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            try
            {
                da.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
            
            
        }
        public static int execNonQuery(String str, String msg="")
        {
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
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    if (ex.Message.Contains("Error converting data type varchar to int"))
                        MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                    else MessageBox.Show(ex.Message);
                }
                conn.Close();
                return -1;
            }
        }
        [STAThread]
        static void Main()                                                                             
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new FrmLogin());
        }
    }
}
