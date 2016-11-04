using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Tests
{
    [TestClass]
    public class CollegeTests
    {

        #region CompareTo() Lecturer

        // CompareTo() Method in Lecturer Class
        [TestMethod]
        public void CompareLecturerObjectsByStaffIdWhenOtherGreaterThanThis()
        {
            // arrange
            Lecturer first = new Lecturer("Mark", "Carl", "23 street", "Dublin", "Ireland",
                                         "0987T","2345657", "mark@gmail", 1, 23456M, "Chemistry, Biology");
            Lecturer second = new Lecturer("John", "Call", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "John@gmail", 2, 32435M, "Arts, Painting");
            int result = -1;

            //act
            first.StaffId.CompareTo(second.StaffId);


            // assert
            int actualResult = first.StaffId.CompareTo(second.StaffId);
            Assert.AreEqual(result, actualResult);

        }

        [TestMethod]
        public void CompareLecturerObjectsByStaffIdWhenThisGreaterThanOther()
        {
            // arrange
            Lecturer first = new Lecturer("Mark", "Barl", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "mark@gmail", 4, 32445M, "Software");
            Lecturer second = new Lecturer("John", "Call", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "john@gmail", 2, 4533M, "Business");
            int result = 1;

            //act
            first.StaffId.CompareTo(second.StaffId);


            // assert
            int actualResult = first.StaffId.CompareTo(second.StaffId);
            Assert.AreEqual(result, actualResult);

        }

        [TestMethod]
        public void CompareLecturerObjectsByStaffIdWhenThisEqualToOther()
        {
            // arrange
            Lecturer first = new Lecturer("Mark", "Barl", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "mark@gmail", 4, 32435, "Algorithms");
            Lecturer second = new Lecturer("John", "Call", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "mark@gmail", 4, 4235M, "Finance");
            int result = 0;

            //act
            first.StaffId.CompareTo(second.StaffId);


            // assert
            int actualResult = first.StaffId.CompareTo(second.StaffId);
            Assert.AreEqual(result, actualResult);

        }


        [TestMethod]
        public void CompareLecturerObjectsByFirstNameWhenOtherGreaterThanThis()
        {
            // arrange
            Lecturer first = new Lecturer("Mark", "Carl", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "mark@gmail", 1, 32454M, "Physics");
            Lecturer second = new Lecturer("Sean", "Call", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "sean@gmail", 2, 4352M, "Science");
            int result = -1;

            //act
            first.FirstName.CompareTo(second.FirstName);


            // assert
            int actualResult = first.FirstName.CompareTo(second.FirstName);
            Assert.AreEqual(result, actualResult);

        }

        [TestMethod]
        public void CompareLecturerObjectsByFirstNameWhenThisGreaterThanOther()
        {
            // arrange
            Lecturer first = new Lecturer("Mark", "Barl", "23 street", "Dublin", "Ireland",
                                            "0987T", "2345657", "mark@gmail", 4, 2435M, "Sociology");
            Lecturer second = new Lecturer("John", "Call", "23 street", "Dublin", "Ireland",
                                            "0987T", "2345657", "john@gmail", 2, 3245M, "Psicology");
            int result = 1;

            //act
            first.FirstName.CompareTo(second.FirstName);


            // assert
            int actualResult = first.FirstName.CompareTo(second.FirstName);
            Assert.AreEqual(result, actualResult);

        }

        [TestMethod]
        public void CompareLecturerObjectsByFirstNameWhenThisEqualToOther()
        {
            // arrange
            Lecturer first = new Lecturer("John", "Barl", "23 street", "Dublin", "Ireland",
                                          "0987T", "2345657", "john@gmail", 4, 3425346M, "Sales");
            Lecturer second = new Lecturer("John", "Call", "23 street", "Dublin", "Ireland",
                                         "0987T", "2345657", "mark@gmail", 2, 32435M, "Astronomy");
            int result = 0;

            //act
            first.FirstName.CompareTo(second.FirstName);


            // assert
            int actualResult = first.FirstName.CompareTo(second.FirstName);
            Assert.AreEqual(result, actualResult);

        }

        [TestMethod]
        public void CompareLecturerObjectsBySurnameWhenOtherGreaterThanThis()
        {
            // arrange
            Lecturer first = new Lecturer("Mark", "Barl", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "mark@gmail", 1, 24356M, "Science");
            Lecturer second = new Lecturer("John", "Call", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "john@gmail", 2, 34546M, "Literature");
            int result = -1;

            //act
            first.Surname.CompareTo(second.Surname);


            // assert
            int actualResult = first.Surname.CompareTo(second.Surname);
            Assert.AreEqual(result, actualResult);

        }

        [TestMethod]
        public void CompareLecturerObjectsBySurnameWhenThisEqualToOther()
        {
            // arrange
            Lecturer first = new Lecturer("Mark", "Call", "23 street", "Dublin", "Ireland",
                                            "0987T", "2345657", "mark@gmail", 4, 4258M, "English");
            Lecturer second = new Lecturer("John", "Call", "23 street", "Dublin", "Ireland",
                                            "0987T", "2345657", "John@gmail", 2, 3455M, "Spanish");
            int result = 0;

            //act
            first.Surname.CompareTo(second.Surname);


            // assert
            int actualResult = first.Surname.CompareTo(second.Surname);
            Assert.AreEqual(result, actualResult);

        }

        [TestMethod]
        public void CompareLecturerObjectsBySurnameWhenThisGreaterThanOther()
        {
            // arrange
            Lecturer first = new Lecturer("Mark", "Daily", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "mark@gmail", 4, 3245M, "Criminology");
            Lecturer second = new Lecturer("John", "Call", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "john@gmail", 2, 4354M, "Speleology");
            int result = 1;

            //act
            first.Surname.CompareTo(second.Surname);


            // assert
            int actualResult = first.Surname.CompareTo(second.Surname);
            Assert.AreEqual(result, actualResult);

        }

        #endregion

        #region FilterList() Students
        // Filter List Method for Students
        [TestMethod]        
        public void FilterListStudentsIfTheInputIsNumberResultFilteredListById()
        {
            // arrange
            
            List<Student> listOfStudent = new List<Student>() { 
                                        new Student("Mark", "Carling", "19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", Status.UnderGrad, 12, "Science"),
                                        new Student("John", "Thompson","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "john@gmail", Status.UnderGrad, 55, "Arts"),
                                        new Student("Tommy", "Barrington","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", Status.PostGrad, 21, "Maths")
                                        };
            string input = "55";
            Student objExpected = listOfStudent[1];

            //act
            List<Student> filtList = FormsMethods.FilterList(listOfStudent, input);

            // assert   
                    
            CollectionAssert.Contains(filtList, objExpected);
        }
    
        [TestMethod]
        public void FilterListStudentsIfTheInputIsNotNumberResultFilteredListByFirstName()
        {
            // arrange

            List<Student> listOfStudent = new List<Student>() {
                                        new Student("Mark", "Carling", "19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", Status.UnderGrad, 12, "Science"),
                                        new Student("John", "Thompson","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "john@gmail", Status.UnderGrad, 55, "Arts"),
                                        new Student("Tommy", "Barrington","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", Status.PostGrad, 21, "Maths")
                                        };
            string input = "ma";
            Student objExpected = listOfStudent[0];

            //act
            List<Student> filtList = FormsMethods.FilterList(listOfStudent, input);

            // assert            
            CollectionAssert.Contains(filtList, objExpected);
        }

        [TestMethod]
        public void FilterListStudentsIfTheInputIsNotNumberResultFilteredListBySurname()
        {

            List<Student> listOfStudent = new List<Student>() {
                                        new Student("Mark", "Carling", "19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", Status.UnderGrad, 12, "Science"),
                                        new Student("John", "Thompson","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "john@gmail", Status.UnderGrad, 55, "Arts"),
                                        new Student("Tommy", "Barrington","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", Status.PostGrad, 21, "Maths")
                                        };
            string input = "Th";
            Student objExpected = listOfStudent[1];

            //act
            List<Student> filtList = FormsMethods.FilterList(listOfStudent, input);

            // assert
            CollectionAssert.Contains(filtList, objExpected);
        }
        
        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FilterListStudentsIfInpuListIsNullNullReferenceExceptionThrow()
        {
            // arrange
            string input = "33";
            List<Student> inputList = null;

            // act
            FormsMethods.FilterList(inputList, input);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FilterListStudentstWhenResultsIsNullNullArgExceptionThrow()
        {
            // arrange
            List<Student> list = new List<Student>() {
                                new Student("John", "Mall", "19 avenue", "Cork", "Ireland",
                                "0987U", "345778", "john@gmail", Status.PostGrad, 45, "Computer Science") };
            string subString = "ad";

            // act
            FormsMethods.FilterList(list, subString);
        }

        #endregion

        #region FilterList() Lecturers
        [TestMethod]
        public void FilterListLecturerIfTheInputIsNumberResultFilteredListById()
        {
            // arrange

            List<Lecturer> listOfLecturers = new List<Lecturer>() {
                                        new Lecturer("Mark", "Carling", "19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", 12, 23455M, "Science"),
                                        new Lecturer("John", "Thompson","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "john@gmail", 55, 234556M, "Arts"),
                                        new Lecturer("Tommy", "Barrington","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", 21, 235536M, "Maths")
                                        };
            string input = "21";
            Lecturer objExpected = listOfLecturers[2];

            //act
            List<Lecturer> filtList = FormsMethods.FilterList(listOfLecturers, input);

            // assert   

            CollectionAssert.Contains(filtList, objExpected);
        }

        [TestMethod]
        public void FilterListLecturerIfTheInputIsNotNumberResultFilteredListByFirstName()
        {
            // arrange

            List<Lecturer> listOfLecturers = new List<Lecturer>() {
                                        new Lecturer("Mark", "Carling", "19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", 12, 32464M, "Science"),
                                        new Lecturer("John", "Thompson","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "john@gmail", 55, 232435M, "Arts"),
                                        new Lecturer("Tommy", "Barrington","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", 21, 2456M, "Maths")
                                        };
            string input = "to";
            Lecturer objExpected = listOfLecturers[2];

            //act
            List<Lecturer> filtList = FormsMethods.FilterList(listOfLecturers, input);

            // assert            
            CollectionAssert.Contains(filtList, objExpected);
        }

        [TestMethod]
        public void FilterListLecturersIfTheInputIsNotNumberResultFilteredListBySurname()
        {

            List<Lecturer> listOfLecturers = new List<Lecturer>() {
                                        new Lecturer("Mark", "Carling", "19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", 12, 32435M, "Science"),
                                        new Lecturer("John", "Thompson","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "john@gmail", 55, 32453M, "Arts"),
                                        new Lecturer("Tommy", "Barrington","19 street", "Dublin", "Ireland",
                                                    "0897Y", "23456546", "mark@gmail", 21, 12324M, "Maths")
                                        };
            string input = "Ba";
            Lecturer objExpected = listOfLecturers[2];

            //act
            List<Lecturer> filtList = FormsMethods.FilterList(listOfLecturers, input);

            // assert
            CollectionAssert.Contains(filtList, objExpected);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FilterListLecturersIfInpuListIsNullNullReferenceExceptionThrow()
        {
            // arrange
            string input = "Sen";
            List<Lecturer> inputList = null;

            // act
            FormsMethods.FilterList(inputList, input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FilterListLecturerstWhenResultsIsNullNullArgExceptionThrow()
        {
            // arrange
            List<Lecturer> list = new List<Lecturer>() {
                                new Lecturer("John", "Mall", "19 avenue", "Cork", "Ireland",
                                "0987U", "345778", "john@gmail", 45, 32435M, "Computer Science") };
            string subString = "bac";

            // act
            FormsMethods.FilterList(list, subString);
        }

        #endregion

        #region AddRecordToList() Lecturers

        // AddRecordToList() Method Lecturer Object
        [TestMethod]
        public void AddRecordToListLecturersVerifyObjectIsReallyAddedToList()
        {
            // arrange
            Lecturer lect = new Lecturer("Mark", "Allison", "19 street", "Dublin", "Ireland",
                                        "0897Y", "23456546", "mark@gmail", 12, 23456M, "Chemistry");
            List<Lecturer> anyList = new List<Lecturer>()
            {
                new Lecturer("John", "Carlson", "19 street", "Dublin", "Ireland",
                            "0897Y", "23456546", "john@gmail", 33, 34556M, "Biology"),
                new Lecturer("Mat", "Benny", "19 street", "Dublin", "Ireland",
                            "0897Y", "23456546", "mat@gmail", 44, 2454M, "Arts")
            };
            

            // act
            FormsMethods.AddRecordToList(anyList, lect);

            // assert
            CollectionAssert.Contains(anyList, lect);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddRecordToListLecturerRecordIdAlreadyExistsArgExceptionThrown()
        {

            // arrange
            Lecturer lect = new Lecturer("Mark", "Allison", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "mark@gmail", 44, 4355M, "Geology" );
            List<Lecturer> list = new List<Lecturer>()
            {
                new Lecturer("John", "Carlson", "23 street", "Dublin", "Ireland",
                            "0987T","2345657", "john@gmail", 33, 3245M, "Geophysics"),
                new Lecturer("Mat", "Benny", "23 street", "Dublin", "Ireland",
                            "0987T","2345657", "mat@gmail", 44, 3245M, "Sismology")
            };

            // act
            FormsMethods.AddRecordToList(list, lect);
        }

        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRecordToListLecturerPropertyNullArgNullExceptionThrown()
        {

            // arrange
            Lecturer lect = new Lecturer("", "Allison", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "@gmail", 44, 3435M, "Engineering");
            List<Lecturer> list = new List<Lecturer>()
            {
                new Lecturer("John", "Carlson", "23 street", "Dublin", "Ireland",
                            "0987T","2345657", "john@gmail", 33, 132454M, "Gemmology"),
                new Lecturer("Mat", "Benny", "23 street", "Dublin", "Ireland",
                            "0987T","2345657", "mark@gmail", 44, 32435M, "Archeology")
            };

            // act
            FormsMethods.AddRecordToList(list, lect);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void AddRecordToListLecturerPropertyFormatNotCorrectFormatExceptionThrown()
        {

            // arrange
            Lecturer lect = new Lecturer("Mark", "Allison", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "mark@gmail", int.Parse("ser"), 2435M, "Maths");
            List<Lecturer> list = new List<Lecturer>()
            {
                new Lecturer("John", "Carlson", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "john@gmail", 33, 2435M, "Paleontology"),
                new Lecturer("Mat", "Benny", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "mat@gmail", 44, 42536M, "Programming")
            };

            // act
            FormsMethods.AddRecordToList(list, lect);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddRecordToListLecturersWhenRecordIsNullNullReferenceExceptionThrown()
        {
            // arrange
            Lecturer lect = null;
            List<Lecturer> list = new List<Lecturer>()
            {
                new Lecturer("John", "Carlson", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "john@gmail", 33, 2435M, "Paleontology"),
                new Lecturer("Mat", "Benny", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "mat@gmail", 44, 42536M, "Programming")
            };

            // act
            FormsMethods.AddRecordToList(list, lect);

           
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddRecordToListLecturersWhenListIsNullNullReferenceExceptionThrown()
        {

            // arrange
            Lecturer lect = new Lecturer("John", "Carlson", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "john@gmail", 33, 32435M, "Paleontology");

            List<Lecturer> list = null;

            // act
            FormsMethods.AddRecordToList(list, lect);


        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void AddRecordToListLecturersEMailPropertyNotInCorrectFormatFormatExceptionThrown()
        {

            // arrange
            Lecturer lect = new Lecturer("Mark", "Allison", "19 Bervael", "Denver",
                                "USA", "0567L", "33309876", "markgmail.com", 33, 243455M, "Business");
            List<Lecturer> list = new List<Lecturer>()
            {
                new Lecturer("John", "Carlson", "19 Bervael", "Denver",
                            "USA", "0567L", "33309876", "mark@gmail.com", 39, 235556M, "Business")

            };

            // act
            FormsMethods.AddRecordToList(list, lect);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void AddRecordToListLecturersPhoneNumberPropertyNotInCorrectFormatFormatExceptionThrown()
        {

            // arrange
            Lecturer lect = new Lecturer("Mark", "Allison", "19 Bervael", "Denver",
                "USA", "0567L", "sert", "mark@gmail.com", 35, 32435M, "Business");
            List<Lecturer> list = new List<Lecturer>()
            {
                new Lecturer("John", "Carlson", "19 Bervael", "Denver",
                            "USA", "0567L", "33309876", "john@gmail.com", 33, 32453M, "Business")

            };

            // act
            FormsMethods.AddRecordToList(list, lect);
        }

        #endregion

        #region AddRecordToList() Students

        // AddToRecord() Method Student object

        [TestMethod]
        public void AddRecordToListStudentsVerifyObjectIsReallyAddedToList()
        {
            // arrange
            Student stud = new Student("Mark", "Allison", "19 street", "Dublin", "Ireland",
                                        "0897Y", "23456546", "mark@gmail", Status.UnderGrad, 12, "Chemistry");
            List<Student> anyList = new List<Student>()
            {
                new Student("John", "Carlson", "19 street", "Dublin", "Ireland",
                            "0897Y", "23456546", "john@gmail", Status.UnderGrad, 33, "Biology"),
                new Student("Mat", "Benny", "19 street", "Dublin", "Ireland",
                            "0897Y", "23456546", "mat@gmail", Status.PostGrad, 44, "Arts")
            };


            // act
            FormsMethods.AddRecordToList(anyList, stud);

            // assert
            CollectionAssert.Contains(anyList, stud);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddRecordToListStudentsRecordIdAlreadyExistsArgExceptionThrown()
        {

            // arrange
            Student stud = new Student("Mark", "Allison", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "mark@gmail", Status.UnderGrad, 44, "Geology");
            List<Student> list = new List<Student>()
            {
                new Student("John", "Carlson", "23 street", "Dublin", "Ireland",
                            "0987T","2345657", "john@gmail", Status.UnderGrad, 33,"Geophysics"),
                new Student("Mat", "Benny", "23 street", "Dublin", "Ireland",
                            "0987T","2345657", "mat@gmail", Status.PostGrad, 44, "Sismology")
            };

            // act
            FormsMethods.AddRecordToList(list, stud);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddRecordToListStudentStatusPropertyNotInTheRangeArgOutOfRangeExceptionThrown()
        {

            // arrange
            Student stud = new Student("Mark", "Allison", "19 Bervael", "Denver",
                            "USA", "0567L", "33309876", "mark@gmail.com", (Status)5, 33, "Business");
            List<Student> list = new List<Student>()
            {
                new Student("John", "Carlson", "19 Bervael", "Denver",
                            "USA", "0567L", "33309876", "mark@gmail.com", Status.PostGrad, 30, "Business")
                
            };

            // act
            FormsMethods.AddRecordToList(list, stud);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void AddRecordToListStudentEMailPropertyNotInCorrectFormatFormatExceptionThrown()
        {

            // arrange
            Student stud = new Student("Mark", "Allison", "19 Bervael", "Denver",
                            "USA", "0567L", "33309876", "markgmail.com", Status.UnderGrad, 36, "Business");
            List<Student> list = new List<Student>()
            {
                new Student("John", "Carlson", "19 Bervael", "Denver",
                            "USA", "0567L", "33309876", "johnk@gmail.com", Status.PostGrad, 33, "Business")

            };

            // act
            FormsMethods.AddRecordToList(list, stud);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void AddRecordToListStudentPhoneNumberPropertyNotInCorrectFormatFormatExceptionThrown()
        {

            // arrange
            Student stud = new Student("Mark", "Allison", "19 Bervael", "Denver",
                            "USA", "0567L", "sert", "mark@gmail.com", Status.UnderGrad, 23, "Business");
            List<Student> list = new List<Student>()
            {
                new Student("John", "Carlson", "19 Bervael", "Denver",
                            "USA", "0567L", "33309876", "mark@gmail.com", Status.PostGrad, 33, "Business")

            };

            // act
            FormsMethods.AddRecordToList(list, stud);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRecordToListStudentsPropertyNullArgNullExceptionThrown()
        {

            // arrange
            Student stud = new Student("", "Allison", "23 street", "Dublin", "Ireland",
                                        "0987T", "2345657", "@gmail", Status.PostGrad, 40, "Engineering");
            List<Student> list = new List<Student>()
            {
                new Student("John", "Carlson", "23 street", "Dublin", "Ireland",
                            "0987T","2345657", "john@gmail", Status.PostGrad, 33, "Gemmology"),
                new Student("Mat", "Benny", "23 street", "Dublin", "Ireland",
                            "0987T","2345657", "mark@gmail", Status.UnderGrad, 44, "Archeology")
            };

            // act
            FormsMethods.AddRecordToList(list, stud);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddRecordToListStudentsWhenRecordIsNullNullReferenceExceptionThrown()
        {
            // arrange
            Student stud = null;
            List<Student> list = new List<Student>()
            {
                new Student("John", "Carlson", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "john@gmail", Status.UnderGrad, 33, "Paleontology"),
                new Student("Mat", "Benny", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "mat@gmail", Status.PostGrad, 44, "Programming")
            };

            // act
            FormsMethods.AddRecordToList(list, stud);


        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddRecordToListStudentsWhenListIsNullNullRefrenceExceptionThrown()
        {

            // arrange
            Student stud = new Student("John", "Carlson", "23 street", "Dublin", "Ireland",
                                    "0987T", "2345657", "john@gmail", Status.UnderGrad, 33, "Paleontology");

            List<Student> list = null;

            // act
            FormsMethods.AddRecordToList(list, stud);


        }
        #endregion
    }
}