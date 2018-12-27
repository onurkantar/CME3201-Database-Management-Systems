using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOTO.DataAccess
{
    public class StockEntityBase
    {
        private int _id;
        private string _StoDate;
        private int _Quantity;
        private int _Price;
        private string _FromWhere;
        private string _StoName;



        public int ID { get => _id; set => _id = value; }//done

        public string StoDate { get => _StoDate; set => _StoDate = value; }//done

        public int Quantity { get => _Quantity; set => _Quantity = value; } //done

        public int Price { get => _Price; set => _Price = value; }//done

        public string FromWhere { get => _FromWhere; set => _FromWhere = value; }//done

        public string StoName { get => _StoName; set => _StoName = value; }//done

        public class StockEntity : StockEntityBase
        {
            public string Info
            {
                get
                {
                    return StoName + " " + Quantity;
                }
            }

        }

    }
}
