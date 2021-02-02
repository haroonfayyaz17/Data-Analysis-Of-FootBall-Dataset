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
    public partial class yearlyData : Form
    {
        SQLConn obj = new SQLConn();
        SqlConnection con = new SqlConnection();


        void fillteam()
        {
            team.Items.Clear();
            SqlCommand cmd;

            string sql = "select distinct home_team as Name from results Where year(Mdate) = '" + year.Text + "';";
            cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string sname = Convert.ToString(myreader["Name"]);

                    team.Items.Add(sname);



                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void fillteamtab2()
        {
            team.Items.Clear();
            SqlCommand cmd;

            string sql = "select distinct home_team as Name from results Where year(Mdate) = '" + years.Text + "';";
            cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string sname = Convert.ToString(myreader["Name"]);

                    team.Items.Add(sname);



                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public yearlyData()
        {
            InitializeComponent();
            con = obj.con;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string totalMatches = "select count(*) as winning from results where year(Mdate)='" + year.Text + "'";
            string matchPlay = "select count(*) as total from results where (year(Mdate)='" + year.Text + "') and (home_team= '" + team.Text + "' or away_team= '" + team.Text + "') ";
            string winMatch = "select count(*) as win from results where (year(Mdate)='" + year.Text + "') and ((home_team= '" + team.Text + "' and home_score>away_score) OR (away_team= '" + team.Text + "' and away_score>home_score) )";
            string lostMatch= "select count(*) as lost from results where (year(Mdate)='" + year.Text + "') and ((home_team= '" + team.Text + "' and home_score<away_score) OR (away_team= '" + team.Text + "' and away_score<home_score) )";
            string drawMatch = "select count(*) as draw from results where (year(Mdate)='" + year.Text + "') and ((home_team= '" + team.Text + "' and home_score=away_score) OR (away_team= '" + team.Text + "' and away_score=home_score) )";
           

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(totalMatches, con);
                SqlDataReader reader = cmd.ExecuteReader();

                int t = 0, play = 0, win = 0, lost=0,draw=0;
                while (reader.Read())
                {
                    t = Convert.ToInt32(reader["winning"].ToString());
                }
                reader.Close();

                cmd.CommandText = matchPlay;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    play = Convert.ToInt32(reader["total"].ToString());
                }
                reader.Close();
                cmd.CommandText = winMatch;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    win = Convert.ToInt32(reader["win"].ToString());
                }
                reader.Close();

                cmd.CommandText = lostMatch;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lost = Convert.ToInt32(reader["lost"].ToString());
                }
                reader.Close();

                cmd.CommandText = drawMatch;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    draw = Convert.ToInt32(reader["draw"].ToString());
                }
                reader.Close();

               
                float probwin = (float)win / (float)play;
                float problose = (float)lost/(float)play;
                label3.Text = string.Format("Total matches played in " + year.Text + " are " + t);
                label4.Text = string.Format("Total matches played by " + team.Text + " in " + year.Text + " are " + play);
                label9.Text = string.Format("Total matches won by " + team.Text + " in " + year.Text + " are " + win);
                label10.Text = string.Format("Total matches lost by " + team.Text + " in " + year.Text + " are " + lost);
                label11.Text = string.Format("Total matches draw by " + team.Text + " in " + year.Text + " when playing with any other team are " + draw);
                label5.Text = string.Format("Probability of " + team.Text + " winning with total matches it played in " + year.Text + " is '" + probwin + "'");
                label6.Text = string.Format("Probability of " + team.Text + " losing with total matches it played in " + year.Text + " is '" + problose + "'");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 1)
                    dataGridView1.Rows.Clear();

                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
               
               
                for (int i = 0; i < team.Items.Count; i++)
                {
                    if (team.Items[i].ToString() != team.Text)
                    {
                        
                        
                      string winMatch = "select count(*) as win from results  where (year(Mdate)='" + years.Text + "') and ((home_team= '" + team.Items[i] + "' and home_score>away_score) OR (away_team= '" + team.Items[i] + "' and away_score>home_score)) ";
                        string totalPlay = "select count(*) as total from results where (year(Mdate)='" + years.Text + "') and (home_team= '" + team.Items[i] + "' or away_team= '" + team.Items[i] + "') ";
                        
                        string maxGoals1 = "select max(home_score) as max1 from results where (year(Mdate)='" + years.Text + "') and (home_team='" + team.Items[i] + "')";
                        string maxGoals2 = "select max(away_score) as max2 from results where (year(Mdate)='" + years.Text + "') and (away_team='" + team.Items[i] + "')";
                        string minGoals1 = "select min(home_score) as min1 from results where (year(Mdate)='" + years.Text + "') and (home_team='" + team.Items[i] + "')";
                        string minGoals2 = "select min(away_score) as min2 from results where (year(Mdate)='" + years.Text + "') and away_team='" + team.Items[i] + "'";
                       
                        string modeHome = " select top 1 home_score as mode1 from results  where (home_team='" +team.Items[i]+ "') and (YEAR(Mdate)=2002) group by home_score order by count(*) desc";
                        string modeAway = " select top 1 away_score as mode2 from results  where (away_team='" + team.Items[i] + "') and (YEAR(Mdate)=2002) group by away_score order by count(*) desc";


                        cmd.Connection = con;
                        cmd.CommandText = winMatch;
                        reader = cmd.ExecuteReader();
                        int win = 0, totalplay = 0;
                        while (reader.Read())
                        {
                            win = Convert.ToInt32(reader["win"].ToString());
                        }
                        reader.Close();
                        cmd.CommandText = totalPlay;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            totalplay = Convert.ToInt32(reader["total"].ToString());
                        }
                        reader.Close();

                        //////////////////// Maximum Goals /////////////////////////////
                        int goal1 = 0, goal2 = 0, maxGoals=0;
                        cmd.CommandText = maxGoals1;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            goal1 = Convert.ToInt32(reader["max1"].ToString());
                        }
                        reader.Close();

                        cmd.CommandText = maxGoals2;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            goal2 = Convert.ToInt32(reader["max2"].ToString());
                        }
                        reader.Close();

                        if(goal1>goal2)
                        {
                            maxGoals = goal1;
                        }
                        else if(goal1<goal2)
                        {
                            maxGoals = goal2;
                        }
                        else
                        {
                            maxGoals = goal1;
                        }
                        //////////////////////////////////////////////////////////////////////

                        ////////////////////Minimum Goals///////////////////////////////////
                        int g1 = 0, g2 = 0, minGoals = 0;
                        cmd.CommandText = minGoals1;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            g1 = Convert.ToInt32(reader["min1"].ToString());
                        }
                        reader.Close();

                        cmd.CommandText = minGoals2;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            g2 = Convert.ToInt32(reader["min2"].ToString());
                        }
                        reader.Close();

                        if (g1 < g2)
                        {
                            minGoals = g1;
                        }
                        else if (g1 > g2)
                        {
                            minGoals = g2;
                        }
                        else
                        {
                            minGoals = g1;
                        }
        


                        ////////////////////////////////////////////////////////////////

                        ///////////////////////// Average as Home_score (MODE)//////////////////////////////


                        int mode1 = 0;
                        cmd.CommandText = modeHome;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            mode1 = Convert.ToInt32(reader["mode1"].ToString());
                        }
                        reader.Close();



            ///////////////////////////////////////////////////////////////////////////////////////////////

                        ///////////////////////// Average as away_score (MODE)//////////////////////////////


                        int mode2 = 0;
                        cmd.CommandText = modeAway;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            mode2 = Convert.ToInt32(reader["mode2"].ToString());
                        }
                        reader.Close();


                        ///////////////////////////////////////////////////////////////////////////////////////////////
                        float value = (float)win / (float)totalplay;
                        float percentage = value * 100;
                        
                            dataGridView1.Rows.Add(team.Items[i].ToString(), win, maxGoals, minGoals, mode1, mode2, (int)percentage + " %");
                       

                    }
                }
                dataGridView1.Visible = true;
                con.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Main m = new Main();
                this.Hide();
                m.Show();
            }
        }

        private void team_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillteam();
        }

        private void years_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillteamtab2();
        }

        private void yearlyData_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
