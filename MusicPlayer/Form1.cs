using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        bool playState = true;

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(104,104,104);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(104, 104, 104);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Black;
        }

        private void btnLibrary_MouseHover(object sender, EventArgs e)
        {
            btnLibrary.BackColor = Color.FromArgb(104, 104, 104);
        }

        private void btnLibrary_MouseLeave(object sender, EventArgs e)
        {
            btnLibrary.BackColor = Color.Black;
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (playState)
            {
                btnPlay.Text = "=";
                playState = false;
            }
   
            else
            {
                btnPlay.Text = ">";
                playState = true;
            }
        }

  
    }
}
