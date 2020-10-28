namespace MS_Project
{
    partial class FRM_Login
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
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Tbx_ID = new System.Windows.Forms.TextBox();
            this.Lbl_PW = new System.Windows.Forms.Label();
            this.Tbx_PW = new System.Windows.Forms.TextBox();
            this.Nav_Top = new System.Windows.Forms.Panel();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_SignUp = new System.Windows.Forms.Button();
            this.Nav_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("굴림", 20F);
            this.Lbl_ID.Location = new System.Drawing.Point(58, 83);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(49, 34);
            this.Lbl_ID.TabIndex = 0;
            this.Lbl_ID.Text = "ID";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(111, 217);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(131, 59);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Tbx_ID
            // 
            this.Tbx_ID.Font = new System.Drawing.Font("굴림", 20F);
            this.Tbx_ID.Location = new System.Drawing.Point(155, 80);
            this.Tbx_ID.Name = "Tbx_ID";
            this.Tbx_ID.Size = new System.Drawing.Size(249, 46);
            this.Tbx_ID.TabIndex = 1;
            this.Tbx_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_ID_KeyPress);
            // 
            // Lbl_PW
            // 
            this.Lbl_PW.AutoSize = true;
            this.Lbl_PW.Font = new System.Drawing.Font("굴림", 20F);
            this.Lbl_PW.Location = new System.Drawing.Point(58, 147);
            this.Lbl_PW.Name = "Lbl_PW";
            this.Lbl_PW.Size = new System.Drawing.Size(67, 34);
            this.Lbl_PW.TabIndex = 0;
            this.Lbl_PW.Text = "PW";
            // 
            // Tbx_PW
            // 
            this.Tbx_PW.Font = new System.Drawing.Font("굴림", 20F);
            this.Tbx_PW.Location = new System.Drawing.Point(155, 144);
            this.Tbx_PW.Name = "Tbx_PW";
            this.Tbx_PW.Size = new System.Drawing.Size(249, 46);
            this.Tbx_PW.TabIndex = 2;
            this.Tbx_PW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_PW_KeyPress);
            // 
            // Nav_Top
            // 
            this.Nav_Top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nav_Top.Controls.Add(this.Btn_Close);
            this.Nav_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nav_Top.Location = new System.Drawing.Point(0, 0);
            this.Nav_Top.Name = "Nav_Top";
            this.Nav_Top.Size = new System.Drawing.Size(478, 40);
            this.Nav_Top.TabIndex = 5;
            this.Nav_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseDown);
            this.Nav_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseMove);
            this.Nav_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseUp);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.Location = new System.Drawing.Point(443, 5);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 6;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_SignUp
            // 
            this.Btn_SignUp.Location = new System.Drawing.Point(248, 217);
            this.Btn_SignUp.Name = "Btn_SignUp";
            this.Btn_SignUp.Size = new System.Drawing.Size(131, 59);
            this.Btn_SignUp.TabIndex = 6;
            this.Btn_SignUp.Text = "Sign Up";
            this.Btn_SignUp.UseVisualStyleBackColor = true;
            this.Btn_SignUp.Click += new System.EventHandler(this.Btn_SignUp_Click);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 321);
            this.Controls.Add(this.Btn_SignUp);
            this.Controls.Add(this.Nav_Top);
            this.Controls.Add(this.Tbx_PW);
            this.Controls.Add(this.Tbx_ID);
            this.Controls.Add(this.Lbl_PW);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Lbl_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Login";
            this.Text = "FRM_Login";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.Nav_Top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Tbx_ID;
        private System.Windows.Forms.Label Lbl_PW;
        private System.Windows.Forms.TextBox Tbx_PW;
        private System.Windows.Forms.Panel Nav_Top;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_SignUp;
    }
}