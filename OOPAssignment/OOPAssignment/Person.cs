using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public abstract class Person 
    {
        private readonly string ERROR_MESSAGE = "Field cannot be empty. ";

        //Properties
        private string firstName;

        public string FirstName
        {
            get { return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstName); }

            private set
            {

                if(!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }

                else
                {
                    throw new ArgumentNullException("First Name", ERROR_MESSAGE);
                }
                
            }
        }

        private string surname;

        public string Surname
        {
            get { return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(surname); }

            private set
            {

                if(!string.IsNullOrEmpty(value))
                {
                    surname = value;
                }

                else
                {
                    throw new ArgumentNullException("Surname", ERROR_MESSAGE);
                }
                
            }
        }

        private string ppsNumber;

        public string PPSNumber
        {
            get
            {
                return ppsNumber;
            }

            set
            {

                if (!string.IsNullOrEmpty(value))
                {
                    ppsNumber = value;
                }

                else
                {
                    throw new ArgumentNullException("PPS Number", ERROR_MESSAGE);
                }
            }
        }

        private string address;

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    address = value;
                }

                else
                {
                    throw new ArgumentNullException("Address", ERROR_MESSAGE);
                }
            }
         }

        private string city;

        public string City
        {
            get
            {
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city);
            }

            set
            {

                if(!string.IsNullOrEmpty(value))
                {
                    city = value;
                }

                else
                {
                    throw new ArgumentNullException("City", ERROR_MESSAGE);
                }
            }
        }

        private string country;

        public string Country
        {
            get
            {
                return country;
            }
            set
            {

                if(!string.IsNullOrEmpty(value))
                {
                    country = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
                }

                else
                {
                    throw new ArgumentNullException("Country", ERROR_MESSAGE);
                }
            }
               
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }

            set
            {     
                          
                long phone;
                bool checkNumber = long.TryParse(value, out phone);

                if(checkNumber)
                {

                    phoneNumber = value;

                }

                else
                {

                    throw new FormatException("Phone Number is not in the correct format!");

                }

                

                
            }
        }

        private string eMail;

        public string EMail
        {
            get { return eMail; }

            set
            {
                if(value.Contains('@'))
                {
                    eMail = value;
                }
                else
                {
                    throw new FormatException("E-Mail input is not in the correct format!");
                }
               
            }
        }

        // Constructor        
        public Person(string fName, string surname, string address, 
            string city, string country, string pps, string phone, string eMail)
            
        {
            FirstName = fName;
            Surname = surname;
            Address = address;
            City = city;
            Country = country;
            PhoneNumber = phone;
            EMail = eMail;
            PPSNumber = pps;

        }

        // Overridden ToString() Method
        public override string ToString()
        {
            return string.Format("First Name: {0}\nSurname: {1}\nAddress: {2}\nCity: {3}" + 
                "\nCountry: {4}\nPPS: {5}\nPhone Number: {6}\nE-Mail: {7}",
                FirstName, Surname, Address, City, Country, PPSNumber, PhoneNumber, EMail);
        }

        
        
    }
}
