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
    public partial class GroundPredicition : Form
    {
        SQLConn obj = new SQLConn();
        SqlConnection con = new SqlConnection();
        void LoadTeams(ComboBox cmb, string query)
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
                    cmb.Items.Add(reader["Name"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public GroundPredicition()
        {
            InitializeComponent();
            con = obj.con;
            LoadTeams(comboBox1, "select distinct home_team As Name from results");
            LoadTeams(comboBox2, "select distinct away_team As Name from results");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string A = "select r.city, Count(r.city) from results r where r.home_score != r.away_score and home_team='" + comboBox1.Text + "' or away_team='" + comboBox2.Text + "' group by r.city order by Count(r.city) desc";

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(A, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int n1 = 0;
                string s1=" ";
                while (reader.Read()&&n1<1)
                {
                    if (reader["city"] == DBNull.Value)
                        s1 = " ";
                    else
                        s1=reader["city"].ToString();
                    n1++;
                }
                reader.Close();
                linkLabel1.Text = "Predicted ground for the match of " + comboBox1.Text + " VS " + comboBox2.Text + " is = " + s1;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string B = "select r.city from results r where r.home_score != r.away_score group by r.city having count(r.city)>4";

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                //listView1.View = View.Details;
                //SqlCommand cmd = new SqlCommand(B, con);
                SqlDataAdapter ada = new SqlDataAdapter(B, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    
                    TrendingListView.Items.Add(dr["city"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Main m = new Main();
                this.Hide();
                m.Show();
            }
        }
    }
}
