using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOTO.DataAccess
{
    public class Connection
    {
        public static readonly SqlConnection Con = new SqlConnection("server=DESKTOP-MA5SROA;database=dbms;Trusted_Connection=true;MultipleActiveResultSets=True;");
    }
}
