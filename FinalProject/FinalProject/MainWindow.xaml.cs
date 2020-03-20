using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTxt.Text.Length == 0)
            {
                ErrorMessage.Text = "Please enter a valid username";
                UsernameTxt.Focus();
            }

            else

            {

                //User login input fields

                string username = UsernameTxt.Text;
                string password = PasswordBox.Password;
                
                ErrorMessage.Text = "";


                    //Set SQL Credentials
                     SqlConnection connection = new SqlConnection("Data Source = localhost;" + "Initial Catalog = Project;" + "User ID = SA;" + "Password= Passw0rd2018;");
                     //Open New SQL Connection
                     connection.Open();

                     //SQL DML Query
                     SqlCommand command = new SqlCommand("SELECT * " + "FROM AppUsers WHERE Username ='" + username + "'  and Password ='" + password + "'", connection);

                     SqlDataAdapter adapter = new SqlDataAdapter();
                     adapter.SelectCommand = command;
                     DataSet dataSet = new DataSet();
                     adapter.Fill(dataSet);
                     if (dataSet.Tables[0].Rows.Count > 0)
                     {
                         this.Hide();
                         WelcomeMenu login = new WelcomeMenu();
                         login.Show();
                         Close();
                     }
                     else
                     {
                         ErrorMessage.Text = "Try Again Incorrect";
                     }
     
                }
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void RegisterButton1_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    } 
}

