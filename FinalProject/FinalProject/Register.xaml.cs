﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindowObject = new MainWindow();
            MainWindowObject.Show();
            this.Close();
        }

        private void RegisterButton2_Click(object sender, RoutedEventArgs e)
        {
            //User Textbox Input Fields

            string username = registerUsername.Text;
            string password = registerPassword.Password;

            //Password Parameters
            if (registerPassword.Password.Length == 0)
            {
                ErrorMessage.Text = "Please enter a password";
                registerPassword.Focus();
            }

            //Password Confirmation
            else if (RetypePassword.Password.Length == 0)
            {
                ErrorMessage.Text = "Please confirm your password";
                registerPassword.Focus();
            }

            else if (registerPassword.Password != RetypePassword.Password)
            {
                ErrorMessage.Text = "Password is not matching";
                RetypePassword.Focus();
            }

            //SQL Database Entry
            else
            {
                ErrorMessage.Text = "";

                //Set SQL Credentials
                SqlConnection connection = new SqlConnection("Data Source = localhost;" + "Initial Catalog = Project;" + "User ID = SA;" + "Password= Passw0rd2018;");

                //Open New SQL Connection
                connection.Open();

                //SQL DML Query
                SqlCommand command = new SqlCommand("INSERT INTO AppUsers " + "(Username, Password) " + "VALUES('" + username + "','" + password + "')", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                MainWindow registered = new MainWindow();
                registered.Show();
                this.Close();
            }
        }
    }
}