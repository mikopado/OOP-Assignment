using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{


    public class Student : Person, IComparable<Student>
    {

        // Properties

        public static SortMethod SortOrder { get; set; }

        public static SortDirection SortWay { get; set; }

        private Status studStatus;        

        public Status StudentStatus
        {

            get { return studStatus; }

            set
            {

                if(value != Status.UnderGrad && value != Status.PostGrad)
                {

                    throw new ArgumentOutOfRangeException("Student Status", "Value is not selected!");

                }

                else
                {
                    studStatus = value;
                }
                
            }
        }

        private int studentId;

        public int StudentId
        {

            get
            {

                return studentId;

            }

            private set
            {

                if(value > 0)
                {

                    studentId = value;

                }

                else
                {

                    throw new ArgumentOutOfRangeException("Student ID", "Value cannot be negative.");

                }

            }
        }

        private string degreeTitle;

        public string DegreeTitle
        {

            get
            {
                return degreeTitle;
            }

            set
            {

                if(!string.IsNullOrEmpty(value))
                {
                    degreeTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
                }

                else
                {
                    throw new ArgumentNullException("Degree Title", "Field cannot be empty.");
                }
            }
        }


        // Constructor     
        public Student(string fName, string surname, string address, 
            string city, string country, string pps, string phone, string eMail, 
            Status currentStatus, int id, string degree) 
            : base(fName, surname, address, city, country, pps, phone, eMail)             

        {
            StudentStatus = currentStatus;
            StudentId = id;
            DegreeTitle = degree;
        }


        // Overriden ToString() Method 
        public override string ToString()
        {
            return (string.Format("Student ID: {0}", StudentId) + Environment.NewLine +
                base.ToString() + Environment.NewLine + string.Format("Current Student Status: {0}\nDegree Title: {1}",
                StudentStatus, DegreeTitle));
        }


        // CompareTo() Method to modify the default Sort() method of List<Student> associated.
        // Overridden CompareTo() Method inherited from IComparable<Student> Interface.
        // Summary: Comparing two Student objects in three different ways based 
        //          on three Student properties(ID, First Name and Surname) and comparing 
        //          this object to other if ascending, the other way around if descending. 
        // Parameters : Student object.
        // Return : integer i equal to 1, -1 or 0.  
        public int CompareTo(Student other)
        {
            int i = -1;

            if(other != null)
            {
                if(SortWay == SortDirection.Ascending)
                {
                    switch (SortOrder)
                    {
                        case SortMethod.Id:
                            i = this.StudentId.CompareTo(other.StudentId);
                            break;
                        case SortMethod.FirstName:
                            i = this.FirstName.CompareTo(other.FirstName);
                            break;
                        case SortMethod.Surname:
                            i = this.Surname.CompareTo(other.Surname);
                            break;
                        
                    }
                }
                else if(SortWay == SortDirection.Descending)
                {
                    switch (SortOrder)
                    {
                        case SortMethod.Id:
                            i = other.StudentId.CompareTo(this.StudentId);
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
