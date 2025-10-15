using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        private static string SetFileName;

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            SetFileName = StudentNoTxt.Text + ".txt";
            string SetStudentNo = StudentNoTxt.Text;
            string SetProgram = ProgramCmb.Text;
            string SetLastName = LastNameTxt.Text;
            string SetFirstName = FirstNameTxt.Text;
            string SetMiddleName = MiddleNameTxt.Text;
            string SetAge = AgeTxt.Text;
            string SetGender = GenderCmb.Text;
            string SetBirthday = BirthdayPicker.Text;
            string SetContactNo = ContactNoTxt.Text;

            string[] Values =
            {
                "Student No.: " + SetStudentNo,
                "Program: " + SetProgram,
                "Last Name: " + SetLastName,
                "First Name: " + SetFirstName,
                "Middle Name: " + SetMiddleName,
                "Age: " + SetAge,
                "Gender: " + SetGender,
                "Birthday: " + SetBirthday,
                "Contact No.: " + SetContactNo
            };


            string docPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CreatedFiles");

            string fullPath = Path.GetFullPath(docPath);

            Directory.CreateDirectory(fullPath);

            string FileDirectory = Path.Combine(docPath, SetFileName + ".txt");

            //

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(fullPath, SetFileName)))
            
                try
                {
                    if (File.Exists(FileDirectory))
                    {
                        MessageBox.Show("Student No. Already Exists!");
                        return;
                    }

                    foreach (string line in Values)
                    outputFile.WriteLine(line);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            MessageBox.Show("Registered Successfully");
        }
        

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            StudentNoTxt.Clear();
            ProgramCmb.SelectedIndex = -1;
            LastNameTxt.Clear();
            FirstNameTxt.Clear();
            MiddleNameTxt.Clear();
            AgeTxt.Clear();
            GenderCmb.SelectedIndex = -1;
            BirthdayPicker.Value = DateTime.Now;
            ContactNoTxt.Clear();
        }
    }
}
