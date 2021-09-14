using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Reality_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the fantastic world of Reality!");
			Console.WriteLine("Please do not abandon now, we promise it will not be as bad!");

			Console.WriteLine("Tell us your name"); // Chosing the name
			string charName = Console.ReadLine();
			Console.WriteLine("Okay so your name is " + charName);
			Console.WriteLine(""); //creat space

			Console.WriteLine("Are you \"teen\", \"adult\" or \"old\""); //Chosing the age and stats, the stats are not supposed to be displayed to the player

			//Give your variables an initial value or you'll have problems changing the values inside if/else statements and saving them to modify later
			int hp = 0;
			int energy = 0;
			int money = 0;
			int str = 0;
			int joy = 0;

			/*Variable used to count the days you survided in-game, later will be used to limit the play to 3 activities per day
			* this needs more work*/
			int day = 0;

			Random dice = new Random(); //Used to mimic a dice roll, increasing a decreasing some the variables 

			bool dec = true; //bool variable is used to get out of the while or keep it running


			while (dec)
			{
				string ageInp = Console.ReadLine();
				string age = ageInp.ToLower();

				switch (age)
				{
					case "teen":

						Console.WriteLine("You have just picked up your stats and cannot change them. Good luck!");

						hp = 10;
						energy = 15;
						money = 4;
						str = 5;
						joy = 15;

						Console.WriteLine("Your health is: " + hp);
						Console.WriteLine("Your energy is: " + energy);
						Console.WriteLine("Your money is: " + money);
						Console.WriteLine("Your strength is: " + str);
						Console.WriteLine("Your joy is: " + joy);

						dec = false; //dec = false makes you jump out of the while
						break;


					case "adult":

						Console.WriteLine("You have just picked up your stats and cannot change them. Good luck!");

						hp = 15;
						energy = 7;
						money = 5;
						str = 10;
						joy = 9;

						Console.WriteLine("Your health is: " + hp);
						Console.WriteLine("Your energy is: " + energy);
						Console.WriteLine("Your money is: " + money);
						Console.WriteLine("Your strength is: " + str);
						Console.WriteLine("Your joy is: " + joy);

						dec = false; //dec = false makes you jump out of the while
						break;


					case "old":

						Console.WriteLine("By the gods why would you want to be old? It is what it is now...Best of luck!");

						hp = 5;
						energy = 3;
						money = 15;
						str = 4;
						joy = 5;

						Console.WriteLine("Your health is: " + hp);
						Console.WriteLine("Your energy is: " + energy);
						Console.WriteLine("Your money is: " + money);
						Console.WriteLine("Your strength is: " + str);
						Console.WriteLine("Your joy is: " + joy);

						dec = false; //dec = false makes you jump out of the while
						break;


					default:

						Console.WriteLine("Please try again, unless you can't read and then i don't even know did you get this far!");
						break;
				}

			}

			Console.WriteLine(""); //creat space

			day = day + 1;
			Console.WriteLine("Day number #" + day);
			Console.WriteLine("Since you just got into the game and your head is kinda confused with what is going on,");
			Console.WriteLine("you may want to go drink a coffee to cheer your spirits");
			Console.WriteLine("You want to have a coffee? Type \"Yay\" or \"Nay\"");

			dec = true; //Reset before using for another while cicle

			while (dec)
			{
				string decisionYNinp = Console.ReadLine();
				string decisionYN = decisionYNinp.ToLower();

				if (decisionYN == "yay")
				{
					Console.WriteLine("You have just been introduced to a game meachnic in the most clichê way there is!");
					Console.WriteLine("Drinking coffee will always cost you 1 money and replenishes some energy...some...");
					Console.WriteLine("As they say...MAY THE ODDS BE EVER IN YOUR FAVOR!");

					money = money - 1;
					energy = energy + dice.Next(1, 7);

					Console.WriteLine("Your money now is: " + money);
					Console.WriteLine("In RNGesus we trust and your energy is: " + energy);
					Console.WriteLine("Now that we had that coffee...");
					dec = false;
				}

				else if (decisionYN == "nay")
				{
					Console.WriteLine("It looks like you're not a coffee person.");
					Console.WriteLine("Maybe in the future you'll think about what you're missing out!");
					Console.WriteLine("Oh well! Anyways...");
					dec = false;
				}

				else
				{
					Console.WriteLine("I am really hopping you'll learn how to write");
				}
			}

			Console.WriteLine(""); //creat space
			Console.WriteLine("What are we doing here you might ask. Not even me your dear narrator really knows!");
			Console.WriteLine("But has something to deal with work. Like what you should be doing right now!");
			Console.WriteLine("*You head-out to work*");
			Console.WriteLine("There you are working like a machine, nothing compares to your efficiency!");
			Console.WriteLine("And your boss shows up and asks \"What are you doing? Are you kidding...\"");
			Console.WriteLine("Your thoughts drift away you don't even understand what he said...but how do you respond? (type the number)");
			Console.WriteLine("a - Chicken out and say \"I'm doing my best sir I promise!\"");
			Console.WriteLine("b - Calmely answer \"Sir I already told you that if you want this project to succeed you have to give me time!\" and try your luck");
			Console.WriteLine("c - The funny one \"Guess you like blood in your coffee but it won't be mine!\"");

			dec = true;

			while (dec)
			{
				string bossFightinp = Console.ReadLine();
				string bossFight = bossFightinp.ToLower();
				//variable used to chose how will the battle happen: loss, try to escape, fight.

				switch (bossFight)
				{
					case "a":

						Console.WriteLine("Your boss took advantage of your weakness and pounced on you like a famished lion!");
						hp = hp - dice.Next(1, 7);
						if (hp <= 0)
						{
							Console.WriteLine("Your health reached 0 pretty fast!");
							Console.WriteLine("I told RNGesus wasn't always on your side didn't I?");
							Console.WriteLine("How could you lose to the first boss?! Man you suck!");
							break;
						}
						else
						{
							Console.WriteLine("You endured it! You survived another day!");
							Console.WriteLine("But you lost some health. Your health is now: " + hp);
							dec = false;
						}
						break;

					case "b":

						Console.WriteLine("Your boss was not very happy with your answer. RNGesus will decide your fate!");
						if (dice.Next(1, 7) >= 3)
						{
							Console.WriteLine("But as you said you're a machine and he respected you.");
							Console.WriteLine("Still...as he goes he shouts \"Next time you might not be this lucky!\"");
							dec = false;
						}
						else
						{
							Console.WriteLine("He didn't buy it and kept at it!");
							hp = hp - dice.Next(1, 7);

							if (hp <= 0)
							{
								Console.WriteLine("Your health reached 0 pretty fast!");
								Console.WriteLine("I told RNGesus wasn't always on your side didn't I?");
								Console.WriteLine("How could you lose to the first boss?! Man you suck!");
								break;
							}
							else
							{
								Console.WriteLine("You really thought you were that smart?!");
								Console.WriteLine("Look at your health now: " + hp + ". Good job dumbass at least you survived!");
								dec = false;
							}
						}
						break;

					case "c":

						Console.WriteLine("Well you wanted blood didnt you?");
						Console.WriteLine("The base strength of the boss is 5. A dice will be rolled for you and the boss.");
						Console.WriteLine("The result of the first roll will be added to the boss strength.");
						Console.WriteLine("The result of the second roll will be added to yours, you'll not keep it.");
						Console.WriteLine("The one with the bigger value wins...if you lose you'll take damage based on the difference of strengths");
						Console.WriteLine("What am I doing...a narrator explaing basica in-game mechanics...boooring!");

						int bossStr = 5 + dice.Next(1, 7);
						int newStr = str + dice.Next(1, 7);

						if (newStr > bossStr)
						{
							Console.WriteLine("Your strength is: " + newStr);
							Console.WriteLine("Boss' strength is: " + bossStr);
							Console.WriteLine("Your arguments were great! Someof them may even be recorded in the histoty books!");
							Console.WriteLine("You beat him fair a square! Well done!");
							dec = false;
						}
						else if (newStr == bossStr)
						{
							Console.WriteLine("Your strength is: " + newStr);
							Console.WriteLine("Boss' strength is: " + bossStr);
							Console.WriteLine("You almost fell for him...but out of a sudden a pretty solid comeback!");
							Console.WriteLine("You barely did it but he left you alone! Well done!");
							dec = false;
						}
						else
						{
							if (hp <= (bossStr - newStr))
							{
								Console.WriteLine("Your strength is: " + newStr);
								Console.WriteLine("Boss' strength is: " + bossStr);
								Console.WriteLine("Your health reached 0 pretty fast!");
								Console.WriteLine("I told RNGesus wasn't always on your side didn't I?");
								Console.WriteLine("How could you lose to the first boss?! Man you suck!");
								break;
							}
							else
							{
								hp = hp - (bossStr - newStr); //Health lost

								Console.WriteLine("Your strength is: " + newStr);
								Console.WriteLine("Boss' strength is: " + bossStr);
								Console.WriteLine("That is what you get for trying out your odds.");
								Console.WriteLine("I mean you're just an employee and you're lucky he didn't reap your head off!");
								Console.WriteLine("Look at what you did to yourself. Health: " + hp);
								dec = false;
							}
						}
						break;

					default:

						Console.WriteLine("Chose a, b or c...This isn't rocket science!");
						break;
				}
			}

			money = money + 10;
			Console.WriteLine("You survived your day at work and got 10 money. You money is now: " + money);
			Console.WriteLine("I bet this were the toughest 30 seconds of your life");
			Console.WriteLine("I mean IRL...in-game you just got really tired after this day of work, went home and");
			Console.WriteLine("got some instant noodles and crashed on your bed, thinking about quiting this job yadda yadda!");

			day = day + 1;
			Console.WriteLine(""); //creat space
			Console.WriteLine("Day number #" + day);
			Console.WriteLine("You made it! \"A WINNER IS YOU!\" ");
			Console.WriteLine("Nop I was just playing this was you...dreaming but this game is far from over!");
			Console.WriteLine("You start listening to an annoying sound in the background...beep...beep...");
			Console.WriteLine("That gets louder and louder. Its your alarm clock! Who would've guessed!");
			Console.WriteLine("Aunt May yells: \"" + charName + "breakfast is ready! Hurry!\"");
			Console.WriteLine("Just kidding! You didn't mix your DNA with a spider (only with regret for starting this)");
			Console.WriteLine("You are barely awake a ear someone knock on your door.");
			Console.WriteLine("Its your landlord...a stinky ugly bugger...screaming at your door: \"PAY THE RENT YOU LAZY DONKEY!\"");
			Console.WriteLine("He didn't really say \"donkey\" but I couldn't write it here.");
			Console.WriteLine("Anyway... what will you do:");
			Console.WriteLine("a - Open the door and pay your rent. (It costs 9 money)");
			Console.WriteLine("b - Jump out of the window, but remember you're no spider-something.");
			Console.WriteLine("c - Kick the door on his face and tell him you'll only pay when he stops doing this scenes.");

			dec = true;

			while (dec)
			{

				string bossFightinp = Console.ReadLine();
				string bossFight = bossFightinp.ToLower();

				switch (bossFight)
				{
					case "a":

						money = money - 9;
						joy = joy - 2;

						Console.WriteLine("You oppened the door and your nose was filled with his breath!");
						Console.WriteLine("I told you he was stinky didn't I?! And beholding this sight you even lost 2 joy!");
						Console.WriteLine("Your joy is now: " + joy);
						Console.WriteLine("You disguntingly, if this even exists, pay your rent. Your money is now: " + money);
						Console.WriteLine("He leaves you alone and you get back inside to shower and have breakfast.");

						dec = false;
						break;

					case "b":

						hp = hp - 2;

						Console.WriteLine("You took a quick shower, got dressed, grabbed some fruit and jumped out the backdoor window.");
						Console.WriteLine("You twisted your ankle when you landed and lost 2 health!");

						if (hp <= 0)
						{
							Console.WriteLine("Doesn't this remeber you of some game that rhymes with bark and soles! \"YOU DIED\"");
						}
						else
						{
							Console.WriteLine("Wow you are really out of shape, can't even jump out the window properly!");
							Console.WriteLine("Maybe you should hit the gym some of this days...maybe after work.");
							Console.WriteLine("Your health is now: " + hp + " and you head out to work.");
						}

						dec = false;
						break;

					case "c":

						int bossStr = 6 + dice.Next(1, 7);
						int newStr = str + dice.Next(1, 7);

						Console.WriteLine("You chose violence with a stinky guy...why would you do that?");
						Console.WriteLine("Its too late now and I will not explain how this works!");
						Console.WriteLine("Just letting you know that his strength is 6! Good luck!");
						Console.WriteLine(""); //creat space

						if (newStr > bossStr)
						{
							joy = joy + 2;

							Console.WriteLine("You fought valiantly and shook him off! He ran like a little kid!");
							Console.WriteLine("Your strength after the roll was " + newStr + " and the boss strength was " + bossStr);
							Console.WriteLine("You wish that in reality you could roll a dice and not pay your rent!");
							Console.WriteLine("You got back inside flexed in the mirror and got 2 joy for your triumph!");
							Console.WriteLine("Your joy is now: " + joy + " you took a shower, grabbed a bite to eat and went to work.");
							Console.WriteLine("");
							dec = false;
						}
						else if (newStr == bossStr)
						{
							Console.WriteLine("You barely made it, look at this luck! Your strength was " + newStr + ", the boss strength was " + bossStr);
							Console.WriteLine("With this kind of luck RNGesus on your side, you took your shower, ate breakfast and went to work");
							Console.WriteLine("");
							dec = false;
						}
						else
						{
							hp = hp - (bossStr - newStr);
							money = money - 9;

							if (hp <= 0)
							{
								Console.WriteLine("Jesus you should think about not going head to head with people, because you suck at this!");
								Console.WriteLine("Your strength was " + newStr + " and the boss strength was " + bossStr + ".");
								Console.WriteLine("Look go back to the begining LUL!");
							}
							else
							{
								Console.WriteLine("When you try your best but you don't succeed...you just succ!");
								Console.WriteLine("Please don't copyright me, you survided this one but look at this.");
								Console.WriteLine("Your strength was " + newStr + " and the boss strength was " + bossStr + ".");
								Console.WriteLine("Your health is now at the fantastic value of " + hp + ".");
								Console.WriteLine("Remember that you lost your fight...and had to pay your rent.");
								Console.WriteLine("Your money is now " + money + ". What a...smart guy you are...");
								dec = false;
							}
						}

						break;

					default:
						Console.WriteLine("We may have been through this before...you just need to type a, b or c.");
						break;
				}
			}



		}
	}
}
