namespace MS_Project
{
    partial class FRM_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nav_Top = new System.Windows.Forms.Panel();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nav_Bottom = new System.Windows.Forms.Panel();
            this.Nav_Side = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Btn_ZoomOut = new System.Windows.Forms.Button();
            this.Btn_ZoomIn = new System.Windows.Forms.Button();
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.Nav_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Nav_Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nav_Top
            // 
            this.Nav_Top.BackColor = System.Drawing.SystemColors.Control;
            this.Nav_Top.Controls.Add(this.Btn_Close);
            this.Nav_Top.Controls.Add(this.pictureBox1);
            this.Nav_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nav_Top.Location = new System.Drawing.Point(0, 0);
            this.Nav_Top.Name = "Nav_Top";
            this.Nav_Top.Size = new System.Drawing.Size(1020, 36);
            this.Nav_Top.TabIndex = 2;
            this.Nav_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseDown);
            this.Nav_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseMove);
            this.Nav_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Nav_Top_MouseUp);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.Location = new System.Drawing.Point(987, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Nav_Bottom
            // 
            this.Nav_Bottom.BackColor = System.Drawing.SystemColors.Control;
            this.Nav_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Nav_Bottom.Location = new System.Drawing.Point(0, 512);
            this.Nav_Bottom.Name = "Nav_Bottom";
            this.Nav_Bottom.Size = new System.Drawing.Size(1020, 29);
            this.Nav_Bottom.TabIndex = 4;
            // 
            // Nav_Side
            // 
            this.Nav_Side.Controls.Add(this.Btn_Back);
            this.Nav_Side.Controls.Add(this.listBox);
            this.Nav_Side.Controls.Add(this.trackBar1);
            this.Nav_Side.Controls.Add(this.Btn_ZoomOut);
            this.Nav_Side.Controls.Add(this.Btn_ZoomIn);
            this.Nav_Side.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nav_Side.Location = new System.Drawing.Point(0, 36);
            this.Nav_Side.Name = "Nav_Side";
            this.Nav_Side.Size = new System.Drawing.Size(200, 476);
            this.Nav_Side.TabIndex = 6;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(12, 338);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(171, 62);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 57);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(171, 259);
            this.listBox.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 6);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(110, 56);
            this.trackBar1.TabIndex = 9;
            // 
            // Btn_ZoomOut
            // 
            this.Btn_ZoomOut.Location = new System.Drawing.Point(164, 6);
            this.Btn_ZoomOut.Name = "Btn_ZoomOut";
            this.Btn_ZoomOut.Size = new System.Drawing.Size(30, 30);
            this.Btn_ZoomOut.TabIndex = 8;
            this.Btn_ZoomOut.Text = "-";
            this.Btn_ZoomOut.UseVisualStyleBackColor = true;
            // 
            // Btn_ZoomIn
            // 
            this.Btn_ZoomIn.Location = new System.Drawing.Point(128, 6);
            this.Btn_ZoomIn.Name = "Btn_ZoomIn";
            this.Btn_ZoomIn.Size = new System.Drawing.Size(30, 30);
            this.Btn_ZoomIn.TabIndex = 7;
            this.Btn_ZoomIn.Text = "+";
            this.Btn_ZoomIn.UseVisualStyleBackColor = true;
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Main.Location = new System.Drawing.Point(200, 36);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(820, 476);
            this.Pnl_Main.TabIndex = 7;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 541);
            this.Controls.Add(this.Pnl_Main);
            this.Controls.Add(this.Nav_Side);
            this.Controls.Add(this.Nav_Top);
            this.Controls.Add(this.Nav_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Nav_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Nav_Side.ResumeLayout(false);
            this.Nav_Side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Nav_Top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Nav_Bottom;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Nav_Side;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Btn_ZoomOut;
        private System.Windows.Forms.Button Btn_ZoomIn;
        private System.Windows.Forms.Panel Pnl_Main;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Btn_Back;
    }
}

