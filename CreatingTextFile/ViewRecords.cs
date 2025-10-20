using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class ViewRecords : Form
    {
        public ViewRecords()
        {
            InitializeComponent();
            OpenTextFile Open = new OpenTextFile();

            foreach (ListViewItem Item in Open.GetList.Items)
            {
                FileList.Items.Add((ListViewItem)Item.Clone());
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();
        }

        private void ViewRecords_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
