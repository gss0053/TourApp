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
        private JObject jsonObj;
        private JObject jsonCat1;
        private JsonSource source;
        List<JsonSource> areaList;  // 지역코드
        List<JsonSource> muniList;  // 시군구코드
        List<JsonSource> cat1List;  // 대분류
        List<JsonSource> cat2List;  // 중분류
        List<JsonSource> cat3List;  // 소분류

        private string key = "iTK7s%2Fzqx%2BryS2LJoVUsUlYMRuHqxtez6UB7TdDdf%2FZNdvCjoilYCNJWbX%2BfX7ZXum2O8mQ8tn3mal2jzuplRA%3D%3D";
        private string path = "";

        public Form1()
        {
            InitializeComponent();
            areaList = new List<JsonSource>();
            muniList = new List<JsonSource>();
            cat1List = new List<JsonSource>();
            cat2List = new List<JsonSource>();
            cat3List = new List<JsonSource>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "한국 국문관광정보 프로그램";

            // json얻어오기
            jsonObj = GetJson(GetPath("areaCode", 17));

            var itemsArr = JArray.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());
            GetObject(itemsArr, areaList, cbxArea);


            // 대분류 얻어오기
            jsonCat1 = GetJson(GetPath("categoryCode", 10));
            var itemsArr1 = JArray.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
            GetObject(itemsArr1, cat1List, cbxService1);

        }
        // 주소 얻어오는 메서드
        private string GetPath(string apiKind, int rowNum)
        {
            if (apiKind == "areaCode")
            {
                path = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/" + apiKind + "?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=" + rowNum + "&_type=json";
            }
            else if (apiKind == "categoryCode")
            {
                path = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/" + apiKind + "?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=" + rowNum + "&_type=json";             
            }
            
            return path;
        }

        private void GetObject(JArray itemsArr, List<JsonSource> lst, ComboBox cbx)
        {
            foreach (JObject item in itemsArr)
            {
                source = new JsonSource
                {
                    Code = item.GetValue("code").ToString(),
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
            cbxMuni.Text = "소분류";
            cbxMuni.Items.Clear();
            muniList.Clear();
            // 세종 JSON 구조 달라서 if문 걸어줌
            jsonObj = GetJson(GetPath("areaCode", 50) + "&areaCode=" + areaList[cbxArea.SelectedIndex].Code);
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
                    Code = item.GetValue("code").ToString(),
                    Name = item.GetValue("name").ToString(),
                    Rnum = int.Parse(item.GetValue("rnum").ToString())
                };
                muniList.Add(source);
                cbxMuni.Items.Add(item.Property("name").Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/" + "areaBasedList" + "?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=" + 10 + "&cat1=" + cat1List[cbxService1.SelectedIndex].Code + "&cat2=" + cat2List[cbxService2.SelectedIndex].Code+ "&cat3=" + cat3List[cbxService3.SelectedIndex].Code + "&areaCode="+areaList[cbxArea.SelectedIndex].Code + "&sigunguCode=" + muniList[cbxMuni.SelectedIndex].Code + "&_type=json";

            textBox1.Text =GetJson(path).ToString();
        }

        private void cbxService1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxService2.Items.Clear();
            cbxService2.Text = "중분류";
            cat2List.Clear();
            cbxService3.Items.Clear();
            cbxService3.Text = "소분류";
            cat3List.Clear();

            path = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/" + "categoryCode" + "?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=" + 10 + "&cat1="+ cat1List[cbxService1.SelectedIndex].Code+ "&_type=json";

            jsonCat1 = GetJson(path);
            var itemsArr1 = JArray.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
            GetObject(itemsArr1, cat2List, cbxService2);

        }

        private void cbxService2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxService3.Items.Clear();
            cbxService3.Text = "소분류";
            cat3List.Clear();

            path = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/" + "categoryCode" + "?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=" + 10 + "&cat1=" + cat1List[cbxService1.SelectedIndex].Code+ "&cat2=" + cat2List[cbxService2.SelectedIndex].Code + "&_type=json";

            jsonCat1 = GetJson(path);
            var itemsArr1 = JArray.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
            GetObject(itemsArr1, cat3List, cbxService3);
        }
    }
}
