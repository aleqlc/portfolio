using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //지도차트
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Random random = new Random();
            Dictionary<string, double> value = new Dictionary<string, double>();
            value["CA"] = random.Next(0, 100);//캐나다
            value["US"] = random.Next(0, 100);//미국
            value["GB"] = random.Next(0, 100);//영국
            value["CN"] = random.Next(0, 100);//중국
            value["KR"] = random.Next(0, 100);//한국
            value["JP"] = random.Next(0, 100);//일본

            //value["2038"] = random.Next(0, 100);//서울
            //value["2037"] = random.Next(0, 100);//강원도
            //xml에 표시된 name이 아니라 id로 넣어야 지도에 파랑색표시됨
            //xml복사해올때 한글로 번역된거 복사해오면 실행안됨


            geoMap.HeatMap = value;
            geoMap.Source = $"{Application.StartupPath}\\World.xml";//세계지도
            //geoMap.Source = $"{Application.StartupPath}\\South Korea.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }
    }
}
