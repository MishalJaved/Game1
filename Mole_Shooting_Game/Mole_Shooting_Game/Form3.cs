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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            this.label1.Text = "SCORE";
            this.label2.Text = "MISS SHOT";
            this.label3.Text = "TOTAL SHOT";

            this.label1.BackColor = Color.LightPink;
            this.label2.BackColor = Color.LightPink;
            this.label3.BackColor = Color.LightPink;
            this.label4.BackColor = Color.LightPink;
            this.button1.BackColor = Color.LightPink;
           

            this.button1.Text="TRY AGAIN!";
            

           /* Form2 f2 = new Form2();
            f2.scoreCount++;
            this.textBox1.Text = f2.scoreCount.ToString();
            */
            //f2.scoreCount++;
           // scorecount2();
           // this.label1.Text ="score"+ f2.scoreCount;
           /* int a;
            a = f2.scoreCount;
            this.label1.Text = Convert.ToString(a);
          */

        }
        internal void SetLabelText(string p1, string p2, string p3,string p4)
        {
            label1.Text = p1;
            label2.Text = p2;
            label3.Text = p3;
            label4.Text = p4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        internal void SetLabelText2(string q1, string q2, string q3, string q4)
        {
            label1.Text = q1;
            label2.Text = q2;
            label3.Text = q3;
            label4.Text = q4;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();

           
        }
    }
}
