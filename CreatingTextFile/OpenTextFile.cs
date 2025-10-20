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
    public partial class OpenTextFile : Form
    {
        public OpenTextFile()
        {
            InitializeComponent();
        }

        public ListView GetList
        {
            get
            {
                return FindFileList;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"..\..\CreatedFiles";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    FindFileList.Items.Add(_getText);
                }
            }
        }

        private void FindFileList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenTextFile_Load(object sender, EventArgs e)
        {

        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            ViewRecords viewRecords = new ViewRecords();
            foreach (ListViewItem Item in FindFileList.Items)
            {
                viewRecords.FileList.Items.Add((ListViewItem)Item.Clone());
            }
            viewRecords.Show();
        }
    }
}
