namespace FireGame1
{
    partial class Settingpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settingpage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.playewith = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.music1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FireGame1.Properties.Resources.imageedit_4_6033230938;
            this.panel1.Controls.Add(this.playewith);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.music1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(156, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 561);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // playewith
            // 
            this.playewith.BackColor = System.Drawing.Color.Lime;
            this.playewith.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playewith.Location = new System.Drawing.Point(370, 290);
            this.playewith.Name = "playewith";
            this.playewith.Size = new System.Drawing.Size(67, 44);
            this.playewith.TabIndex = 7;
            this.playewith.UseVisualStyleBackColor = false;
            this.playewith.Click += new System.EventHandler(this.playewith_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(50, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 82);
            this.button5.TabIndex = 6;
            this.button5.Text = "Play With Keyboard";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // music1
            // 
            this.music1.BackColor = System.Drawing.Color.Lime;
            this.music1.Location = new System.Drawing.Point(370, 190);
            this.music1.Name = "music1";
            this.music1.Size = new System.Drawing.Size(67, 44);
            this.music1.TabIndex = 5;
            this.music1.UseVisualStyleBackColor = false;
            this.music1.Click += new System.EventHandler(this.musicclic);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(50, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Music";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(181, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.backTomain);
            // 
            // Settingpage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 583);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settingpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settingpage";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settingpage_FormClosed);
            this.Load += new System.EventHandler(this.Settingpage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button music1;
        private System.Windows.Forms.Button playewith;
        private System.Windows.Forms.Button button5;
    }
}