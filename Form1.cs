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
    public partial class MainWindform : Form
    {
        public MainWindform()
        {
            InitializeComponent();
        }

        private void OpenNextForm_Click(object sender, EventArgs e)
        {
            SecondWindform form2 = new SecondWindform();
            form2.Show();
            OpenNextForm.Enabled = false;
            if (checkBox1.Checked == true && OpenNextForm.Enabled == false)
            {
                Submit.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true && OpenNextForm.Enabled == false)
            {
                Submit.Enabled = true;
            }
            if(checkBox1.Checked==false && OpenNextForm.Enabled == false)
            {
                Submit.Enabled = false;
            }

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SecondWindform form2 = new SecondWindform();
            if (checkBox1.Checked==true && OpenNextForm.Enabled==false )
            {
                Submit.Enabled = true;
            }
            string nama = Convert.ToString(NameBox.Text);
            if(NameBox.Text=="")
            {
                MessageBox.Show("Enter the correct Input");
            }
            if (ArtistBox.Text == "")
            {
                MessageBox.Show("Enter the correct Input");
            }
            string favartist = Convert.ToString(ArtistBox.Text);
            form2.Show();
            form2.labeltext(nama, favartist);
        }
        public void changebackground(Color color)
        {
            this.BackColor = color;
        }

        private void MainWindform_Load(object sender, EventArgs e)
        {
            
        }
    }
}
