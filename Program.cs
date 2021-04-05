using System;

namespace Storybook1
{
    class Program
    {
        static void Main(string[] args)
        {



            // creating the vairables for our characters
            int Achar = 1;
            int Cchar = 1;
            bool runGame = true;
            //While runGame is true, the game will run.
            while (runGame == true)
            {



                // starting text, and having our user choose their character
                Console.WriteLine("* * * * * Storybook Title * * * * *");
                Console.WriteLine("Please choose an Adventurer by entering A, B, or C then pressing enter.");
                Console.WriteLine("A: Talulah");
                Console.WriteLine("B: Bee ");
                Console.WriteLine("C: Gorilla Thompson");


                int usernumber = -1;

                while (usernumber < 0)
                {

                    string input = Console.ReadLine();

                    if (input == "a" || input == "A")
                    {
                        //this is where we put what to do if they entered a or A
                        usernumber++;
                        Achar++;
                    }
                    else if (input == "b" || input == "B")
                    {
                        //this is where we put what to do if they entered b or B
                        string[] lines = {" ",
                "Bees are cute, but not very good adventurers",
                " ",
                "     .-.         .--''-.",
                "   .'   '.     /'       `.",
                "   '.     '. ,'          |",
                " o    '.o   ,'        _.-'",
                "  \\.--./'. /.:. :._:.'",
                " .'    '._-': ': ': ': ':",
                ":(#) (#) :  ': ': ': ': ':>-",
                " ' ____ .'_.:' :' :' :' :'",
                "  '\\__/'/ | | :' :' :'",
                "        \\  \\ \\",
                "         '  ' '",
                "Please enter A, or C."
                };

                        foreach (string line in lines)
                            Console.WriteLine(line);
                    }
                    else if (input == "c" || input == "C")
                    {
                        //this is where we put what to do if they entered c or C
                        usernumber++;
                        Cchar++;
                    }

                    else
                    {
                        Console.WriteLine("Please enter A, B, or C.");
                    }

                }






                //if they chose char a, the following will run
                if (Achar == 2)
                {
                    string[] lines = {" ",
                    "* * * * * The Adventure of Talulah * * * * *",
                    "",
                    "Talulah is playing a rad roguelike and needs help outfitting her party.",
                    "First up is her barbarian, Thud Hamfist.",
                    "Should he use a Warhammer or a Battle Axe? Press enter after typing your choice",
                    "",


                };


                    foreach (string line in lines)
                        Console.WriteLine(line);

                    string BarbWeapon = "";
                    string WepQual = "";
                    int BarbChoice = 0;

                    while (BarbChoice < 1)
                    {

                        string Hamfistinput = Console.ReadLine();

                        if (Hamfistinput == "Warhammer" || Hamfistinput == "warhammer")
                        {

                            Console.WriteLine(" ");
                            BarbWeapon = "Warhammer";
                            WepQual = "crush";
                            BarbChoice++;

                        }

                        else if (Hamfistinput == "Battle Axe" || Hamfistinput == "battle axe")
                        {

                            Console.WriteLine(" ");
                            BarbWeapon = "Battle Axe";
                            WepQual = "cleave";
                            BarbChoice++;

                        }

                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Thud will not use such a puny weapon!");
                            Console.WriteLine(" ");
                        }
                    }

                    Console.WriteLine("Alright, Thud will use a " + BarbWeapon + " to " + WepQual + " his enemies!");
                    Console.WriteLine("");

                    //START OF ROGUE
                    string[] linesTwo = {" ",
                    "Next up is Talulah's rogue, Sneaky Snek",
                    "Should Snek use a Dagger or a Rapier? Press enter after typing your choice",
                    "",

                };


                    foreach (string lineTwo in linesTwo)
                        Console.WriteLine(lineTwo);


                    string RogWeapon = "";
                    string RogWepQual = "";
                    int RogChoice = 0;

                    while (RogChoice < 1)
                    {
                        string SnekInput = Console.ReadLine();

                        if (SnekInput == "Dagger" || SnekInput == "dagger")
                        {
                            Console.WriteLine(" ");
                            RogWeapon = "Dagger";
                            RogWepQual = "stab";
                            RogChoice++;

                        }

                        else if (SnekInput == "Rapier" || SnekInput == "rapier")
                        {
                            Console.WriteLine(" ");
                            RogWeapon = "Rapier";
                            RogWepQual = "slash";
                            RogChoice++;
                        }

                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Snek can't sneak around with that!");
                            Console.WriteLine(" ");
                        }


                    }

                    Console.WriteLine("Alright, Snek will use a " + RogWeapon + " to " + RogWepQual + " his enemies!");
                    Console.WriteLine("");

                    //START OF WIZARD

                    string[] linesThree = {" ",
                    "Lastly is Talulah's wizard, Jandalf",
                    "Should Jandalf use a Staff or a Wand? Press enter after typing your choice",
                    "",

                };


                    foreach (string lineThree in linesThree)
                        Console.WriteLine(lineThree);


                    string WizWeapon = "";
                    string WizWepQual = "";
                    int WizChoice = 0;

                    while (WizChoice < 1)
                    {
                        string WizInput = Console.ReadLine();

                        if (WizInput == "Staff" || WizInput == "staff")
                        {
                            Console.WriteLine(" ");
                            WizWeapon = "Staff";
                            WizWepQual = "ensorcel";
                            WizChoice++;

                        }

                        else if (WizInput == "Wand" || WizInput == "wand")
                        {
                            Console.WriteLine(" ");
                            WizWeapon = "Wand";
                            WizWepQual = "blast";
                            WizChoice++;
                        }

                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Jandalf can't magic it up with that!");
                            Console.WriteLine(" ");
                        }
                    }

                    Console.WriteLine("Alright, Jandalf will use a " + WizWeapon + " to " + WizWepQual + " his enemies!");
                    Console.WriteLine("");
                    Achar++;

                    //A Char Closing bracket
                }

                if (Achar == 3)
                {
                    bool menuChoice = false;
                   while (menuChoice == false){
                    Console.WriteLine("Thanks for playing, you are gud adventurer!");
                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("Y/N");

                    string playAgain = Console.ReadLine();
                    if (playAgain == "y" || playAgain == "Y")
                    {
                        Console.WriteLine("\r\n\n\n");
                        menuChoice = true;
                    }

                    else if (playAgain == "n" || playAgain == "N")
                    {
                        runGame = false;
                            menuChoice = true;
                    }

                    else
                    {
                        Console.WriteLine("Please type Y or N and press enter");
                        Console.WriteLine("");
                    }
                    }
                }





                //if they chose char c, the following will run
                if (Cchar == 2)
                {
                    string[] lines = {" ",
                    "* * * * * The Adventure of Gorilla Thompson * * * * *",
                    "",
                    "Gorilla Thompson is hungry, and wants to make a sandwich.",
                    "He knows how to make a sandwich, but isn't entirely sure what to put on one.",
                    "Here's a list of Gorilla Thompson's ingredients, help him pick 3 ingredients to put on his sandwich.",
                    "After typing your choice, press enter.",
                    " ",
                    "Bananas",
                    "Cheddar Cheese",
                    "Peanut Butter",
                    "Ham",
                    "Mustard",
                    " ",
                    " ",
                };

                    foreach (string line in lines)
                        Console.WriteLine(line);

                    int Bananas = 0;
                    int Cheddar = 0;
                    int PeanutB = 0;
                    int Ham = 0;
                    int Mustard = 0;

                    int ingredients = 0;


                    while (ingredients < 3)
                    {
                        string SandwichInput = Console.ReadLine();
                        //The following are the various inputs allowed to increase the variable "ingredients"
                        if (SandwichInput == "Bananas" || SandwichInput == "bananas")
                        {
                            Console.WriteLine("Some Bananas huh?");
                            Console.WriteLine(" ");
                            Bananas++;
                            ingredients++;

                        }

                        else if (SandwichInput == "Cheddar" || SandwichInput == "cheddar" || SandwichInput == "Cheddar Cheese" || SandwichInput == "cheddar cheese")
                        {
                            Console.WriteLine("Some Cheese huh?");
                            Console.WriteLine(" ");
                            Cheddar++;
                            ingredients++;
                        }

                        else if (SandwichInput == "Peanut Butter" || SandwichInput == "peanut butter")
                        {
                            Console.WriteLine("Some Peanut Butter huh?");
                            Console.WriteLine(" ");
                            PeanutB++;
                            ingredients++;
                        }

                        else if (SandwichInput == "Ham" || SandwichInput == "ham")
                        {
                            Console.WriteLine("Nice, Ham is my Jam!...ooh, if only he had some jam.");
                            Console.WriteLine(" ");
                            Ham++;
                            ingredients++;
                        }

                        else if (SandwichInput == "Mustard" || SandwichInput == "mustard")
                        {
                            Console.WriteLine("Some Mustard huh?");
                            Console.WriteLine(" ");
                            Mustard++;
                            ingredients++;
                        }

                        else
                        {
                            Console.WriteLine("Gorilla Thompson doesn't have that ingredient :[");
                            Console.WriteLine(" ");
                        }

                    }

                    int ingredientsNeeded = 3;
                    bool SandwichComplete;

                    if (ingredients >= ingredientsNeeded)
                    {
                        SandwichComplete = true;
                    }

                    else
                    {
                        SandwichComplete = false;
                    }

                    //here's what happens if they add 3 ingredients to make the sandwich
                    if (SandwichComplete)
                    {
                        Console.WriteLine("Gorilla Thompson puts those ingredients together and...");
                        Console.WriteLine(" ");

                        if (Bananas > 0 && Cheddar > 0)
                        {
                            Console.WriteLine("aw yeh, das a good one");
                            Console.WriteLine(" ");
                            Cchar++;
                        }

                        else if (Bananas > 0 && PeanutB > 0)
                        {
                            Console.WriteLine("The King would be proud.");
                            Console.WriteLine(" ");
                            Cchar++;
                        }

                        else
                        {
                            Console.WriteLine("You did it! and what a sandwich you made!");
                            Console.WriteLine(" ");
                            Cchar++;
                        }
                    }
                    //the end of char 3's adventure
                    if (Cchar == 3)
                    {
                        bool menuChoice = false;
                        while (menuChoice == false)
                        {
                            Console.WriteLine("Thanks for playing, you are gud adventurer!");
                            Console.WriteLine("Would you like to play again?");
                            Console.WriteLine("Y/N");

                            string playAgain = Console.ReadLine();
                            if (playAgain == "y" || playAgain == "Y")
                            {
                                Console.WriteLine("\r\n\n\n");
                                menuChoice = true;
                            }

                            else if (playAgain == "n" || playAgain == "N")
                            {
                                runGame = false;
                                menuChoice = true;
                            }

                            else
                            {
                                Console.WriteLine("Please type Y or N and press enter");
                                Console.WriteLine("");
                            }
                        }
                    }




                }




                

            }
        }
    }
}
