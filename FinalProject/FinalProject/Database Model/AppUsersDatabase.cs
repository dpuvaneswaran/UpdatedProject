using Microsoft.EntityFrameworkCore;
using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Database_Model
{
    class AppUsersDatabase : DbContext
    {
        //Create User Table

        public DbSet<AppUsers> Users { get; set; }        
        public DbSet<Highscores> HighScores { get; set; }


        //User Table

        public partial class AppUsers

        {

            //App Users Table Attributes
            public int UserId { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }


            //Linked User & Highscore Relationship

            public List<Highscores> HighScore { get; } = new List<Highscores>();

        }


    }
}
