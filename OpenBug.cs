using BugTracker;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class OpenBug : Form
    {
        /// <summary>
        /// <see cref="SqlConnection"/> used for the <see cref="BugTracker.OpenBug"/> form.
        /// </summary>
        SqlConnection obConnection;

        /// <summary>
        ///  Used externally to identify current opened bug.
        /// </summary>
        public static string sessionOpenBug;


        /// <summary>
        ///  Entry point for the <see cref="BugTracker.OpenBug"/> form.
        /// </summary>
        public OpenBug()
        {
            InitializeComponent();
            PopulateOpenList();
        }

        /// <summary>
        ///  Connects to the database (<see cref="obConnection"/>) and selects, then attempts to read SQL data (<see cref="SqlDataReader"/>) that populates the list 
        ///  in the <see cref="OpenBug"/> form.
        /// </summary>
        private void PopulateOpenList()
        {
            obConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\BTDATABASE.mdf;");
            String selcmd=""; //Obligatory empty string.

            //Binary numbers in comments used to help identify combination of on/off filters for use in switch statement.>>>
            int caseSwitch=1;                                                                                                                      //001
            if (!checkBoxDisplayOwn.Checked && !checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text != "All Languages") { caseSwitch = 2; };   //000
            if (!checkBoxDisplayOwn.Checked &&  checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text != "All Languages") { caseSwitch = 3; };   //010
            if (!checkBoxDisplayOwn.Checked &&  checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text == "All Languages") { caseSwitch = 4; };   //011
            if ( checkBoxDisplayOwn.Checked && !checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text != "All Languages") { caseSwitch = 5; };   //100
            if ( checkBoxDisplayOwn.Checked && !checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text == "All Languages") { caseSwitch = 6; };   //101
            if ( checkBoxDisplayOwn.Checked &&  checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text != "All Languages") { caseSwitch = 7; };   //110
            if ( checkBoxDisplayOwn.Checked &&  checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text == "All Languages") { caseSwitch = 8; };   //111
           
            switch (caseSwitch)
            {
                case 1:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable";
                    break;
                case 2:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Language = '" +comboBoxLanguage.Text +"'";
                    break;
                case 3:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Fixed = 0 AND Language = '" +comboBoxLanguage.Text + "'";
                    break;
                case 4:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Fixed = 0";
                    break;
                case 5:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Username = '" + BugTracker.Login.sessionUsername + "' AND Language = '" + comboBoxLanguage.Text + "'";
                    break;
                case 6:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Username = '" + BugTracker.Login.sessionUsername + "'";
                    break;
                case 7:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Fixed = 0 AND Username = '" + BugTracker.Login.sessionUsername +"' AND Language = '" +comboBoxLanguage.Text + "'";
                    break;
                case 8:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Fixed = 0 AND Username = '" + BugTracker.Login.sessionUsername + "'";
                    break;
            }
                        
            SqlCommand mySqlCommand = new SqlCommand(selcmd, obConnection);

            try
            {
                obConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                listBoxOpen.Items.Clear();

                while (mySqlDataReader.Read())
                {
                        listBoxOpen.Items.Add(mySqlDataReader["BugId"] + "." + mySqlDataReader["Application"] + "." + mySqlDataReader["Username"]);     //Populates the list with necessary information to find required bug.
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        ///  Creates an <see cref="Array"/> from the list (<see cref="listBoxOpen"/>) and splits it, getting the first entry which is the 'BugId' setting it as <see cref="sessionOpenBug"/>, 
        ///  hides the <see cref="OpenBug"/> form and any previously active <see cref="Main"/> form and begins a new <see cref="Main"/> form 'session', when <see cref="ButtonOpen_Click"/> is clicked.
        /// </summary>
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (listBoxOpen.SelectedIndex != -1)
            {
                obConnection.Close();
                String selectedItem = listBoxOpen.SelectedItem.ToString();      //Creates string from the bug selected from the list.
                String[] seletectItemArray = selectedItem.Split('.');           //String is split from delimiter used in SQL data read.
                sessionOpenBug = seletectItemArray[0];                          //First index is the unique 'BugId' which is public and used in other forms.
                this.Hide();
                Main.ActiveForm.Hide();
                Main session = new Main();
                session.Show();                                                 //New form displayed using unique 'BugId' (sessionOpenBug).
            }
        }

        /// <summary>
        ///  Closes the <see cref="SqlConnection"/> and current <see cref="OpenBug"/>, when <see cref="buttonCancel"/> is clicked.
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            obConnection.Close();
            this.Hide();
        }

        /// <summary>
        ///  Repopulates the list (<see cref="PopulateOpenList"/>) , when <see cref="checkBoxDisplayOwn"/> is clicked.
        /// </summary>
        private void CheckBoxDisplayOwn_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOpenList();
        }

        /// <summary>
        ///  Repopulates the list (<see cref="PopulateOpenList"/>) , when <see cref="checkBoxDisplayUnfixed"/> is clicked.
        /// </summary>
        private void CheckBoxDisplayUnfixed_CheckedChanged(object sender, EventArgs e)
        {
            PopulateOpenList();
        }

        /// <summary>
        ///  Repopulates the list (<see cref="PopulateOpenList"/>) , when <see cref="comboBoxLanguage"/> is clicked.
        /// </summary>
        private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateOpenList();
        }
    }
}
