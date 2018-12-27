using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OTOTO.DataAccess.StockEntityBase;

namespace OTOTO.DataAccess
{
    public class StockDAO
    {
        public static List<StockEntity> GetAllStock()
        {
            List<StockEntity> list = null;
            SqlCommand com = new SqlCommand("spSelectStock", Connection.Con);

            if (com.Connection.State == ConnectionState.Closed)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                list = new List<StockEntity>();
                while (rd.Read())
                {
                    list.Add(new StockEntity
                    {
                        ID = Convert.ToInt16(rd["sto_id"]),
                        StoDate = rd["sto_date"].ToString(),
                        Quantity = Convert.ToInt16(rd["quantity"]),
                        Price = Convert.ToInt16(rd["price"]),
                        FromWhere = rd["fromwhere"].ToString(),
                        StoName = rd["sto_name"].ToString()
                    });
                }
            }
            com.Dispose();
            com.Connection.Close();
            return list;
        }

        public static StockEntity SelectStockById(int id)
        {
            SqlCommand com = new SqlCommand("sp_GetStockByID @ID", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);

            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {

                rd.Read();

                return new StockEntity
                {
                    ID = Convert.ToInt16 (rd["sto_id"]),
                    StoDate = rd["sto_date"].ToString(),
                    Quantity = Convert.ToInt16(rd["quantity"]),
                    Price = Convert.ToInt16(rd["price"]),
                    FromWhere = rd["fromwhere"].ToString(),
                    StoName = rd["sto_name"].ToString()
                };

            }
            com.Dispose();
            com.Connection.Close();

            return null;
        }


        public static StockEntity InsertStock(System.DateTime StoDate, int Quantity, int Price, string FromWhere, string StoName)
        {
            SqlCommand com = new SqlCommand("SP_InsertStock @STODATE ,@QUANTITY ,@PRICE ,@FROMWHERE ,@STONAME", Connection.Con);
            com.Parameters.AddWithValue("@STODATE", StoDate);
            com.Parameters.AddWithValue("@QUANTITY", Quantity);
            com.Parameters.AddWithValue("@PRICE", Price);
            com.Parameters.AddWithValue("@FROMWHERE", FromWhere);
            com.Parameters.AddWithValue("@STONAME", StoName);

            com.Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();



            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();


            com.Dispose();
            com.Connection.Close();

            return null;
        }

        public static StockEntity UpdateStock(int id,System.DateTime StoDate, int Quantity, int Price, string FromWhere, string StoName)
        {


            SqlCommand com = new SqlCommand("SP_UpdateStock @ID ,@STODATE ,@QUANTITY ,@PRICE ,@FROMWHERE ,@STONAME", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);
            com.Parameters.AddWithValue("@STODATE", StoDate);
            com.Parameters.AddWithValue("@QUANTITY", Quantity);
            com.Parameters.AddWithValue("@PRICE", Price);
            com.Parameters.AddWithValue("@FROMWHERE", FromWhere);
            com.Parameters.AddWithValue("@STONAME", StoName);

            com.Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();

            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();

            com.Dispose();
            com.Connection.Close();

            return null;
        }

        public static StockEntity DeleteStock(int id)
        {


            SqlCommand com = new SqlCommand("SP_DeleteStock @ID", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);

            com.Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();


            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }


            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();

            com.Dispose();
            com.Connection.Close();

            return null;
        }


    }
}
