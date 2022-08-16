using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Admin
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ESOFT-SERVER\SQLEXPRESS;Initial Catalog=DITECSTUDENT;Persist Security Info=True;User ID=ditec;Password=ST00@00");
        public void selectALL();
    {
         


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
        
        }

        private void txtstuid_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
