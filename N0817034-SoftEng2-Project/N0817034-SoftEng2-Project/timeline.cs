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
    public partial class timeline : Form
    {
        public timeline(int projID)
        {
            InitializeComponent();

            //Define the string used to connect to the SQL database then opens the database
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\N0817034-SoftEng2-Project\N0817034-SoftEng2-Project\wmsDatabase.mdf;Integrated Security=True";

            //Creating the command text
            string commandText = "SELECT comment, time, commentor FROM comments WHERE projectID LIKE @projID";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                //This way is secure against SQL injection attacks
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@projID", SqlDbType.Int).Value = projID;
                try
                {
                    //Opening the Connection and then sending the query
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //For each of the values returned
                        while(reader.Read())
                        {
                            //Getting the names of all the current projects
                            string comment = String.Format("{0}", reader["comment"]);
                            DateTime dateT = (DateTime)reader["time"];
                            int commentor = (int)reader["commentor"];

                            //Showing the details
                            DataGridViewRow row = (DataGridViewRow)timelineTable.Rows[0].Clone();
                            row.Cells[0].Value = dateT;
                            row.Cells[1].Value = comment;

                            string commandTextTwo = "SELECT username FROM \"user\" WHERE Id LIKE @Id";
                            using (SqlConnection connectionTwo = new SqlConnection(connetionString))
                            {
                                //This way is secure against SQL injection attacks
                                SqlCommand commandTwo = new SqlCommand(commandTextTwo, connectionTwo);
                                commandTwo.Parameters.Add("@Id", SqlDbType.Int).Value = commentor;
                                try
                                {
                                    //Opening the Connection and then sending the query
                                    connectionTwo.Open();
                                    using (SqlDataReader readerTwo = commandTwo.ExecuteReader())
                                    {
                                        //Returning the value
                                        if (readerTwo.Read())
                                        {
                                            row.Cells[2].Value = String.Format("{0}", readerTwo["username"]);
                                        }
                                        else
                                        {
                                            row.Cells[2].Value = "No Username Was Provided";
                                        }
                                    }
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("Error getting username");
                                }
                                finally
                                {
                                    connectionTwo.Close();
                                }
                            }
                            timelineTable.Rows.Add(row);
                        }
                    }
                }
                catch{}
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
