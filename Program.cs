using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace RPGAdv
{
    class Global
    {
        public static int checkpoint;
        public static bool loadedCheckPoint;
        public static string name;

        class Program
        {
            static void Main()
            {
                Database databaseObject =  new Database();

                Console.WriteLine("Welcome Voyager! Have you played this game before?");
                string playedInput = Console.ReadLine();

                if (playedInput == "No")
                {
                    //Create profile
                    Console.WriteLine("Welcome new player! Please start by telling me your name!");
                    string name = Console.ReadLine();

                    //Tell data base what we want it to do
                    string query = "INSERT INTO login ('name', 'checkpoint') VALUES (@name, @checkpoint)";

                    //Creates a SQLite coomand
                    SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

                    //OPens the databse
                    databaseObject.OpenConnection();

                    //Insert the data into the database1name);
                    myCommand.Parameters.AddWithValue("@checkpoint", 0);

                    //Execute the command
                    myCommand.ExecuteNonQuery();

                    //Close the data
                    databaseObject.CloseConnection();

                    Console.WriteLine($"Welcome {name}! Allow me a moment to set up your profile");

                    //Connect to the pause method
                    //Pause();

                    Console.WriteLine("Ready! Press enter to begin");
                    Console.ReadLine();

                    //Connect to the StartGame Method
                    //StartGame();
                    //StartGame();

                    Console.ReadKey();
                }

                else if (playedInput == "Yes")
                {
                    Console.WriteLine("Please tell me your name");
                    Global.name = Console.ReadLine();

                    Console.WriteLine("Great! Give me a moment to pull up your profile.");
                    //Pause();


                    // checking user info form the database.

                    string query = $"SELECT * FROM login WHERE name = '{Global.name}'";

                    SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

                    databaseObject.OpenConnection();

                    SQLiteDataReader user = myCommand.ExecuteReader();

                    // checking to make sure the database has info in it.

                    if (user.HasRows)   
                    {
                        while (user.Read())
                        {
                            Console.WriteLine("Welcome back {0}!", user["name"]);

                        }
                    }

                    //closing database
                    databaseObject.CloseConnection();

                    //load checkpoint method
                    //LoadCheckpoint();
                }
            }
        }
    }
}