using System;
public class TsuruKame
{
	public  void Start()
	{
		Random r = new Random();
		string random = r.Next(10, 20) + " " + r.Next(10) + " " + r.Next(3) + " " + r.Next(5);
		string[] line2 = random.Split(' ');
		//↑ 本来は 
		//string [] line2 = Console.ReadLine().Split(' ');

		double amount = double.Parse(line2[0]);
		double head = double.Parse(line2[1]);
		double xLegs = double.Parse(line2[2]);
		double yLegs = double.Parse(line2[3]);

        Console.WriteLine("問題です！\r\n全部で足の数が{0}本、頭の数が{1}本あります。\r\nガメーヌの足の数は{2}本、ツルリーヌの足の数は{3}本です。\r\nさて、ガメーヌとツルリーヌはそれぞれ何匹ずついるでしょう？", amount, head, xLegs, yLegs);

		double answer = -1;
		for (int i = 0; i < head; i++)
		{
			if (i * xLegs + (head - i) * yLegs == amount)
			{
				if (0 <= answer)
				{
					answer = -1; break;
				}
				answer = i;
			}
		}
        if (answer == -1) Console.WriteLine("miss");
        else
        {
            Console.WriteLine(answer + " " + (head - answer));
        }


		Console.ReadLine();		

	}
}