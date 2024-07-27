using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gym
{
    class Class1
    {
        public static TextBox chengnum(TextBox textboxname)
        {
            textboxname.Text = textboxname.Text.Replace("0", "0").Replace("1","1").Replace("2","2").Replace("3", "3").Replace("4", "4").Replace("5", "5").Replace("6", "6").Replace("7", "7").Replace("8", "8").Replace("9", "9");
            textboxname.SelectionStart = textboxname.Text.Length;
            return textboxname;
        }
    }
}
