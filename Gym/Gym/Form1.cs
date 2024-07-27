using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void ribbonBar2_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            Frmsabtename fsn = new Frmsabtename();
            fsn.ShowDialog();
        }

        private void btnmaneg_Click(object sender, EventArgs e)
        {
            modiriat mdt = new modiriat();
            mdt.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            analogClockControl1.Value = System.DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            analogClockControl1.Value = System.DateTime.Now;
            DateTime day = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            lblsall.Text = pc.GetYear(day).ToString("0000");
            lblmahh.Text = pc.GetMonth(day).ToString("00");
            lbldayy.Text = pc.GetDayOfMonth(day).ToString("00");
            switch(pc.GetDayOfWeek(day).ToString())
            {
                case "Saturday":
                    {
                        lblday.Text = "شنبه";
                        break;
                    }
                case "Sunday":
                    {
                        lblday.Text = "یکشنبه";
                        break;
                    }
                case "Monday":
                    {
                        lblday.Text = "دوشنبه";
                        break;
                    }
                case "Tusday":
                    {
                        lblday.Text = "سه شنبه";
                        break;
                    }
                case "Wednesday":
                    {
                        lblday.Text = "چهارشنبه";
                        break;
                    }
                case "Thursday":
                    {
                        lblday.Text = "پنج شنبه";
                        break;
                    }
                case "Friday":
                    {
                        lblday.Text = "جمعه";
                        break;
                    }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            frmmessag fm = new frmmessag();
            fm.Text = "خروج از نرم افزار";
            fm.lbltext.Text = "ایا از خروج اطمینان دارید؟";
            fm.picyes.Visible = true;
            fm.picno.Visible = true;
            fm.ShowDialog();
            if(fm.mriz == true)
            {
                Application.Exit();
            }
        }

        private void btnsavabeg_Click(object sender, EventArgs e)
        {
            frmsavabegh fm = new frmsavabegh();
            fm.ShowDialog();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Form2 ft = new Form2();
            ft.ShowDialog();
        }

        private void analogClockControl1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
