﻿using System;
using System.Collections.Generic;
using System.Linq;

public class List1
{
	class Form
	{
		public int data1 { get; set; }
		public string data2 { get; set; }
	}

	public void Start()
	{
		var list = new List<Form>();
		Form d;

		string[] input = { "160 ともやす", "150 おいたん", "165 おにゃん", "155 ぶーたん" };

		foreach (string e in input)
		{
			string[] temp = e.Split(' ');
			d = new Form();
			d.data1 = int.Parse(temp[0]);
			d.data2 = temp[1];

			list.Add(d);
		}

		foreach (Form e in list)
		{
			Console.WriteLine(e.data1 + e.data2);
		}
		Console.ReadLine();


		// 並べ替え
		list = list.OrderBy(n => n.data1).ThenBy(n => n.data2).ToList();

		foreach (Form e in list)
		{
			Console.WriteLine(e.data1 + e.data2);
		}
	}
}