using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    class Documentation
    {

        #region  Additional Innovation Documentation
        /*
        
        The main additional innovation applied to this application is the modification of the 
        default Sort() method. 
        The application implements the functionality of sorting the lists in data grid view of both
        classes (student and lecturer).

        The user has the possibility to sort the list by ID(Student Id or Staff Id), First Name and
        Surname independently. Moreover the application allows the sorting either in ascending order 
        or descending order.
        This implemented functionality it has been obtained by implementing the IComparable<> Interface 
        for the mentioned classes.
        In this way the CompareTo() method of the Interface has been modified to compare the objects 
        of classes based on the selected properties.

        An other small addition to the application is the Show Student/Lecturer Detail event.
        This event allows the user to display the information of any single record that 
        it has been added to the List. 
        This should enhance the readability of the details of the selected record in the List.

        */

        #endregion

        #region Testing Documentation

        /*
         The methods tested are :
                ---> CompareTo() from Lecturer Class
                    Tested for each properties(ID, First Name, Surname) if the integer output
                    it is 1 when this object is greater than other object, -1 vice versa or zero
                    when they are equal.

                ---> FilterList(List<Lecturer>, string) from FormsMethods Class
                    Tested if the ouptut list contains the element in the original list that has been searched,
                    either it is a number(ID) or a string(FirstName, Surname).
                    Tested some exceptions when the input list is null and when the output list is null.
                 
                ---> FilterList(List<Student>, string) from FormsMethod Class

                ---> AddRecordToList(List<Lecturer>, Lecturer) from FormsMethods Class
                    Tested if the method add the Lecturer object to the List.
                    Tested if some Exceptions are thrown when properties of the object are not 
                    well formatted or are null or the ID properties already exists.

                ---> AddRecordToList(List<Student>, Student) from FormsMethods Class 
        */

        #endregion
    }
}
