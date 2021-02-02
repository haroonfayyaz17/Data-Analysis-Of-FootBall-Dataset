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
    public partial class ProjectedScore : Form
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
        void FillProjected()
        {
            try
            {
                cmbGoals.Items.Clear();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("select max(home_score) As score from results", con);
                SqlDataReader reader = cmd.ExecuteReader();

                int n1 = 0, n2 = 0;
                while (reader.Read())
                {
                    n1 = Convert.ToInt32(reader["score"].ToString());
                }
                reader.Close();
                cmd.CommandText = "select max(away_score) As score from results";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n2 = Convert.ToInt32(reader["score"].ToString());
                }
                if (n1 < n2)
                    n1 = n2;
                for (int i = 0; i <= n1; i++)
                {
                    cmbGoals.Items.Add(Convert.ToString(i));
                    cmbGoals1.Items.Add(Convert.ToString(i));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ProjectedScore()
        {
            InitializeComponent();
            con = obj.con;
            LoadTeams(cmbTeamA, "select distinct home_team As Name from results");
            LoadTeams(cmbTeamB, "select distinct away_team As Name from results");
            LoadTeams(cmbTeams, "select distinct away_team As Name from results");
            LoadTeams(cmbTeamAPG, "select distinct home_team As Name from results");
            LoadTeams(cmbTeamBPG, "select distinct away_team As Name from results");
            LoadTeams(cmbTeamPG, "select distinct away_team As Name from results");
            FillProjected();
            gridGoals.Visible = false;
            GridPG.Visible = false;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            /*team a and team b  probability that A will score x goals given that the match is against team B  */

            string AIntersectionB = "select count(*) as 'A and B' from results r where (r.away_score>=" + cmbGoals.Text + "or r.home_score>=" + cmbGoals.Text + ") and (r.home_team='" + cmbTeamA.Text + "' and r.away_team='" + cmbTeamB.Text + "')or (r.home_team='" + cmbTeamB.Text + "'and away_team='" + cmbTeamA.Text + "')";
            string probB = "select count(*) as 'probB' from results where away_team='" + cmbTeamB.Text + "' or home_team='" + cmbTeamB.Text + "'";

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(AIntersectionB, con);
                SqlDataReader reader = cmd.ExecuteReader();

                int n1 = 0, n2 = 0;
                while (reader.Read())
                {
                    n1 = Convert.ToInt32(reader["A and B"].ToString());
                }
                reader.Close();
                cmd.CommandText = probB;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n2 = Convert.ToInt32(reader["probB"].ToString());
                }
                float value = (float)n1 / (float)n2;
                lblValue.Text = "Probability that " + cmbTeamA.Text + " will score " + cmbGoals.Text + " or more goals given that the match is against " + cmbTeamB.Text + "= " + value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            /*team a and team b  probability that A will score x goals given that the match is against team B  */
            try
            {
                
                if (gridGoals.RowCount > 1)
                    gridGoals.Rows.Clear();
                if (cmbTeams.Text != "")
                {
                    if (cmbGoals1.Text != "")
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand();
                        SqlDataReader reader;

                        for (int i = 0; i < cmbTeams.Items.Count; i++)
                        {
                            if (cmbTeams.Items[i].ToString() != cmbTeams.Text)
                            {
                                string AIntersectionB = "select count(*) as 'A and B' from results r where (r.away_score>=" + cmbGoals1.Text + "or r.home_score>=" + cmbGoals1.Text + ") and (r.home_team='" + cmbTeams.Text + "' and r.away_team='" + cmbTeams.Items[i].ToString() + "')or (r.home_team='" + cmbTeams.Items[i].ToString() + "'and away_team='" + cmbTeams.Text + "')";
                                string probB = "select count(*) as 'probB' from results where away_team='" + cmbTeams.Items[i].ToString() + "' or home_team='" + cmbTeamB.Items[i].ToString() + "'";
                                cmd.Connection = con;
                                cmd.CommandText = AIntersectionB;
                                reader = cmd.ExecuteReader();
                                int n1 = 0, n2 = 0;
                                while (reader.Read())
                                {
                                    if (reader["A and B"] == DBNull.Value)
                                        n1 = 0;
                                    else
                                        n1 = Convert.ToInt32(reader["A and B"].ToString());
                                }
                                reader.Close();
                                cmd.CommandText = probB;
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    if (reader["probB"] == DBNull.Value)
                                        n2 = 0;
                                    else
                                        n2 = Convert.ToInt32(reader["probB"].ToString());
                                }
                                reader.Close();
                                float value = (float)n1 / (float)n2;
                                gridGoals.Rows.Add(cmbTeams.Items[i].ToString(), value.ToString());
                            }
                        }
                    }

                }
                gridGoals.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbGoals_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            //if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}
        }

        private void btnGetPG_Click(object sender, EventArgs e)
        {
            string home_score = "select round(avg(home_score),0) As 'AvgH' from results where home_team='" + cmbTeamAPG.Text + "' and away_team='" + cmbTeamBPG.Text + "'";
            string away_score = "select round(avg(away_score),0) As 'AvgA' from results where home_team='" + cmbTeamBPG.Text + "' and away_team='" + cmbTeamAPG.Text + "'";

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(home_score, con);
                SqlDataReader reader = cmd.ExecuteReader();

                int n1H = 0, n2A = 0;
                while (reader.Read())
                {
                    if (reader["AvgH"] == DBNull.Value)
                        n1H = 0;
                    else
                        n1H = Convert.ToInt32(reader["AvgH"].ToString());
                }
                reader.Close();
                cmd.CommandText = away_score;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["AvgA"] == DBNull.Value)
                        n2A = 0;
                    else
                        n2A = Convert.ToInt32(reader["AvgA"].ToString());
                }
                if (n2A > n1H)
                    n1H = n2A;
                lblGoals.Text = "Projected Goals that " + cmbTeamAPG.Text + " can score against " + cmbTeamBPG.Text + " = " + n1H;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayPG_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (GridPG.RowCount > 1)
                    GridPG.Rows.Clear();
                if (cmbTeamPG.Text != "")
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;

                    for (int i = 0; i < cmbTeams.Items.Count; i++)
                    {
                        if (cmbTeams.Items[i].ToString() != cmbTeams.Text)
                        {
                            string home_score = "select round(avg(home_score),0) As 'AvgH' from results where home_team='" + cmbTeamAPG.Text + "' and away_team='" + cmbTeamPG.Items[i].ToString() + "'";
                            string away_score = "select round(avg(away_score),0) As 'AvgA' from results where home_team='" + cmbTeamPG.Items[i].ToString() + "' and away_team='" + cmbTeamPG.Text + "'";
                            cmd.Connection = con;
                            cmd.CommandText = home_score;
                            reader = cmd.ExecuteReader();
                            int n1H = 0, n2A = 0;
                            while (reader.Read())
                            {
                                if (reader["AvgH"] == DBNull.Value)
                                    n1H = 0;
                                else
                                    n1H = Convert.ToInt32(reader["AvgH"].ToString());
                            }
                            reader.Close();
                            cmd.CommandText = away_score;
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                if (reader["AvgA"] == DBNull.Value)
                                    n2A = 0;
                                else
                                    n2A = Convert.ToInt32(reader["AvgA"].ToString());
                            }
                            if (n2A > n1H)
                                n1H = n2A;
                            reader.Close();

                            GridPG.Rows.Add(cmbTeams.Items[i].ToString(), n1H.ToString());
                        }
                    }
                }
                GridPG.Visible = true;
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

        private void SingleTeamTab_Click(object sender, EventArgs e)
        {

        }
    }
}
