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
    public partial class frmmessag : Form
    {
        public Boolean mriz = false;
        public frmmessag()
        {
            InitializeComponent();
        }

        private void frmmessag_Load(object sender, EventArgs e)
        {

        }

        private void picno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picyes_Click(object sender, EventArgs e)
        {
            mriz = true;
            this.Close();
        }
    }
}
