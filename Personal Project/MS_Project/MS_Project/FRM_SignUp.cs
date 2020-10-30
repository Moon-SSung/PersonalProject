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

namespace MS_Project
{
    public partial class FRM_SignUp : Form
    {
        private bool yn = false;

        public FRM_SignUp()
        {
            InitializeComponent();
        }

        private void FRM_SignUp_Load(object sender, EventArgs e)
        {
            ClearTextControl();
        }

        #region 아이디 중복확인 버튼
        private void Btn_CheckID_Click(object sender, EventArgs e)
        {
            if(Tbx_ID.Text == "")
            {
                MessageBox.Show(this, "아이디를 입력해주세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tbx_ID.Text = "";
                Tbx_ID.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(DBConnect.GetConString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT User_ID FROM TB_User ";
               
                SqlDataReader reader = cmd.ExecuteReader();
               
                if (reader.HasRows == true)
                {
                    reader.Read();

                    if (reader[0].ToString() == Tbx_ID.Text)
                    {
                        MessageBox.Show(this, "이미 아이디가 있습니다.");
                        Tbx_ID.Text = "";
                        Tbx_ID.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "가능한 아이디");
                        Tbx_PW.Focus();
                        yn = true;
                        return;
                    }
                }
            }
        }
        #endregion

        private void Btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx_ID.Text) ||
                string.IsNullOrEmpty(Tbx_PW.Text) ||
                string.IsNullOrEmpty(Tbx_Name.Text) ||
                string.IsNullOrEmpty(Tbx_Addr.Text) ||
                string.IsNullOrEmpty(Tbx_Mobile.Text)
                )
            {          
                    MessageBox.Show(this, "입력되지 않은 값이 있습니다!\n빈칸을 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;     
            }
            if (yn==false)//중복확인 N55
            {
                MessageBox.Show(this, "아이디 중복확인을 해주세요..", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            yn = false;
            SignUpProcess();            
        }

        private void SignUpProcess()
        {
            MessageBox.Show(this, "SignProcessTest");

            string sqlQuery = "";

            using (SqlConnection conn = new SqlConnection(DBConnect.GetConString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (DBConnect.sqlMode == "INSERT")
                {
                    //MessageBox.Show("TEST");
                    sqlQuery = "INSERT INTO TB_User " +
                               " (User_ID, User_PW, User_Name, User_Address, User_Mobile) " +
                               " VALUES " +
                               " (@User_ID, @User_PW, @User_Name, @User_Address, @User_Mobile) ";
                }

                cmd.CommandText = sqlQuery;

                //////////////////////////////////////////////////////////////// 아이디
                SqlParameter paramID = new SqlParameter("@User_ID", SqlDbType.VarChar, 50);
                paramID.Value = Tbx_ID.Text;
                cmd.Parameters.Add(paramID);

                //////////////////////////////////////////////////////////////// 비밀번호
                SqlParameter paramPW = new SqlParameter("@User_PW", SqlDbType.VarChar, 50);
                paramPW.Value = Tbx_PW.Text;
                cmd.Parameters.Add(paramPW);

                ///////////////////////////////////////////////////////////////// 이름
                SqlParameter paramName = new SqlParameter("@User_Name", SqlDbType.VarChar, 10);
                paramName.Value = Tbx_Name.Text;
                cmd.Parameters.Add(paramName);

                ////////////////////////////////////////////////////////////////// 주소
                SqlParameter paramAddr = new SqlParameter("@User_Address", SqlDbType.VarChar, 100);
                paramAddr.Value = Tbx_Addr.Text;
                cmd.Parameters.Add(paramAddr);

                ////////////////////////////////////////////////////////////////// 전화번호
                SqlParameter paramMobile = new SqlParameter("@User_Mobile", SqlDbType.VarChar, 20);
                paramMobile.Value = Tbx_Mobile.Text;
                cmd.Parameters.Add(paramMobile);
                
                cmd.ExecuteNonQuery();
            }
                ClearTextControl();
        }

        #region 입력값 초기화
        private void ClearTextControl()
        {
            Tbx_ID.Text = Tbx_PW.Text = Tbx_Name.Text = Tbx_Addr.Text = Tbx_Mobile.Text = "";
            Tbx_ID.Focus();
        }
        #endregion

        #region 프로그램 종료 버튼 처리
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("종료하시겠습니까?","종료 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    this.DialogResult = DialogResult.Abort;                
            //    Application.Exit();
            //}

            this.DialogResult = DialogResult.Abort;
            Application.Exit();
        }
        #endregion

        #region Form 마우스 이동
        bool TagMove;
        int MValX, MValY;
        private void Nav_Top_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }
        private void Nav_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }


        private void Nav_Top_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }
        #endregion
    }
}
