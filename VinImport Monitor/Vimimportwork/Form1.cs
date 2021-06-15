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
            InitializeComponent();
            Environment();
            Lager();
            DKtime();
        }

        private void DKtime()
        {
            DayOfWeek day = DateTime.Today.DayOfWeek;
            Console.WriteLine(day);
            string CPH = DateTime.Now.ToString(" M-d-yyyy HH.mm.ss");
            string LDN = DateTime.Now.AddHours(-1).ToString(" M-d-yyyy HH.mm.ss");
            string SGP = DateTime.Now.AddHours(6).ToString(" M-d-yyyy HH.mm.ss");
            label12.Text = day + CPH;
            label13.Text = day + LDN;
            label15.Text = day + SGP;

            String hour = DateTime.Now.ToString("HH");
            int a = Convert.ToInt32(hour);
            String hourLND = DateTime.Now.AddHours(-1).ToString("HH");
            int b = Convert.ToInt32(hourLND);
            String hourSGP = DateTime.Now.AddHours(0).ToString("HH");
            int c = Convert.ToInt32(hourSGP);
            if (a >= 7 && a <= 16 )
            {
                label12.ForeColor = Color.Green;
            }
            else
            {
                label12.ForeColor = Color.Red;

            }
            if (b >= 8 && b <= 17)
            {
                label13.ForeColor = Color.Green;
            }
            else
            {

                label13.ForeColor = Color.Red;

            }
            if (c >= 9 && c <= 13)
            {
                label15.ForeColor = Color.Green;
            }


            if (c == 14 )
            {
                label15.ForeColor = Color.Red;
            }

            if (c >= 8 && c <= 17)
            {
                label15.ForeColor = Color.Green;
            }
            else
            {

                label15.ForeColor = Color.Red;
            }

        }



        private void Environment()
        {
            
            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();


            
            textBox1.Text = (ds.StockTemp().ToString("N2") + "°C");
                textBox2.Text = (ds.StockHumidity().ToString("N2") + "%");
                textBox3.Text = (ds.OutdoorTemp().ToString("N2") + "°C");
                textBox4.Text = (ds.OutdoorHumidity().ToString("N2") + "%");

            textBox1.ForeColor = Color.Red;


        }

        private void Lager()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();


            foreach (string line in ds.StockItemsUnderMin())
                listBox1.Items.Add(line);
            foreach (string line in ds.StockItemsOverMax())
                listBox2.Items.Add(line);
            foreach (string line in ds.StockItemsMostSold())
                listBox3.Items.Add(line.ToString());


        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {

            DKtime();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Environment();
            Lager();
        }


       

       
    }
}
