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
    public partial class frmsavabegh : Form
    {
        DBGymEntities data = new DBGymEntities();
        public frmsavabegh()
        {
            InitializeComponent();
        }

        private void frmsavabegh_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.tblTarakoneshes.ToList();

        }

        private void txtserchname_TextChanged(object sender, EventArgs e)
        {
            serch();
        }
        private void serch()
        {
            var qury = (from tr in data.tblTarakoneshes where tr.CustomerID.ToString().Contains(txtserchcod.Text)&& tr.CustomerName.Contains(txtserchname.Text) select tr);
            grdlist.DataSource = qury.ToList();
        }
        private void txtserchcod_TextChanged(object sender, EventArgs e)
        {
            Class1.chengnum(txtserchcod);
            serch();
        }
    }
}
