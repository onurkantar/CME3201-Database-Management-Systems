using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOTO.DataAccess
{
    public class LogEntityBase
    {
        private string _id;
        private string _op;
        private string _name;
        private string _context;
        private string _allocUnit;
        private string _pid;
        private string _sid;

        private string _begin;

        private string _end;
        private System.DateTime _date;





        public string id { get => _id; set => _id = value; }//done

        public string op { get => _op; set => _op = value; } //done

        public string name { get => _name; set => _name = value; } //done


        public string context { get => _context; set => _context = value; } //done

        public string allocUnit { get => _allocUnit; set => _allocUnit = value; } //done

        public string pid { get => _pid; set => _pid = value; } //done

        public string sid { get => _sid; set => _sid = value; }//done
        public string begin { get => _begin; set => _begin = value; } //done
        public string end { get => _end; set => _end = value; } //done

        public class LogEntity : LogEntityBase
        {
            public string Info
            {
                get
                {
                    return op;
                }
            }

        }

    }
}
