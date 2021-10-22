using System;
using System.Collections.Generic;
using System.Linq;

public class List2
{
    class Form
    {
        public int data1 { get; set; }
        public string data2 { get; set; }
        //コンストラクタ
        public Form(int data1, string data2)
        {
            this.data1 = data1;
            this.data2 = data2;
        }
    }

    public void Start()
    {
        var list = new List<Form>();

        string[] input = { "160 ともやす", "150 おいたん", "170 おにゃん", "155 ぶーたん" };

        foreach (string e in input)
        {
            string[] temp = e.Split(' ');
            list.Add(new Form(int.Parse(temp[0]), temp[1]));

        }

        foreach (Form e in list)
        {
            Console.WriteLine(e.data1 + e.data2);
        }
        Console.ReadLine();

        list = list.OrderBy(n => n.data1).ThenBy(n => n.data2).ToList();

        foreach (Form e in list)
        {
            Console.WriteLine(e.data1 + e.data2);
        }
    }
}