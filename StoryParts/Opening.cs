using RPGAdv;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace rpgADV.StoryParts
{
    internal class Opening
    {
        public void StartGame()
        {
            Console.WriteLine("Welcome Tarnished, one of the forsaken who has lost his grace and seeks to reclaim it" +
                "You find yourself in the Cave of knowledge where you will encounter challenges and guidance. " +
                "Interact with a Site of Grace; Follow the light of their path.");
            Varre();
        }

        static void Varre()
        {

            Console.WriteLine("Oh yes... Tarnished, are we? Come to the Lands Between for the Elden Ring, hmm?" +
                "Of course you have. No shame in it.");
            System.Threading.Thread.Sleep(4500);
            Console.WriteLine("Unfortunately for you, however,");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("you are maidenless.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Without guidance, without the strength of runes, and without an invitation to the Roundtable Hold..." +
                "You are fated, it seems, to die in obscurity.");
            Console.WriteLine("Luckily for you, however, there is one shining ray of hope for even the maidenless.");
            Console.WriteLine("Me. Varré. Take care to listen.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Are you familiar with grace? The golden light that gives life to you Tarnished.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("You may also behold its golden rays pointing in a particular direction at times.");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("That is the guidance of grace. The path that a Tarnished must travel.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Mm, indeed. Grace's guidance holds the answers.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("It will lead you Tarnished to the path you are meant to follow.");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("Even if it leads you to your grave.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Grace's guidance will reveal the path forward, most certainly.");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("To Castle Stormveil, over on the cliff.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("The home of the decrepit demigod, Godrick the Grafted.");;
            Console.WriteLine("It's time you set off, I should think.");
            Console.WriteLine("To Castle Stormveil, on the cliff, where grace would guide you.");
            Console.WriteLine("If you seek the Elden Ring, maidenless as you are.");


            int[] roll = { 0, 1 };
            Random rawndomNumber = new Random();
            int ranRoll = rawndomNumber.Next(roll.Length);

            switch (ranRoll)
            {
                case 0:
                    Console.WriteLine("Fight Tree Sentinel?");
                    Console.WriteLine("1. Yes. \n 2. No.");
                    string choice = Console.ReadLine();
                    choice.ToLower();

                    if (choice == "yes" || choice == "1"|| choice == "one")
                    {
                        Console.WriteLine("You confront the soldier");
                        //FightTreeSen();
                    }
                    else if (choice == "no" ||  choice == "2" || choice == "second")
                    {
                        Console.WriteLine("Wise choice.");
                        //Walking();
                    }
                    break;
                case 1:
                    Console.WriteLine("You approach a grace.");
                    Console.WriteLine("\nTouch grace?");
                    Console.WriteLine("1. Yes. \n 2. No.");
                    string choice2 = Console.ReadLine();
                    choice2.ToLower();

                    if (choice2 == "yes" || choice2 == "1")
                    {
                        Console.WriteLine("Lost Grace Discovered.");
                        Console.WriteLine("Health resotred \n Enemies resurrected \n Saved Checkpoint");
                        Grace1();
                    }
                    else if (choice2 == "no" || choice2 == "2")
                    {
                        Console.WriteLine("No choice anyways");
                        Console.WriteLine("Health resotred \n Enemies resurrected \n Saved Checkpoint");
                        Grace1();
                    }
                    break;
            }


            static void Grace1()
            {
                Database databaseObject = new Database();
                //Update the user info using the database
                string query = $"UPDATE log set checkpoint = 2 WHER name = '{Global.name}'";

                SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

                databaseObject.OpenConnection();
                
                myCommand.ExecuteNonQuery();

                databaseObject.CloseConnection();

                
            }

            
        }
    }
}
