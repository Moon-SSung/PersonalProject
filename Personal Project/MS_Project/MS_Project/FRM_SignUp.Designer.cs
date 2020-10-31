namespace MS_Project
{
    partial class FRM_SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Nav_Top = new System.Windows.Forms.Panel();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Btn_SignUp = new System.Windows.Forms.Button();
            this.Tbx_ID = new System.Windows.Forms.TextBox();
            this.Lbl_PW = new System.Windows.Forms.Label();
            this.Tbx_PW = new System.Windows.Forms.TextBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Tbx_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Addr = new System.Windows.Forms.Label();
            this.Tbx_Addr = new System.Windows.Forms.TextBox();
            this.Lbl_Mobile = new System.Windows.Forms.Label();
            this.Tbx_Mobile = new System.Windows.Forms.TextBox();
            this.Btn_Cancle = new System.Windows.Forms.Button();
            this.Btn_CheckID = new System.Windows.Forms.Button();
            this.Nav_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("굴림", 30F);
            this.Lbl_Title.Location = new System.Drawing.Point(253, 78);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(222, 50);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "회원가입";
            // 
            // Nav_Top
            // 
            this.Nav_Top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nav_Top.Controls.Add(this.Btn_Close);
            this.Nav_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nav_Top.Location = new System.Drawing.Point(0, 0);
            this.Nav_Top.Name = "Nav_Top";
            this.Nav_Top.Size = new System.Drawing.Size(740, 40);
            this.Nav_Top.TabIndex = 9;
            this.Nav_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseDown);
            this.Nav_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseMove);
            this.Nav_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseUp);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.Location = new System.Drawing.Point(705, 5);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 9;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("굴림", 15F);
            this.Lbl_ID.Location = new System.Drawing.Point(82, 170);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(87, 25);
            this.Lbl_ID.TabIndex = 2;
            this.Lbl_ID.Text = "아이디";
            // 
            // Btn_SignUp
            // 
            this.Btn_SignUp.Location = new System.Drawing.Point(117, 448);
            this.Btn_SignUp.Name = "Btn_SignUp";
            this.Btn_SignUp.Size = new System.Drawing.Size(245, 79);
            this.Btn_SignUp.TabIndex = 7;
            this.Btn_SignUp.Text = "회원가입";
            this.Btn_SignUp.UseVisualStyleBackColor = true;
            this.Btn_SignUp.Click += new System.EventHandler(this.Btn_SignUp_Click);
            // 
            // Tbx_ID
            // 
            this.Tbx_ID.Font = new System.Drawing.Font("굴림", 15F);
            this.Tbx_ID.Location = new System.Drawing.Point(213, 167);
            this.Tbx_ID.Name = "Tbx_ID";
            this.Tbx_ID.Size = new System.Drawing.Size(275, 36);
            this.Tbx_ID.TabIndex = 1;
            this.Tbx_ID.TextChanged += new System.EventHandler(this.Tbx_ID_TextChanged);
            // 
            // Lbl_PW
            // 
            this.Lbl_PW.AutoSize = true;
            this.Lbl_PW.Font = new System.Drawing.Font("굴림", 15F);
            this.Lbl_PW.Location = new System.Drawing.Point(82, 224);
            this.Lbl_PW.Name = "Lbl_PW";
            this.Lbl_PW.Size = new System.Drawing.Size(112, 25);
            this.Lbl_PW.TabIndex = 2;
            this.Lbl_PW.Text = "비밀번호";
            // 
            // Tbx_PW
            // 
            this.Tbx_PW.Font = new System.Drawing.Font("굴림", 15F);
            this.Tbx_PW.Location = new System.Drawing.Point(213, 221);
            this.Tbx_PW.Name = "Tbx_PW";
            this.Tbx_PW.Size = new System.Drawing.Size(275, 36);
            this.Tbx_PW.TabIndex = 3;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("굴림", 15F);
            this.Lbl_Name.Location = new System.Drawing.Point(82, 278);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(62, 25);
            this.Lbl_Name.TabIndex = 2;
            this.Lbl_Name.Text = "이름";
            // 
            // Tbx_Name
            // 
            this.Tbx_Name.Font = new System.Drawing.Font("굴림", 15F);
            this.Tbx_Name.Location = new System.Drawing.Point(213, 275);
            this.Tbx_Name.Name = "Tbx_Name";
            this.Tbx_Name.Size = new System.Drawing.Size(275, 36);
            this.Tbx_Name.TabIndex = 4;
            // 
            // Lbl_Addr
            // 
            this.Lbl_Addr.AutoSize = true;
            this.Lbl_Addr.Font = new System.Drawing.Font("굴림", 15F);
            this.Lbl_Addr.Location = new System.Drawing.Point(82, 332);
            this.Lbl_Addr.Name = "Lbl_Addr";
            this.Lbl_Addr.Size = new System.Drawing.Size(62, 25);
            this.Lbl_Addr.TabIndex = 2;
            this.Lbl_Addr.Text = "주소";
            // 
            // Tbx_Addr
            // 
            this.Tbx_Addr.Font = new System.Drawing.Font("굴림", 15F);
            this.Tbx_Addr.Location = new System.Drawing.Point(213, 329);
            this.Tbx_Addr.Name = "Tbx_Addr";
            this.Tbx_Addr.Size = new System.Drawing.Size(275, 36);
            this.Tbx_Addr.TabIndex = 5;
            // 
            // Lbl_Mobile
            // 
            this.Lbl_Mobile.AutoSize = true;
            this.Lbl_Mobile.Font = new System.Drawing.Font("굴림", 15F);
            this.Lbl_Mobile.Location = new System.Drawing.Point(82, 386);
            this.Lbl_Mobile.Name = "Lbl_Mobile";
            this.Lbl_Mobile.Size = new System.Drawing.Size(112, 25);
            this.Lbl_Mobile.TabIndex = 2;
            this.Lbl_Mobile.Text = "전화번호";
            // 
            // Tbx_Mobile
            // 
            this.Tbx_Mobile.Font = new System.Drawing.Font("굴림", 15F);
            this.Tbx_Mobile.Location = new System.Drawing.Point(213, 383);
            this.Tbx_Mobile.Name = "Tbx_Mobile";
            this.Tbx_Mobile.Size = new System.Drawing.Size(275, 36);
            this.Tbx_Mobile.TabIndex = 6;
            // 
            // Btn_Cancle
            // 
            this.Btn_Cancle.Location = new System.Drawing.Point(368, 448);
            this.Btn_Cancle.Name = "Btn_Cancle";
            this.Btn_Cancle.Size = new System.Drawing.Size(245, 79);
            this.Btn_Cancle.TabIndex = 8;
            this.Btn_Cancle.Text = "취소";
            this.Btn_Cancle.UseVisualStyleBackColor = true;
            this.Btn_Cancle.Click += new System.EventHandler(this.Btn_Cancle_Click);
            // 
            // Btn_CheckID
            // 
            this.Btn_CheckID.Location = new System.Drawing.Point(514, 167);
            this.Btn_CheckID.Name = "Btn_CheckID";
            this.Btn_CheckID.Size = new System.Drawing.Size(99, 36);
            this.Btn_CheckID.TabIndex = 2;
            this.Btn_CheckID.Text = "중복확인";
            this.Btn_CheckID.UseVisualStyleBackColor = true;
            this.Btn_CheckID.Click += new System.EventHandler(this.Btn_CheckID_Click);
            // 
            // FRM_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 550);
            this.Controls.Add(this.Btn_CheckID);
            this.Controls.Add(this.Tbx_Mobile);
            this.Controls.Add(this.Tbx_Addr);
            this.Controls.Add(this.Lbl_Mobile);
            this.Controls.Add(this.Tbx_Name);
            this.Controls.Add(this.Lbl_Addr);
            this.Controls.Add(this.Tbx_PW);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Tbx_ID);
            this.Controls.Add(this.Lbl_PW);
            this.Controls.Add(this.Btn_Cancle);
            this.Controls.Add(this.Btn_SignUp);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Nav_Top);
            this.Controls.Add(this.Lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SignUp";
            this.Text = "FRM_SignUp";
            this.Load += new System.EventHandler(this.FRM_SignUp_Load);
            this.Nav_Top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Nav_Top;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Button Btn_SignUp;
        private System.Windows.Forms.TextBox Tbx_ID;
        private System.Windows.Forms.Label Lbl_PW;
        private System.Windows.Forms.TextBox Tbx_PW;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Tbx_Name;
        private System.Windows.Forms.Label Lbl_Addr;
        private System.Windows.Forms.TextBox Tbx_Addr;
        private System.Windows.Forms.Label Lbl_Mobile;
        private System.Windows.Forms.TextBox Tbx_Mobile;
        private System.Windows.Forms.Button Btn_Cancle;
        private System.Windows.Forms.Button Btn_CheckID;
    }
}