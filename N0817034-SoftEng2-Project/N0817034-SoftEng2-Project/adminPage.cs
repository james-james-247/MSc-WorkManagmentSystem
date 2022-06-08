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
    public partial class adminPage : Form
    {
        int ID;
        public adminPage(int id)
        {
            ID = id;
            InitializeComponent();
            databaseProjectNames();
        }

        private void databaseProjectNames()
        {
            projectSelector.Items.Clear();
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "SELECT projectName, projectID FROM projects";

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
                            //Getting the names of all the current projects
                            string projectNames = String.Format("{0}", reader["projectName"]).ToLower();
                            projectSelector.Items.Add(projectNames);
                        }
                    }
                }
                catch(Exception ex)
                {
                    //Showing an error message
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Error in loading project names");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        int projID;
        private void projectSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enabling the comment box and button 
            commentbox.Enabled = true;
            commentButton.Enabled = true;
            deleteButton.Enabled = true;

            //reseting the values of certain things 
            timelineButton.Enabled = true;
            table.Rows.Clear();

            string selectorValue = projectSelector.Items[projectSelector.SelectedIndex].ToString();
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "SELECT feature, completed, comment, projectID FROM projectDetails WHERE projectID LIKE (SELECT projectID FROM projects WHERE projectName LIKE '%' + @name + '%')";
            //string commantext2 = "SELECT comment FROM comments WHERE projectID LIKE (SELECT projectID FROM projects WHERE projectName LIKE '%' + @name + '%')";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                //SqlCommand commandTwo = new SqlCommand(commantext2, connection);

                //Adding the variable values
                command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = selectorValue;
                //commandTwo.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = selectorValue;
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
                            DataGridViewRow row = (DataGridViewRow)table.Rows[0].Clone();
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
                            table.Rows.Add(row);
                            projID = (int)reader["projectID"];
                        }
                    }
                }
                catch(Exception ex)
                {
                    //Showing an error message
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Error in loading project details");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            //Getting commentBox information 
            string comment = commentbox.Text;
            //Getting selector box value
            string selectorValue = projectSelector.Items[projectSelector.SelectedIndex].ToString();

            //getting the current time
            DateTime dateT = DateTime.Now;

            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            //connetionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\wmsDatabase.mdf; Integrated Security = True";
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "INSERT INTO comments (projectID, comment, time, commentor) VALUES ((SELECT projectID FROM projects WHERE projectName LIKE '%' + @name + '%'), @comment, @time, @commentor)";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);

                //Adding variable value
                command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = selectorValue;
                command.Parameters.Add("@comment", SqlDbType.VarChar, 1000).Value = comment;
                command.Parameters.Add("@time", SqlDbType.DateTime).Value = dateT;
                command.Parameters.Add("@commentor", SqlDbType.Int).Value = ID;
                try
                {
                    if (comment == "")
                    {
                        MessageBox.Show("Please Enter a Value in Comment Box");
                    }
                    else
                    {
                        //Opening the Connection and then sending the query
                        connection.Open();
                        command.ExecuteNonQuery();
                        commentbox.Text = "";
                    }
                }
                catch(Exception ex)
                {
                    //Showing an error message
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Error in loading uploading comment");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void adminNewProject_Click(object sender, EventArgs e)
        {
            adminCreate create = new adminCreate(ID);
            create.Show();
            Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            Hide();
        }

        private void newUser_Click(object sender, EventArgs e)
        {
            adminNewUser newUser = new adminNewUser(ID);
            newUser.Show();
            Hide();
        }

        private void timelineButton_Click(object sender, EventArgs e)
        {
            timeline time = new timeline(projID);
            time.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Delete from database
            string projectName = projectSelector.Items[projectSelector.SelectedIndex].ToString();
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            //connetionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\wmsDatabase.mdf; Integrated Security = True";
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            //Kinda have to do this command first or the project doesnt delete due to a FK error so yeah
            string commandTextFirst = "DELETE FROM comments WHERE projectID LIKE (SELECT projectID FROM projects WHERE projectName LIKE @projName)";
            string commandText = "DELETE FROM projectDetails WHERE projectID LIKE (SELECT projectID FROM projects WHERE projectName LIKE @projName)";
            string commandTextTwo = "DELETE FROM projects WHERE projectName LIKE @projName";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand commandFirst = new SqlCommand(commandTextFirst, connection);
                SqlCommand command = new SqlCommand(commandText, connection);
                SqlCommand commandTwo = new SqlCommand(commandTextTwo, connection);

                //Adding variable value
                commandFirst.Parameters.Add("@projName", SqlDbType.VarChar, 50).Value = projectName;
                command.Parameters.Add("@projName", SqlDbType.VarChar, 50).Value = projectName;
                commandTwo.Parameters.Add("@projName", SqlDbType.VarChar, 50).Value = projectName;
                try
                {
                   //Opening the Connection and then sending the query
                   connection.Open();
                   commandFirst.ExecuteNonQuery();
                   command.ExecuteNonQuery();
                   commandTwo.ExecuteNonQuery();
                   commentbox.Text = "";
                }
                catch (Exception ex)
                {
                    //Showing an error message
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Error in loading deleting project");
                }
                finally
                {
                    connection.Close();
                }
            }
            table.Rows.Clear();
            projectSelector.SelectedIndex = 0;
            databaseProjectNames();
        }
    }
}
