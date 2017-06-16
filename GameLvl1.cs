using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace FireGame1
{
    public partial class GameLvl1 : Form
    {
        bool keyup , keydown, keyleft, keyright,keyspace;
        bool movdown, playwithkeyboard = true, music = true;
        bool inside;
        bool lvl2 = false;
        int score = 0;
        List<int> posofshoots,delposRockts,DelPosPlayerShoots;
        List<PictureBox> PlayerShoots,Shoots;
        List<int> moveLeft;
        int distmov = 1;

        System.Media.SoundPlayer gamesound = new System.Media.SoundPlayer();
        System.Media.SoundPlayer playershootsound = new System.Media.SoundPlayer();
        System.Media.SoundPlayer gameover = new System.Media.SoundPlayer();
        System.Media.SoundPlayer playerwinsound = new System.Media.SoundPlayer();

        public GameLvl1(bool p1,bool p2) // p1 for playwith keyboar  and p2 for play keyboard and p3 for sound
        {
            InitializeComponent();
            gamesound.SoundLocation = "Music.wav";
            gameover.SoundLocation = "gameover.wav";
            playerwinsound.SoundLocation = "You_win_sound_effect_5.wav";
            PlayerShoots = new List<PictureBox>();
            Shoots = new List<PictureBox>();
            posofshoots = new List<int>();
            delposRockts = new List<int>();
            DelPosPlayerShoots = new List<int>();
            moveLeft = new List<int>();
            playwithkeyboard = p1;
            music = p2;
            // initalize setting 

            if (music ==true)
                music1.BackColor = System.Drawing.Color.Lime;
            else
                music1.BackColor = System.Drawing.Color.WhiteSmoke;
            // play with keyboard
            if (playwithkeyboard == true)
                playewith.BackColor = System.Drawing.Color.Lime;
            else
                playewith.BackColor = System.Drawing.Color.WhiteSmoke;

            // create postions of Rockets with X start 12
            int f = 12;
            for (int i = 0; i < 8; i++)
            {
                posofshoots.Add(f);
                f += 87;
            }
        }
        private void GameLvl1_Load(object sender, EventArgs e)
        {
            if (music == true)
                gamesound.PlayLooping();
        }

        private void GameLvl1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void GameLvl1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    keyleft =false;
                    break;
                case Keys.Right:
                    keyright = false;
                    break;
                case Keys.Down:
                    keydown = false;
                    break;
                case Keys.Up:
                    keyup = false;
                    break;
                case Keys.Space:
                    keyspace = false;
                    break;
            }
        }

        private void GameLvl1_MouseLeave(object sender, EventArgs e)
        {
            inside = false;
        }

        private void GameLvl1_MouseEnter(object sender, EventArgs e)
        {
            inside = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Scoretxt.Text = "Score : " + score.ToString();
            if (score == 500)
            {
                distmov =2;
            }
            if (score == 1000)
            {
                distmov =3;
            }
            if (score == 1500)
            {
                distmov =4;
            }
            if (score == 2000)
            {
                distmov = 5;
            }
            if (score == 100&&lvl2==false)
            {
                lvl2 = true;
                Point p = new Point();
                p.X = 278;
                p.Y = 331;
                if(music)
                playerwinsound.Play();
                lvltwo.Location=p;
                lvltwo.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            if (playwithkeyboard)
            {
                if (keyleft)
                {
                    if (player.Left - 10 > 2)
                        player.Left -= 10;
                   // keyleft = false;
                }
                else if (keyright)
                {
                    if (player.Left + 10 < 709)
                        player.Left += 10;
                   // keyright = false;
                }
                else if (keyup)
                {
                    if (player.Top - 10 > 2)
                        player.Top -= 10;
                    //keyup = false;
                }
                else if (keydown)
                {
                    if (player.Top + 10 < 540)
                        player.Top += 10;
                    //keydown = false;
                }
                
            }
            else
            {
                if (inside && Cursor.Position.X - (player.Width + 10) * 2 > 2 && Cursor.Position.X - (player.Width + 10) * 2 < 709)
                    player.Left = Cursor.Position.X - (player.Width + 10) * 2;
                //if (Cursor.Position.X - Left - (player.Width / 2) >= 2 && Cursor.Position.X - Left - (player.Width / 2) < 709)
                //{
                //    if (Cursor.Position.Y - Top - 31 - (player.Height / 2) > 2 && Cursor.Position.Y - Top - 31 - (player.Height / 2) <540)
                //    player.Location = new Point(Cursor.Position.X - Left - (player.Width / 2), Cursor.Position.Y - Top - 31 - (player.Height / 2));

                //}
            }

            // move Shoots 
            for (int i = 0; i < Shoots.Count; i++)
            {
                Shoots[i].Top += distmov;
                if (lvl2) // move diagonal in lvl2 
                {
                    if (moveLeft[i] == 2) // move left
                    {
                        Shoots[i].Left -= distmov;
                        if (Shoots[i].Left <= -20)
                        {
                            moveLeft[i] = 3; // move right
                        }
                    }
                    else if(moveLeft[i]==3) // move right
                    {
                        Shoots[i].Left += 1;
                        if (Shoots[i].Left >= 768)
                        {
                            moveLeft[i] = 2; // move left
                        }
                    }
                }
            }
            for (int i = 0; i < PlayerShoots.Count; i++)
            {
                PlayerShoots[i].Top -= 5;
            }

            // Create New Shoot
            if (keyspace || movdown)
            {

               // playershootsound.Play();
               
                Point p = new Point();
                p = player.Location;
                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox",
                    Size = shootplayer.Size,
                    BackColor = shootplayer.BackColor,
                    Location = new Point(p.X+45, p.Y),
                    //  BackColor = System.Drawing.Color.Lime,
                    Image = shootplayer.Image,
                    SizeMode = shootplayer.SizeMode,
                };
                keyspace = false;
                movdown = false;
                this.Controls.Add(picture);
                PlayerShoots.Add(picture);
            }
            // Remove Shoots that hit 
            for (int i = 0; i < PlayerShoots.Count; i++)
            {
                for (int j = 0; j < Shoots.Count; j++)
                {
                    if (Shoots[j].Bounds.IntersectsWith(PlayerShoots[i].Bounds))
                    {
                        score += 10;
                        PlayerShoots[i].Visible = false;
                        Shoots[j].Visible = false;
                        this.Controls.Remove(Shoots[j]);
                        this.Controls.Remove(PlayerShoots[i]);
                        Shoots[j].Dispose();
                        PlayerShoots[i].Dispose();
                        PlayerShoots.RemoveAt(i);
                        Shoots.RemoveAt(j);
                        moveLeft.RemoveAt(j);
                        break;
                    }
                }
            }
            for (int j = 0; j < Shoots.Count; j++)
            {
                if (Shoots[j].Bounds.IntersectsWith(player.Bounds))
                {
                    Shoots[j].Visible = false;
                    this.Controls.Remove(Shoots[j]);
                    Shoots[j].Dispose();
                    Shoots.RemoveAt(j);
                    moveLeft.RemoveAt(j);
                    if(Health.Value>0)
                    Health.Value -= 25;
                    if (Health.Value == 0)
                    {
                        if (music)
                        {
                            gameover.Play();
                        }
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        Point p = new Point();
                        p.X = 278;
                        p.Y = 331;
                        gameover1.Location = p;
                        gameover1.Visible = true;
                    }
                    break;
                }
            }
            if (timer1.Enabled&&Health.Value == 0)
            {
                if (music)
                {
                    gameover.Play();
                }
                timer1.Enabled = false;
                timer2.Enabled = false;
                Point p = new Point();
                p.X = 278;
                p.Y = 331;
                gameover1.Location = p;
                gameover1.Visible = true;
            }
        }
        int c = 0;
        int prev1 = -1, prev2 = -1, prev3 = -1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            // create New Shoot in game every  sec 
           
            // Create Game Shoot
            Random rnd = new Random();
            int pos1,pos2,pos3;
            List<int> L = new List<int>();
            L.Add(prev1);
            L.Add(prev2);
            L.Add(prev3);
            L.Sort();
            while (true)
            {
                pos1 = rnd.Next(0, 8);
                pos2 = rnd.Next(0, 8);
                pos3 = rnd.Next(0, 8);
                List<int> L1 = new List<int>();
                L1.Add(pos1);
                L1.Add(pos2);
                L1.Add(pos3);
                if (pos1 != pos2 && pos2 != pos3 && pos1 != pos3)
                {
                    bool ok=true;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (L[i] == L1[j])
                                ok = false;
                        }
                    }
                    if(ok)
                        break;
                }
            }
            prev1 = pos1;
            prev2 = pos2;
            prev3 = pos3;
              PictureBox picture = new PictureBox
               {
                            Name = "pictureBox",
                            Size = shootgame.Size,
                            BackColor = shootgame.BackColor,
                            Location = new Point(posofshoots[pos1], 58),
                            //  BackColor = System.Drawing.Color.Lime,
                            Image = shootgame.Image,
                            SizeMode = shootgame.SizeMode,
                };
               this.Controls.Add(picture);
               Shoots.Add(picture);
               int r1 = rnd.Next(1, 4); // 1 for horz , 2 for left ,3 for right
               // lvl 2 of game
               if (lvl2 == true)
                  moveLeft.Add(r1);
                else
                   moveLeft.Add(1);
               if (lvl2)
               {
                   PictureBox picture1 = new PictureBox
                  {
                     Name = "pictureBox",
                     Size = shootgame2.Size,
                     BackColor = shootgame2.BackColor,
                     Location = new Point(posofshoots[pos2], 58),
                     //  BackColor = System.Drawing.Color.Lime,
                     Image = shootgame2.Image,
                     SizeMode = shootgame2.SizeMode,
                  };
                   this.Controls.Add(picture1);
                   Shoots.Add(picture1);

                   r1 = rnd.Next(1, 4); // 1 for horz , 2 for left ,3 for right
                   // lvl 2 of game
                   if (lvl2 == true)
                       moveLeft.Add(r1);
                   else
                       moveLeft.Add(1);
                   PictureBox picture2 = new PictureBox
                   {
                       Name = "pictureBox",
                       Size = shootgame3.Size,
                       BackColor = shootgame3.BackColor,
                       Location = new Point(posofshoots[pos3], 58),
                       //  BackColor = System.Drawing.Color.Lime,
                       Image = shootgame3.Image,
                       SizeMode = shootgame3.SizeMode,
                   };
                   this.Controls.Add(picture2);
                   Shoots.Add(picture2);
                   r1 = rnd.Next(1, 4); // 1 for horz , 2 for left ,3 for right
                   // lvl 2 of game
                   if (lvl2 == true)
                       moveLeft.Add(r1);
                   else
                       moveLeft.Add(1);
               }
            // determine objects that not in form and delete it
            if (Shoots.Count > 0)
            {
                timer2.Enabled = false;
                for (int i = 0; i < Shoots.Count; i++)
                {
                    if (Shoots[i].Top>640) // not in form
                    {
                        Shoots[i].Dispose();
                        Shoots.RemoveAt(i);
                        i = -1;
                        if(Health.Value>0)
                        Health.Value -= 25;
                    }
                }
                timer2.Enabled = true;
            }
            if (PlayerShoots.Count > 20)
            {
                timer2.Enabled = false;
                for (int i = 0; i < PlayerShoots.Count; i++)
                {
                    if (PlayerShoots[i].Top<23)
                    {
                        PlayerShoots[i].Dispose();
                        PlayerShoots.RemoveAt(i);
                        i = -1; // to start loop from first after remove
                        // MessageBox.Show(i.ToString());
                    }
                }
                timer2.Enabled = true;
            }
        }


        private void GameLvl1_MouseDown(object sender, MouseEventArgs e)
        {
            movdown = true;
        }

        private void GameLvl1_MouseUp(object sender, MouseEventArgs e)
        {
            movdown = false;
        }

        private void GameLvl1_KeyDown12(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("here ");
            switch (e.KeyCode)
            {
                case Keys.Left:
                    keyleft = true;
                    break;
                case Keys.Right:
                    keyright = true;
                    break;
                case Keys.Down:
                    keydown = true;
                    break;
                case Keys.Up:
                    keyup = true;
                    break;
                case Keys.Space:
                    keyspace = true;
                    break;
            }
        }

        private void GameStop(object sender, EventArgs e)
        {
            
            if(stopbtn.Text=="Stop"){
                stopbtn.Text = "Resume";
                
                timer2.Enabled = false;
                timer1.Enabled = false;
            }
            else {
                stopbtn.Text = "Stop";
                if (Health.Value > 0)
                {
                    timer2.Enabled = true;
                    timer1.Enabled = true;
                }
            } 
        }

        private void newgame(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            GameLvl1 g = new GameLvl1(playwithkeyboard,music);
            g.Show();
            this.Hide();
        }

        private void settingclc(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            timer2.Enabled=false;
            gameover1.Visible = false;
            setting1.Visible = true;
        }

        private void playewith_Click(object sender, EventArgs e)
        {
            if (playwithkeyboard == false)
            {
                playewith.BackColor = System.Drawing.Color.Lime;
                playwithkeyboard = true;
            }
            else
            {
                playewith.BackColor = System.Drawing.Color.WhiteSmoke;
                playwithkeyboard = false;
            }
        }

        private void music1_Click(object sender, EventArgs e)
        {
            if (music == false)
            {
                music1.BackColor = System.Drawing.Color.Lime;
                music = true;
                gamesound.PlayLooping();
            }
            else
            {
                music1.BackColor = System.Drawing.Color.WhiteSmoke;
                music = false;
                gamesound.Stop();
            }
        }

        private void backgame_Click(object sender, EventArgs e)
        {
            setting1.Visible = false;
            if (Health.Value == 0)
            {
                gameover1.Visible = true;
            }
            if (Health.Value > 0 && stopbtn.Text == "Stop")  // that sure game is not finisd and player not get game over
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void gotolvl2(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            if (music)
            {
                gamesound.PlayLooping();
            }
            lvltwo.Visible = false;
        }
    }

    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
    public class myButtonObject : UserControl
    {
        // Draw the new button. 
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            // Draw the button in the form of a circle
            graphics.DrawEllipse(myPen, 0, 0, 100, 100);
            myPen.Dispose();
        }
    }
}
