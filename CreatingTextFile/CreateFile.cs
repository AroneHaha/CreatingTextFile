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
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,CreateFile.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

            MessageBox.Show("File Created Successfully");
            frmRegistration.Show();
            this.Hide();
            //Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            filenameTxt.Clear();
            contentTxt.Clear();
        }
    }
}
