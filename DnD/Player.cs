using System;
namespace DnD
{
	public class Player
	{
		public int hitPoints = 100;
		public int armorClass { get; set; }
		public string name { get; set; }
		Random random = new Random();

		public void Fight(Player player1, Player player2)
		{
			do
			{
				//Probably should have used player[i] to reduce code redundancy 
				//player 1 attacking player 2
				if (player2.hitPoints >= 0)
				{
					int roll1 = player1.Roll();
					Console.WriteLine($"{player1.name} rolled a {roll1} to hit {player2.name}");
					if (roll1 >= player2.armorClass)
					{
						roll1 = player1.Roll();
						player2.hitPoints -= roll1;
						Console.WriteLine($"{player1.name} hit {player2.name} for {roll1} damage");
					}
					//player 2 attacking player 1
					if (player1.hitPoints >= 0)
					{
						roll1 = player2.Roll();
						Console.WriteLine($"{player2.name} rolled a {roll1} to hit {player1.name}");
						if (roll1 >= player1.armorClass)
						{
							roll1 = player2.Roll();
							player1.hitPoints -= roll1;
							Console.WriteLine($"{player2.name} hit {player1.name} for {roll1} damage");
						}
					}
				}
			} while (player1.hitPoints >= 0 && player2.hitPoints >= 0);
			if (player1.hitPoints > player2.hitPoints)
            {
				Console.WriteLine($"{player1.name} has defeated {player2.name}");
			}
			else Console.WriteLine($"{player2.name} has defeated {player1.name}");
		}

		private int Roll()
		{
			int roll = random.Next(1, 20);
			return roll;

		}
	}
}


