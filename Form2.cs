using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takehomeweek3
{
    public partial class SecondWindform : Form
    {
        public SecondWindform()
        {
            InitializeComponent();
        }
        public void labeltext(string name,string artist )
        {
            namefavourite.Text= "Hi, my name is "+name+"and my favorite artist is"+artist;
        }

        private void Magic_Click(object sender, EventArgs e)
        {
            bool check = false;
            if(Terms.Checked==true && picktrue.Checked==true)
            {
                Magic.Enabled = true;
            }
            MainWindform form1 = new MainWindform();
            if(Red.Checked==true)
            {
                form1.BackColor = Color.Red;
                check = true;
            }
            else if (Green.Checked == true)
            {
                form1.BackColor = Color.Green;
                check = true;
            }
            else if (Blue.Checked == true)
            {
                form1.BackColor = Color.Blue;
                check = true;
            }
            else if (Yellow.Checked == true)
            {
                form1.BackColor = Color.Yellow;
                check = true;
            }
            if(Pink.Checked == true)
            {
                form1.ForeColor= Color.Pink;
                check = true;
            }
            else if (Purple.Checked == true)
            {
                form1.ForeColor = Color.Purple;
                check = true;
            }
            else if (Orange.Checked == true)
            {
                form1.ForeColor = Color.Orange;
                check = true;
            }
            if(check==false)
            {
                MessageBox.Show("Choose the radio button","Warning");
            }

            form1.Show();
        }

        private void Terms_CheckedChanged(object sender, EventArgs e)
        {
            if(Terms.Checked == true && picktrue.Checked==true)
            {
                Magic.Enabled = true;
            }
        }

        private void picktrue_CheckedChanged(object sender, EventArgs e)
        {
            if (Terms.Checked == true && picktrue.Checked==true)
            {
                Magic.Enabled = true;
            }
        }
    }
}
