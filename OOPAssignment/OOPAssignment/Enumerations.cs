using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{

    // Enumerations used in Lecturer and Student Classes. 
    // Lumped together for better readability.

    // Enumeration to distinguish two Student Status
    public enum Status
    {
        UnderGrad,
        PostGrad
    }

    // Enumeration for sorting the Lists in three different way
    public enum SortMethod
    {
        Id,
        FirstName,
        Surname
    }

    // Enumeration for swapping the sorting from ascending to descending
    public enum SortDirection
    {
        Ascending,
        Descending
    }
}
