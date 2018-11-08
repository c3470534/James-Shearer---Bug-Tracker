using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BugTracker
{
    public partial class Login : Form
    {

            /// Indentify Session User
        
        public static string sessionUsername;

        
            /// Login Page Opening
            
        public Login()
        {
            InitializeComponent();
        }

            /// Database Connection Using the sqlDataAdapter, Selects the username and password from the database using the credentials you entered ("loginusername" and "loginpass")
            /// If the correct input is found then the login form will close and the main session will open and is displayed when the login button is clicked.

  
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection loginConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\BTDATABASE.mdf;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From UserTable where Username='" + loginusername.Text + "' and Password = '" + loginpass.Text + "'", loginConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                sessionUsername = loginusername.Text;
                this.Hide();
                Main session = new Main();
                session.Show();
            }
            else
            {
                MessageBox.Show("You have Entered Incorrect Login Details, Please try again.");
            }
        }
         
         /// Placeholder text and Main image below.
         
        private void txtLoginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
