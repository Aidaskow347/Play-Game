using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.Beep_Sound);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Countinglabel_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            Countinglabel.Visible = true;
            Refresh();

            player.Play();

            Thread.Sleep(1250);
            Countinglabel.Text = "Counting Down From: 2";
            player.Play();
            Refresh();

            Thread.Sleep(1250);
            Countinglabel.Text = "Counting Down From: 1";
            player.Play();
            Refresh();

            Thread.Sleep(1250);
            player = new SoundPlayer(Properties.Resources.Ping_Sound);
            player.Play();
            Countinglabel.Text = "Go!!!";

            this.BackColor = Color.LimeGreen;
        }
    }
}
