using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    class Program
    {
        public static List<Dragon> ListOfDragons = new List<Dragon>();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Ascii Art";
            string Title = @"           
                                                    (                                       
                         (            )            )\ )                                    
                         )\  (     ( /(    (   (  (()/(   (       )  (  (                  
                       (((_) )\ )  )\())  ))\  )(  /(_))  )(   ( /(  )\))(  (    (     (   
                       )\___(()/( ((_)\  /((_)(()\(_))_  (()\  )(_))((_))\  )\   )\ )  )\  
                      ((/ __|)(_))| |(_)(_))   ((_)|   \  ((_)((_)_  (()(_)((_) _(_/( ((_) 
                       | (__| || || '_ \/ -_) | '_|| |) || '_|/ _` |/ _` |/ _ \| ' \))(_-< 
                        \___|\_, ||_.__/\___| |_|  |___/ |_|  \__,_|\__, |\___/|_||_| /__/ 
                             |__/                                   |___/                ";
            bool keepThinking = true;
            while (keepThinking == true)
            {
                Console.Clear();
                Console.WriteLine(Title);
                Console.WriteLine("Welcome to CyberDragons! We've got so many dragons here, y'all. Just a million dragons.");
                Console.WriteLine($"You currently have {ListOfDragons.Count} dragons.");
                Console.WriteLine("Choose an option!");
                Console.WriteLine("1. Create a dragon.");
                Console.WriteLine("2. View your dragons.");
                Console.WriteLine("3. Instructions.");
                Console.WriteLine("4. Exit.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Dragon myDragon = CreateDragon();
                        break;
                    case "2":
                        ShowDragonStats();
                        break;
                    case "3":
                        //Instructions();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using CyberDragons! Goodbye.");
                        System.Threading.Thread.Sleep(1000);
                        keepThinking = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        System.Threading.Thread.Sleep(500);
                        break;
                }
            }
        }

        public static Dragon CreateDragon()
        {
            Console.Clear();
            string age = PickDragonAge();
            string color = PickDragonColor();
            Console.WriteLine("What would you like to name this dragon?");
            string name = Console.ReadLine();

            Dragon myDragon = new Dragon(age, color);
            ListOfDragons.Add(myDragon);
            myDragon.SetName(name);
            return myDragon;
            
        }
        public static string PickDragonAge()
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.WriteLine("What age is your dragon?");
                Console.WriteLine("1. Wyrmling");
                Console.WriteLine("2. Young");
                Console.WriteLine("3. Adult");
                Console.WriteLine("4. Ancient.");
                string ageChoice = Console.ReadLine().ToLower();
                switch (ageChoice)
                {
                    case "1":
                        string age = "wyrmling";
                        keepThinking = false;
                        return age;
                    case "2":
                        age = "young";
                        keepThinking = false;
                        return age;
                    case "3":
                        age = "adult";
                        keepThinking = false;
                        return age;
                    case "4":
                        age = "ancient";
                        keepThinking = false;
                        return age;
                    default:
                        Console.WriteLine("Invalid input!");
                        System.Threading.Thread.Sleep(500);
                        break;
                }
            }

            string errorcode = "Something got fucked.";
            return errorcode;
        }
        public static string PickDragonColor()
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.WriteLine("What color is your dragon?");
                Console.WriteLine("1. Black");
                Console.WriteLine("2. Blue");
                Console.WriteLine("3. Green");
                Console.WriteLine("4. Red");
                Console.WriteLine("5. White");
                string colorChoice = Console.ReadLine().ToLower();
                switch (colorChoice)
                {
                    case "1":
                        string color = "black";
                        keepThinking = false;
                        return color;
                    case "2":
                        color = "blue";
                        keepThinking = false;
                        return color;
                    case "3":
                        color = "green";
                        keepThinking = false;
                        return color;
                    case "4":
                        color = "red";
                        keepThinking = false;
                        return color;
                    case "5":
                        color = "white";
                        keepThinking = false;
                        return color;
                    default:
                        Console.WriteLine("Invalid input!");
                        System.Threading.Thread.Sleep(500);
                        break;
                }
            }

            string errorcode = "Something got fucked.";
            return errorcode;
        }

        public static void ShowDragonStats()
        {
            int index = 1;
            foreach (Dragon dragon in ListOfDragons)
            {
                Console.WriteLine($"{index}. {dragon.GetName()}, {dragon.GetAge()} {dragon.GetColor()} dragon.");
                index++;
            }

            Console.WriteLine("Which dragon would you like to see?");
            int Selected = Convert.ToInt32(Console.ReadLine());

            Dragon selectedDragon = ListOfDragons[Selected - 1];

            selectedDragon.ViewStats();

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadLine();
        }
    }
}
