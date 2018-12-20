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
            Button btn1 = new Button();
            btn1.Location = new Point(166, 90);
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 0;
            btn1.Text = "button2";
            btn1.Name = "btn1";
            this.Controls.Add(btn1);

            btn1.Show();

        }
    }
}
