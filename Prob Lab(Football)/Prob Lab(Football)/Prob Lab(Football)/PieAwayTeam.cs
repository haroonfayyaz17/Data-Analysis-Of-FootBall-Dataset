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
    public partial class PieAwayTeam : Form
    {
        SQLConn obj = new SQLConn();
        SqlConnection con = new SqlConnection();
        public PieAwayTeam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Main m = new Main();
                this.Hide();
                m.Show();
            }
        }

        private void PieAwayTeam_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Statistics of Winning Probability on Away Ground");

            SQLConn obj = new SQLConn();
            SqlConnection con = new SqlConnection();
            con = obj.con;


            string[] arr =  { "Algeria", "Angola", "Argentina", "Australia", "Belgium", "Bosnia and Herzegovina",
            "Brazil","Cameroon","Chile","China PR","Colombia","Costa Rica","Croatia","Czech Republic","Denmark","Ecuador","Egypt","England","France","Germany","Ghana"
            ,"Greece","Honduras","Iceland","Iran","Italy","Ivory Coast","Japan","Mexico","Morocco","Netherlands","New Zealand","Nigeria","North Korea","Panama","Paraguay","Peru"
            ,"Poland","Portugal","Republic of Ireland","Russia","Saudi Arabia","Senegal","Serbia","Slovakia","Slovenia","South Africa","South Korea","Spain","Sweden","Switzerland","Togo"
            ,"Trinidad and Tobago","Tunisia","Turkey","Ukraine","United States","Uruguay"};
            int x = 0;

            chart1.Series["Series1"].IsValueShownAsLabel = true;

            for (int i = 0; i < arr.Length; i++)
            {

                string sql = "select count(*) as stat from results where away_team = '" + arr[i] + "' and (away_score > home_score)";
                string total = "select count(*) as tot from results where away_team= '" + arr[i] + "' ";
                float n1 = 0;
                int t = 0, t1 = 320;
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        n1 = Convert.ToInt32(reader["stat"].ToString());
                    }

                    reader.Close();
                    cmd.CommandText = total;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        t = Convert.ToInt32(reader["tot"].ToString());
                    }


                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (n1 != 0)
                {
                    float temp = 0;
                    temp = n1 / t1;
                    // temp = temp * 360;
                    double val = Math.Round(temp, 4);
                    //   double val = temp;
                    chart1.Series["Series1"].Points.AddXY(arr[i], val);

                }

                else
                {
                    x++;
                }


            }


            label1.Text = "*" + Convert.ToString(x) + " Countries have 0 Probability on Away Ground";
        }
    }
}
