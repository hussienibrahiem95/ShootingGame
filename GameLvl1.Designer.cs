namespace FireGame1
{
    partial class GameLvl1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLvl1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Scoretxt = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.playewith = new System.Windows.Forms.Button();
            this.music1 = new System.Windows.Forms.Button();
            this.setting1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.shootgame3 = new System.Windows.Forms.PictureBox();
            this.shootgame2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.shootgame = new System.Windows.Forms.PictureBox();
            this.shootplayer = new System.Windows.Forms.PictureBox();
            this.gameover1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lvltwo = new System.Windows.Forms.Panel();
            this.roundButton2 = new FireGame1.RoundButton();
            this.roundButton1 = new FireGame1.RoundButton();
            this.stopbtn = new FireGame1.RoundButton();
            this.panel1.SuspendLayout();
            this.setting1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shootgame3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootgame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootgame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootplayer)).BeginInit();
            this.gameover1.SuspendLayout();
            this.lvltwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Scoretxt
            // 
            this.Scoretxt.AutoSize = true;
            this.Scoretxt.BackColor = System.Drawing.Color.Transparent;
            this.Scoretxt.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretxt.ForeColor = System.Drawing.Color.Red;
            this.Scoretxt.Location = new System.Drawing.Point(15, 7);
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.Size = new System.Drawing.Size(144, 39);
            this.Scoretxt.TabIndex = 1;
            this.Scoretxt.Text = "Score : 0";
            // 
            // Health
            // 
            this.Health.BackColor = System.Drawing.Color.Blue;
            this.Health.ForeColor = System.Drawing.Color.Red;
            this.Health.Location = new System.Drawing.Point(15, 58);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(379, 30);
            this.Health.TabIndex = 2;
            this.Health.Value = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Controls.Add(this.stopbtn);
            this.panel1.Controls.Add(this.Scoretxt);
            this.panel1.Controls.Add(this.Health);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 100);
            this.panel1.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // playewith
            // 
            this.playewith.BackColor = System.Drawing.Color.Lime;
            this.playewith.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playewith.Location = new System.Drawing.Point(377, 46);
            this.playewith.Name = "playewith";
            this.playewith.Size = new System.Drawing.Size(67, 44);
            this.playewith.TabIndex = 13;
            this.playewith.UseVisualStyleBackColor = false;
            this.playewith.Click += new System.EventHandler(this.playewith_Click);
            // 
            // music1
            // 
            this.music1.BackColor = System.Drawing.Color.Lime;
            this.music1.Location = new System.Drawing.Point(377, 175);
            this.music1.Name = "music1";
            this.music1.Size = new System.Drawing.Size(67, 44);
            this.music1.TabIndex = 11;
            this.music1.UseVisualStyleBackColor = false;
            this.music1.Click += new System.EventHandler(this.music1_Click);
            // 
            // setting1
            // 
            this.setting1.BackColor = System.Drawing.Color.Black;
            this.setting1.Controls.Add(this.button4);
            this.setting1.Controls.Add(this.music1);
            this.setting1.Controls.Add(this.playewith);
            this.setting1.Controls.Add(this.button2);
            this.setting1.Controls.Add(this.button5);
            this.setting1.Location = new System.Drawing.Point(207, 108);
            this.setting1.Name = "setting1";
            this.setting1.Size = new System.Drawing.Size(577, 310);
            this.setting1.TabIndex = 14;
            this.setting1.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(196, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.backgame_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(38, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 62);
            this.button2.TabIndex = 10;
            this.button2.Text = "Music";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(38, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 82);
            this.button5.TabIndex = 12;
            this.button5.Text = "Play With Keyboard";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // shootgame3
            // 
            this.shootgame3.BackColor = System.Drawing.Color.Transparent;
            this.shootgame3.Image = global::FireGame1.Properties.Resources._148347294786134__2_;
            this.shootgame3.InitialImage = global::FireGame1.Properties.Resources.a10002;
            this.shootgame3.Location = new System.Drawing.Point(740, 543);
            this.shootgame3.Margin = new System.Windows.Forms.Padding(0);
            this.shootgame3.Name = "shootgame3";
            this.shootgame3.Size = new System.Drawing.Size(80, 53);
            this.shootgame3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shootgame3.TabIndex = 16;
            this.shootgame3.TabStop = false;
            this.shootgame3.Visible = false;
            // 
            // shootgame2
            // 
            this.shootgame2.BackColor = System.Drawing.Color.Transparent;
            this.shootgame2.Image = global::FireGame1.Properties.Resources._148347294786134__1_;
            this.shootgame2.InitialImage = global::FireGame1.Properties.Resources.a10002;
            this.shootgame2.Location = new System.Drawing.Point(664, 543);
            this.shootgame2.Margin = new System.Windows.Forms.Padding(0);
            this.shootgame2.Name = "shootgame2";
            this.shootgame2.Size = new System.Drawing.Size(57, 52);
            this.shootgame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shootgame2.TabIndex = 15;
            this.shootgame2.TabStop = false;
            this.shootgame2.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::FireGame1.Properties.Resources.Ship5;
            this.player.Location = new System.Drawing.Point(367, 529);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(123, 154);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // shootgame
            // 
            this.shootgame.BackColor = System.Drawing.Color.Transparent;
            this.shootgame.Image = global::FireGame1.Properties.Resources._148347294786134;
            this.shootgame.InitialImage = global::FireGame1.Properties.Resources.a10002;
            this.shootgame.Location = new System.Drawing.Point(587, 543);
            this.shootgame.Margin = new System.Windows.Forms.Padding(0);
            this.shootgame.Name = "shootgame";
            this.shootgame.Size = new System.Drawing.Size(49, 45);
            this.shootgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shootgame.TabIndex = 4;
            this.shootgame.TabStop = false;
            this.shootgame.Visible = false;
            // 
            // shootplayer
            // 
            this.shootplayer.BackColor = System.Drawing.Color.Transparent;
            this.shootplayer.Image = global::FireGame1.Properties.Resources.rockets_PNG13272;
            this.shootplayer.Location = new System.Drawing.Point(412, 450);
            this.shootplayer.Margin = new System.Windows.Forms.Padding(0);
            this.shootplayer.Name = "shootplayer";
            this.shootplayer.Size = new System.Drawing.Size(28, 77);
            this.shootplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shootplayer.TabIndex = 5;
            this.shootplayer.TabStop = false;
            this.shootplayer.Visible = false;
            // 
            // gameover1
            // 
            this.gameover1.Controls.Add(this.label1);
            this.gameover1.Location = new System.Drawing.Point(26, 450);
            this.gameover1.Name = "gameover1";
            this.gameover1.Size = new System.Drawing.Size(248, 114);
            this.gameover1.TabIndex = 14;
            this.gameover1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over";
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::FireGame1.Properties.Resources.blog_test_background_bright;
            this.button6.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Image = global::FireGame1.Properties.Resources.Game_Scenes__1_;
            this.button6.Location = new System.Drawing.Point(58, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 63);
            this.button6.TabIndex = 1;
            this.button6.Text = "Lvl 2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.gotolvl2);
            // 
            // lvltwo
            // 
            this.lvltwo.Controls.Add(this.button6);
            this.lvltwo.Location = new System.Drawing.Point(29, 569);
            this.lvltwo.Name = "lvltwo";
            this.lvltwo.Size = new System.Drawing.Size(248, 114);
            this.lvltwo.TabIndex = 17;
            this.lvltwo.Visible = false;
            // 
            // roundButton2
            // 
            this.roundButton2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.Location = new System.Drawing.Point(682, 0);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(117, 97);
            this.roundButton2.TabIndex = 19;
            this.roundButton2.TabStop = false;
            this.roundButton2.Text = "Setting";
            this.roundButton2.UseVisualStyleBackColor = true;
            this.roundButton2.Click += new System.EventHandler(this.settingclc);
            // 
            // roundButton1
            // 
            this.roundButton1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Location = new System.Drawing.Point(554, 0);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(117, 97);
            this.roundButton1.TabIndex = 18;
            this.roundButton1.TabStop = false;
            this.roundButton1.Text = "New Game";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.newgame);
            // 
            // stopbtn
            // 
            this.stopbtn.BackColor = System.Drawing.Color.Black;
            this.stopbtn.FlatAppearance.BorderSize = 0;
            this.stopbtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbtn.ForeColor = System.Drawing.Color.Blue;
            this.stopbtn.Location = new System.Drawing.Point(426, 3);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(110, 94);
            this.stopbtn.TabIndex = 18;
            this.stopbtn.TabStop = false;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.GameStop);
            // 
            // GameLvl1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(832, 683);
            this.Controls.Add(this.lvltwo);
            this.Controls.Add(this.shootgame3);
            this.Controls.Add(this.gameover1);
            this.Controls.Add(this.shootgame2);
            this.Controls.Add(this.setting1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.shootgame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shootplayer);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameLvl1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameLvl1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameLvl1_FormClosed);
            this.Load += new System.EventHandler(this.GameLvl1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameLvl1_KeyDown12);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameLvl1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameLvl1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.GameLvl1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.GameLvl1_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameLvl1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.setting1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shootgame3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootgame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootgame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootplayer)).EndInit();
            this.gameover1.ResumeLayout(false);
            this.gameover1.PerformLayout();
            this.lvltwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Scoretxt;
        private System.Windows.Forms.ProgressBar Health;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox shootgame;
        private System.Windows.Forms.PictureBox shootplayer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button playewith;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button music1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel setting1;
        private System.Windows.Forms.PictureBox shootgame2;
        private System.Windows.Forms.PictureBox shootgame3;
        private System.Windows.Forms.Panel gameover1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel lvltwo;
        private RoundButton stopbtn;
        private RoundButton roundButton2;
        private RoundButton roundButton1;

    }
}