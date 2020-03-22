using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Database_Model
{
    class HighscoresList : DbContext
    {
        public class Highscores

           
        {

            private List<Highscores> hs;


            //App Users Table Attributes
            public int HighscoreID { get; set; }
            public string Username { get; set; }
            public int Score { get; set; }


            //Linked User & Highscore Relationship

            public List<HighscoresList> HighScore { get; } = new List<HighscoresList>();


            public override string ToString()
            {
                return $"{Username} {Score}";
            }
        }


    }
}
