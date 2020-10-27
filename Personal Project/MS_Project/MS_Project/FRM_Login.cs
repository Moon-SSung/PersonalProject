using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Project
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            Tbx_ID.Focus();

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Tbx_ID.Text) || String.IsNullOrEmpty(Tbx_PW.Text))
            {
                MessageBox.Show("ID와 PW를 입력해주세요.","로그인 실패");
                return;
            }
            LoginProcess();
        }

        private void LoginProcess()
        {
            string strUserID = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnect.GetConString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT User_ID, User_PW FROM TB_USER " +
                                      " WHERE User_ID = @User_ID " + 
                                      " AND User_PW = @User_PW ";

                    //User_ID
                    SqlParameter parmID = new SqlParameter("@User_ID", SqlDbType.VarChar, 50);
                    parmID.Value = Tbx_ID.Text;
                    cmd.Parameters.Add(parmID);
                    //User_PW
                    SqlParameter parmPW = new SqlParameter("@User_PW", SqlDbType.VarChar, 50);
                    parmPW.Value = Tbx_PW.Text;
                    cmd.Parameters.Add(parmPW);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    strUserID = ( reader["User_ID"] != null ? reader["User_ID"].ToString() : "" ); 

                    if(strUserID != "")
                    {
                        MessageBox.Show(this, "접속성공", "로그인");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this,"접속실패", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(this, $"ERROR : {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Tbx_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Tbx_PW.Focus();
            }
        }

        private void Tbx_PW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginProcess();
            }
        }
    }
}
