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
    public partial class adminCreate : Form
    {
        int ID;
        public adminCreate(int id)
        {
            ID = id;
            InitializeComponent();

            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "SELECT groupName, groupID FROM groups";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
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
                            groupSelector.Items.Add(groupNames);
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

        private void detailsButton_Click(object sender, EventArgs e)
        {
            //Getting variables
            string projectName = nameBox.Text;
            string groupText = "";
            try
            {
                groupText = groupSelector.Items[groupSelector.SelectedIndex].ToString().ToLower();
            }
            catch {}

            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "SELECT projectName FROM projects WHERE projectName LIKE '%' + @projName + '%'";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@projName", SqlDbType.VarChar, 50).Value = projectName;
                try
                {
                    if (projectName == "")
                    {
                        MessageBox.Show("Please Enter a Value in Project Name");
                    }
                    else
                    {
                        //Opening the Connection and then sending the query
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //For each of the values returned
                            if (reader.Read())
                            {
                                //Name in use
                                MessageBox.Show("Project Name In Use: Please Try Again!");
                            }
                            else
                            {
                                insertData(groupText, projectName);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    //Showing an error message
                    MessageBox.Show("Error in loading project names");
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void insertData(string groupText, string projectName)
        {
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                if (groupText != "")
                {
                    //Creating the command text
                    string commandText = "INSERT INTO projects (groupID, projectName) VALUES ((SELECT groupID FROM groups WHERE groupName LIKE '%' + @groupName + '%'), @projName)";

                    connection.Open();
                    //This way is secure against SQL injection attacks
                    SqlCommand commandTwo = new SqlCommand(commandText, connection);
                    //Adding variable values
                    commandTwo.Parameters.Add("@groupName", SqlDbType.VarChar, 50).Value = groupText;
                    commandTwo.Parameters.Add("@projName", SqlDbType.VarChar, 50).Value = projectName;
                    try
                    {
                        //Executing the query
                        commandTwo.ExecuteNonQuery();
                        connection.Close();

                        //enabling and disabling certain features
                        groupBox1.Enabled = true;
                        nameBox.Enabled = false;
                        groupSelector.Enabled = false;
                        detailsButton.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Error Adding New Project");
                    }
                }
                else
                {
                    //Telling the user they need to choose a group
                    MessageBox.Show("Please choose a group");
                }
                connection.Close();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Defining Variables
            string featureNames = featureName.Text;
            string comment = commentBox.Text;
            string projName = nameBox.Text;

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
                        MessageBox.Show("Please Ensure You Have Values in Both Boxes");
                    }
                    else
                    {
                        //Executing the query
                        command.ExecuteNonQuery();
                        connection.Close();

                        featureName.Text = "";
                        commentBox.Text = "Not Completed";
                    }
                }
                catch
                {
                    MessageBox.Show("Error Inserting Detail");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            featureName.Text = "";
            commentBox.Text = "Not Compelted";
            groupBox1.Enabled = false;
            nameBox.Enabled = true;
            groupSelector.Enabled = true;
            detailsButton.Enabled = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            adminPage admin = new adminPage(ID);
            admin.Show();
            Hide();
        }
    }
}
