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
    public partial class FrmResultClick : Form
    {
        List<Language> languages;
        public FrmResultClick()
        {
            InitializeComponent();
        }

        public FrmResultClick(string zipcode, string addr1, string tel, string title, string overview, string homepage, Image img, List<Language> languages) : this()
        {
            this.languages = languages;
            lbl_addr.Text= languages[Int32.Parse(ConfigurationManager.AppSettings["lang"])].Addr;
            lbl_homepage.Text= languages[Int32.Parse(ConfigurationManager.AppSettings["lang"])].Home_page;
            lbl_phone.Text= languages[Int32.Parse(ConfigurationManager.AppSettings["lang"])].Phone;
            lbl_post.Text= languages[Int32.Parse(ConfigurationManager.AppSettings["lang"])].Post;
            lbl_main.Text = languages[Int32.Parse(ConfigurationManager.AppSettings["lang"])].Main_txt;
            this.Text = title;
            lblTitle.Text = title;
            lblZipCode.Text = zipcode;
            lblTel.Text = tel;
            if (homepage != "X")
            {
                lklbl.Text = homepage;
                lblhome.Text = string.Empty;
            }
            else
            {
                lklbl.Text = string.Empty;
                lblhome.Text = homepage;
            }

            lblAddr.Text = addr1;
            if (img != null)
            {
                pbx.Image = img; 
            }
            else
            {
                pbx.ImageLocation = Application.StartupPath + @"\images\no.jpg";
            }

            txtOverview.Enabled = false;
            txtOverview.Text = overview;
        }

        private void lklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", lklbl.Text);
        }
    }
}
