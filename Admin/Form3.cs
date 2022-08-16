using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            student obj8 = new student();
            this.Hide();
                obj8.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
