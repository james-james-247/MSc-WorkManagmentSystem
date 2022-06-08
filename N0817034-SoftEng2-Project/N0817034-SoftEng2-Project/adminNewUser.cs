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

namespace N0817034_SoftEng2_Project
{
    public partial class adminNewUser : Form
    {
        int ID;
        public adminNewUser(int id)
        {
            ID = id;
            InitializeComponent();
            startDatabase();
        }

        private void startDatabase()
        {
            groupCombo.Items.Clear();
            userCombo.Items.Clear();
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "SELECT groupName, groupID FROM groups";
            string commandTextTwo = "SELECT username FROM \"user\"";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                SqlCommand commandTwo = new SqlCommand(commandTextTwo, connection);
                try
                {
                    //Opening the Connection and then sending the query
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //For each of the values returned
                        while (reader.Read())
                        {
                            //Getting the names of all the current groups
                            string groupNames = String.Format("{0}", reader["groupName"]);
                            groupCombo.Items.Add(groupNames);
                        }
                    }
                    using (SqlDataReader readerTwo = commandTwo.ExecuteReader())
                    {
                        //For each value
                        while (readerTwo.Read())
                        {
                            //Getting the names of all the users
                            string userNames = String.Format("{0}", readerTwo["username"]);
                            userCombo.Items.Add(userNames);
                        }
                    }
                }
                catch
                {
                    //Showing an error message
                    MessageBox.Show("Error in loading project names");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            adminPage admin = new adminPage(ID);
            admin.Show();
            Hide();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string password = passwordBox.Text.Trim();
            string username = usernameBox.Text.Trim();
            string group = groupCombo.Items[groupCombo.SelectedIndex].ToString();
            string admin = adminCombo.Items[adminCombo.SelectedIndex].ToString().ToLower();

            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "INSERT INTO \"user\" (username, password, groupID, admin) VALUES (@username, @password, (SELECT groupID FROM groups WHERE groupName LIKE '%' + @groupName + '%'), @admin)";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
                command.Parameters.Add("@groupName", SqlDbType.VarChar, 50).Value = group;
                command.Parameters.Add("@admin", SqlDbType.VarChar, 50).Value = admin;

                connection.Open();
                try
                {
                    if(password == "" && username == "")
                    {
                        MessageBox.Show("Please Enter a Value");
                    }
                    else if(group == "" || admin == "")
                    {
                        MessageBox.Show("Please Select a Dropdown Value");
                    }
                    else
                    {
                        //Executing the query
                        command.ExecuteNonQuery();

                        passwordBox.Text = "";
                        usernameBox.Text = "";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Adding New User");
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            startDatabase();
        }

        private void userCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCombo.Enabled = true;
        }

        //This will be used to select sql string later on
        string currentState = "";
        string userState = "";
        private void changeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changalbeBox.Enabled = true;
            string username = userCombo.Items[userCombo.SelectedIndex].ToString();
            string change = changeCombo.Items[changeCombo.SelectedIndex].ToString();
            userState = username;
            string chosenChange = "";

            //Getting the acctual description
            string[,] array = { {"Group", "groupID"}, {"Username", "username"}, {"Password", "password"}, {"Admin Status", "admin"} };
            for(int i = 0; i < array.GetLength(0); i++)
            {
                if(array[i,0] == change)
                {
                    chosenChange = array[i, 1];
                }
            }

            //this switch statement determines which string to send and which objects to make visible
            string commandText = "";
            switch (chosenChange)
            {
                case "groupID":
                    changalbeBox.Visible = false;
                    changeDrop.Visible = true;
                    currentState = "groupID";
                    commandText = "SELECT groupName FROM groups";
                    idSelected(commandText);
                    break;
                case "username":
                    changalbeBox.Visible = true;
                    changeDrop.Visible = false;
                    currentState = "username";
                    commandText = "SELECT username FROM \"user\" WHERE username LIKE @username";
                    userPass(commandText, username);
                    break;
                case "password":
                    changalbeBox.Visible = true;
                    changeDrop.Visible = false;
                    currentState = "password";
                    commandText = "SELECT password FROM \"user\" WHERE username LIKE @username";
                    userPass(commandText, username);
                    break;
                case "admin":
                    changalbeBox.Visible = false;
                    changeDrop.Visible = true;
                    currentState = "admin";
                    adminSelect();
                    break;
            }
        }

        private void userPass(string commandText, string username)
        {
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                connection.Open();
                try
                {
                    //Executing the query
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //For each of the values returned
                        if(reader.Read())
                        {
                            //Getting the value
                            string value = String.Format("{0}", reader[0]);
                            changalbeBox.Text = value;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error Changing User Details");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void idSelected(string commandText)
        {
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                connection.Open();
                try
                {
                    //Executing the query
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //For each of the values returned
                        while(reader.Read())
                        {
                            //Getting the value
                            string value = String.Format("{0}", reader[0]);
                            changeDrop.Items.Add(value);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error Changing User Details");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void adminSelect()
        {
            //Displaying values
            changeDrop.Items.Clear();
            changeDrop.Items.Add("yes");
            changeDrop.Items.Add("no");
        }

        //When the user clicks the confirm button
        private void changeButton_Click(object sender, EventArgs e)
        {
            string value;
            if(changeDrop.Visible == true)
            {
                //Get value here
                value = changeDrop.Items[changeDrop.SelectedIndex].ToString();
            }
            else
            {
                //Get value also here 
                value = changalbeBox.Text;
            }

            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();

                string commandText = "";
                //Creating the command text based on which value is being changed
                switch (currentState)
                {
                    case "groupID":
                        commandText = "UPDATE \"user\" SET groupID = (SELECT groupID FROM groups WHERE groupName LIKE @value) WHERE username LIKE @userState";
                        break;
                    case "username":
                        commandText = "UPDATE \"user\" SET username = @value WHERE username LIKE @userState";
                        break;
                    case "password":
                        commandText = "UPDATE \"user\" SET password = @value WHERE username LIKE @userState";
                        break;
                    case "admin":
                        commandText = "UPDATE \"user\" SET admin = @value WHERE username LIKE @userState";
                        break;
                }


                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);

                //Adding variable values
                command.Parameters.Add("@value", SqlDbType.VarChar, 50).Value = value;
                command.Parameters.Add("@userState", SqlDbType.VarChar, 50).Value = userState;
                try
                {
                    //Executing the query
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Error Adding Changing User Details");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
