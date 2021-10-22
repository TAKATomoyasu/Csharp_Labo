using System;
using System.Collections.Generic;
using System.Linq;

public class Medal
{
	class Form
	{
		public int data1 { get; set; }
		public int data2 { get; set; }
		public int data3 { get; set; }
		//コンストラクタ
		public Form(int data1, int data2, int data3)
		{
			this.data1 = data1;
			this.data2 = data2;
			this.data3 = data3;
		}
	}

	public void Start()
	{
		var list = new List<Form>();

		int loop = int.Parse(Console.ReadLine());

		for (int i = 0; i < loop; i++)
		{
			string[] temp = Console.ReadLine().Split(' ');
			list.Add(new Form(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2])));

		}

		list = list.OrderBy(n => n.data1).ThenBy(n => n.data2).ThenBy(n => n.data3).ToList();
		list.Reverse();
		foreach (Form e in list)
		{
			Console.WriteLine("{0} {1} {2}", e.data1, e.data2, e.data3);
		}
	}
}