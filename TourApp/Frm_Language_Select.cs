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
    public partial class Frm_Language_Select : Form
    {
        private List<Language> languages;
        int lang_index;
        int lang_count;

        public Frm_Language_Select()
        {
            InitializeComponent();
        }

        public Frm_Language_Select(List<Language> languages) : this()
        {
            this.languages = languages;
        }

        private void Frm_Language_Select_Load(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Test");
                    break;
                default:
                    break;
            }
        }
    }
}
