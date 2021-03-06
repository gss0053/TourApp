﻿using Newtonsoft.Json.Linq;
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
        List<Result> resultList; // 검색결과 컬렉션
        List<Language> languages;

        private string key = "et09skASPRv2AIlhJrNK8wPRL%2BG8S%2BBeEG35iFl0kejmnWLWA%2B1gAr480VSUor7FywfV%2Fuf1H9zlkrTYDt%2FV%2FQ%3D%3D";
        private string path = "";

        public Form1()
        {
            InitializeComponent();
            listView.View = View.LargeIcon;
            areaList = new List<JsonSource>();
            muniList = new List<JsonSource>();
            cat1List = new List<JsonSource>();
            cat2List = new List<JsonSource>();
            cat3List = new List<JsonSource>();
            resultList = new List<Result>();
            languages = new List<Language>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "한국 국문관광정보 프로그램";

            //KorService 국어
            //EngService 영어
            //JpnService 일어
            //ChsService 중문(간체)
            //ChtService 중문(번체)
            //GerService 독어(독일어) 언어 선택 : Sprache wählen 지역 선택 : Region auswählen
            //FreService 불어(프랑스어)
            //SpnService 서어(스페인어)
            //RusService 노어(러시아어)

            languages.Clear();
            languages.Add(new Language("KorService", "국어(한글)", "언어 선택", "지역 선택", "서비스 분류", "대분류", "중분류", "소분류"));
            languages.Add(new Language("EngService", "English(영어)", "Select language", "Select region", "Service classification", "Main Category", "Middle Category", "Small Category"));
            languages.Add(new Language("JpnService", "日本語(일어)", "言語を選択", "地域を選択", "サービスの分類", "大分類", "中分類", "小分類"));
            languages.Add(new Language("ChsService", "简体中文(중어-간체)", "选择语言", "选择地区", "服务分类", "主要类别", "中产阶级", "小类"));
            languages.Add(new Language("ChtService", "繁體中文(중어-번체)", "選擇語言", "選擇地區", "服務分類", "主要類別", "中產階級", "小類"));
            languages.Add(new Language("GerService", "Deutsch(독일어)", "Sprache wählen", "Region auswählen", "Service Klassifizierung", "Hauptkategorie", "MittelKategorie", "Kleine Kategorie"));
            languages.Add(new Language("FreService", "Le français(프랑스어)", "Sélectionnez la langue", "Sélectionnez une région", "Classification de service", "Catégorie majeure", "Classe moyenne", "Petite catégorie"));
            languages.Add(new Language("SpnService", "Español(스페인어)", "Seleccionar idioma", "Seleccione region", "Clasificación de servicios", "Catégorie majeure", "Clase media", "Categoría pequeña"));
            languages.Add(new Language("RusService", "русский(러시아어)", "Выберите язык", "Выберите регион", "Сервисная классификация", "Основная категория", "Средний класс", "Малая категория"));
            foreach (var item in languages)
            {
                cbx_language.Items.Add(item.KorName);
            }
            cbx_language.SelectedIndex = 0;

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

        // 주소 얻어오는 메서드
        private string GetPath(string language, string apiKind, string rowNum)
        {
            path = "http://api.visitkorea.or.kr/openapi/service/rest/" + language + "/" + apiKind + "?ServiceKey=" + key + "&MobileOS=ETC&MobileApp=AppTest&numOfRows=" + rowNum + "&cat1=" + checkIndex(cbxService1, cat1List) + "&cat2=" + checkIndex(cbxService2, cat2List) + "&cat3=" + checkIndex(cbxService3, cat3List) + "&areaCode=" + checkIndex(cbxArea, areaList) + "&sigunguCode=" + checkIndex(cbxMuni, muniList) + "&_type=json";
            return path;
        }

        private void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMuni.Text = "소분류";
            cbxMuni.Items.Clear();
            muniList.Clear();
            // 세종 JSON 구조 달라서 if문 걸어줌
            jsonObj = GetJson(GetPath(languages[cbx_language.SelectedIndex].EngName, "areaCode", "50"));

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
        // 콤보박스 아이템이 체크되었는지 확인해서 안되어있으면 ""를 되어있으면 코드를 반납해주는 메서드
        private string checkIndex(ComboBox cbx, List<JsonSource> lst)
        {
            string temp = string.Empty;
            if (cbx.SelectedIndex == -1)
            {
                return temp;
            }
            else
            {
                return lst[cbx.SelectedIndex].Code;
            }
        }


        // 대분류가 바뀔때 중분류
        private void cbxService1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxService2.Items.Clear();
            cbxService2.Text = "중분류";
            cat2List.Clear();
            cbxService3.Items.Clear();
            cbxService3.Text = "소분류";
            cat3List.Clear();


            GetPath(languages[cbx_language.SelectedIndex].EngName, "categoryCode", "10");

            jsonCat1 = GetJson(path);

            if (cbx_language.SelectedIndex == 0)
            {
                if (cbxService1.SelectedIndex != 3 && cbxService1.SelectedIndex != 4 && cbxService1.SelectedIndex != 5)
                {
                    var itemsArr1 = JArray.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
                    GetObject(itemsArr1, cat2List, cbxService2);
                }
                else
                {
                    var item = JObject.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
                    source = new JsonSource
                    {
                        Code = item.GetValue("code").ToString(),
                        Name = item.GetValue("name").ToString(),
                        Rnum = int.Parse(item.GetValue("rnum").ToString())
                    };
                    cat2List.Add(source);

                    cbxService2.Items.Add(item.Property("name").Value.ToString());
                }
            }
            else
            {
                if (cbxService1.SelectedIndex != 3 && cbxService1.SelectedIndex != 4 && cbxService1.SelectedIndex != 5 && cbxService1.SelectedIndex != 6)
                {
                    var itemsArr1 = JArray.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
                    GetObject(itemsArr1, cat2List, cbxService2);
                }
                else
                {
                    var item = JObject.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
                    source = new JsonSource
                    {
                        Code = item.GetValue("code").ToString(),
                        Name = item.GetValue("name").ToString(),
                        Rnum = int.Parse(item.GetValue("rnum").ToString())
                    };
                    cat2List.Add(source);

                    cbxService2.Items.Add(item.Property("name").Value.ToString());
                }
            }
        }

        // 중분류의 바뀔때 소분류 
        private void cbxService2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxService3.Items.Clear();
            cbxService3.Text = "소분류";
            cat3List.Clear();

            path = GetPath(languages[cbx_language.SelectedIndex].EngName, "categoryCode", "10");

            jsonCat1 = GetJson(path);

            if (cbx_language.SelectedIndex == 0)
            {

                if (cbxService1.SelectedIndex != 6 && !(cbxService1.SelectedIndex == 2 && cbxService2.SelectedIndex == 4))
                {
                    var itemsArr1 = JArray.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
                    GetObject(itemsArr1, cat3List, cbxService3);
                }
                else
                {
                    var item = JObject.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
                    source = new JsonSource
                    {
                        Code = item.GetValue("code").ToString(),
                        Name = item.GetValue("name").ToString(),
                        Rnum = int.Parse(item.GetValue("rnum").ToString())
                    };
                    cat3List.Add(source);

                    cbxService3.Items.Add(item.Property("name").Value.ToString());
                }
            }
            else
            {
                if (!(cbxService1.SelectedIndex == 2 && cbxService2.SelectedIndex == 4))
                {
                    var itemsArr1 = JArray.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
                    GetObject(itemsArr1, cat3List, cbxService3);
                }
                else
                {
                    var item = JObject.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
                    source = new JsonSource
                    {
                        Code = item.GetValue("code").ToString(),
                        Name = item.GetValue("name").ToString(),
                        Rnum = int.Parse(item.GetValue("rnum").ToString())
                    };
                    cat3List.Add(source);

                    cbxService3.Items.Add(item.Property("name").Value.ToString());
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            imgList.Images.Clear();
            resultList.Clear();
            path = GetPath(languages[cbx_language.SelectedIndex].EngName, "areaBasedList", "15");
            jsonObj = GetJson(path);
            var itemsArr = JArray.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());
            foreach (JObject item in itemsArr)
            {
                Result result = new Result();
                if (item.Property("addr1") != null)
                {
                    result.Addr1 = item.GetValue("addr1").ToString();
                }
                if (item.Property("addr2") != null)
                {
                    result.Addr2 = item.GetValue("addr2").ToString();
                }
                if (item.Property("areacode") != null)
                {
                    result.Areacode = int.Parse(item.GetValue("areacode").ToString());
                }
                if (item.Property("cat1") != null)
                {
                    result.Cat1 = item.GetValue("cat1").ToString();
                }
                if (item.Property("cat2") != null)
                {
                    result.Cat2 = item.GetValue("cat2").ToString();
                }
                if (item.Property("cat3") != null)
                {
                    result.Cat3 = item.GetValue("cat3").ToString();
                }
                if (item.Property("contentid") != null)
                {
                    result.Contentid = Int32.Parse(item.GetValue("contentid").ToString());
                }
                if (item.Property("contenttypeid") != null)
                {
                    result.Contenttypeid = Int32.Parse(item.GetValue("contenttypeid").ToString());
                }
                if (item.Property("createdtime") != null)
                {
                    result.Createdtime = Int64.Parse(item.GetValue("createdtime").ToString());
                }
                if (item.Property("mapx") != null)
                {
                    result.Mapx = double.Parse(item.GetValue("mapx").ToString());
                }
                if (item.Property("mapy") != null)
                {
                    result.Mapy = double.Parse(item.GetValue("mapy").ToString());
                }
                if (item.Property("mlevel") != null)
                {
                    result.Mlevel = Int32.Parse(item.GetValue("mlevel").ToString());
                }
                if (item.Property("modifiedtime") != null)
                {
                    result.Modifiedtime = double.Parse(item.GetValue("modifiedtime").ToString());
                }
                if (item.Property("readcount") != null)
                {
                    result.Readcount = Int32.Parse(item.GetValue("readcount").ToString());
                }
                if (item.Property("sigungucode") != null)
                {
                    result.Sigungucode = Int32.Parse(item.GetValue("sigungucode").ToString());
                }
                if (item.Property("title") != null)
                {
                    result.Title = item.GetValue("title").ToString();
                }
                if (item.Property("zipcode") != null)
                {
                    result.Zipcode = item.GetValue("zipcode").ToString();
                }
                if (item.Property("tel") != null)
                {
                    result.Tel = item.GetValue("tel").ToString();
                }

                ListViewItem li;
                string title = result.Title;
                listView.LargeImageList = imgList;
                if (item.Property("firstimage") != null)
                {
                    result.Firstimage = item.GetValue("firstimage").ToString(); // 썸네일
                    var req = WebRequest.Create(result.Firstimage) as HttpWebRequest;
                    var res = req.GetResponse() as HttpWebResponse;
                    var imgStream = res.GetResponseStream();
                    Image file1 = Image.FromStream(imgStream);
                    imgList.ImageSize = new Size(256, 256);
                    imgList.ColorDepth = ColorDepth.Depth32Bit;
                    imgList.Images.Add(title, file1);

                    li = new ListViewItem(title);
                    li.ImageKey = title;
                    listView.Items.Add(li);
                }
                else
                {
                    li = new ListViewItem(title);
                    listView.Items.Add(li);
                }

                if (item.Property("firstimage2") != null)
                {
                    result.Firstimage2 = item.GetValue("firstimage2").ToString(); // 썸네일
                }
                resultList.Add(result);
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            //    cbxArea.Text = cbxService1.Text = "대분류";
            //    cbxMuni.Text = cbxService3.Text = "소분류";
            //    cbxService2.Text = "중분류";
            cbx_language.Items.Clear();
            cbxArea.Items.Clear();
            cbxMuni.Items.Clear();
            cbxService1.Items.Clear();
            cbxService2.Items.Clear();
            cbxService3.Items.Clear();

            Form1_Load(null, null);
            //cbxMuni.Text = cbxService3.Text 
        }

        //다국어 바뀔때
        private void cbx_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxArea.Items.Clear();
            cbxMuni.Items.Clear();
            cbxService1.Items.Clear();
            cbxService2.Items.Clear();
            cbxService3.Items.Clear();
            areaList.Clear();
            muniList.Clear();
            cat1List.Clear();
            cat2List.Clear();
            cat3List.Clear();

            lbl_language.Text = languages[cbx_language.SelectedIndex].Select_language;
            lbl_region.Text = languages[cbx_language.SelectedIndex].Select_region;
            lbl_service.Text = languages[cbx_language.SelectedIndex].Service_classification;
            lbl_main1.Text = lbl_main2.Text = languages[cbx_language.SelectedIndex].Main_Category;
            lbl_middle.Text = languages[cbx_language.SelectedIndex].Middle_class;
            lbl_small1.Text = lbl_small2.Text = languages[cbx_language.SelectedIndex].Small_Category;

            jsonObj = GetJson(GetPath(languages[cbx_language.SelectedIndex].EngName, "areaCode", "17"));

            var itemsArr = JArray.Parse(jsonObj["response"]["body"]["items"]["item"].ToString());
            GetObject(itemsArr, areaList, cbxArea);
            cbx_language.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMuni.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxService1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxService2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxService3.DropDownStyle = ComboBoxStyle.DropDownList;
            // 대분류 얻어오기
            jsonCat1 = GetJson(GetPath(languages[cbx_language.SelectedIndex].EngName, "categoryCode", "7"));
            itemsArr = JArray.Parse(jsonCat1["response"]["body"]["items"]["item"].ToString());
            GetObject(itemsArr, cat1List, cbxService1);
        }
    }
}
