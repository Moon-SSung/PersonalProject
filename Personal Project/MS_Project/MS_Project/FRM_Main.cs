using LiveCharts.Maps;
using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MS_Project
{
    public partial class FRM_Main : Form
    {
        GeoMap geoMap;
        Dictionary<string, string> FileList = new Dictionary<string, string>();

        public FRM_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FRM_Login loginForm = new FRM_Login();
            loginForm.ShowDialog();

            openMap();
            ResizeForm();

            FileList["KR"] = "South Korea";
            FileList["US"] = "United States of America";
            FileList["AU"] = "Austria";
            FileList["CA"] = "Canada";
            FileList["FR"] = "France";
            FileList["RU"] = "Russia";
            //test
        }


        private void openMap()
        {       
            ////Form 크기 변경시, 다시 그리기
            this.ResizeRedraw = true;       
            
            ////지도 생성
            geoMap = new GeoMap();
            geoMap.Source = $@"{Application.StartupPath}\Maps\World.xml";
            geoMap.LandClick += GeoMap_Click;
            Pnl_Main.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }

        #region 지도 클릭 이벤트
        private void GeoMap_Click(object sender, MapData data)
        {
            ResultListBox(data);
            //listBox.Items.Add(data.Id + " = " + data.Name);
            //listBox.SelectedIndex = listBox.Items.Count - 1;
            //listBox.SelectedIndex = -1;

            if (FileList.ContainsKey(data.Id))
            {
                //Pnl_Main.Controls.Remove(this.geoMap);
                this.geoMap.Dispose();
                geoMap = new GeoMap();

                geoMap.Source = $@"{Application.StartupPath}\Maps\{FileList[data.Id]}.xml";
                geoMap.LandClick += Sub_GeoMap_Click;
                Pnl_Main.Controls.Add(geoMap);
                geoMap.Dock = DockStyle.Fill;
            }
        }

        private void Sub_GeoMap_Click(object sender, MapData data)
        {
            ResultListBox(data);

            //listBox.Items.Add(data.Id + " = " + data.Name);
            //listBox.SelectedIndex = listBox.Items.Count - 1;
            //listBox.SelectedIndex = -1;

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.geoMap.Dispose();
            openMap();
        }
        #endregion


        private void ResizeForm()
        {
            ////창 크기에 맞게 반응
            this.MinimumSize = new Size(1280, 800);
            GeoMap geoMap = new GeoMap();
            geoMap.Anchor = AnchorStyles.Top;
            geoMap.Dock = DockStyle.None;
        }

        private void ResultListBox(MapData data)
        {
            listBox.Items.Add(data.Id + " = " + data.Name);
            listBox.SelectedIndex = listBox.Items.Count - 1;
            listBox.SelectedIndex = -1;
        }

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
