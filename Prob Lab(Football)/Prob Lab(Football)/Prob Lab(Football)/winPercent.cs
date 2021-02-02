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
    public partial class winPercent : Form
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
                SqlDataReader readers = cmd.ExecuteReader();

                while (readers.Read())
                {
                    cmb.Items.Add(readers["Name"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public winPercent()
        {
            InitializeComponent();
            con = obj.con;
            LoadTeams(team, "select distinct home_team As Name from results");
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string winMatch = "select count(*) as winning from results  where (home_team= '" + team.Text + "' and home_score>away_score) OR (away_team= '" + team.Text + "' and away_score>home_score) ";

            string totalPlay = "select count(*) as total from results where home_team= '" + team.Text + "' or away_team= '" + team.Text + "' ";
           
            string maxGoals1 = "select max(home_score) as max1 from results where (home_team='" + team.Text + "')";
            string maxGoals2 = "select max(away_score) as max2 from results where (away_team='" + team.Text + "')";

            string modeHome = " select top 1 home_score as mode1 from results  where (home_team='" + team.Text + "')  group by home_score order by count(*) desc";
            string modeAway = " select top 1 away_score as mode2 from results  where (away_team='" + team.Text + "')  group by away_score order by count(*) desc";

            string sum1 = "select sum(home_score) as Sum1 from results where home_team= '" +team.Text+ "'";
            string sum2 = "select sum(away_score) as Sum2 from results where away_team= '" + team.Text + "'";


            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(winMatch, con);
                SqlDataReader reader = cmd.ExecuteReader();

                int n1 = 0, n2 = 0;
                while (reader.Read())
                {
                    n1 = Convert.ToInt32(reader["winning"].ToString());
                }
                reader.Close();

                reader.Close();
                cmd.CommandText = totalPlay;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n2 = Convert.ToInt32(reader["total"].ToString());
                }
                reader.Close();
                float value = (float)n1 / (float)n2;
                float percentage = value * 100;


                //////////////////// Maximum Goals /////////////////////////////
                int goal1 = 0, goal2 = 0, maxGoals = 0;
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

                if (goal1 > goal2)
                {
                    maxGoals = goal1;
                }
                else if (goal1 < goal2)
                {
                    maxGoals = goal2;
                }
                else
                {
                    maxGoals = goal1;
                }
                //////////////////////////////////////////////////////////////////////

                ///////////////////////// Average as (MODE)//////////////////////////////


                int mode1 = 0;
                cmd.CommandText = modeHome;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    mode1 = Convert.ToInt32(reader["mode1"].ToString());
                }
                reader.Close();



               

                int mode2 = 0;
                cmd.CommandText = modeAway;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    mode2 = Convert.ToInt32(reader["mode2"].ToString());
                }
                reader.Close();


               
                ////////////////////////////////////////////////////////////////


                /////////////////////////////////sum of all goals/////////////////////////////
                int s1=0, s2=0, sum=0;
                cmd.CommandText = sum1;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    s1 = Convert.ToInt32(reader["Sum1"].ToString());
                }
                reader.Close();

                cmd.CommandText = sum2;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    s2 = Convert.ToInt32(reader["Sum2"].ToString());
                }
                reader.Close();
                sum = s1 + s2;
                ///////////////////////////////////////////////////////////////////////

                label5.Text = string.Format("Number of Matches played by " + team.Text + " in World Cup since 2002 are " + n2);
                label4.Text = string.Format("Number of Matches won by " + team.Text + " are " + n1);
                label8.Text = string.Format("Maximum Goals by " + team.Text + " since 2002 are " + maxGoals);
                label9.Text = string.Format("Average goal ratio of team as home and away team is " +mode1+ ":" +mode2);
                label10.Text = string.Format("Total Goals by "+team.Text+ " from 2002 to 2018 are " +sum);
                label3.Text = string.Format("Probability of winning " + team.Text + " against any team is " + value);
                label11.Text = string.Format("Percentage " + percentage + "%");

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
                int temp = team.Items.Count;
                string[] arr = new string[temp];
                string[] arr2 = new string[temp];
                string[] arr3 = new string[temp];
               
                for (int i = 0; i < team.Items.Count; i++)
                {
                    if (team.Items[i].ToString() != team.Text)
                    {
                        string winMatch = "select count(*) as winning from results  where (home_team= '" + team.Items[i] + "' and home_score>away_score) OR (away_team= '" + team.Items[i] + "' and away_score>home_score) ";
                        string totalPlay = "select count(*) as total from results where home_team= '" + team.Items[i] + "' or away_team= '" + team.Items[i] + "' ";

                        cmd.Connection = con;
                        cmd.CommandText = winMatch;
                        reader = cmd.ExecuteReader();
                        int n1 = 0, n2 = 0;
                        while (reader.Read())
                        {
                            n1 = Convert.ToInt32(reader["winning"].ToString());
                        }
                        reader.Close();
                        cmd.CommandText = totalPlay;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            n2 = Convert.ToInt32(reader["total"].ToString());
                        }
                       
                        reader.Close();

                        float value = (float)n1 / (float)n2;
                        float percentage = value * 100;
                        if (percentage != 0)
                        {
                            arr[i] = team.Items[i].ToString();
                            double per = (double)Math.Round(percentage * 100) / 100;
                           
                            dataGridView1.Rows.Add(arr[i].ToString(), per.ToString()+ " %");
                        }
                        if(percentage >=70)
                        {
                            arr2[i] = team.Items[i].ToString();
                            label13.Text = string.Format(arr2[i] + " ");
                        }
                        if(percentage==0)
                        {
                            arr3[i] = team.Items[i].ToString();
                            label15.Text = string.Format(arr3[i] + " ");
                        }
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

        private void button4_Click(object sender, EventArgs e)
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