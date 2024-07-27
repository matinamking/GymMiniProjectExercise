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
    public partial class modiriat : Form
    {
        DBGymEntities data = new DBGymEntities();
        public modiriat()
        {
            InitializeComponent();
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void modiriat_Load(object sender, EventArgs e)
        {
            grd.DataSource = data.tblUsers.ToList();
        }
        private void serch()
        {
            var qury = (from tr in data.tblUsers where tr.Name.Contains(textserchname.Text) select tr);
            grd.DataSource = qury.ToList();
        }
        private void textserchname_TextChanged(object sender, EventArgs e)
        {
            serch();
        }
        ///ااناتلاب بعت
        private void btnmosha_Click(object sender, EventArgs e)
        {
            try
            {
                frmd fd = new frmd();
                fd.lblesm.Text = grd.CurrentRow.Cells["username"].Value.ToString();
                fd.lbletebardate.Text = grd.CurrentRow.Cells["EtebarDate"].Value.ToString();
                fd.lblcomod.Text = grd.CurrentRow.Cells["Column2"].Value.ToString();
                fd.lbltavald.Text = grd.CurrentRow.Cells["Column1"].Value.ToString();
                fd.lblsabtdate.Text = grd.CurrentRow.Cells["Column3"].Value.ToString();
                fd.lblcodozviat.Text = grd.CurrentRow.Cells["ID"].Value.ToString();

                fd.userpic.Load(Application.StartupPath + "\\pic\\" + grd.CurrentRow.Cells[0].Value.ToString() + ".jpg");
                fd.ShowDialog();
            }
            catch
            {
                MessageBox.Show("در نمایش مشخصات کاربر خطا وجود دارد");
            }


        }

        private void btnvirayesh_Click(object sender, EventArgs e)
        {
            string sindex = "";
            frmmessag fm = new frmmessag();
            if (grd.RowCount == 0)
            {
                fm.Text = "حذف";
                fm.lbltext.Text = "رکوردی برای ویرایش وجود ندارد";
                fm.picyes.Visible = true;
                fm.ShowDialog();
                return;
            }
            frmuseedit fuser = new frmuseedit();
            int a;
            for (a = 1; a <= 31; a++)
            {
               fuser. cmbday.Items.Add(a.ToString());
            }
            for (a = 1; a <= 12; a++)
            {
               fuser. cmbmah.Items.Add(a.ToString());
            }
            for (a = 1300; a <= 1500; a++)
            {
               fuser. cmbsall.Items.Add(a.ToString());
            }


            for (a = 1; a <= 31; a++)
            {
               fuser. cmddaysabt.Items.Add(a.ToString());
            }
            for (a = 1; a <= 12; a++)
            {
              fuser.  cmdmahsabt.Items.Add(a.ToString());
            }
            for (a = 1300; a <= 1500; a++)
            {
             fuser.   cmdsalsabt.Items.Add(a.ToString());
            }


            for (a = 1; a <= 31; a++)
            {
             fuser.   cmddayetebar.Items.Add(a.ToString());
            }
            for (a = 1; a <= 12; a++)
            {
            fuser.    cmdmahetebar.Items.Add(a.ToString());
            }
            for (a = 1300; a <= 1500; a++)
            {
              fuser.  cmdsalletebar.Items.Add(a.ToString());
            }


            fuser. cmbday.SelectedIndex = 0;
            fuser. cmbmah.SelectedIndex = 0;
           fuser. cmbsall.SelectedIndex = 0;

           fuser. cmddaysabt.SelectedIndex = 0;
            fuser. cmdmahsabt.SelectedIndex = 0;
            fuser. cmdsalsabt.SelectedIndex = 0;

            fuser. cmddayetebar.SelectedIndex = 0;
            fuser. cmdmahetebar.SelectedIndex = 0;
            fuser. cmdsalletebar.SelectedIndex = 0;

            fuser.code = Convert.ToInt32( grd.CurrentRow.Cells["ID"].Value.ToString());
            fuser.textname.Text = grd.CurrentRow.Cells["username"].Value.ToString();
           sindex = grd.CurrentRow.Cells["Column1"].Value.ToString().Substring(0, 4);
            fuser.cmbsall.SelectedIndex = Convert.ToInt32(sindex) - 1300;

            sindex = grd.CurrentRow.Cells["Column1"].Value.ToString().Substring(5, 2);
            sindex = sindex.Replace("/", "");
            fuser.cmbmah.SelectedIndex = Convert.ToInt32(sindex) - 1;

            sindex = grd.CurrentRow.Cells["Column1"].Value.ToString().Substring(grd.CurrentRow.Cells["Column1"].Value.ToString().Length - 2 , 2);
            sindex = sindex.Replace("/", "");
            fuser.cmbday.SelectedIndex = Convert.ToInt32(sindex) - 1;

            sindex = grd.CurrentRow.Cells["Column3"].Value.ToString().Substring(0, 4);
            fuser.cmdsalsabt.SelectedIndex = Convert.ToInt32(sindex) - 1300;

            sindex = grd.CurrentRow.Cells["Column3"].Value.ToString().Substring(5, 2);
            sindex = sindex.Replace("/", "");
            fuser.cmdmahsabt.SelectedIndex = Convert.ToInt32(sindex) - 1;

            sindex = grd.CurrentRow.Cells["Column3"].Value.ToString().Substring(grd.CurrentRow.Cells["Column3"].Value.ToString().Length - 2, 2);
            sindex = sindex.Replace("/", "");
            fuser.cmddaysabt.SelectedIndex = Convert.ToInt32(sindex) - 1;

            sindex = grd.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(0, 4);
            fuser.cmdsalletebar.SelectedIndex = Convert.ToInt32(sindex) - 1300;

            sindex = grd.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(5, 2);
            sindex = sindex.Replace("/", "");
            fuser.cmdmahetebar.SelectedIndex = Convert.ToInt32(sindex) - 1;

            sindex = grd.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(grd.CurrentRow.Cells["EtebarDate"].Value.ToString().Length - 2, 2);
            sindex = sindex.Replace("/", "");
            fuser.cmddayetebar.SelectedIndex = Convert.ToInt32(sindex) - 1;

            fuser.picaks.Load(Application.StartupPath + "\\pic\\" + grd.CurrentRow.Cells[0].Value.ToString() + ".jpg");
            fuser.ShowDialog();
            data = fuser.data;
            grd.DataSource = data.tblUsers.ToList();
        }

        private void btnhazf_Click(object sender, EventArgs e)
        {
            frmmessag fm = new frmmessag();
            if (grd.RowCount==0)
            {
                fm.Text = "حذف";
                fm.lbltext.Text = "رکوردی برای حذف وجود ندارد";
                fm.picyes.Visible = true;
                fm.ShowDialog();
                return;
            }
            fm.Text = "حذف";
            fm.lbltext.Text = "ایا از حذف اطمینان دارید؟";
            fm.picyes.Visible = true;
            fm.picno.Visible = true;
            fm.ShowDialog();
            if(fm.mriz==true)
            {
                int codee = Convert.ToInt32( grd.CurrentRow.Cells["ID"].Value.ToString());
                var qury = (from ozviat in data.tblUsers where ozviat.ID == codee select ozviat).SingleOrDefault();
                data.tblUsers.Remove(qury);
                data.SaveChanges();
                try
                {
                    System.IO.File.Delete(Application.StartupPath + "\\pic\\" + codee + ".jpg");
                }
                catch
                {

                }
                grd.DataSource = data.tblUsers.ToList();
            }
        }

        private void btnpardakht_Click(object sender, EventArgs e)
        {
            string sindex = "";
            pardakht ft = new pardakht();
            int a;
            for (a = 1; a <= 31; a++)
            {
               ft.cmdday.Items.Add(a.ToString());
            }
            for (a = 1; a <= 12; a++)
            {
                ft.cmdmah.Items.Add(a.ToString());
            }
            for (a = 1300; a <= 1500; a++)
            {
               ft.cmdsall.Items.Add(a.ToString());
            }


            ft.cmdday.SelectedIndex = 0;
            ft.cmdmah.SelectedIndex = 0;
            ft.cmdsall.SelectedIndex = 0;

            sindex = grd.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(0, 4);
            ft.cmdsall.SelectedIndex = Convert.ToInt32(sindex) - 1300;

            sindex = grd.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(5, 2);
            sindex = sindex.Replace("/", "");
            ft.cmdmah.SelectedIndex = Convert.ToInt32(sindex) - 1;

            sindex = grd.CurrentRow.Cells["EtebarDate"].Value.ToString().Substring(grd.CurrentRow.Cells["EtebarDate"].Value.ToString().Length - 2, 2);
            sindex = sindex.Replace("/", "");
            ft.cmdday.SelectedIndex = Convert.ToInt32(sindex) - 1;

            ft.code = Convert.ToInt32(grd.CurrentRow.Cells["ID"].Value.ToString());
            ft.cname = grd.CurrentRow.Cells["username"].Value.ToString();

            ft.ShowDialog();
            data = ft.data;
            grd.DataSource = data.tblUsers.ToList();
        }
    }
}
