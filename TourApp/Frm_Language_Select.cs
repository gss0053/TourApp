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
        internal Form1 form1;

        internal string lang_index;

        public Frm_Language_Select()
        {
            InitializeComponent();
        }


        private void Frm_Language_Select_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + @"\images\icon.png";
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
                    lang_index = "Kor";
                    break;
                case "btn_Eng":
                    lang_index = "Eng";
                    break;
                case "btn_Jpn":
                    lang_index = "Jpn";
                    break;
                case "btn_Chs":
                    lang_index = "Chs";
                    break;
                case "btn_Cht":
                    lang_index = "Cht";
                    break;
                case "btn_Ger":
                    lang_index = "Ger";
                    break;
                case "btn_Fre":
                    lang_index = "Fre";
                    break;
                case "btn_Spn":
                    lang_index = "Spn";
                    break;
                case "btn_Rus":
                    lang_index = "Rus";
                    break;
                default:
                    break;
            }

            ConfigurationManager.AppSettings["lang"] = lang_index;


            Close();
        }
    }
}
