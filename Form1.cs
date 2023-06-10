using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace VuelingStudentManagerCrud_Client
{
    public partial class Form1 : Form
    {
        private readonly WCFService.Service1Client ServerInteraction = new WCFService.Service1Client();

        private readonly BindingList<WCFService.Student> LocalStudentList = new BindingList<WCFService.Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DataGrid.DataSource = LocalStudentList;

                DataGrid.CellEndEdit += DataGridView1_RowEdit;
                DataGrid.UserDeletingRow += DataGridView1_RowDelete;

                ReloadAllStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load Form. Please check logs for more info.");
                Logger.Log("Couldn't load Form. Please check logs for more info.\n   " + ex.Message + "\n   " + ex.StackTrace, Logger.Severity.Error);
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newStudentName = StudentNameText.Text;
                string newStudentSurname = StudentSurnameText.Text;
                DateTime newStudentBirthday = DateTime.Parse(StudentBirthdayText.Text);

                WCFService.Student newStudent = new WCFService.Student()
                {
                    Name = newStudentName,
                    Surname = newStudentSurname,
                    Birthday = newStudentBirthday
                };

                bool result = ServerInteraction.AddStudent(newStudent);
                if (result)
                {
                    ReloadAllStudents();
                }
                else
                {
                    MessageBox.Show("Server couldn't add Student.");
                    Logger.Log("Server couldnt add Student " + newStudentName + ", " + newStudentSurname + ", " + newStudentBirthday.ToString(), Logger.Severity.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not create Student. Please check logs for more info.");
                Logger.Log("Could not create Student. Please check logs for more info.\n   " + ex.Message + "\n   " + ex.StackTrace, Logger.Severity.Error);
            }
        }

        private void DataGridView1_RowEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow updatedRow = DataGrid.Rows[e.RowIndex];
                WCFService.Student updatedStudent = GetStudentFromRow(updatedRow);
                bool result = ServerInteraction.UpdateStudent(updatedStudent);
                if (result)
                {
                    ReloadAllStudents();
                }
                else
                {
                    MessageBox.Show("Server couldn't edit Student.");
                    Logger.Log("Server couldnt edit Student " + updatedStudent.Guid, Logger.Severity.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't edit Student. Please check logs for more info.");
                Logger.Log("Couldn't edit Student. Please check logs for more info.\n   " + ex.Message + "\n   " + ex.StackTrace, Logger.Severity.Error);
            }
        }

        private void DataGridView1_RowDelete(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DataGridViewRow deletedRow = e.Row;
                WCFService.Student deletedStudent = GetStudentFromRow(deletedRow);
                bool result = ServerInteraction.DeleteStudent(deletedStudent);
                if (result)
                {
                    ReloadAllStudents();
                }
                else
                {
                    MessageBox.Show("Server couldn't delete Student.");
                    Logger.Log("Server couldnt delete Student " + deletedStudent.Guid, Logger.Severity.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't delete Student. Please check logs for more info.");
                Logger.Log("Couldn't delete Student. Please check logs for more info.\n   " + ex.Message + "\n   " + ex.StackTrace, Logger.Severity.Error);
            }
        }

        private void ReloadAllStudents()
        {
            try
            {
                List<WCFService.Student> receivedStudents = ServerInteraction.GetAllStudents();

                LocalStudentList.Clear();
                foreach (WCFService.Student student in receivedStudents)
                {
                    LocalStudentList.Add(student);
                }

                DataGrid.Update();
                DataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load Students. Please check logs for more info.");
                Logger.Log("Couldn't load Students. Please check logs for more info.\n   " + ex.Message + "\n   " + ex.StackTrace, Logger.Severity.Error);
            }
        }

        private WCFService.Student GetStudentFromRow(DataGridViewRow row)
        {
            int id = (int)row.Cells["Id"].Value;
            string name = (string)row.Cells["Name"].Value;
            string surname = (string)row.Cells["Surname"].Value;
            Guid guid = (Guid)row.Cells["Guid"].Value;
            DateTime birthday = (DateTime)row.Cells["Birthday"].Value;
            short age = (short)row.Cells["Age"].Value;
            DateTime creationDate = (DateTime)row.Cells["CreationDate"].Value;

            return new WCFService.Student()
            {
                Id = id,
                Guid = guid,
                CreationDate = creationDate,
                Birthday = birthday,
                Age = age,
                Name = name,
                Surname = surname
            };
        }
    }
}
