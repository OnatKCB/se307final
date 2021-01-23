using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArmoryManagementSystemFinal
{
    public partial class WeaponUserDetail : Form
    {

        public string number;
        //Data Source=DESKTOP-4AS747J;Initial Catalog=ArmoryDB;Integrated Security=True

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4AS747J;Initial Catalog=ArmoryDB;Integrated Security=True");
        public WeaponUserDetail()
        {
            InitializeComponent();
        }

        private void WeaponUserDetail_Load(object sender, EventArgs e)
        {
            serialnumLabel.Text = number;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ArmoryTable where WeaponSerialID = @p1", con);
            cmd.Parameters.AddWithValue("@p1", number);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read()) 
            {
                wpnameLabel.Text = read[1].ToString();
                manufacturerLabel.Text = read[2].ToString();
                ownerLabel.Text = read[3].ToString();
                ammoLabel.Text = read[4].ToString();
                currentLabel.Text = read[5].ToString();
                totalLabel.Text = read[6].ToString();
                borrowLabel.Text = read[7].ToString();
            }
            con.Close();
        }
    }
}
