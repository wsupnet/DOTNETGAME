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
		string[, ] weapons1 = new string[3, 2]{{"Torch (it)", "1000"}, {"Freeze (make harder)", "100"}, {"Candle (burn with prayers)", "500"}};
		string[, ] weapons2 = new string[3, 2]{{"Spoon (her)", "1000"}, {"Whip Cream (on it)", "100"}, {"Fork (it)", "500"}};
		string[, ] weapons3 = new string[3, 2]{{"Toothpick (poker face)", "1000"}, {"Vodka (martini)", "100"}, {"Mouth (smash)", "500"}};
		Alien alien1 = new Alien();
		alien1.healthPoints = 1000;
		alien1.strenght = new string[1]{"Freeze (make harder)"};
		alien1.weakness = new string[2]{"Torch (it)", "Candle (burn with prayers)"};
		Alien alien2 = new Alien();
		alien1.healthPoints = 1000;
		alien1.strenght = new string[1]{"Whip Cream (on it)"};
		alien1.weakness = new string[2]{"Spoon (her)", "Fork (it)"};
		Alien alien3 = new Alien();
		alien1.healthPoints = 1000;
		alien1.strenght = new string[1]{"Vodka (martini)"};
		alien1.weakness = new string[2]{"Toothpick (poker face)", "Mouth (smash)"};
		while (alien1.healthPoints > 0 && hero.lives > 0)
		{
			Console.WriteLine("Choice A = {0} , or , Choice B {1} , or , Choice C {2}", weapons1[0, 0], weapons1[1, 0], weapons1[2, 0]);
			string selection = Console.ReadLine();
			int points = 0;
			switch (selection)
			{
				case "A":
					points = Convert.ToInt32(weapons1[0, 1]);
					alien1.healthPoints = alien1.healthPoints - points;
					Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
					Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
					//Inline Condition
					hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives +1;
					Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
					break;
				case "B":
					points = Convert.ToInt32(weapons1[1, 1]);
					alien1.healthPoints = alien1.healthPoints + points;
					Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
					Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
					//Inline Condition
					hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives;
					Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
					break;
				case "C":
					points = Convert.ToInt32(weapons1[1, 1]);
					alien1.healthPoints = alien1.healthPoints - points;
					Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
					Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
					//Inline Condition
					hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives +1;
					Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
					break;
			}
		}
		
		if (alien1.healthPoints <= 0) {
		
			Console.WriteLine("You have melted your friend and you left behind a puddle.");
		} else {
		
		}
	// this doesnt work yet
	// trying to get back to how it was before it all deleted :(
	/*if (selection == "A" ||selection == "B"||selection == "C"){
			Console.WriteLine("Invalid Character Try Again foo.");
			selection = Console.ReadLine();
		}
		else 
		{
			Console.WriteLine("You chose {0} as your choice ",selection);
		}*/
	}

	public static void alienDraw1()
	{
		string alien1 = @"
   _..._
 .'_(.)_'.
/ (.) (.) \
| ,_____. |
\    '-'  /
 '.PATRICK_.' 
 __//   \\__
(___)   (___)";
		Console.WriteLine(alien1);
	}

	public static void alienDraw2()
	{
		string alien2 = @"
   _..._
 .'_(.)_'.
/ (.) (.) \
| ,_____. |
\    '-'  /
 '.GAGA_.' 
 __//   \\__
(___)   (___)";
		Console.WriteLine(alien2);
	}

	public static void alienDraw3()
	{
		string alien2 = @"	
		
      __
  __ {_/ 
  \_}\\ ___  
 /  x   x  \
/, _..(   ).\
| `’’’—__|  |
\   ANNA —  /
 '.        .'
   '-.....-'
";
		Console.WriteLine(alien2);
	}
}

public class Hero
{
	public string heroName
	{
		get;
		set;
	}

	public int lives
	{
		get;
		set;
	}

	public string currentWeapon
	{
		get;
		set;
	}
}

public class Alien
{
	public string alienName
	{
		get;
		set;
	}

	public string[] weakness
	{
		get;
		set;
	}

	public string[] strenght
	{
		get;
		set;
	}

	public int healthPoints
	{
		get;
		set;
	}
}

public class Weapons
{
	string[, ] weapons1 = new string[3, 2]{{"Spoon (her)", "9000"}, {"Whip Cream (on it)", "1"}, {"Fork (it)", "25"}};
	string[, ] weapons2 = new string[3, 2]{{"Torch (it)", "9000"}, {"Freeze (make harder)", "1"}, {"Candle (burn with prayers)", "5"}};
	string[, ] weapons3 = new string[3, 2]{{"Toothpick (poker face)", "9000"}, {"Vodka (martini)", "1"}, {"Mouth (smash)", "15"}};
}

}
