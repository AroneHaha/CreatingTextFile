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
    public partial class CreateFile : Form
    {
        private static string SetFileName;

        public CreateFile()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();

            SetFileName = filenameTxt.Text + ".txt";
            string getInput = contentTxt.Text;
            string docPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\CreatedFiles");

            string fullPath = Path.GetFullPath(docPath);

            Directory.CreateDirectory(fullPath);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(fullPath, SetFileName)))
            {
                outputFile.WriteLine(getInput);
            }


            MessageBox.Show("File Created Successfully");
            frmRegistration.Show();
            this.Hide();

            //Close();
            //used Hide instead of Close in order to proceed on the next form
            //Close method forces the application to terminate
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            filenameTxt.Clear();
            contentTxt.Clear();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenTextFile OpenTextFile = new OpenTextFile();
            OpenTextFile.ShowDialog();
        }
    }
}
