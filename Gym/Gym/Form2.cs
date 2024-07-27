using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Form2 : Form
    {
        int code = 0;
        
        

        int ch = 0;
        int ch1 = 0;
        int ch2 = 0;
        int ch3 = 0;
        int ch4 = 0;
        int ch5 = 0;
        int ch6 = 0;
        int ch7 = 0;
        int ch8 = 0;
        int ch9 = 0;

        int num = 0;
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;
        int num7 = 0;
        int num8 = 0;
        int num9 = 0;


        DBGymEntities dats = new DBGymEntities();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             
            if (checkBox1.Checked==true)
            {
                
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch = a;
                return;
            }
             if (checkBox1.Checked == false)
            {
                numericUpDown1.Value = 1;
                ch = 0;
                return;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value>1)
            {
                checkBox1.Checked = true;
                int a = Convert.ToInt32(numericUpDown1.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num = b * a;
                num = num - b;
                return;
            }
             if(numericUpDown1.Value==1)
            {
                num = 0;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(num1 + num + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + ch2 + ch3 + ch4 + ch5 + ch6 + ch7 + ch8 + ch9 + ch + ch1);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch1 = a + ch1;
                return;
            }
             if (checkBox2.Checked == false)
            {
                numericUpDown2.Value = 1;
                ch1 = 0;
                return;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 1)
            {
                checkBox2.Checked = true;
                int a = Convert.ToInt32(numericUpDown2.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num1 = b * a;
                num1 = num1 - b;
                return;
            }
             if (numericUpDown2.Value == 1)
            {
                num1 = 0;
                return;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 1)
            {
                checkBox3.Checked = true;
                int a = Convert.ToInt32(numericUpDown3.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num2 = b * a;
                num2 = num2 - b;
                return;
            }
            if (numericUpDown3.Value == 1)
            {
                num2 = 0;
                return;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 1)
            {
                checkBox4.Checked = true;
                int a = Convert.ToInt32(numericUpDown4.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num3 = b * a;
                num3 = num3 - b;
                return;
            }
            if (numericUpDown4.Value == 1)
            {
                num3 = 0;
                return;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value > 1)
            {
                checkBox5.Checked = true;
                int a = Convert.ToInt32(numericUpDown5.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num4 = b * a;
                num4 = num4 - b;
                return;
            }
            if (numericUpDown5.Value == 1)
            {
                num4 = 0;
                return;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value > 1)
            {
                checkBox6.Checked = true;
                int a = Convert.ToInt32(numericUpDown6.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num5 = b * a;
                num5 = num5 - b;
                return;
            }
            if (numericUpDown6.Value == 1)
            {
                num5 = 0;
                return;
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown7.Value > 1)
            {
                checkBox7.Checked = true;
                int a = Convert.ToInt32(numericUpDown7.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num6 = b * a;
                num6 = num6 - b;
                return;
            }
            if (numericUpDown7.Value == 1)
            {
                num6 = 0;
                return;
            }
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown8.Value > 1)
            {
                checkBox8.Checked = true;
                int a = Convert.ToInt32(numericUpDown8.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num7 = b * a;
                num7 = num7 - b;
                return;
            }
            if (numericUpDown8.Value == 1)
            {
                num7 = 0;
                return;
            }
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown9.Value > 1)
            {
                checkBox9.Checked = true;
                int a = Convert.ToInt32(numericUpDown9.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num8 = b * a;
                num8 = num8 - b;
                return;
            }
            if (numericUpDown9.Value == 1)
            {
                num8 = 0;
                return;
            }
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown10.Value > 1)
            {
                checkBox10.Checked = true;
                int a = Convert.ToInt32(numericUpDown10.Value);
                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int b = Convert.ToInt32(q.Price);
                num9 = b * a;
                num9 = num9 - b;
                return;
            }
            if (numericUpDown10.Value == 1)
            {
                num9 = 0;
                return;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch2 = a + ch2;
                return;
            }
            if (checkBox3.Checked == false)
            {
                numericUpDown3.Value = 1;
                ch2 = 0;
                return;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch3 = a + ch3;
                return;
            }
            if (checkBox4.Checked == false)
            {
                numericUpDown4.Value = 1;
                ch3 = 0;
                return;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch4 = a + ch4;
                return;
            }
            if (checkBox5.Checked == false)
            {
                numericUpDown5.Value = 1;
                ch4 = 0;
                return;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch5 = a + ch5;
                return;
            }
            if (checkBox6.Checked == false)
            {
                numericUpDown6.Value = 1;
                ch5 = 0;
                return;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch6 = a + ch6;
                return;
            }
            if (checkBox7.Checked == false)
            {
                numericUpDown7.Value = 1;
                ch6 = 0;
                return;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch7 = a + ch7;
                return;
            }
            if (checkBox8.Checked == false)
            {
                numericUpDown8.Value = 1;
                ch7 = 0;
                return;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch8 = a + ch8;
                return;
            }
            if (checkBox9.Checked == false)
            {
                numericUpDown9.Value = 1;
                ch8 = 0;
                return;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {

                code = 1;
                var q = (from oz in dats.tblTarakoneshes where oz.ID == code select oz).SingleOrDefault();
                int a = Convert.ToInt32(q.Price);
                ch9 = a + ch9;
                return;
            }
            if (checkBox10.Checked == false)
            {
                numericUpDown10.Value = 1;
                ch9 = 0;
                return;
            }
        }

        private void bb(int n)
        {
            int sum = 0;
            for ( int i = 1; i <= n; i++ )
            {
                if(n%i==0)
                {
                    sum += i;
                }
            }
            int aa = 0;
            aa = Convert.ToInt32(textBox2.Text);
            
            if (sum-aa ==Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("عدد" + aa + "کامل است");
            }
            else
            {
                MessageBox.Show("عدد کامل نیست");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
          bb(int.Parse(textBox2.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
