using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class NewBugForm : Form
    {
        /// <summary>
        /// <see cref="SqlConnection"/> used for the <see cref="BugTracker.NewBugForm"/> form.
        /// </summary>
        SqlConnection newBugConnection;

        /// <summary>
        ///  Entry point for the <see cref="BugTracker.NewBugForm"/> form.
        /// </summary>
        public NewBugForm()
        {
            InitializeComponent();
            txtAuthorNew.Text = BugTracker.Login.sessionUsername;
        }

        /// <summary>
        ///  Tries to connect to the database (<see cref="newBugConnection"/>) for the 'BugTable', then tries to insert parameters by <see cref="SqlCommand"/>, then tries to execute.
        /// </summary>
        /// <param name="application">Used to specify the application which is contained in the bug.</param>
        /// <param name="symptom">Used to specify the suggested symptom of the bug by the author.</param>
        /// <param name="cause">Used to specify the suggested cause of the bug by the author.</param>
        /// <param name="tclass">Used to identify the class that contains the bug by the author.</param>
        /// <param name="method">Used to identify the method that contains the bug by the author.</param>
        /// <param name="code">Used to encapsulate the whole code which contains the bug by the author.</param>
        /// <param name="linenostart">Used to identify the starting line number, tracking where in the code the bug is by the author.</param>
        /// <param name="linenoend">Used to identify the end line number, tracking where in the code the bug is by the author.</param>
        /// <param name="language">Used to identify which programming language the code containing the bug by the author is.</param>
        /// <param name="commandString">Used to indicate the <see cref="string"/> which inserts the parameters contained within <see cref="InsertBugRecord"/> to SQL format.</param>
        public void InsertBugRecord(String application, String symptom, String cause, String tclass, String method, String code, String linenostart, String linenoend, String language, String commandString)
        {
            try
            {
                newBugConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\BTDATABASE.mdf;");
                newBugConnection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandString, newBugConnection);
                cmdInsert.Parameters.AddWithValue("@Username", BugTracker.Login.sessionUsername);
                cmdInsert.Parameters.AddWithValue("@Application", application);
                cmdInsert.Parameters.AddWithValue("@Symptom", symptom);
                cmdInsert.Parameters.AddWithValue("@Cause", cause);
                cmdInsert.Parameters.AddWithValue("@Class", tclass);
                cmdInsert.Parameters.AddWithValue("@Method", method);
                cmdInsert.Parameters.AddWithValue("@Code", code);
                cmdInsert.Parameters.AddWithValue("@LineNoStart", linenostart);
                cmdInsert.Parameters.AddWithValue("@LineEndStart", linenoend);
                cmdInsert.Parameters.AddWithValue("@Language", language);
                cmdInsert.ExecuteNonQuery();
                this.Hide();
                MessageBox.Show(application + " bug submitted successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(application + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        ///  Tries to connect to the database (<see cref="newBugConnection"/>), then tries to insert parameters by <see cref="SqlCommand"/>, then tries to execute. 
        ///  This is to make sure the first 'version' is the original author of the bug report.
        /// </summary>
        /// <param name="isfixedbool">Used to identify whether the bug is fixed/unfixed (<see cref="bool"/>), is always '0'(unfixed) in this instance.</param>
        /// <param name="sqlFormatDateTimeNow">Used to specify <see cref="DateTime"/> formatted for SQL.</param>
        /// <param name="alteredcode">Used to indicate the block of original code (<see cref="txtCode"/>), (unedited for original version).</param>
        /// <param name="username">Used to indicate the current session user's username (<see cref="Login.sessionUsername"/>).</param>
        /// <param name="bugid">Used to indicate the current session bug's idenfication (<see cref="txtBugId"/>).</param>
        /// <param name="entryno">Used to indicate current entry number which is equal to the count of the number of edit entries, is always '0'(first entry) in this instance.</param>
        /// <param name="commandString">Used to indicate the <see cref="string"/> which inserts the parameters contained within <see cref="InsertVerRecord"/> to SQL format.</param>
        public void InsertVerRecord(String isfixedbool, String sqlFormatDateTimeNow, String alteredcode, String username, int bugid, String entryno, String commandString)
        {
            try
            {
                newBugConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\BTDATABASE.mdf;");
                newBugConnection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandString, newBugConnection);
                cmdInsert.Parameters.AddWithValue("@Fixed", isfixedbool);
                cmdInsert.Parameters.AddWithValue("@EntryDateTime", sqlFormatDateTimeNow);
                cmdInsert.Parameters.AddWithValue("@AlteredCode", alteredcode);
                cmdInsert.Parameters.AddWithValue("@Username", username);
                cmdInsert.Parameters.AddWithValue("@BugId", bugid);
                cmdInsert.Parameters.AddWithValue("@EntryNo", entryno);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(bugid + "." + entryno + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  Checks that all user's input (<see cref="txtApplicationNew"/>, <see cref="txtSymptomNew"/>, <see cref="txtCauseNew"/>, <see cref="txtClassNew"/>, 
        ///  <see cref="txtMethodNew"/>, <see cref="txtCodeNew"/>, <see cref="txtLineNoStartNew"/>, <see cref="txtLineNoEndNew"/>) are not empty or null for when a new bug submission is made.
        /// </summary>  
        public bool CheckInputs()
        {
            bool rtnvalue = true;

            if (
                string.IsNullOrEmpty(txtApplicationNew.Text) ||
                string.IsNullOrEmpty(txtSymptomNew.Text) ||
                string.IsNullOrEmpty(txtCauseNew.Text) ||
                string.IsNullOrEmpty(txtClassNew.Text) ||
                string.IsNullOrEmpty(txtMethodNew.Text) ||
                string.IsNullOrEmpty(txtCodeNew.Text) ||
                string.IsNullOrEmpty(txtLineNoStartNew.Text) ||
                string.IsNullOrEmpty(txtLineNoEndNew.Text) ||
                comboBoxLanguage.Text == "")
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }
            return (rtnvalue);
        }

        /// <summary>
        ///  If <see cref="CheckInputs"/> is passed, inserts parameters (<see cref="InsertBugRecord"/>) to the database using SQL 'INSERT' statement (selBugIdCommand), 
        ///  then inserts parameters (<see cref="InsertVerRecord"/>) to the database using SQL 'INSERT' statement (selVerIdCommand) for the first 'Version' entry, when <see cref="buttonNewBug"/> is clicked.
        /// </summary> 
        private void ButtonNewBug_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                String bugCommandString = "INSERT INTO BugTable(Username, Application, Symptom, Cause, Class, Method, CodeBlock, LineNoStart, LineNoEnd, Language) VALUES (@Username, @Application, @Symptom, @Cause, @Class, @Method, @Code, @LineNoStart, @LineEndStart, @Language)";
                InsertBugRecord(txtApplicationNew.Text, txtSymptomNew.Text, txtCauseNew.Text, txtClassNew.Text, txtMethodNew.Text, txtCodeNew.Text, txtLineNoStartNew.Text, txtLineNoEndNew.Text, comboBoxLanguage.SelectedItem.ToString(), bugCommandString);

                //Gets 'BugId' from latest users submission (above), this way is used because database could theoretically be used simultaneously where consecutive IDs could be mismatched between users.
                String selBugIdCommand = "SELECT TOP 1 BugId FROM BugTable WHERE Username = '" + BugTracker.Login.sessionUsername +"' ORDER BY BugId DESC";
                SqlCommand sqlBugIdCommand = new SqlCommand(selBugIdCommand, newBugConnection);

                SqlDataReader bugIdSqlDataReader = sqlBugIdCommand.ExecuteReader();

                int bugId =0;   //Obligatory value assigned.
                while (bugIdSqlDataReader.Read())
                {
                    bugId = bugIdSqlDataReader.GetInt32(0);
                }

                bugIdSqlDataReader.Close();
                            
                String verCommandString = "INSERT INTO VersionTable(Fixed, EntryDateTime, AlteredCode, Username, BugId, EntryNo) VALUES (@Fixed, @EntryDateTime, @AlteredCode, @Username, @BugId, @EntryNo)";
                InsertVerRecord("0", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), txtCodeNew.Text, BugTracker.Login.sessionUsername, bugId, "0", verCommandString);
                //First version (0) is always original code and needs to be inserted into database so it can be shown in audit list along side later edits.

                newBugConnection.Close();
                this.Close();
            }  
        }

        /// <summary>
        ///  Coses the current <see cref="NewBugForm"/>, when <see cref="buttonNBCancel"/> is clicked.
        /// </summary>
        private void ButtonNBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
