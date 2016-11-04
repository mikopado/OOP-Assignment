using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAssignment
{
    public partial class AddStudent : Form
    {

        internal static List<Student> EnrolledStudents = new List<Student>();
       
        public AddStudent()
        {
            InitializeComponent();
        }


        // Add Button Event
        // Try to initialize a new student acquiring all the properties from the user entries.
        // Then Add this new Student to the List<Student> of all Enrolled Students.
        // Catch four kind of main Exceptions that the user might enter while typing students properties.
        private void btnAddStud_Click(object sender, EventArgs e)
        {

            try
            {

                Student newStudent = new Student(txtFirst.Text, 
                                              txtSurname.Text, 
                                              txtAddress.Text,
                                              txtCity.Text, 
                                              txtCountry.Text, 
                                              txtPPS.Text, 
                                              txtPhone.Text, 
                                              txtEmail.Text,
                                              (Status)(cmbStatus.SelectedIndex), 
                                              int.Parse(txtId.Text), 
                                              txtDegree.Text);

                FormsMethods.AddRecordToList(EnrolledStudents, newStudent);
                
                                    
                this.Close();
                
                
               
            }            

            catch (ArgumentNullException ex)
            {

                MessageBox.Show("All the fields need to be completed. " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show("Field values are not valid. " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch(ArgumentException ex)
            {

                MessageBox.Show(ex.Message, "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (FormatException ex)
            {

                MessageBox.Show("Impossible store data. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }

}
