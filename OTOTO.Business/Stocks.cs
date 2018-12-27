using System;
using System.Collections.Generic;
using OTOTO.DataAccess;
using static OTOTO.DataAccess.StockEntityBase;

namespace OTOTO.Business
{
    public class Stocks
    {
        public static List<StockEntity> GetAllStock()
        {
            return DataAccess.StockDAO.GetAllStock();
        }

        public static StockEntity SelectStock(int id)
        {
            if (id > 0)
                return DataAccess.StockDAO.SelectStockById(id);
            else
                return null;
        }

        public static StockEntity SelectStock(string value)
        {
            throw new NotImplementedException();
        }


        public static StockEntity DeleteStock(int id)
        {

            if (id > 0)
                return DataAccess.StockDAO.DeleteStock(id);
            else
                return null;


        }

        public static StockEntity InsertStock(System.DateTime sto_date, int quantity, int price, string fromwhere, string sto_name)
        {

            return DataAccess.StockDAO.InsertStock(sto_date, quantity, price, fromwhere, sto_name);

        }

        public static StockEntity UpdateStock(int id,System.DateTime sto_date, int quantity, int price, string fromwhere, string sto_name)
        {

            return DataAccess.StockDAO.UpdateStock(id, sto_date, quantity, price, fromwhere, sto_name);

        }

    }
}
