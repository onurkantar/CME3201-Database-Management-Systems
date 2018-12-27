using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOTO.DataAccess
{
    public class EmployeeEntityBase
    {
        private int _id;
            private string _Name;
            private string _SurName;
            private DateTime _Birthday;
            private int _Salary;
            private string _Workdays;
            private string _isPartTime;
            private string _Phone;
            private string _Mail;
            private string _Position;
            private string _SSN;



        public int id { get => _id; set => _id = value; }//done

        public string Name { get => _Name; set => _Name = value; }//done

        public string SurName { get => _SurName; set => _SurName = value; } //done

        public int Salary { get => _Salary; set => _Salary = value; }//done

        public string Workdays { get => _Workdays; set => _Workdays = value; }//done

        public string isPartTime { get => _isPartTime; set => _isPartTime = value; }//done

        public string Phone { get => _Phone; set => _Phone = value; }//done

        public string Mail { get => _Mail; set => _Mail = value; }//done

        public string Position { get => _Position; set => _Position = value; }//done

        public string SSN { get => _SSN; set => _SSN = value; }//done
        
        public DateTime Birthday { get => _Birthday; set => _Birthday = value; }//done
        
        public class EmployeeEntity : EmployeeEntityBase
        {
            public int getId() {

                return id;
            }

            public string getName() {

                return Name;
            }

            public int getSalary() {

                return Salary;

            }

            public string Info
            {
                get
                {
                    return Name + " " + SurName;
                }
            }
            public string BirthdayStr
            {
                get { return Birthday.ToString("dd.MM.yyyy dddd"); }
            }

        }

    }
}
