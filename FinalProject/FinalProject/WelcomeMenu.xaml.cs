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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WelcomeMenu.xaml
    /// </summary>
    public partial class WelcomeMenu : Window
    {
        public WelcomeMenu()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HighscoreClick_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Highscores high = new Highscores();
            high.Show();

        }

        private void Instructions_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Instructions instructions = new Instructions();
            instructions.Show();
            this.Close();
        }

        internal void LoginButton_Clicked()
        {
            throw new NotImplementedException();
        }
    }
}
