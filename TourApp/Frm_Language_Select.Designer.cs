namespace TourApp
{
    partial class Frm_Language_Select
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Kor = new System.Windows.Forms.Button();
            this.btn_Eng = new System.Windows.Forms.Button();
            this.btn_Jpn = new System.Windows.Forms.Button();
            this.btn_Chs = new System.Windows.Forms.Button();
            this.btn_Cht = new System.Windows.Forms.Button();
            this.btn_Ger = new System.Windows.Forms.Button();
            this.btn_Fre = new System.Windows.Forms.Button();
            this.btn_Spn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Rus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kor
            // 
            this.btn_Kor.Location = new System.Drawing.Point(0, 180);
            this.btn_Kor.Name = "btn_Kor";
            this.btn_Kor.Size = new System.Drawing.Size(467, 82);
            this.btn_Kor.TabIndex = 0;
            this.btn_Kor.Text = "국어(한글)";
            this.btn_Kor.UseVisualStyleBackColor = true;
            this.btn_Kor.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // btn_Eng
            // 
            this.btn_Eng.Location = new System.Drawing.Point(78, 268);
            this.btn_Eng.Name = "btn_Eng";
            this.btn_Eng.Size = new System.Drawing.Size(129, 23);
            this.btn_Eng.TabIndex = 1;
            this.btn_Eng.Text = "English(영어)";
            this.btn_Eng.UseVisualStyleBackColor = true;
            this.btn_Eng.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // btn_Jpn
            // 
            this.btn_Jpn.Location = new System.Drawing.Point(217, 268);
            this.btn_Jpn.Name = "btn_Jpn";
            this.btn_Jpn.Size = new System.Drawing.Size(129, 23);
            this.btn_Jpn.TabIndex = 2;
            this.btn_Jpn.Text = "日本語(일어)";
            this.btn_Jpn.UseVisualStyleBackColor = true;
            this.btn_Jpn.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // btn_Chs
            // 
            this.btn_Chs.Location = new System.Drawing.Point(78, 297);
            this.btn_Chs.Name = "btn_Chs";
            this.btn_Chs.Size = new System.Drawing.Size(129, 23);
            this.btn_Chs.TabIndex = 3;
            this.btn_Chs.Text = "简体中文(중어-간체)";
            this.btn_Chs.UseVisualStyleBackColor = true;
            this.btn_Chs.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // btn_Cht
            // 
            this.btn_Cht.Location = new System.Drawing.Point(217, 297);
            this.btn_Cht.Name = "btn_Cht";
            this.btn_Cht.Size = new System.Drawing.Size(129, 23);
            this.btn_Cht.TabIndex = 4;
            this.btn_Cht.Text = "繁體中文(중어-번체)";
            this.btn_Cht.UseVisualStyleBackColor = true;
            this.btn_Cht.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // btn_Ger
            // 
            this.btn_Ger.Location = new System.Drawing.Point(78, 326);
            this.btn_Ger.Name = "btn_Ger";
            this.btn_Ger.Size = new System.Drawing.Size(129, 23);
            this.btn_Ger.TabIndex = 5;
            this.btn_Ger.Text = "Deutsch(독일어)";
            this.btn_Ger.UseVisualStyleBackColor = true;
            this.btn_Ger.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // btn_Fre
            // 
            this.btn_Fre.Location = new System.Drawing.Point(217, 326);
            this.btn_Fre.Name = "btn_Fre";
            this.btn_Fre.Size = new System.Drawing.Size(129, 23);
            this.btn_Fre.TabIndex = 6;
            this.btn_Fre.Text = "Le français(프랑스어)";
            this.btn_Fre.UseVisualStyleBackColor = true;
            this.btn_Fre.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // btn_Spn
            // 
            this.btn_Spn.Location = new System.Drawing.Point(78, 355);
            this.btn_Spn.Name = "btn_Spn";
            this.btn_Spn.Size = new System.Drawing.Size(129, 23);
            this.btn_Spn.TabIndex = 7;
            this.btn_Spn.Text = "Español(스페인어)";
            this.btn_Spn.UseVisualStyleBackColor = true;
            this.btn_Spn.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(407, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Rus
            // 
            this.btn_Rus.Location = new System.Drawing.Point(217, 355);
            this.btn_Rus.Name = "btn_Rus";
            this.btn_Rus.Size = new System.Drawing.Size(129, 23);
            this.btn_Rus.TabIndex = 9;
            this.btn_Rus.Text = "русский(러시아어)";
            this.btn_Rus.UseVisualStyleBackColor = true;
            this.btn_Rus.Click += new System.EventHandler(this.LangBtn_Click);
            // 
            // Frm_Language_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 618);
            this.Controls.Add(this.btn_Rus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Spn);
            this.Controls.Add(this.btn_Fre);
            this.Controls.Add(this.btn_Ger);
            this.Controls.Add(this.btn_Cht);
            this.Controls.Add(this.btn_Chs);
            this.Controls.Add(this.btn_Jpn);
            this.Controls.Add(this.btn_Eng);
            this.Controls.Add(this.btn_Kor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Language_Select";
            this.Text = "Frm_Language_Select";
            this.Load += new System.EventHandler(this.Frm_Language_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Kor;
        private System.Windows.Forms.Button btn_Eng;
        private System.Windows.Forms.Button btn_Jpn;
        private System.Windows.Forms.Button btn_Chs;
        private System.Windows.Forms.Button btn_Cht;
        private System.Windows.Forms.Button btn_Ger;
        private System.Windows.Forms.Button btn_Fre;
        private System.Windows.Forms.Button btn_Spn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Rus;
    }
}