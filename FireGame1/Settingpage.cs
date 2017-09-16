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
    public partial class Settingpage : Form
    {
        bool wmusic = true, wkeyboard = true;
        bool mousedw = false;
        public Settingpage(bool p1,bool p2)
        {
           // MessageBox.Show(p2.ToString());
            wkeyboard = p1;
            wmusic = p2;
           
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
          //  mousedw = true;
        }
        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mousedw = false;
        }
        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mousedw==true)
            {
                this.Left = Cursor.Position.X - panel1.Width / 2;
                this.Top = Cursor.Position.Y - panel1.Height / 2;
            }
        }

        private void backTomain(object sender, EventArgs e)
        {
            Menu m = new Menu(wkeyboard,wmusic);
            m.Show();
            this.Hide();
        }
        private void musicclic(object sender, EventArgs e)
        {
            if (wmusic == false)
            {
                music1.BackColor = System.Drawing.Color.Lime;
                wmusic = true;
            }
            else
            {
                music1.BackColor = System.Drawing.Color.WhiteSmoke;
                wmusic = false;
            }
        }

        private void playewith_Click(object sender, EventArgs e)
        {
            if (wkeyboard == false)
            {
                playewith.BackColor = System.Drawing.Color.Lime;
                wkeyboard = true;
            }
            else
            {
                playewith.BackColor = System.Drawing.Color.WhiteSmoke;
                wkeyboard = false;
            }
        }

        private void Settingpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Settingpage_Load(object sender, EventArgs e)
        {
            if (wmusic == true)
                music1.BackColor = System.Drawing.Color.Lime;
            else
                music1.BackColor = System.Drawing.Color.WhiteSmoke;
            //play with keyboard
            if (wkeyboard == true)
                playewith.BackColor = System.Drawing.Color.Lime;
            else
                playewith.BackColor = System.Drawing.Color.WhiteSmoke;
        }
    }
}
