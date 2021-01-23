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
    public partial class WeaponAdminDetail : Form
    {
        public WeaponAdminDetail()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4AS747J;Initial Catalog=ArmoryDB;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WeaponAdminDetail_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'armoryDBDataSet2.ArmoryTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.armoryTableTableAdapter2.Fill(this.armoryDBDataSet2.ArmoryTable);
            // TODO: Bu kod satırı 'armoryDBDataSet.ArmoryTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.armoryTableTableAdapter1.Fill(this.armoryDBDataSet1.ArmoryTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ArmoryTable (WeaponSerialID, WeaponName, WeaponManufacturer, WeaponOwner, SpentTime) values (@P1, @P2, @P3, @P4, @P5)",con);
            cmd.Parameters.AddWithValue("@P1", maskedSerial.Text);
            cmd.Parameters.AddWithValue("@P2", wnametbox.Text);
            cmd.Parameters.AddWithValue("@P3", mfacturertbox.Text);
            cmd.Parameters.AddWithValue("@P4", ownertbox.Text);
            cmd.Parameters.AddWithValue("@P5", timetbox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Press to continue");
            this.armoryTableTableAdapter2.Fill(this.armoryDBDataSet2.ArmoryTable);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            maskedSerial.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            wnametbox.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            mfacturertbox.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            ownertbox.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            timetbox.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
            ammotbox.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            currenttbox.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            totaltbox.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();

            //timetbox.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            //ammotbox.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            //currenttbox.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            //totaltbox.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update ArmoryTable set AmmoType=@P1,CurrentAmmo=@P2,TotalAmmo=@P3 where WeaponSerialID = @P4", con);
            cmd.Parameters.AddWithValue("@P1", ammotbox.Text);
            cmd.Parameters.AddWithValue("@P2", currenttbox.Text);
            cmd.Parameters.AddWithValue("@P3", totaltbox.Text);
            cmd.Parameters.AddWithValue("@P4", maskedSerial.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Press to continue");
            this.armoryTableTableAdapter2.Fill(this.armoryDBDataSet2.ArmoryTable);
        }
    }
}
