
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


		List<int> lottoticket = new List<int> {};

		foreach (int i in lottoticket)
		{
		  Console.WriteLine(i);
		}
		 
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

