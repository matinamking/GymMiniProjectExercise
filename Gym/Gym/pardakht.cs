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
    public partial class pardakht : Form
    {
        public DBGymEntities data = new DBGymEntities();
        public int code = 0;
        public String cname = "";
        public pardakht()
        {
            InitializeComponent();
        }

        private void pardakht_Load(object sender, EventArgs e)
        {
            txtmablagh.Text = Properties.Settings.Default.shahriye.ToString();
        }

        private void btnpardakht_Click(object sender, EventArgs e)
        {
            var qury = (from ozviat in data.tblUsers where ozviat.ID == code select ozviat).SingleOrDefault();
            qury.EtebarDate = cmdsall.Text + "/" + cmdmah.Text + "/" + cmdday.Text;
            data.SaveChanges();

            tblTarakonesh tbl = new tblTarakonesh();
            DateTime todey = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();

            string tdate = pc.GetYear(todey).ToString("0000") + "/" + pc.GetMonth(todey).ToString("00") + "/" + pc.GetDayOfMonth(todey).ToString("00");
            tbl.TarakoneshDate = tdate;
            tbl.TarakoneshKind = "پرداخت شهریه";
            tbl.Price = txtmablagh.Text;
            tbl.CustomerID = code;
            tbl.CustomerName = cname;

            data.tblTarakoneshes.Add(tbl);
            data.SaveChanges();

            MessageBox.Show("پرداخت شهریه با موفقیت انجام شد");

            Properties.Settings.Default.shahriye = txtmablagh.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void txtmablagh_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show((Convert.ToInt32(e.KeyChar).ToString());
            if(Convert.ToInt32(e.KeyChar) >=48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8 )
            {

            }   
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

        private void txtmablagh_TextChanged(object sender, EventArgs e)
        {
            Class1.chengnum(txtmablagh);
        }
    }
}
