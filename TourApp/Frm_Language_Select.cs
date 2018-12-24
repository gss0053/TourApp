using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourApp
{
    public partial class Frm_Language_Select : Form
    {

        internal int lang_index;

        public Frm_Language_Select()
        {
            InitializeComponent();
        }


        private void Frm_Language_Select_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + @"\images\icon.png";
            pbxKor.ImageLocation = Application.StartupPath + @"\images\kor.png";
            pbxChi1.ImageLocation = Application.StartupPath + @"\images\chi.png";
            pbxChi2.ImageLocation = Application.StartupPath + @"\images\chi.png";
            pbxEng.ImageLocation = Application.StartupPath + @"\images\eng.jpg";
            pbxJap.ImageLocation = Application.StartupPath + @"\images\jap.jpg";
            pbxDeu.ImageLocation = Application.StartupPath + @"\images\dot.png";
            pbxFra.ImageLocation = Application.StartupPath + @"\images\fra.png";
            pbxRus.ImageLocation = Application.StartupPath + @"\images\rus.png";
            pbxSpa.ImageLocation = Application.StartupPath + @"\images\spa.png";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LangBtn_Click(object sender, EventArgs e)
        {
            Button LangBtn = (Button)sender;

            switch (LangBtn.Name)
            {
                case "btn_Kor":
                    lang_index = 0;
                    break;
                case "btn_Eng":
                    lang_index = 1;
                    break;
                case "btn_Jpn":
                    lang_index = 2;
                    break;
                case "btn_Chs":
                    lang_index = 3;
                    break;
                case "btn_Cht":
                    lang_index = 4;
                    break;
                case "btn_Ger":
                    lang_index = 5;
                    break;
                case "btn_Fre":
                    lang_index = 6;
                    break;
                case "btn_Spn":
                    lang_index = 7;
                    break;
                case "btn_Rus":
                    lang_index = 8;
                    break;
                default:
                    break;
            }

            ConfigurationManager.AppSettings["lang"] = lang_index.ToString();


            Close();
        }
    }
}
