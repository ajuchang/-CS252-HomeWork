using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            RedButton.Visible = false;
            YellowButton.BackColor = Color.WhiteSmoke;
            YellowButton.Text = "你是男生";
            GreenButton.BackColor = Color.WhiteSmoke;
            GreenButton.Text = "你是女生";

            Choice();
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            YellowButton.Visible = false;

            RedButton.BackColor = Color.WhiteSmoke;
            RedButton.Text = "您心情好";
            GreenButton.BackColor = Color.WhiteSmoke;
            GreenButton.Text = "你心情不好";
            Choice();
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            GreenButton.Visible = false;
            RedButton.BackColor = Color.WhiteSmoke;
            RedButton.Text = "你喜歡郊遊";
            YellowButton.BackColor = Color.WhiteSmoke;
            YellowButton.Text = "你喜歡看書";

            Choice();
        }

        public void Choice()
        {
            string PicUrl = Application.StartupPath;
            ShowPicture.Visible = true;

            if (RedButton.Visible == false && YellowButton.Visible == false && GreenButton.Visible == true)
            {
                ShowPicture.Image = Image.FromFile(PicUrl + "\\Happy.PNG");
            }
            else if (RedButton.Visible == false && YellowButton.Visible == true && GreenButton.Visible == false)
            {
                ShowPicture.Image = Image.FromFile(PicUrl + "\\Read.PNG");
            }
            else if (RedButton.Visible == true && YellowButton.Visible == false && GreenButton.Visible == false)
            {
                ShowPicture.Image = Image.FromFile(PicUrl + "\\Travel.PNG");
            }
        }
    }
}