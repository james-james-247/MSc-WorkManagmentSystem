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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        //Defining the empty variables
        private string username = string.Empty;
        private string password = string.Empty;

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Assiging the variables with the text box values
            username = usernameBox.Text;
            password = passwordBox.Text;

            //Creating the command text
            string commandText = "SELECT username, password, admin, Id FROM \"user\" WHERE username LIKE '%' + @username + '%' AND password LIKE '%' + @password + '%'";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);

                //Adding the variable values
                command.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
                try
                {
                    //Opening the Connection and then sending the query
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //If it returns a result then that means the user has succesfully logged in
                        if(reader.Read())
                        {
                            //Checking to see if the user is an admin (superuser) or not and send to appropraite page
                            string adminCheck = String.Format("{0}", reader["admin"]).ToLower();
                            string adminFinal = adminCheck.Trim();
                            if(adminFinal == "yes")
                            {
                                //Sending to admin page
                                int id = (int)reader["Id"];
                                adminPage admin = new adminPage(id);
                                admin.Show();
                                Hide();
                            }
                            else
                            {
                                //Sending to homepage page
                                userHome home = new userHome(username);
                                home.Show();
                                Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Attempt Failed. Username Or Password Incorrect.");
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    //Dispalying an error message if for some reason the query fails
                    MessageBox.Show("Error in handling your request!");
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    //Closing the connection to keep it secure
                    connection.Close();
                }
            }

        
        }
    }
}
