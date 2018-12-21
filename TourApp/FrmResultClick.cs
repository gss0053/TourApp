using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public FrmResultClick()
        {
            InitializeComponent();
        }

        public FrmResultClick(string zipcode, string addr1, string tel, string title, string overview, string homepage, Image img) : this()
        {
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
