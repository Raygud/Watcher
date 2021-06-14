using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Vimimportwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TF();
            MINI();
            DKtime();
        }

        private void DKtime()
        {
            DayOfWeek day = DateTime.Today.DayOfWeek;
            Console.WriteLine(day);
            string CPH = DateTime.Now.ToString(" M-d-yyyy HH.mm.ss");
            string LDN = DateTime.Now.AddHours(-1).ToString(" M-d-yyyy HH.mm.ss");
            string SGP = DateTime.Now.AddHours(2).ToString(" M-d-yyyy HH.mm.ss");
            label12.Text = day + CPH;
            label13.Text = day + LDN;
            label15.Text = day + SGP;

            String hour = DateTime.Now.ToString("HH");
            int a = Convert.ToInt32(hour);
            String hourLND = DateTime.Now.AddHours(-1).ToString("HH");
            int b = Convert.ToInt32(hourLND);
            String hourSGP = DateTime.Now.AddHours(2).ToString("HH");
            int c = Convert.ToInt32(hourSGP);


            if (a <= 07 && a >= 02)
            {
                label12.ForeColor = Color.Green;
            }
            else
            {
                label12.ForeColor = Color.Red;

            }
            if (a <= 07 && a >= 10)
            {
                label13.ForeColor = Color.Green;
            }
            else
            {

                label13.ForeColor = Color.Red;

            }
            if (a <= 07 && a >= 10)
            {
                label15.ForeColor = Color.Green;
            }
            else
            {

                label15.ForeColor = Color.Red;
            }

            timer1.Start();
        }



        private void TF()
        {
            InitializeComponent();
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();



            textBox1.Text = (ds.StockTemp().ToString("N2") + "°C");
                textBox2.Text = (ds.StockHumidity().ToString("N2") + "%");
                textBox3.Text = (ds.OutdoorTemp().ToString("N2") + "°C");
                textBox4.Text = (ds.OutdoorHumidity().ToString("N2") + "%");
            
        }

        private void MINI()
        {
            InitializeComponent();
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();
            


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            DayOfWeek day = DateTime.Today.DayOfWeek;
            Console.WriteLine(day);
            string CPH = DateTime.Now.ToString(" M-d-yyyy HH.mm.ss");
            string LDN = DateTime.Now.AddHours(-1).ToString(" M-d-yyyy HH.mm.ss");
            string SGP = DateTime.Now.AddHours(2).ToString(" M-d-yyyy HH.mm.ss");
            label12.Text = day + CPH;
            label13.Text = day + LDN;
            label15.Text = day + SGP;
            String hour = DateTime.Now.ToString("HH");
            int a = Convert.ToInt32(hour);
            String hourLND = DateTime.Now.AddHours(-1).ToString("HH");
            int b = Convert.ToInt32(hourLND);
            String hourSGP = DateTime.Now.AddHours(2).ToString("HH");
            int c = Convert.ToInt32(hourSGP);
            

            if (a <= 07 && a >= 02) 
            {
                    label12.ForeColor = Color.Green;
            }
            else
            {
                label12.ForeColor = Color.Red;
                
            }
            if (a <= 07 && a >= 10)
            {
                label13.ForeColor = Color.Green;
            }
            else
            {
                
                label13.ForeColor = Color.Red;
                
            }
            if (a <= 07 && a >= 10)
            {
                label15.ForeColor = Color.Green;
            }
            else
            {
                
                label15.ForeColor = Color.Red;
            }
            
            timer1.Start();
        }
       

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
