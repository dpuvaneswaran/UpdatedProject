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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for TicTacToe.xaml
    /// </summary>
    public partial class TicTacToe : Window
    {
        public TicTacToe()
        {
            InitializeComponent();
            NewGame();
        }

        private MarkType[] mResults;    // Holds the current values of the cells in the active game

        private bool player1Turn;       // True if its player 1 turn (x) or player 2 turn (0)

        private bool gameEnded;         // True if the game has ended


        private void NewGame()
        {
            mResults = new MarkType[9]; // Creates a blank array of free cells

            for (var i = 0; i < mResults.Length; i++)
            {
                mResults[i] = MarkType.Free;

                player1Turn = true;

                //interates every bttns on the grids
                Container.Children.Cast<Button>().ToList().ForEach(btton =>
                {
                    //Changes bg, foreground and contents to a default value
                    btton.Content = string.Empty;
                    btton.Background = Brushes.White;
                    btton.Foreground = Brushes.Blue;

                });

            }

            //Making sure the game hasnt finished
            gameEnded = false;
        }

        // Hnadles button click events
        private void Button0_0_Click(object sender, RoutedEventArgs e)
        {
            // starts new game once its finished
            if (gameEnded)
            {
                NewGame();
                return;
            }

            //cast the sender to a button
            var button = (Button)sender;

            //find the buttons position in the array    
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            //Dont do anything if the cell already has a value in it
            if (mResults[index] != MarkType.Free)
            {
                return;
            }

            //Set the value based on which players turn it is
            mResults[index] = player1Turn ? MarkType.Cross : MarkType.Nought;

            //Set button text to the result
            button.Content = player1Turn ? "X" : "O";


            //Change colour of noughts to green

            if (player1Turn != true)
            {
                button.Foreground = Brushes.Red;

            }

            //Toggles the player turns
            player1Turn ^= true;


            //Checks for winner
            CheckForWinner();


        }

        //This method will check if there is a winner of 3 lines straight
        private void CheckForWinner()
        {

            // Chcks for if there isnt any winners
            if (!mResults.Any(f => f == MarkType.Free))
            {
                gameEnded = true;

                Container.Children.Cast<Button>().ToList().ForEach(btton =>
                {
                    //Changes bg, foreground and contents to a default value
                    btton.Background = Brushes.Orange;

                });
            }

            // Checks for diagonal wins

            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                gameEnded = true;

                // Highlight winning cells in green
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.LightGreen;

            }

            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                gameEnded = true;

                // Highlight winning cells in green
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.LightGreen;

            }

            //Checks for winners horizontally

            // ROW 0
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                gameEnded = true;

                // Highlight winning cells in green
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.LightGreen;

            }

            // ROW 1
            if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[0])
            {
                gameEnded = true;

                // Highlight winning cells in green
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.LightGreen;

            }

            //ROW 2

            if (mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                gameEnded = true;

                // Highlight winning cells in green
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.LightGreen;

            }


            // Checking for vertical wins

            // COLUMN 0
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                gameEnded = true;

                // Highlight winning cells in green
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.LightGreen;
                
            }

            // COLUMN  1
            if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                gameEnded = true;

                // Highlight winning cells in green
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.LightGreen;
                
            }

            // COLUMN  2

            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                gameEnded = true;

                // Highlight winning cells in green
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.LightGreen;
                
            }





        }
    }
}
