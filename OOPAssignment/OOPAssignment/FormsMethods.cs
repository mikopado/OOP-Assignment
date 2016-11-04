using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAssignment
{
    public class FormsMethods
    {
        
        #region Overloaded Filter Methods
        // Two methods with the same title (FilterList), because they do exactly the same thing,
        // but different signature (the generics Lists have as a types in one Student object and in the other Lecture object)

        // Overloaded Method to filter the List<Student>.
        // Summary: Searching if an input string corresponds to any Student ID, First Name 
        //          or Surname properties of Student class into an input List<Student>. 
        //          Then create a new List<Student> adding all records in the input List 
        //          that properties match to the key string.
        // Parameters: a List<Student> that needs to be filtered.
        //             a string that works as a filtered key.
        // Returns: a new List<Student> that contains all the matches.
        public static List<Student> FilterList(List<Student> originalList, string inputString)
        {

            int idSearching;

            bool isNumber = int.TryParse(inputString, out idSearching);

            List<Student> filteredList = new List<Student>();

            if (isNumber)
            {

                foreach (var item in originalList)
                {

                    if (item.StudentId == idSearching)
                    {

                        filteredList.Add(item);

                    }
                }
            }

            else
            {

                foreach (var item in originalList)
                {

                    if (item.FirstName.IndexOf(inputString, StringComparison.OrdinalIgnoreCase) == 0
                        || item.Surname.IndexOf(inputString, StringComparison.OrdinalIgnoreCase) == 0)
                    {

                        filteredList.Add(item);

                    }
                }
            }

            if (filteredList == null || filteredList.Count == 0)
            {

                throw new ArgumentException("No Student Found.");

            }

            return filteredList;
        }


        // Overloaded Method to filter the List<Lecturer>
        // Summary: Searching if an input string corresponds to any Staff ID, First Name 
        //          or Surname properties of Lecturer class into an input List<Lecturer>. 
        //          Then create a new List<Lecturer> adding all records in the input List 
        //          that properties match to the key string.
        // Parameters: a List<Lecturer> that needs to be filtered.
        //             a string that works as a filtered key.
        // Returns: a new List<Lecturer> that contains all the matches.
        public static List<Lecturer> FilterList(List<Lecturer> originalList, string inputString)
        {
            int idSearching;

            bool isNumber = int.TryParse(inputString, out idSearching);

            List<Lecturer> filteredList = new List<Lecturer>();

            if (isNumber)
            {

                foreach (var item in originalList)
                {

                    if (item.StaffId == idSearching)
                    {

                        filteredList.Add(item);

                    }
                }
            }
            else
            {

                foreach (var item in originalList)
                {

                    if (item.FirstName.IndexOf(inputString, StringComparison.OrdinalIgnoreCase) == 0
                        || item.Surname.IndexOf(inputString, StringComparison.OrdinalIgnoreCase) == 0)
                    {

                        filteredList.Add(item);

                    }
                }
            }

            if (filteredList == null || filteredList.Count == 0)
            {

                throw new ArgumentException("No Lecturer found.");

            }
            return filteredList;
        }

        #endregion

        #region Overloaded Add Record To List Methods
        // Add Lecturer object to a List.
        // Summary: it adds a lecturer object, pass to the method, to a List of same object
        //          only if there aren't objects in the list with the same ID property.
        // Parameters: a list of Lecturer and a Lecturer object.       
        public static void AddRecordToList(List<Lecturer> ListOfLecturers, Lecturer lect)
        {

            if (ListOfLecturers.Exists(x => x.StaffId == lect.StaffId))
            {

                throw new ArgumentException("Student ID already exists.");
                

            }

            else
            {

                ListOfLecturers.Add(lect);
                

            }

        }


        // Add Student object to a List.
        // Summary: it adds a Student object, pass to the method, to a List of same object
        //          only if there aren't objects in the list with the same ID property.
        // Parameters: a list of Student and a Student object.   
        public static void AddRecordToList(List<Student> listOfStudents, Student stud)
        {

            if (listOfStudents.Exists(x => x.StudentId == stud.StudentId))
            {

                throw new ArgumentException("Student ID already exists.");
                
            }

            
            listOfStudents.Add(stud);
                
            
        }

        #endregion
    }
}
