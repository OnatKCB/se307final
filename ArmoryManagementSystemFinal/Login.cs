using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmoryManagementSystemFinal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            WeaponUserDetail wud = new WeaponUserDetail();
            wud.number = maskedTextBox1.Text;
            wud.Show();
        }

        //JUST USELESS, IGNORE IT
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text == "6666") 
            {
                WeaponAdminDetail wad = new WeaponAdminDetail();
                wad.Show();
            }
        }
        //JUST USELESS, IGNORE IT

        private void maskedTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "0000")
            {
                WeaponAdminDetail wad = new WeaponAdminDetail();
                wad.Show();
            }
        }
    }
}
