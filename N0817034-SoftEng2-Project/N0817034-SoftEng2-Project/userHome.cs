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
    public partial class userHome : Form
    {
        string Newusername;
        public userHome(string username)
        {
            Newusername = username;
            InitializeComponent();
            databaseStart(username);
        }

        private void databaseStart(string username)
        {
            projectCombo.Items.Clear();
            dataGrid.Rows.Clear();
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandTexts = "SELECT projectName, projectID, groupID FROM projects WHERE groupID LIKE (SELECT groupID FROM \"user\" WHERE username LIKE '%' + @username + '%')";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandTexts, connection);
                command.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                try
                {
                    //Opening the Connection and then sending the query
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //For each of the values returned
                        while (reader.Read())
                        {
                            //Getting the names of all the current projects
                            string projectNames = String.Format("{0}", reader["projectName"]).ToLower();
                            projectCombo.Items.Add(projectNames);
                        }
                    }
                }
                catch (Exception e)
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

        private void projectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            featureCombo.Items.Clear();
            featureCombo.Enabled = true;

            selector();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            Hide();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Defining Variables
            string featureNames = featureName.Text;
            string comment = comBox.Text;
            string projName = projectCombo.Items[projectCombo.SelectedIndex].ToString().ToLower();

            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //Create command text
                string commandText = "INSERT INTO projectDetails (feature, completed, comment, projectID) VALUES (@feature, 'no', @comment, (SELECT projectID FROM projects WHERE projectName LIKE @projName))";

                connection.Open();
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                //Adding variable values
                command.Parameters.Add("@feature", SqlDbType.VarChar, 50).Value = featureNames;
                command.Parameters.Add("@comment", SqlDbType.VarChar, 50).Value = comment;
                command.Parameters.Add("@projName", SqlDbType.VarChar, 50).Value = projName;
                try
                {
                    if (featureNames == "" && (comment == "" || comment == "Not Completed"))
                    {
                        MessageBox.Show("Please Ensure All Inputs Have Values");
                    }
                    else
                    {
                        //Executing the query
                        command.ExecuteNonQuery();
                        connection.Close();


                        featureName.Text = "";
                        comBox.Text = "Not Completed";

                        selector();
                    }
                }
                catch
                {
                    MessageBox.Show("Error Adding Project Details");
                }
                finally
                {
                    connection.Close();
                }
            }
            databaseStart(Newusername);
        }

        string[,] databaseDetails = new string[1, 3];
        private void selector()
        {
            string projectName = projectCombo.Items[projectCombo.SelectedIndex].ToString();
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "SELECT feature, completed, comment, projectID FROM projectDetails WHERE projectID LIKE (SELECT projectID FROM projects WHERE projectName LIKE '%' + @name + '%')";
            string commantext2 = "SELECT comment FROM comments WHERE projectID LIKE (SELECT projectID FROM projects WHERE projectName LIKE '%' + @name + '%')";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //reseting the values of certain things 
                commentBox.Text = "";
                dataGrid.Rows.Clear();

                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                SqlCommand commandTwo = new SqlCommand(commantext2, connection);

                command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = projectName;
                commandTwo.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = projectName;

                try
                {
                    //Opening the Connection and then sending the query
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //For each of the values returned
                        while (reader.Read())
                        {
                            //Showing the feature name
                            DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
                            row.Cells[0].Value = String.Format("{0}", reader["feature"]);

                            //Showing either green or red for complete or not
                            string completed = String.Format("{0}", reader["completed"]).ToLower();
                            if (completed == "yes")
                            {
                                row.Cells[1].Style.BackColor = Color.Green;
                            }
                            else
                            {
                                row.Cells[1].Style.BackColor = Color.Red;
                            }

                            //Showing any comment added to the feature
                            row.Cells[2].Value = String.Format("{0}", reader["comment"]);
                            dataGrid.Rows.Add(row);


                            //Addding to the selector
                            featureCombo.Items.Add(String.Format("{0}", reader["feature"]));
                            //adding to the comment box
                            commentBoxChange.Text = String.Format("{0}", reader["comment"]);
                        }
                    }
                    //getting the comments on the system currently
                    using (SqlDataReader reader = commandTwo.ExecuteReader())
                    {
                        //For each of the values returned
                        while (reader.Read())
                        {
                            //Showing any comment added to the feature
                            commentBox.Text += String.Format("{0}", reader["comment"]) + " / ";
                        }
                    }
                    newFeatureBox.Enabled = true;
                }
                catch
                {
                    //Showing an error message
                    MessageBox.Show("Error in loading project details");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        string currentStatus = "";
        private void featureCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Erasing any past text and then enabling
            commentBoxChange.Text = "";
            commentBoxChange.Enabled = true;
            changeButton.Enabled = true;

            //Getting current value
            string feature = featureCombo.Items[featureCombo.SelectedIndex].ToString();

            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandTexts = "SELECT completed FROM projectDetails WHERE feature LIKE @featureName";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandTexts, connection);
                command.Parameters.Add("@featureName", SqlDbType.VarChar, 50).Value = feature;
                try
                {
                    //Opening the Connection and then sending the query
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //For each of the values returned
                        while (reader.Read())
                        {
                            //Getting the names of all the current projects
                            string completed = String.Format("{0}", reader["completed"]);
                            if(completed == "yes")
                            {
                                changeButton.Text = "Change Status. Currently: Completed";
                                changeButton.BackColor = Color.Green;
                                currentStatus = "yes";
                            }
                            else
                            {
                                changeButton.Text = "Change Status. Currently: Not Completed";
                                changeButton.BackColor = Color.Red;
                                currentStatus = "no";
                            }
                        }
                    }
                }
                catch
                {
                    //Showing an error message
                    MessageBox.Show("Error in loading project features status");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //Dont blame me, C# forced me to put the following in a stupid if-else statement
        private void changeButton_Click(object sender, EventArgs e)
        {
            string feature = featureCombo.Items[featureCombo.SelectedIndex].ToString();
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //We need two different sql strings here based on current completed status
            if (currentStatus == "yes")
            {
                using (SqlConnection connection = new SqlConnection(connetionString))
                {
                    connection.Open();

                    //Creating the command text
                    string commandText = "UPDATE projectDetails SET completed = 'no', comment = @comment WHERE feature LIKE @featureName";

                    //This way is secure against SQL injection attacks
                    SqlCommand command = new SqlCommand(commandText, connection);
                    //Adding variable values
                    command.Parameters.Add("@comment", SqlDbType.VarChar, 50).Value = commentBox.Text;
                    command.Parameters.Add("@featureName", SqlDbType.VarChar, 50).Value = feature;
                    try
                    {
                        //Executing the query
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("Error Adding Changing Complete Status");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connetionString))
                {
                    connection.Open();

                    //Creating the command text
                    string commandText = "UPDATE projectDetails SET completed = 'yes', comment = @comment WHERE feature LIKE @featureName";

                    //This way is secure against SQL injection attacks
                    SqlCommand command = new SqlCommand(commandText, connection);
                    //Adding variable values
                    command.Parameters.Add("@comment", SqlDbType.VarChar, 50).Value = commentBox.Text;
                    command.Parameters.Add("@featureName", SqlDbType.VarChar, 50).Value = feature;
                    try
                    {
                        //Executing the query
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("Error Adding Changing Complete Status");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            databaseStart(Newusername);
        }
    }
}
