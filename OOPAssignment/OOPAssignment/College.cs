using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAssignment
{
    public partial class College : Form
    {

        private readonly string SEARCH_CUE_TEXT = "Search by Name, Surname or ID";

        // Boolean variables. Necessary to swap the sorting from one sorting way to another.
        private bool sortingStatusStudentId = true;
        private bool sortingStatusFNameStudent = true;
        private bool sortingStatusSurnameStudent = true;
        private bool sortingStatusStaffId = true;
        private bool sortingStatusFNameLecturer = true;
        private bool sortingStatusSurnameLecturer = true;

        // Two Integer variable that represent the row selected (either for student or lecturer)
        // for displaying the details of the selected row when user launches the Show Details Event.
        private int studentRowSelected;
        private int lecturerRowSelected;


        public College()
        {
            InitializeComponent();         
            
        }

        #region Students

        // Add Student Button Event
        // Summary: Show an Add Student form and then updating data grid view 
        //          with the list of students updated to the last added object.
        private void btnAddStud_Click(object sender, EventArgs e)
        {

            using (AddStudent newStudent = new AddStudent())
            {

                newStudent.ShowDialog();
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = AddStudent.EnrolledStudents;

            }
        }


        // Show Students Event
        // Summary: Shows the list of all the students that are stored in the List<Student>.
        private void btnShowStud_Click(object sender, EventArgs e)
        {

            dgvStudent.Visible = true;
            dgvLecturer.Visible = false;
            pnlScreen.Visible = false;
            lblTitleDgvs.Visible = true;

            lblTitleDgvs.Text = "Enrolled Students";
            

            dgvStudent.DataSource = null;
            dgvStudent.DataSource = AddStudent.EnrolledStudents;

        }


        // Row Header Mouse Click Event for Student Data Grid View.
        // Summary: Allows the user to right click on the row header and displaying 
        //          a context menu strip with a Show Student details Event into it.
        private void dgvStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                studentRowSelected = e.RowIndex;
                var relativePosition = dgvStudent.PointToClient(Cursor.Position);
                cmstripStudent.Show(dgvStudent, relativePosition);

            }
        }


        // Show Student Details Event.
        // Summary: Displaying the details of the selected student (selected record or row) 
        //          using the ToString() method associated to Student Class.
        private void showStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(AddStudent.EnrolledStudents[studentRowSelected].ToString(), "Student Details");

        }

        #endregion


        #region Lecturers
        // Add Lecturer Button Event
        // Summary: Shows an Add Lecturer form and then updates the data grid view 
        //          with the updated List of Lecturer.
        private void btnAddLect_Click(object sender, EventArgs e)
        {
            
            using (AddLecturers newLecturer = new AddLecturers())
            {

                newLecturer.ShowDialog();
                dgvLecturer.DataSource = null;
                dgvLecturer.DataSource = AddLecturers.ListOfLecturers;

            }
        }


        // Show Lecturers Event
        // Summary: Displaying on Data Grid View the List of all Lecturers stored in the
        //          List<Lecturer> ListOfLecturers.
        private void btnShowLect_Click(object sender, EventArgs e)
        {
            dgvStudent.Visible = false;
            dgvLecturer.Visible = true;
            pnlScreen.Visible = false;
            lblTitleDgvs.Visible = true;

            lblTitleDgvs.Text = "Lecturers";
            
            
            dgvLecturer.DataSource = null;
            dgvLecturer.DataSource = AddLecturers.ListOfLecturers;
           
            
        }


        // Row Header Mouse Click for Lecturer Data Grid View.
        // Summary : Allows the user to right click on the row header and displaying a context menu strip
        //           with Show Lecturer details event into it.
        private void dgvLecturer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                lecturerRowSelected = e.RowIndex;
                var relativePosition = dgvLecturer.PointToClient(Cursor.Position);
                cmstripLecturer.Show(dgvStudent, relativePosition);

            }
        }


        // Show Lecturer details Event.
        // Summary : Displaying the details of the selected lecturer (selected row) using the 
        //           ToString() method associated to Lecturer Class
        private void showLecturerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(AddLecturers.ListOfLecturers[lecturerRowSelected].ToString(), "Lecturer Details");

        }

        #endregion


        #region Search
        // Search Text Box Enter Event.
        // Summary: Handles the event when the  search text box becomes active control, 
        //          calling the EnterCueText method.
        private void txtSearch_Enter(object sender, EventArgs e)
        {

            EnterCueText(txtSearch, SEARCH_CUE_TEXT);

        }

        // Method to be called in the Search Text Box Enter Event
        // Summary: If the Search box becomes the active control, 
        //          then the Cue message will be removed from the Search text box and 
        //          allows the user to type in.
        private void EnterCueText(TextBox txtBox, string cueText)
        {

            if (txtBox.Text.Equals(cueText))
            {

                txtBox.Text = "";
                txtBox.ForeColor = SystemColors.WindowText;

            }
        }

        // Search Text Box Leave Event.
        // Summary: Handles the Leave Event (so when the control is not active), 
        //          calling LeaveCueText method.
        private void txtSearch_Leave(object sender, EventArgs e)
        {

            LeaveCueText(txtSearch, SEARCH_CUE_TEXT);

        }

        // Method to be called into Search text box Leave Event.
        // Summary: If the Search Text Box is not the active control, 
        //          then the Cue Message will be displayed into it.
        private void LeaveCueText(TextBox txtBox, string cueText)
        {

            if (txtBox.Text.Length == 0)
            {

                txtBox.Text = cueText;
                txtBox.ForeColor = SystemColors.GrayText;

            }
        }


        // Search Button Event.
        // Summary: Handles the Search Button Event.
        //          Displaying a filtered list of Students or Lecturers based on 
        //          the key typed in the search text box by the user.
        private void btnIconSearch_Click(object sender, EventArgs e)
        {
            
            if(dgvStudent.Visible)
            {

                try
                {

                    dgvStudent.DataSource = FormsMethods.FilterList(AddStudent.EnrolledStudents, txtSearch.Text);

                }

                catch(ArgumentException ex)
                {

                    MessageBox.Show(ex.Message, "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
              
            }

            else if(dgvLecturer.Visible)
            {

                try
                {

                    dgvLecturer.DataSource = FormsMethods.FilterList(AddLecturers.ListOfLecturers, txtSearch.Text);

                }

                catch(ArgumentException ex)
                {

                    MessageBox.Show(ex.Message, "Information",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }
           
        }


        // Key Press Event in Search Text Box.
        // Summary: Allows the user to launch Search Button Event 
        //          also pressing Enter inside the Search Text Box.
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                btnIconSearch.PerformClick();                

            }
        }

        #endregion



        #region Sorting Events

        // Events that use the modification of default Sort() methods in the Student and 
        // Lecturer classes, that have been obtained modifying the CompareTo() methods inherited 
        // from IComparable<Student> Interface and from IComparable<Staff> Inteface.


        // Column Header Mouse Click Event for Student Data Grid View.
        // Summary: Allows the user to Sort the List pressing on the column header 
        //          of Student ID, FirstName and Surname properties. 
        //          In Ascending and in Descending direction.
        //          
        private void dgvStudent_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.ColumnIndex == 0)
            {

                if(sortingStatusStudentId)
                {

                    Student.SortWay = SortDirection.Ascending;
                    sortingStatusStudentId = false;

                }

                else
                {

                    Student.SortWay = SortDirection.Descending;
                    sortingStatusStudentId = true;

                }

                Student.SortOrder = SortMethod.Id;
                AddStudent.EnrolledStudents.Sort();
               
            } 

            else if(e.ColumnIndex == 1)
            {

                if(sortingStatusFNameStudent)
                {

                    Student.SortWay = SortDirection.Ascending;
                    sortingStatusFNameStudent = false;

                }

                else
                {

                    Student.SortWay = SortDirection.Descending;
                    sortingStatusFNameStudent = true;

                }

                Student.SortOrder = SortMethod.FirstName;
                AddStudent.EnrolledStudents.Sort();
                
            }

            else if(e.ColumnIndex == 2)
            {

                if(sortingStatusSurnameStudent)
                {

                    Student.SortWay = SortDirection.Ascending;
                    sortingStatusSurnameStudent = false;

                }

                else
                {

                    Student.SortWay = SortDirection.Descending;
                    sortingStatusSurnameStudent = true;

                }

                Student.SortOrder = SortMethod.Surname;
                AddStudent.EnrolledStudents.Sort();
                
            }

            dgvStudent.DataSource = null;
            dgvStudent.DataSource = AddStudent.EnrolledStudents;
        }


        // Column Header Mouse Click Event for Lecturer Data Grid View.
        // Summary: Allows the user to sort the list based on Staff Id, 
        //          First Name and Surname properties. In Ascendind and in Descending order.
        private void dgvLecturer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if(e.ColumnIndex == 0)
            {

                if(sortingStatusStaffId)
                {

                    Lecturer.SortWay = SortDirection.Ascending;
                    sortingStatusStaffId = false;

                }

                else
                {

                    Lecturer.SortWay = SortDirection.Descending;
                    sortingStatusStaffId = true;

                }

                Lecturer.SortOrder = SortMethod.Id;
                AddLecturers.ListOfLecturers.Sort();
               
            }

            else if(e.ColumnIndex == 1)
            {

                if(sortingStatusFNameLecturer)
                {

                    Lecturer.SortWay = SortDirection.Ascending;
                    sortingStatusFNameLecturer = false;

                }

                else
                {

                    Lecturer.SortWay = SortDirection.Descending;
                    sortingStatusFNameLecturer = true;

                }

                Lecturer.SortOrder = SortMethod.FirstName;
                AddLecturers.ListOfLecturers.Sort();
            }

            else if(e.ColumnIndex == 2)
            {

                if(sortingStatusSurnameLecturer)
                {

                    Lecturer.SortWay = SortDirection.Ascending;
                    sortingStatusSurnameLecturer = false;

                }

                else
                {

                    Lecturer.SortWay = SortDirection.Descending;
                    sortingStatusSurnameLecturer = true;

                }

                Lecturer.SortOrder = SortMethod.Surname;
                AddLecturers.ListOfLecturers.Sort();
            }

            dgvLecturer.DataSource = null;
            dgvLecturer.DataSource = AddLecturers.ListOfLecturers;

        }

        #endregion


        #region Start and Notify Icon Events

        // Start Button Event.
        // Summary: handles the click of start button at the beginning of the application.
        //          Allows to swap from the opening screen to the main screen of application.
        private void btnStart_Click(object sender, EventArgs e)
        {

            lblWelcome.Visible = false;
            btnStart.Visible = false;
            pnlScreen.BackColor = Color.White;
            pnlScreen.BackgroundImage = null;


            txtSearch.Visible = true;
            btnShowStud.Visible = true;
            btnShowLect.Visible = true;
            btnIconSearch.Visible = true;
            btnAddStud.Visible = true;
            btnAddLect.Visible = true;

            LeaveCueText(txtSearch, SEARCH_CUE_TEXT);

            ActiveControl = btnAddStud;

        }

        // Notify Icon Control and Context Menu Strip Item Events associated to it.

        // Show Tool Strip Menu Item Click event.
        // Summary: Shows the program when the window program is minimized from main taskbar.
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Show();

        }

        // Hide Tool Strip Menu Item Click Event.
        // Summary: Hides the program clicking notify icons from main taskbar.
        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();

        }


        // Exit Tool Strip Menu Item Click Event
        // Summary: Exit the application clicking notify icons from main taskbar. 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        #endregion

       
    }
}
