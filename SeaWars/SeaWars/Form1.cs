using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaWars
{
    public partial class Form1 : Form
    {
        User user;
        Enemy enemy;
        Field f;
        bool yourStep = true, EnemyStep = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            user = new User(pictureBox1.Width, pictureBox1.Height);
            enemy = new Enemy(pictureBox2.Width, pictureBox2.Height);
            pictureBox1.Image = user.getStartField();
            pictureBox2.Image = enemy.getStartField();
            timer1.Interval = 500;
            timer1.Enabled = true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (EnemyStep)
            {
                pictureBox1.Image = enemy.getEnemyStep();
                yourStep = true;
                EnemyStep = false;
            }
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            user.Matrix[(e.Location.X / user.sq), (e.Location.Y / user.sq)] = 1;
            pictureBox2.Image = user.getFieldNow();
            yourStep = false;
            EnemyStep = true;
        }
    }
}
