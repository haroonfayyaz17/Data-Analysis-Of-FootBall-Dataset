using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Management;
using System.Threading.Tasks;

namespace Prob_Lab_Football_
{
    class SQLConn
    {
        public SqlConnection con;

        public SQLConn()
        {
            con = new SqlConnection(@"Data Source=(localdb)\haroongaba;Initial Catalog=FootballData;Integrated Security=True;multipleactiveresultsets=true");

            //con=new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString);
        }
        
    }
}
