using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob_Lab_Football_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnProjected_Click(object sender, EventArgs e)
        {
            ProjectedScore frm = new ProjectedScore();
            this.Hide();
            frm.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void projectedbtn_Click(object sender, EventArgs e)
        {
            ProjectedScore frm = new ProjectedScore();
            this.Hide();
            frm.Show();
        }

        private void awayteamwinbtn_Click(object sender, EventArgs e)
        {
            PieAwayTeam P = new PieAwayTeam();
            this.Hide();
            P.Show();
        }

        private void winpredictorbtn_Click(object sender, EventArgs e)
        {
            WinPredictor W = new WinPredictor();
            this.Hide();
            W.Show();
        }

        private void groundpredictorbtn_Click(object sender, EventArgs e)
        {
            GroundPredicition nextForm = new GroundPredicition();
            this.Hide();
            nextForm.Show();
           
        }

        private void hometeamwinbtn_Click(object sender, EventArgs e)
        {
            Barchart1 nextForm = new Barchart1();
            this.Hide();
            nextForm.Show();
        }

        

        private void btnWinningPer_Click(object sender, EventArgs e)
        {
            winPercent nextForm = new winPercent();
            this.Hide();
            nextForm.Show();
        }

        private void finalistpredictorbtn_Click(object sender, EventArgs e)
        {
            yearlyData nextForm = new yearlyData();
            this.Hide();
            nextForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString();
            lblDateTime.Text += ",     " + DateTime.Now.ToLongTimeString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showData form = new showData();
            this.Hide();
            form.Show();
        }
    }
}
