using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public abstract class Staff : Person, IComparable<Staff>
    {

        // Properties
        private int staffId;

        public int StaffId
        {

            get
            {

                return staffId;

            }

            private set
            {

                if(value > 0)
                {

                    staffId = value;

                }

                else
                {

                    throw new ArgumentOutOfRangeException("Staff ID", "Value cannot be negative.");
                }
            }
        }

        private decimal salary;

        public decimal Salary
        {

            get { return salary; }

            set
            {

                if (value >= 0M)
                {

                    salary = value;

                }

                else
                {

                    throw new ArgumentOutOfRangeException("Salary", "Value cannot be less than zero.");

                }
            }
        }


        // Constructor       
        public Staff(string fName, string surname, string address,
            string city, string country, string pps, string phone, string eMail, 
            int id, decimal salary)
            : base(fName, surname, address, city, country, pps, phone, eMail)
        {

            StaffId = id;
            Salary = salary;

        }
        

        // Overridden ToString() Method
        public override string ToString()
        {

            return (string.Format("Staff ID: {0}", StaffId) + Environment.NewLine + 
                base.ToString() + Environment.NewLine + string.Format("Salary in €: {0}", Salary));

        }

        // IComparable<Staff> Interface Implementation. Implemented in Lecturer Class
        public abstract int CompareTo(Staff other);

    }
}
