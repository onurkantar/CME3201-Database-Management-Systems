using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOTO.DataAccess
{
    public class CustomerEntityBase
    {
        private string _Name;
        private string _SurName;
        private string _Phone;
        private string _Mail;
        private string _SSN;





        public string Name { get => _Name; set => _Name = value; }//done

        public string SurName { get => _SurName; set => _SurName = value; } //done

        public string Phone { get => _Phone; set => _Phone = value; }//done

        public string Mail { get => _Mail; set => _Mail = value; }//done

        public string SSN { get => _SSN; set => _SSN = value; }//done

        public class CustomerEntity : CustomerEntityBase
        {
            public string Info
            {
                get
                {
                    return Name + " " + SurName;
                }
            }

        }

    }
}
