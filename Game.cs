using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        bool _gameOver = false;
        string _playerName = "the player";
        int playerHealth = 100;
        void Requestname(ref string name)
        {
            if (name == " ")
            {
                return;
            }
            //Initialize 
            char input = ' ';
            //Loop until valid input is given
            while (input != '1')
            {
                //Clear previous text
                Console.Clear();
                //Ask user for name
                Console.WriteLine("Please enter a new name for " + name);
                name = Console.ReadLine();
                //Display username
                Console.WriteLine("Hello " + name);
                //Give the user the option to change their name
                Console.WriteLine("Are you sure you want to be called " + name);
                input = GetInput("Yes", "No", "Pick one");

                if (input == '2')
                {
                    Console.WriteLine("Yeah thats a horrible name. Please try again");
                    Console.ReadKey();
                }

            }
            //If the player likes the name given then end the game
        }

        void Explore()
        {
            string drunkName = "a drunk man";
            string enemyName = "Bonnie";
            char input = ' ';
            Console.WriteLine("You came to a cross road");
            input = GetInput("Go Left", "Go right", "Pick one");
            if (input == '1')
            {
                Console.WriteLine("You find" + drunkName + " and for some reason he " +
                    "is dancing like he's drunk because..." +
                    "well he's drunk. He is listening to some Kpop song so you have instant respect for the dude. He is now " +
                    "in your party. Deal with it. What is his name?");
                Console.ReadKey();
                Requestname(ref drunkName);
                Console.WriteLine("His name is now " + drunkName);
                Console.ReadKey();

            }
            else if (input == '2')
            {
                Console.WriteLine("You go right and continue walking");
                Console.WriteLine("Please continue");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("You run into a bunny that looks cute but it turns into a giant " +
                "weird monster. Talk about evolution... anyways, he wants to fight so get ready to fight.");

            int enemyHealth = 75;
            _gameOver = StartBattle(ref playerHealth, ref enemyHealth);
        }

        void EnterRoom(int roomNumber)
        {
            string exitMessage = "";
            switch (roomNumber)
            {
                case 0:
                    {
                        exitMessage = "You leave the mansion";
                        Console.WriteLine("You are walking in the woods and find a giant" +
                            "mansion. It looks abandoned so you decide to go inside.");
                        break;
                    }
                case 1:
                case 2:
                    {
                        exitMessage = "You leave the kitchen";
                        Console.WriteLine("When you go inside, you notice the rooms are scrambled." +
                            "You find yourself in a kitchen for some odd reason.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("You notice a table in front of you." +
                            "It is missing a chair on one side");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("You look around and find the missing chair by a wall." +
                            "Behind the chair is a hidden door.");
                        break;
                    }

                default:
                    {
                        exitMessage = "You left the hallway";
                        Console.WriteLine("You go through the hidden door. " +
                            "It was unlocked surprisingly...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Coldness hits your cheek.");
                        Console.ReadKey();
                        Console.WriteLine("The room looks pretty small, and you spot a door on the opposite side of you. " +
                            "out if the corner of your eye, you spot an old man in a chair.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("He has something in his hands... it looks like a Gameboy Advance.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("...");
                        Console.ReadKey();
                        Console.WriteLine("HEs playing POKEMON!");
                        break;
                    }
            }
            Console.WriteLine("you are in room number " + roomNumber);
            char input = ' ';
            input = GetInput("Go forward", "Go back", "Which direction would you like to go?");
            if (input == '1')
            {
                EnterRoom(roomNumber + 1);
            }
            Console.WriteLine("You are leaving room " + roomNumber);
            Console.ReadKey();
        }

        bool StartBattle(ref int character1Health, ref int character2Health)
        {
            //Initialize the input variable
            char input = ' ';
            //Create battle loop. Loops until the player or enemy is dead
            while (character1Health > 0 && character2Health > 0)
            {
                Console.WriteLine("Character 1 health: " + character1Health);
                Console.WriteLine("Enemy");
                input = GetInput("Attack", "Defend", "What will you do?");
                //This means the player attacks
                if (input == '1')
                {
                    character2Health -= 10;
                    Console.WriteLine("You dealt 10 damage");


                }
                //This means the player defends
                else if (input == '2')
                {
                    Console.WriteLine("You blocked the enemy's attack!");
                    Console.ReadKey();
                    continue;
                }
                character1Health -= 20;
                Console.WriteLine("The enemy hit you and dealt 20 damage");
                Console.ReadKey();
            }
            return character1Health <= 0;
        }

        void ViewStats()
        {
            //Prints player stats to screen
            Console.WriteLine(_playerName);
            Console.WriteLine("\nPress any key to continue");
            Console.Write("> ");
            Console.ReadKey();
        }
        char GetInput(string option1, string option2, string query)
        {
            //Initialize input value
            char input = ' ';
            //Loop until a valid input is received
            while (input != '1' && input != '2')
            {

                Console.WriteLine("1. " + option1, "Pick one");
                Console.WriteLine("2. " + option2, "Pick one");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            //return input received from user
            return input;
        }

        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        //Performed once when the game begins
        //Used for initializing variables
        //Also used for performing start up tasks that should only be done once
        public void Start()
        {
            Console.WriteLine("Hello there strange traveler!!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("This game is really weird, so anything can happen. " +
                "you might run into a dear or a flying baby horse who likes anime " +
                "you know? ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("But I guess we should get introductions out the way. " +
                "My name is <RETRACTED>");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("What? You couldn't hear my name?");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You THOught i Would Tell you tHat?#$? ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("wHy WOuld i TelL YOu thAt???");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("We aren't friends... Not even close.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("No...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You may not know where you are...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("*butyou deserve it _7&24252..>?");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("#!#$^*()#@#...i...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("i..I...#%#@(");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("YOu wiLl pAy@#!#...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("I will...Avenge THem...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("...all of them...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("*YOU HEAR A LOUD CRASH, THEN SILENCE FOLLOWS...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ahem.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("HI THERE FRIEND!!! "
                + "WE ARE GOING TO BE BEST OF FRIENDS!!!!");
            Console.ReadKey();
            Console.Clear();





        }

        //Repeated until the game ends
        //Used for all game logic that will repeat
        public void Update()
        {
            Requestname(ref _playerName);
            EnterRoom(0);
        }



        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThe end...of your life (>^^<)");
        }
    }
}
