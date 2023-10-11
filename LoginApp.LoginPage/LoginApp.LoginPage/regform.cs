using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.LoginPage
{
    public partial class regform : Form
    {
        public regform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=LoginDB;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {



        }
    private void RegButton_Click(object sender, EventArgs e)

    {
        String reguser = RegFormUsername.Text;
        String regpassword = RegFormPassword.Text;
        String regemail = RegFormEmail.Text;
        String regphone = RegFormPhoneNumber.Text;
        conn.Open();
        if (CreatableOrNot(reguser))
            {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LoginTable (username,password,email,phone) VALUES ('" + reguser + "','" + regpassword + "','" + regemail + "','" + regphone + "')  ", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("You have succesfuly registered in!", "Succesful!", MessageBoxButtons.OK);
                RegFormUsername.Clear();
                RegFormPassword.Clear();
                RegFormEmail.Clear();
                RegFormPhoneNumber.Clear();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
                conn.Close();
                }
        }
        else
        {
            MessageBox.Show("The username is already in use! Try another one!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            regform regform = new regform();
            this.Hide();
            regform.Show();
            conn.Close();
        }
                

    }
      
        private void RegFormUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void regformexitbutton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) { Application.Exit(); }

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }
        private bool CreatableOrNot(string username)
        {
            String query = "SELECT COUNT(*) FROM LoginTable WHERE username = '"+username+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int scalar = (int)cmd.ExecuteScalar();

            if (scalar > 0) 
                {return false;}
            else 
                {return true; }
            
        }
    }

}
