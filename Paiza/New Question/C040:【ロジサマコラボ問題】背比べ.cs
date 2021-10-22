using System;
public class Rojisama
{
	public void Start()
	{
		int loop = int.Parse(Console.ReadLine());
		//string line = Console.ReadLine();
		//string[] line2 = Console.ReadLine().Split(' ');
		//int x = line2[0];
		//int y = line2[1];
		for (int i = 0; i < loop; i++)
		{
			string[] line3 = Console.ReadLine().Split(' ');
			string a = line3[0];
			//double b = line3[1];

			if (a == "le")
			{
				//if (b < min) min = b;
			}
			if (a == "ge")
			{
				//if (max < max) max = b;
			}
		}

		//Console.WriteLine (min.ToString (0.0) + " " + max.ToString (0.0));

	}
}