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
    public partial class Barchart1 : Form
    {
        SQLConn obj = new SQLConn();
        SqlConnection con = new SqlConnection();

        public Barchart1()
        {
            InitializeComponent();
            con = obj.con;
            FillChart();
        }

        void FillChart()
        {
            try
            {
                DataSet st = new DataSet();
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string[] nations = { "Algeria", "Angola", "Argentina", "Australia", "Belgium", "Bosnia and Herzegovina", "Brazil", "Cameroon", "Chile", "China PR", "Colombia", "Costa Rica", "Croatia", "Czech Republic", "Denmark", "Ecuador", "Egypt", "England", "France", "Germany", "Ghana", "Greece", "Honduras", "Iceland", "Iran", "Italy", "Ivory Coast", "Japan", "Mexico", "Morocco", "Netherlands", "New Zealand", "Nigeria", "North Korea", "Panama", "Paraguay", "Peru", "Poland", "Portugal", "Republic of Ireland", "Russia", "Saudi Arabia", "Senegal", "Serbia", "Slovakia", "Slovenia", "South Africa", "South Korea", "Spain", "Sweden", "Switzerland", "Togo", "Trinidad and Tobago", "Tunisia", "Turkey", "Ukraine", "United States", "Uruguay" };
               
                for (int i = 0; i < nations.Length; i++)
                {
                    string que = "select count(*) as home_team_stats from results where home_team='" + nations[i] + "'and (home_score>away_score)";
                    string sum = "select count(*) as total from results where home_team='" + nations[i] + "'";
                    float n1 = 0;
                    int tot = 320;
                    try
                    {
                        SqlCommand cmd = new SqlCommand(que, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            n1 = Convert.ToInt32(reader["home_team_stats"].ToString());
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (n1 != 0)
                    {
                        
                        SqlCommand cmd = new SqlCommand(sum, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            tot = Convert.ToInt32(reader["total"].ToString());
                        }
                        reader.Close();
                        float temp = 0;
                        temp = (n1 / tot)*100;
                        double var = Math.Round(temp, 4);
                        chart1.Series[0].Points.AddXY(nations[i], var);
                    }     
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            chart1.Titles.Add("Home_Team Win Stats");
            con.Close();
        }

        private void Homegroundwin_Load(object sender, EventArgs e)
        {

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
