using System;

namespace Game
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("One day you are at your desk working on some code.");
            Console.WriteLine("You decide to take a break to get a quick snack.");
            Console.WriteLine("As you walk into the kitchen the light go out !");
            Console.WriteLine("Then you hear a hissing sound coming from the refrigerator.");
            Hero hero = new Hero();
            Console.WriteLine("What is your name human!");
            hero.heroName = Console.ReadLine();
            Console.WriteLine("Think quick what are you going to do {0}???", hero.heroName);
            Console.WriteLine("You are very afraid and tired from computing all night");
            hero.lives = 3;
            Console.WriteLine("You remember that you only have {0} lives in you.", hero.lives);
            Console.WriteLine("A wild Patrick Appears");
            alienDraw1();
            Console.WriteLine("you look around and see 3 things you can use as a weapon");
            Console.WriteLine("which weapon do you want to pick?");

            Weapons weapon = new Weapons();

            string[,] weapons1 = new string[3, 2] { { "Spoon (her)", "9000" }, { "Whip Cream (on it)", "1" }, { "Fork (it)", "25" } };
            string[,] weapons2 = new string[3, 2] { { "Torch (it)", "9000" }, { "Freeze (make harder)", "1" }, { "Candle (burn with prayers)", "5" } };
            string[,] weapons3 = new string[3, 2] { { "Toothpick (poker face)", "9000" }, { "Vodka (martini)", "1" }, { "Mouth (smash)", "15" } };

            Console.WriteLine("Choice A = {0} , or , Choice B {1} , or , Choice C {2}", weapons1[0, 0], weapons1[1, 0], weapons1[2, 0]);
            string selection = Console.ReadLine();


            // this doesnt work yet

            // trying to get back to how it was before it all deleted :(


            if (selection == "A" || selection == "B" || selection == "C")
            {
                Console.WriteLine("Invalid Character Try Again foo.");

                selection = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You chose {0} as your choice ", selection);


            }


        }

        public static void alienDraw1()
        {
            string alien1 = @"
   _..._
 .'_(.)_'.
/ (.) (.) \
| ,_____. |
\    '-'  /
 '.GAGA_.' 
 __//   \\__
(___)   (___)";
            Console.WriteLine(alien1);
        }

        public static void alienDraw2()
        {
        }

        public static void alienDraw3()
        {
        }


    }

    public class Hero
    {
        public string heroName
        {
            get;
            set;
        }

        public int lives;
        public string currentWeapon;
    }

    public class Alien
    {
        public string alienName;
        public string weakness;
        public string strenght;
        public string healthPoints;
    }

    public class Weapons
    {
        string[,] weapons1 = new string[3, 2] { { "Spoon (her)", "9000" }, { "Whip Cream (on it)", "1" }, { "Fork (it)", "25" } };
        string[,] weapons2 = new string[3, 2] { { "Torch (it)", "9000" }, { "Freeze (make harder)", "1" }, { "Candle (burn with prayers)", "5" } };
        string[,] weapons3 = new string[3, 2] { { "Toothpick (poker face)", "9000" }, { "Vodka (martini)", "1" }, { "Mouth (smash)", "15" } };
    }

}
