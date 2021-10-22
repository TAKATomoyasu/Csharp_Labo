using System;
using System.Collections.Generic;

public class League
{
    public void Start()
    {
        var loop = int.Parse(Console.ReadLine());
        string[, ] match = new string[loop, loop];
        for (int i = 0; i < loop * (loop - 1) / 2; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]) - 1;
            int b = int.Parse(input[1]) - 1;
            if (a != b)
            {
                match[a, b] = "W";
                match[b, a] = "L";
            }
        }
        for (int i = 0; i < loop; i++)
        {
            string output = "";
            for (int j = 0; j < loop; j++)
            {
                if (i == j) match[i, j] = "-";
                output += match[i, j] + " ";
            }
            Console.WriteLine(output.Trim());
        }
    }
}