using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourApp
{
    public partial class FrmCaptcha : Form
    {
        public FrmMembership fms;
        Random random = new Random();
        int[] captindex = new int[10];
        string passStr;

        public FrmCaptcha()
        {
            InitializeComponent();
        }

        private void FrmCaptcha_Load(object sender, EventArgs e)
        {
            Captchar_Algo();
            Captchar_Create();
        }

        private void Captchar_Algo()
        {
            captindex[0] = random.Next(0, 68);

            do { captindex[1] = random.Next(0, 68); }
            while( captindex[1] == captindex[0] );

            do { captindex[2] = random.Next(0, 68); }
            while (captindex[2] == captindex[1] || captindex[2] == captindex[0]);

            do { captindex[3] = random.Next(0, 68); }
            while (captindex[3] == captindex[2] || captindex[3] == captindex[1] || captindex[3] == captindex[0]);

            do { captindex[4] = random.Next(0, 68); }
            while (captindex[4] == captindex[3] || captindex[4] == captindex[2] || captindex[4] == captindex[1] || captindex[4] == captindex[0]);

            do { captindex[5] = random.Next(0, 68); }
            while (captindex[5] == captindex[4] || captindex[5] == captindex[3] || captindex[5] == captindex[2] || captindex[5] == captindex[1] || captindex[5] == captindex[0]);

            do { captindex[6] = random.Next(0, 68); }
            while (captindex[6] == captindex[5] || captindex[6] == captindex[4] || captindex[6] == captindex[3] || captindex[6] == captindex[2] || captindex[6] == captindex[1] || captindex[6] == captindex[0]);

            do { captindex[7] = random.Next(0, 68); }
            while (captindex[7] == captindex[6] || captindex[7] == captindex[5] || captindex[7] == captindex[4] || captindex[7] == captindex[3] || captindex[7] == captindex[2] || captindex[7] == captindex[1] || captindex[7] == captindex[0]);

            do { captindex[8] = random.Next(0, 68); }
            while (captindex[8] == captindex[7] || captindex[8] == captindex[6] || captindex[8] == captindex[5] || captindex[8] == captindex[4] || captindex[8] == captindex[3] || captindex[8] == captindex[2] || captindex[8] == captindex[1] || captindex[8] == captindex[0]);

            do { captindex[9] = random.Next(0, 68); }
            while (captindex[9] == captindex[8] || captindex[9] == captindex[7] || captindex[9] == captindex[6] || captindex[9] == captindex[5] || captindex[9] == captindex[4] || captindex[9] == captindex[3] || captindex[9] == captindex[2] || captindex[9] == captindex[1] || captindex[9] == captindex[0]);
        }

        private void Captchar_Create()
        {
            passStr = "";
            for (int i = 0; i < captindex.Length; i++)
            {
                if (captindex[i] == 0 || captindex[i] == 1 || captindex[i] == 2)
                {
                    passStr += "1";
                }
                else if (captindex[i] == 3 || captindex[i] == 4 || captindex[i] == 5)
                {
                    passStr += "2";
                }
                else if (captindex[i] == 6)
                {
                    passStr += "3";
                }
                else if (captindex[i] == 7 || captindex[i] == 8 || captindex[i] == 9)
                {
                    passStr += "4";
                }
                else if (captindex[i] == 10)
                {
                    passStr += "5";
                }
                else if (captindex[i] == 11 || captindex[i] == 12)
                {
                    passStr += "6";
                }
                else if (captindex[i] == 13)
                {
                    passStr += "7";
                }
                else if (captindex[i] == 14)
                {
                    passStr += "8";
                }
                else if (captindex[i] == 15)
                {
                    passStr += "9";
                }
                else if (captindex[i] == 16 || captindex[i] == 17 || captindex[i] == 18)
                {
                    passStr += "a";
                }
                else if (captindex[i] == 19 || captindex[i] == 20)
                {
                    passStr += "b";
                }
                else if (captindex[i] == 21 || captindex[i] == 22)
                {
                    passStr += "c";
                }
                else if (captindex[i] == 23 || captindex[i] == 24 || captindex[i] == 25)
                {
                    passStr += "d";
                }
                else if (captindex[i] == 26 || captindex[i] == 27 || captindex[i] == 28 || captindex[i] == 29)
                {
                    passStr += "e";
                }
                else if (captindex[i] == 30)
                {
                    passStr += "f";
                }
                else if (captindex[i] == 31)
                {
                    passStr += "g";
                }
                else if (captindex[i] == 32 || captindex[i] == 33 || captindex[i] == 34)
                {
                    passStr += "h";
                }
                else if (captindex[i] == 35 || captindex[i] == 36)
                {
                    passStr += "i";
                }
                else if (captindex[i] == 37 || captindex[i] == 38)
                {
                    passStr += "j";
                }
                else if (captindex[i] == 39 || captindex[i] == 40 || captindex[i] == 41)
                {
                    passStr += "k";
                }
                else if (captindex[i] == 42 || captindex[i] == 43)
                {
                    passStr += "l";
                }
                else if (captindex[i] == 44 || captindex[i] == 45)
                {
                    passStr += "m";
                }
                else if (captindex[i] == 46 || captindex[i] == 47)
                {
                    passStr += "n";
                }
                else if (captindex[i] == 48)
                {
                    passStr += "o";
                }
                else if (captindex[i] == 49 || captindex[i] == 50)
                {
                    passStr += "p";
                }
                else if (captindex[i] == 51)
                {
                    passStr += "q";
                }
                else if (captindex[i] == 52 || captindex[i] == 53)
                {
                    passStr += "r";
                }
                else if (captindex[i] == 54 || captindex[i] == 55)
                {
                    passStr += "s";
                }
                else if (captindex[i] == 56 || captindex[i] == 57)
                {
                    passStr += "t";
                }
                else if (captindex[i] == 58)
                {
                    passStr += "u";
                }
                else if (captindex[i] == 59)
                {
                    passStr += "v";
                }
                else if (captindex[i] == 60 || captindex[i] == 61 || captindex[i] == 62)
                {
                    passStr += "w";
                }
                else if (captindex[i] == 63 || captindex[i] == 64 || captindex[i] == 65)
                {
                    passStr += "x";
                }
                else if (captindex[i] == 66 || captindex[i] == 67)
                {
                    passStr += "y";
                }
                else if (captindex[i] == 68)
                {
                    passStr += "z";
                }
            }
            pbCapt1.Image = imgListCapt.Images[captindex[0]];
            pbCapt2.Image = imgListCapt.Images[captindex[1]];
            pbCapt3.Image = imgListCapt.Images[captindex[2]];
            pbCapt4.Image = imgListCapt.Images[captindex[3]];
            pbCapt5.Image = imgListCapt.Images[captindex[4]];
            pbCapt6.Image = imgListCapt.Images[captindex[5]];
            pbCapt7.Image = imgListCapt.Images[captindex[6]];
            pbCapt8.Image = imgListCapt.Images[captindex[7]];
            pbCapt9.Image = imgListCapt.Images[captindex[8]];   
            pbCapt10.Image = imgListCapt.Images[captindex[9]];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fms.captchk = true;
            Close();
        }

        private void tbPasscode_TextChanged(object sender, EventArgs e)
        {
            if (tbPasscode.Text.ToLower() == passStr)
            {
                btnSubmit.Enabled = true;
            }
        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Captchar_Algo();
            Captchar_Create();
        }
    }
}