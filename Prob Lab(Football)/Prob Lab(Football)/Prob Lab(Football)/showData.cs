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

namespace Prob_Lab_Football_
{
    public partial class showData : Form
    {
        SqlConnection con;
        SQLConn obj = new SQLConn();
        void GetData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query;
                query = "select Mdate,home_team,away_team,home_score,away_score,tournament,city,country from results order by Mdate";
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);

                dataGridView1.DataSource = dt;
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        
        public showData()
        {
            InitializeComponent();
            con = obj.con;
            GetData(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showData_Load(object sender, EventArgs e)
        {

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

        private void showData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                button1_Click(sender, e);
            }
        }

        

        

    }
}
