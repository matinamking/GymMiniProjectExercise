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
    public partial class Frmsabtename : Form
    {
        DBGymEntities data = new DBGymEntities();
        public Frmsabtename()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmsabtename_Load(object sender, EventArgs e)
        {
            int a;
            for (a = 1; a <= 31; a++) 
            {
                cmbday.Items.Add(a.ToString());
            }
            for (a = 1; a <= 12; a++) 
            {
                cmbmah.Items.Add(a.ToString());
            }
            for (a = 1300; a <= 1500; a++) 
            {
                cmbsall.Items.Add(a.ToString());
            }


            for (a = 1; a <= 31; a++)
            {
               cmddaysabt.Items.Add(a.ToString());
            }
            for (a = 1; a <= 12; a++)
            {
                cmdmahsabt.Items.Add(a.ToString());
            }
            for (a = 1300; a <= 1500; a++)
            {
                cmdsalsabt.Items.Add(a.ToString());
            }


            for (a = 1; a <= 31; a++)
            {
                cmddayetebar.Items.Add(a.ToString());
            }
            for (a = 1; a <= 12; a++)
            {
                cmdmahetebar.Items.Add(a.ToString());
            }
            for (a = 1300; a <= 1500; a++)
            {
                cmdsalletebar.Items.Add(a.ToString());
            }


            cmbday.SelectedIndex = 0;
            cmbmah.SelectedIndex = 0;
            cmbsall.SelectedIndex = 0;

            cmddaysabt.SelectedIndex = 0;
            cmdmahsabt.SelectedIndex = 0;
            cmdsalsabt.SelectedIndex = 0;

            cmddayetebar.SelectedIndex = 0;
            cmdmahetebar.SelectedIndex = 0;
            cmdsalletebar.SelectedIndex = 0;

        }

        private void cmbsall_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void picadd_Click(object sender, EventArgs e)
        {
            DateTime ti = DateTime.Today;
            PersianCalendar ph = new PersianCalendar();
            int dey = ph.GetDayOfMonth(ti);
            cmddaysabt.SelectedIndex = dey - 1;

            int mah = ph.GetMonth(ti);
            cmdmahsabt.SelectedIndex = mah - 1;

            int sall = ph.GetYear(ti);
            cmdsalsabt.SelectedIndex = sall - 1300;
            picaks.LoadAsync(Application.StartupPath + "\\pic");
            groupPanel3.Enabled = true;
            groupPanel1.Enabled = true;
            picadd.Enabled = false;
            picsave.Enabled = true;
            piccancele.Enabled = true;
            textname.Text = "";
            textname.Focus();
        }

        private void picsave_Click(object sender, EventArgs e)
        {
            if(textname.Text=="")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
            {
                tblUser username = new tblUser();
                username.Name = textname.Text;
                username.BirthDate = cmbsall.Text + "/" + cmbmah.Text + "/" + cmbday.Text;
                username.EtebarDate = cmdsalletebar.Text + "/" + cmdmahetebar.Text + "/" + cmddayetebar.Text;
                username.OzviatDate = cmdsalsabt.Text + "/" + cmdmahsabt.Text + "/" + cmddaysabt.Text;
                username.Komod = "no";

                data.tblUsers.Add(username);
                data.SaveChanges();

                picaks.Image.Save(Application.StartupPath + "\\pic\\" + username.ID.ToString() + ".jpg");
                
                MessageBox.Show("ثبت با موفقیت انجام شد");
                groupPanel3.Enabled = false;
                groupPanel1.Enabled = false;
                picadd.Enabled = true;
                picsave.Enabled = false;
                piccancele.Enabled = false;
                
            }
        }

        private void piccancele_Click(object sender, EventArgs e)
        {
            groupPanel3.Enabled = false;
            groupPanel1.Enabled = false;
            picadd.Enabled = true;
            picsave.Enabled = false;
            piccancele.Enabled = false;
        }

        private void cmddaysabt_SelectedIndexChanged(object sender, EventArgs e)
        {
            mah();
        }
        private void mah()
        {
            cmddayetebar.SelectedIndex = cmddaysabt.SelectedIndex;
            if(cmdmahsabt.SelectedIndex==11)
            {
                cmdmahetebar.SelectedIndex = 0;
                cmdsalletebar.SelectedIndex = cmdsalsabt.SelectedIndex+1;
            }
            else
            {
                cmdmahetebar.SelectedIndex = cmdmahsabt.SelectedIndex + 1;
                cmdsalletebar.SelectedIndex = cmdsalsabt.SelectedIndex;
            }
        }
        private void cmdmahsabt_SelectedIndexChanged(object sender, EventArgs e)
        {
            mah();
        }

        private void cmdsalsabt_SelectedIndexChanged(object sender, EventArgs e)
        {
            mah();
        }

        private void picentekhab_Click(object sender, EventArgs e)
        {
           try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "(*.*)|*.*";
                op.Title = "تصویر را وارد کنید";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    picaks.Load(op.FileName);
                }
            }
            catch
            {
                MessageBox.Show("فایل غیر مجاز");
            }
        }
    }
}
