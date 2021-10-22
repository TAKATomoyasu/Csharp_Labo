using System;
using System.Collections.Generic;
using System.Linq;

public class Height 
{
    public void Start()
    {
        var list = new Dictionary<int, string>();

        string[] input = { "160 ともやす", "150 おいたん", "170 おにゃん", "155 ぶーたん" };

        foreach (string e in input)
        {
            string[] temp = e.Split(' ');
            list.Add(int.Parse(temp[0]), temp[1]);
        }

        foreach (KeyValuePair<int, string> e in list)
        {
            Console.WriteLine(e.Key + e.Value);
        }
        Console.ReadLine();

        var result = list.OrderBy(x => x.Key).ToArray(); //ToListにしても大丈夫

        foreach (KeyValuePair<int, string> e in result)
        {
            Console.WriteLine(e.Key + e.Value);
        }
    }
}