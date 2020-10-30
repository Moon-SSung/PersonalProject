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

        FRM_SignUp signupForm = new FRM_SignUp();

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            Reset();
            //Tbx_ID.Focus();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx_ID.Text) || string.IsNullOrEmpty(Tbx_PW.Text))
            {
                MessageBox.Show("ID와 PW를 입력해주세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoginProcess();
            
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            DBConnect.sqlMode = "INSERT";
            signupForm.ShowDialog();
        }

        #region 로그인할 때, ID와 PW를 체킹한다.
        private void LoginProcess()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnect.GetConString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT User_PW FROM TB_User " +
                                      " WHERE User_ID = @User_ID ";

                    //User_ID
                    SqlParameter paramID = new SqlParameter("@User_ID", SqlDbType.VarChar, 50);
                    paramID.Value = Tbx_ID.Text;
                    cmd.Parameters.Add(paramID);

                    ////User_PW
                    //SqlParameter parmPW = new SqlParameter("@User_PW", SqlDbType.VarChar, 50);
                    //parmPW.Value = Tbx_PW.Text;
                    //cmd.Parameters.Add(parmPW);

                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.HasRows == true)
                    {
                        reader.Read();
                        
                        if(reader[0].ToString() == Tbx_PW.Text)
                        {
                            MessageBox.Show(this, "접속성공", "로그인");
                            Reset();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(this, "비밀번호 틀림", "로그인 실패");
                            return;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("없는 ID 회원가입?", "ID 없음", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            signupForm.ShowDialog();
                            return;
                        }
                        else
                        {
                            return;
                        }                   
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"ERROR : {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            if(Tbx_ID.Text != "" || Tbx_PW.Text != "")
            {
                Tbx_ID.Text = Tbx_PW.Text = "";
                Tbx_ID.Focus();
            }
            else
            {
                Tbx_ID.Focus();
                return;
            }
        }
        #endregion

        #region 엔터 키 작동
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
