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
            this.Btn_Cancle = new System.Windows.Forms.Button();
            this.Tbx_ID = new System.Windows.Forms.TextBox();
            this.Lbl_PW = new System.Windows.Forms.Label();
            this.Tbx_PW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Font = new System.Drawing.Font("굴림", 20F);
            this.Lbl_ID.Location = new System.Drawing.Point(97, 55);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(49, 34);
            this.Lbl_ID.TabIndex = 0;
            this.Lbl_ID.Text = "ID";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(133, 223);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(131, 59);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Cancle
            // 
            this.Btn_Cancle.Location = new System.Drawing.Point(294, 223);
            this.Btn_Cancle.Name = "Btn_Cancle";
            this.Btn_Cancle.Size = new System.Drawing.Size(131, 59);
            this.Btn_Cancle.TabIndex = 4;
            this.Btn_Cancle.Text = "Cancle";
            this.Btn_Cancle.UseVisualStyleBackColor = true;
            // 
            // Tbx_ID
            // 
            this.Tbx_ID.Font = new System.Drawing.Font("굴림", 20F);
            this.Tbx_ID.Location = new System.Drawing.Point(194, 52);
            this.Tbx_ID.Name = "Tbx_ID";
            this.Tbx_ID.Size = new System.Drawing.Size(249, 46);
            this.Tbx_ID.TabIndex = 1;
            this.Tbx_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_ID_KeyPress);
            // 
            // Lbl_PW
            // 
            this.Lbl_PW.AutoSize = true;
            this.Lbl_PW.Font = new System.Drawing.Font("굴림", 20F);
            this.Lbl_PW.Location = new System.Drawing.Point(97, 119);
            this.Lbl_PW.Name = "Lbl_PW";
            this.Lbl_PW.Size = new System.Drawing.Size(67, 34);
            this.Lbl_PW.TabIndex = 0;
            this.Lbl_PW.Text = "PW";
            // 
            // Tbx_PW
            // 
            this.Tbx_PW.Font = new System.Drawing.Font("굴림", 20F);
            this.Tbx_PW.Location = new System.Drawing.Point(194, 116);
            this.Tbx_PW.Name = "Tbx_PW";
            this.Tbx_PW.Size = new System.Drawing.Size(249, 46);
            this.Tbx_PW.TabIndex = 2;
            this.Tbx_PW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_PW_KeyPress);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 323);
            this.Controls.Add(this.Tbx_PW);
            this.Controls.Add(this.Tbx_ID);
            this.Controls.Add(this.Btn_Cancle);
            this.Controls.Add(this.Lbl_PW);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Lbl_ID);
            this.Name = "FRM_Login";
            this.Text = "FRM_Login";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Cancle;
        private System.Windows.Forms.TextBox Tbx_ID;
        private System.Windows.Forms.Label Lbl_PW;
        private System.Windows.Forms.TextBox Tbx_PW;
    }
}