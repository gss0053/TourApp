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
        public static List<Membership> lstMembership = new List<Membership>();
        private JObject jsonObj;
        private JsonSource source;
        List<JsonSource> areaList;
        List<JsonSource> muniList;
        private string key = "iTK7s%2Fzqx%2BryS2LJoVUsUlYMRuHqxtez6UB7TdDdf%2FZNdvCjoilYCNJWbX%2BfX7ZXum2O8mQ8tn3mal2jzuplRA%3D%3D";
        private string path = "";

        public Form1()
        {
            InitializeComponent();
            areaList = new List<JsonSource>();
            muniList = new List<JsonSource>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FrmMembership fms = new FrmMembership(lstMembership);
            fms.ShowDialog();

            this.Text = "한국 국문관광정보 프로그램";

            // json얻어오기
            jsonObj = GetJson(GetPath("areaCode", 17));

            var itemsArr = JArray.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());
            GetObject(itemsArr, areaList, cbxArea);
        }
        // 주소 얻어오는 메서드
        private string GetPath(string apiKind, int rowNum)
        {
            path = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/" + apiKind + "?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=" + rowNum + "&_type=json";

            return path;
        }
        private void GetObject(JArray itemsArr, List<JsonSource> lst, ComboBox cbx)
        {
            foreach (JObject item in itemsArr)
            {
                source = new JsonSource
                {
                    Code = int.Parse(item.GetValue("code").ToString()),
                    Name = item.GetValue("name").ToString(),
                    Rnum = int.Parse(item.GetValue("rnum").ToString())
                };
                lst.Add(source);
                cbx.Items.Add(source.Name);
            }
        }
        // 제이슨 얻어오는 메서드
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
            // 세종 JSON 구조 달라서 if문 걸어줌
            jsonObj = GetJson(GetPath("areaCode", 50));
            if (cbxArea.SelectedIndex != 7)
            {
                var itemsArr = JArray.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());
                GetObject(itemsArr, muniList, cbxMuni);
            }
            else
            {
                var item = JObject.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());
                source = new JsonSource
                {
                    Code = int.Parse(item.GetValue("code").ToString()),
                    Name = item.GetValue("name").ToString(),
                    Rnum = int.Parse(item.GetValue("rnum").ToString())
                };
                muniList.Add(source);
                cbxMuni.Items.Add(item.Property("name").Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetJson(GetPath("areaBasedList", 1)).ToString();
        }
    }
}