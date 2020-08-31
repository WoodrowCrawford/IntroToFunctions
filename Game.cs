using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        bool _gameOver = false;
        string _playerName = "none";
        void Requestname()
        {
            if (_playerName != "")
            {
                return;
            }
            //Initialize 
            char input = ' ';
            //Loop until valid input is given
            while(input != '1')
            {
                //Clear previous text
                Console.Clear();
                //Ask user for name
                Console.WriteLine("Please enter your name.");
                _playerName = Console.ReadLine();
                //Display username
                Console.WriteLine("Hello " + _playerName);
                //Give the user the option to change their name
                Console.WriteLine("Are you sure you want to be called this?");
                input = GetInput("Yes", "No", "Pick one");
                if (input == '2')
                {
                    Console.WriteLine("Yeah thats a horrible name. Please try again");
                }
                
            }
            //If the player likes the name given then end the game
        }
        
        void Explore()
        {
            char input = ' ';
            Console.WriteLine("You came to a cross road");
            input = GetInput("Go Left", "Go right", "Pick one");
            if(input == '1')
            {
                Console.WriteLine("You go left and trigger a trap and die");
                _gameOver = true;

            }
        }

        char GetInput(string option1, string option2, string query)
        {
            //Initialize input value
            char input = ' ';
            //Loop until a valid input is received
            while (input != '1' && input != '2')
            {
                
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
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

            while(_gameOver == false)
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
            Console.WriteLine("Hello there...");
            
        }

        //Repeated until the game ends
        //Used for all game logic that will repeat
        public void Update()
        {
            Requestname();
            Explore();
        }
           
            

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThanks for playing!");
        }
    }
}
