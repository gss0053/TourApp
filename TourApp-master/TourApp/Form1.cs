using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TourApp
{
    public partial class Form1 : Form
    {
        private string key = "iTK7s%2Fzqx%2BryS2LJoVUsUlYMRuHqxtez6UB7TdDdf%2FZNdvCjoilYCNJWbX%2BfX7ZXum2O8mQ8tn3mal2jzuplRA%3D%3D";
        private JObject jsonObj;
        List<Area> areaList;
        List<Area> muniList;
        public Form1()
        {
            InitializeComponent();
            areaList = new List<Area>();
            muniList = new List<Area>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "한국 국문관광정보 프로그램";
            // string hexStr = HttpUtility.UrlEncode();

            // json얻어오기
            string path = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaCode?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=17&_type=json";
            jsonObj = GetJson(path);

            var itemsArr = JArray.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());

            foreach (JObject item in itemsArr)
            {
                Area area = new Area
                {
                    Code = int.Parse(item.GetValue("code").ToString()),
                    Name = item.GetValue("name").ToString(),
                    Rnum = int.Parse(item.GetValue("rnum").ToString())
                };
                areaList.Add(area);
                cbxArea.Items.Add(area.Name);
            }
        }

        private static JObject GetJson(string path)
        {
            var req = WebRequest.Create(path) as HttpWebRequest;
            var res = req.GetResponse() as HttpWebResponse;
            var statusCode = res.StatusCode.ToString();
            JObject jsonObj = null;

            if (statusCode == "OK")
            {
                var stream = res.GetResponseStream();
                var sr = new StreamReader(stream, Encoding.UTF8);
                jsonObj = JObject.Parse(sr.ReadToEnd());
            }
            else
            {
                MessageBox.Show("에러 발생 : " + statusCode);
            }
            return jsonObj;
        }

        private void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMuni.Items.Clear();
            muniList.Clear();
            string path = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaCode?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=50&pageNo=1&areaCode=" + areaList[cbxArea.SelectedIndex].Code + "&_type=json";

            jsonObj = GetJson(path);
            if (cbxArea.SelectedIndex != 7)
            {
                var itemsArr = JArray.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());
                foreach (JObject item in itemsArr)
                {
                    Area area = new Area
                    {
                        Code = int.Parse(item.GetValue("code").ToString()),
                        Name = item.GetValue("name").ToString(),
                        Rnum = int.Parse(item.GetValue("rnum").ToString())
                    };
                    muniList.Add(area);
                    cbxMuni.Items.Add(item.GetValue("name").ToString());
                }
            }
            else
            {
                var item = JObject.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());
                Area area = new Area
                {
                    Code = int.Parse(item.GetValue("code").ToString()),
                    Name = item.GetValue("name").ToString(),
                    Rnum = int.Parse(item.GetValue("rnum").ToString())
                };
                muniList.Add(area);
                cbxMuni.Items.Add(item.Property("name").Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fuck = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaBasedList?ServiceKey="+ key + "&MobileOS=ETC&MobileApp=AppTest&areaCode=" + areaList[cbxArea.SelectedIndex].Code + "&sigunguCode=" + muniList[cbxMuni.SelectedIndex].Code + "&_type=json";
            textBox1.Text = GetJson(fuck).ToString();
        }
    }
}
