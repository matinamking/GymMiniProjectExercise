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
    public partial class frmuseedit : Form
    {
       public int code = 0;
       public DBGymEntities data = new DBGymEntities();
        Boolean ispicchang = false;
        public frmuseedit()
        {
            InitializeComponent();
        }

        private void frmuseedit_Load(object sender, EventArgs e)
        {
           
        }

        private void piccancele_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picsave_Click(object sender, EventArgs e)
        {
            if (textname.Text == "")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
            {
                var qury = (from ozviat in data.tblUsers where ozviat.ID == code select ozviat).SingleOrDefault();
                qury.Name = textname.Text;
                qury.BirthDate = cmbsall.Text + "/" + cmbmah.Text + "/" + cmbday.Text;
                qury.EtebarDate = cmdsalletebar.Text + "/" + cmdmahetebar.Text + "/" + cmddayetebar.Text;
                qury.OzviatDate = cmdsalsabt.Text + "/" + cmdmahsabt.Text + "/" + cmddaysabt.Text;
                if(ispicchang==true)
                {
                    picaks.Image.Save(Application.StartupPath + "\\pic\\" + code + ".jpg");
                }
                
                data.SaveChanges();
                MessageBox.Show("ویرایش با موفقیت انجام شد");
                this.Close();
            }
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
                    if(op.FileName== Application.StartupPath + "\\pic\\" +code.ToString() + ".jpg")
                    {
                        MessageBox.Show("تصویر تکراری است");
                    }
                    else
                    {
                        picaks.Load(op.FileName);
                        ispicchang = true;
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("فایل غیر مجاز");
            }
        }
    }
}
