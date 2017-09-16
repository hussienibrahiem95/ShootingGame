using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // to use DllImport

namespace FireGame1
{
    public partial class loading : Form
    {
        int val = 0;
        public loading()
        {
            InitializeComponent();
            ModifyProgressBarColor.SetState(progressBar1, 2);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = val;
            val += 2;
            if (val>=101)
            {
                timer1.Enabled = false;
                Menu m = new Menu(true,true);
                this.Hide();
                m.Show();
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }
    }
    // to change color of prograss 
    static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
