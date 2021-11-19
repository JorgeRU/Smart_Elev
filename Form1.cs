using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_81
{
    public partial class Form1 : Form
    {
        bool t1,t2,t3,t4;
        int Est=0;
        int broke;
        int i;
        public Form1()
        {
            InitializeComponent();
            t4 = false;
            broke = 0;
            Est = 0;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        private void timer2_Tick(object sender, EventArgs e)
        {
            t2 = true;
            if (i > 234)
            {
                i--;
                panel1.Location = new Point(300, i);
            }

            else if (i < 234)
            {
                i++;
                panel1.Location = new Point(300, i);
            }
            else if (i == 234)
            {
                Est = 2;
                timer2.Stop();
            }



        }

        private void button7_Click(object sender, EventArgs e)
        {

            timer4.Start();

            if (Est == 0)
            {
                i = 350;
            }

           else if (Est == 2)
            {
                i = 234;
            }

            else if (Est == 3)
            {
                i = 127;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (i > 127)
            { 
                i--;
                panel1.Location = new Point(300, i);
            }

            else if (i < 127)
            {
                i++;
                panel1.Location = new Point(300, i);
            }
            else if (i == 127)
            {
                Est = 3;
                timer3.Stop();
            }



        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Start();

            if (Est == 0)
            {
                 i = 350;
            }

            else if (Est == 3) 
            {
                i = 124;
            
            }
            else if (Est == 4)
            {
                i = 17;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer3.Start(); 

            if (Est == 0)
            {
                i = 350;
            }

            else if (Est == 2)
            {
                i = 234;
            }

            else if (Est == 4)
            {
                i = 17;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            t4 = true;

            if (i > 17)
            {
                i--;
                panel1.Location = new Point(300, i);
            }
            else if (i == 17)
            {
                Est = 4;
                timer4.Stop();
                t4 = false;
                
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            timer3.Start();
          
            if (t4 == true)
            {
                timer4.Stop();

                for (i = 234; i > 127; i--)
                {
                    panel1.Location = new Point(300, i);
                    System.Threading.Thread.Sleep(10);
                   
                }
                System.Threading.Thread.Sleep(1500);

                timer4.Start();
            }



          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer4.Start();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer3.Start();

            if (t1 == true)
            {
                timer1.Stop();

                for (i = 60; i < 127; i++)
                {
                    panel1.Location = new Point(300, i);
                    System.Threading.Thread.Sleep(10);

                }
                System.Threading.Thread.Sleep(10000);

                timer1.Start();
            }
            else if (t2 == true)
            {
                timer2.Stop();

                for (i = 60; i < 127; i++)
                {
                    panel1.Location = new Point(300, i);
                    System.Threading.Thread.Sleep(10);

                }
                System.Threading.Thread.Sleep(1500);

                timer2.Start();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();

            if (t4 == true)
            {
                timer4.Stop();

                for (i =300 ; i > 234; i--)
                {
                    panel1.Location = new Point(300, i);
                    System.Threading.Thread.Sleep(10);

                }

                System.Threading.Thread.Sleep(2000);

                timer4.Start();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Start();

            if (t1 == true)
            {
                timer1.Stop();

                for (i = 150; i < 234; i++)
                {
                    panel1.Location = new Point(300, i);
                    System.Threading.Thread.Sleep(10);

                }
                System.Threading.Thread.Sleep(1500);

                timer1.Start();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t1 = true;
            if (i<345)
            {
                i++;
                panel1.Location = new Point(300, i);
            }
            else if (i == 345)
            {
                Est = 0;
                timer1.Stop();
                t1 = false;
            }
        }
    }
}
