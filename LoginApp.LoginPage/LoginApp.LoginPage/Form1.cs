using System.Data;
using System.Data.SqlClient;

namespace LoginApp.LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBoxpass.PasswordChar = '*';
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=LoginDB;Integrated Security=True");
        

        private void label1_Click(object sender, EventArgs e)
        {
}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            String username, password;

            username = textBoxuser.Text;
            password = textBoxpass.Text;

            try
            {
                conn.Open();
                String query = "SELECT * FROM LoginTable WHERE username = '" + textBoxuser.Text + "' AND  password = '" + textBoxpass.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);  // directing the querry to related db using connection string
                //SqlDataReader
                DataTable dtable = new DataTable(); //?
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBoxuser.Text;
                    password = textBoxpass.Text;//?

                    // next page
                    MenuForm form2 = new MenuForm();
                    form2.Show();
                    this.Hide(); 

                }
                else
                {
                    MessageBox.Show("Invalid User Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxuser.Clear();
                    textBoxpass.Clear();

                    textBoxuser.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error!");

            }
            finally
            {
                conn.Close();
            }
            
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBoxuser.Clear();
            textBoxpass.Clear();

            textBoxuser.Focus();

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult res;

            res = MessageBox.Show("Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
               
            }
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            regform regform = new regform();
            regform.Show();
            this.Hide();
        }
    }
}