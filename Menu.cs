using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame1
{
    public partial class Menu : Form
    {
        bool mousedw = false;
        bool p1=true, p2=true;
        bool music1 = true;
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        public Menu(bool p11,bool p22)
        {
            p1 = p11;
            p2 = p22;
            InitializeComponent();
            player1.SoundLocation = "Menu.wav";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (p2)
                player1.Play();
            else player1.Stop();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedw = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedw = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedw)
            {
                this.Left = Cursor.Position.X - panel1.Width / 2;
                this.Top = Cursor.Position.Y - panel1.Height / 2;
            }
        }

        private void settingpag(object sender, EventArgs e)
        {
            Settingpage p = new Settingpage(p1,p2);
            p.Show();
            this.Hide();
        }
        private void gamelvl1(object sender, EventArgs e)
        {
            GameLvl1 g = new GameLvl1(p1,p2);
            player1.Stop();
            this.Hide();
            g.Show();
        }
    }
}
