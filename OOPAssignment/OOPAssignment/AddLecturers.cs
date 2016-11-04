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
    public partial class AddLecturers : Form
    {

        internal static List<Lecturer> ListOfLecturers = new List<Lecturer>();
                

        public AddLecturers()
        {
            InitializeComponent();
        }


        // Add Button Event
        // Try to initialize a new Lecturer object with all properties getting from user entries.
        // Catch some major Exceptions and then Add the new object to the List<Lecturer> if it 
        // doesn't throw any exceptions.
        private void btnAddLect_Click(object sender, EventArgs e)
        {

            try
            {

                Lecturer newLecturer = new Lecturer(txtFirst.Text,
                                                    txtSurname.Text,
                                                    txtAddress.Text,
                                                    txtCity.Text,
                                                    txtCountry.Text,
                                                    txtPPS.Text,
                                                    txtPhone.Text,
                                                    txtEMail.Text,
                                                    int.Parse(txtId.Text),
                                                    decimal.Parse(txtSalary.Text),
                                                    txtSubjects.Text);


                FormsMethods.AddRecordToList(ListOfLecturers, newLecturer);

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

            catch (ArgumentException ex)
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
