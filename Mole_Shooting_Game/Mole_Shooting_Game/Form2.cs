using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mole_Shooting_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random r = new Random();
      public  int scoreCount = 0;
       public int missShotCount = 0;
       public int totalShotCunt = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x;
            int y;

            x = r.Next(0, 700);
            y = r.Next(200, 300);
            pictureBox2.Location = new Point(x, y);

            if (missShotCount >= 10)
            {
                //this.label4.Enabled = false;
                //this.label6.Enabled = false;
                
              //  this.label4.Text = "SCORE:" + scoreCount;

                this.label1.Visible = true;
                this.label1.Text = "GAME OVER";
                Form3 f3 = new Form3();
                f3.Show();
              
                f3.SetLabelText(label4.Text, label5.Text, label6.Text, label1.Text);
                timer1.Stop();
                this.Close();

            }
            if (scoreCount == 5)
            {
                
                this.label1.Visible = true;
                this.label1.Text = "CONGRATULATIONS! YOU WIN";
                Form3 f3 = new Form3();
                f3.Show();
             

                f3.button1.Text = "MAIN";
                f3.SetLabelText(label4.Text, label5.Text, label6.Text, label1.Text);
                timer1.Stop();
                this.Close();
            }
        }
        
        public void Score_Count()
        {
            scoreCount++;
            this.label4.Text = "SCORE:  "+scoreCount;

            totalShotCunt++;
            this.label6.Text = "TOTAL SHOT: " + totalShotCunt;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"E:\EducAtion Docs\Semester 3\ViSuAl ProgrAmming\shot2.wav");
            player.Play();
        }

        private void Miss_Shot_Count()
        {
            missShotCount++;
            this.label5.Text = "MISS SHOT:  " + missShotCount;

            totalShotCunt++;
            this.label6.Text = "TOTAL SHOT: " + totalShotCunt;


            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"E:\EducAtion Docs\Semester 3\ViSuAl ProgrAmming\shot.wav");
            player1.Play();

            
        }
       /* private void Total_Shot_Count()
        {
            Score_Count();
            Miss_Shot_Count();
            totalShotCunt++;
            this.label6.Text = "=" + totalShotCunt;
            
        }*/

       /* private void gameMusic1()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\mishAlemAn\Downloads\shot2.wav");
            player.Play();
        
        }

        private void gameMusic2()
        { 
        
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\mishAlemAn\Downloads\shot.wav");
            player1.Play();
        }*/
        
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            this.label1.Visible = false;
            this.label4.Text = "SCORE:";
            this.label5.Text = "MISS SHOTS:";
            this.label6.Text = "TOTAL SHOTS:";
            this.button1.Text = "RESTART";
            this.button2.Text = "EXIT";
            this.button3.Text = "BACK";

            this.label1.BackColor = Color.Fuchsia;
            this.label4.BackColor = Color.Fuchsia;
            this.label5.BackColor = Color.Fuchsia;
            this.label6.BackColor = Color.Fuchsia;
            this.button1.BackColor = Color.Fuchsia;
            this.button2.BackColor = Color.Fuchsia;
            this.button3.BackColor = Color.Fuchsia;

            this.button1.Cursor = Cursors.Hand;
            this.button2.Cursor = Cursors.Hand;
            this.button3.Cursor = Cursors.Hand;

           // System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\mishAlemAn\Downloads\music3.wav");
           // player.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Score_Count();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            scoreCount = 0;
            missShotCount = 0;
            totalShotCunt = 0;

            this.label4.Text = "SCORE:  " + scoreCount;
            this.label5.Text = "MISS SHOT:  " + missShotCount;
            this.label6.Text = "TOTAL SHOT: " + totalShotCunt;
            this.label1.Text = "";

            timer1.Start();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            Miss_Shot_Count();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          /*  System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\mishAlemAn\Downloads\shot2.wav");
            player.Stop();

            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\mishAlemAn\Downloads\shot.wav");
            player1.Stop();*/
        }
    }
}
