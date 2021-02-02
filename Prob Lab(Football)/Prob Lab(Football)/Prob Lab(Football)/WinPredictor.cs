using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob_Lab_Football_
{
    public partial class WinPredictor : Form
    {
        SQLConn obj = new SQLConn();
        SqlConnection con = new SqlConnection();


        void load(ComboBox cmb, string query)
        {
            try
            {
                cmb.Items.Clear();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmb.Items.Add(reader["team"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public WinPredictor()
        {
            InitializeComponent();
            con = obj.con;
            string s, s1;
            s = "select distinct home_team as team from results";
            s1 = "select distinct away_team as team from results";
            load(comboBox1, s);
            load(comboBox2, s1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Main m = new Main();
                this.Hide();
                m.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AinterB = "select count(*) as intersection from results where home_team='" + comboBox1.Text + "'and away_team='" + comboBox2.Text + "' and (home_score>away_score) ";
            string probabilityB = "select count(*) as probb from results where away_team='" + comboBox2.Text + "' ";


            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(AinterB, con);
                SqlDataReader reader = cmd.ExecuteReader();

                float n1 = 0, n2 = 0;
                while (reader.Read())
                {
                    n1 = Convert.ToInt32(reader["intersection"].ToString());
                }

                reader.Close();
                cmd.CommandText = probabilityB;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n2 = Convert.ToInt32(reader["probb"].ToString());
                }


                reader.Close();
                float value = n1 / n2;

                label3.Text = string.Format("The Probability that " + comboBox1.Text + " Wins the Match against " + comboBox2.Text + " on home ground is: {0:F6}", value);

                //away ground

                string totalwinmatch = "select count(*) as intersection from results where home_team='" + comboBox2.Text + "'and away_team='" + comboBox1.Text + "' and (home_score<away_score) ";
                string total = "select count(*) as probb from results where home_team='" + comboBox2.Text + "' ";

                float num1 = 0;
                float num2 = 0;

                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd1 = new SqlCommand(totalwinmatch, con);
                    SqlDataReader readers = cmd1.ExecuteReader();
                    while (readers.Read())
                    {
                        num1 = Convert.ToInt32(readers["intersection"].ToString());
                    }

                    readers.Close();
                    cmd.CommandText = total;
                    readers = cmd.ExecuteReader();
                    while (readers.Read())
                    {
                        num2 = Convert.ToInt32(readers["probb"].ToString());
                    }

                    readers.Close();
                    value = num1 / num2;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                label6.Text = string.Format("The Probability that " + comboBox1.Text + " Wins the Match against " + comboBox2.Text + " on away ground is: {0:F6}", value);







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void WinPredictor_Load(object sender, EventArgs e)
        {

        }

        
    }
}
