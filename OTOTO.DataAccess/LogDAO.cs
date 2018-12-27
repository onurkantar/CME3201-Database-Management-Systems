using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OTOTO.DataAccess.LogEntityBase;

namespace OTOTO.DataAccess
{
    public class LogDAO
    {
        public static List<LogEntity> GetAllLogs()
        {
            List<LogEntity> list = null;
            SqlCommand com = new SqlCommand("spSelectLogs", Connection.Con);

            if (com.Connection.State == ConnectionState.Closed)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                list = new List<LogEntity>();
                while (rd.Read())
                {
                    list.Add(new LogEntity
                    {
                        id = rd["Transaction ID"].ToString(),
                        op = rd["Operation"].ToString(),
                        name = rd["Transaction Name"].ToString(),
                        context = rd["CONTEXT"].ToString(),
                        allocUnit = rd["AllocUnitName"].ToString(),
                        pid = rd["Page ID"].ToString(),
                        sid = rd["Slot ID"].ToString(),
                        begin = rd["Begin Time"].ToString(),
                        end = rd["End Time"].ToString(),
                    });
                }
            }
            com.Dispose();
            com.Connection.Close();
            return list;
        }
        

    }
}
