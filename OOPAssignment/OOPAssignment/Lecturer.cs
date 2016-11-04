using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
   
    public class Lecturer : Staff
    {

        // Properties
        public static SortDirection SortWay { get; set; }

        public static SortMethod SortOrder { get; set; }

        private string subjectTaught;        

        public string SubjectTaught
        {
            get { return subjectTaught; }

            set
            {

                if (!string.IsNullOrEmpty(value))
                {
                    subjectTaught = value;
                }

                else
                {
                    throw new ArgumentNullException("Subject(s) Taught", "Field cannot be empty");
                }

            }
        }


        // Constructor      
        public Lecturer(string fName, string surname, string address, 
            string city, string country, string pps, string phone, string eMail, 
            int id, decimal salary, string subjects)
            : base(fName, surname, address, city, country, pps, phone, eMail, id, salary)
        {

            SubjectTaught = subjects;

        }


        // Overridden ToString() Method
        public override string ToString()
        {

            return base.ToString() + Environment.NewLine + string.Format("Subject(s) Taught: {0}", SubjectTaught);

        }


        // Overridden CompareTo() Method from IComparable<Staff> Interface inherited from Staff Class.
        // Summary: Comparing two Staff objects in three different ways based 
        //          on three Staff properties(ID, First Name and Surname) and comparing 
        //          this object to other if ascending, the other way around if descending. 
        // Parameters : Staff object.
        // Return : integer i equal to 1, -1 or 0.         
        public override int CompareTo(Staff other)
        {
            int i = -1;

            if (other != null)
            {
                if (SortWay == SortDirection.Ascending)
                {
                    switch (SortOrder)
                    {
                        case SortMethod.Id:
                            i = this.StaffId.CompareTo(other.StaffId);
                            break;
                        case SortMethod.FirstName:
                            i = this.FirstName.CompareTo(other.FirstName);
                            break;
                        case SortMethod.Surname:
                            i = this.Surname.CompareTo(other.Surname);
                            break;

                    }
                }

                else if (SortWay == SortDirection.Descending)
                {
                    switch (SortOrder)
                    {
                        case SortMethod.Id:
                            i = other.StaffId.CompareTo(this.StaffId);
                            break;
                        case SortMethod.FirstName:
                            i = other.FirstName.CompareTo(this.FirstName);
                            break;
                        case SortMethod.Surname:
                            i = other.Surname.CompareTo(this.Surname);
                            break;

                    }
                }
            }
           

            return i;
        }


       
    }
}
