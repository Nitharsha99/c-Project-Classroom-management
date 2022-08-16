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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnname_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ESOFT-SERVER\SQLEXPRESS;Initial Catalog=DITECSTUDENT;Persist Security Info=True;User ID=ditec;Password=ST00@00");
            try
            {

                string username = txtname.Text;
                string password = txtpassword.Text;
                string adminid ="";

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admin where user_name = '"+username+"' and password ='"+password+"'", con);
                SqlDataReader r = cmd.ExecuteReader();
          
                while(r.Read()){
                    adminid = r[0].ToString();
                }
                r.Close();

                if (adminid == "")
                {
                    MessageBox.Show("Login fail!");
                }

                else
                {
                    MessageBox.Show("Login success!");
                    this.Hide();
                    Menu objmenu = new Menu();
                    objmenu.Show();
                }
                
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }

        }
    }
}

    