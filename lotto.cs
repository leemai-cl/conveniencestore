
using System;
using System.Collections.Generic;

namespace convenience_store
{
class Lotto
{
	public void runLotto(string[] args)
	{
		//instantiate random object 
		Random rand;
		rand = new Random();

		int lottonum1 = rand.Next(1, 4);
		int lottonum2 = rand.Next(1, 4);
		int lottonum3 = rand.Next(1, 4);
		int lottonum4 = rand.Next(1, 4);

		List<int> lottoticket = new List<int> { lottonum1, lottonum2, lottonum3, lottonum4 };

		foreach (int i in lottoticket)
		{
		  Console.WriteLine(i);
		}
		Console.ReadLine();  
		for (int i=0; i<5; i++)
			{
				Console.ReadLine();
				int scratchnum = rand.Next(1, 10);
				if (scratchnum == 7)
				{
					Console.WriteLine("winner");
				}
				else
				{
					Console.WriteLine("try again");
				}
			}
		 
	}
}
}
