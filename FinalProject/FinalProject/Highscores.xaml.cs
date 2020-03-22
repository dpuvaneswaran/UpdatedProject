using System;
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
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for Highscores.xaml
    /// </summary>
    public partial class Highscores : Window
    {
        public Highscores()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            WelcomeMenu welcome = new WelcomeMenu();
            welcome.Show();

        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            {

                /*using (var db = new ProjectContext())
                {
                    var highscores = 
                    
                        (from highscore in db.Highscores
                         select highscore).ToList();
                }*/

                            
                               /*//Setting the SQL Credentials
                               SqlConnection conn = new SqlConnection("Data Source = localhost;" + "Initial Catalog = Project;" + "User ID = SA;" + "Password= Passw0rd2018;");


                               //Using Data Manipulative Language to Query
                               SqlCommand cmd = new SqlCommand("SELECT HighscoreID, Username, Score " + "FROM Highscores", conn);

                               SqlDataAdapter adapter = new SqlDataAdapter();
                               conn.Open();
                               DataTable dt = new DataTable();
                               dt.Load(cmd.ExecuteReader());

                
                               conn.Close();

                               HighscoresTbl.DataContext = dt;*/
            }

        }
    }
}
