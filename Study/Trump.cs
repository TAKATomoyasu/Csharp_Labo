//トランプをシャッフルする
using System;
using System.Collections.Generic;
using System.Linq;

public class Trump
{
    public  int card = 10;
    public void Start()
    {

        int[] x = new int[card];
        for (int i = 0; i < card; i++)
        {
            x[i] = i + 1;
        }

        Console.WriteLine(string.Join(",", x));
        Console.ReadLine();

        while (true)
        {
            Mix(x);
            //foreach(int p in x){
            //    Console.WriteLine(p);
            //}

            Console.WriteLine(string.Join(",", x));
            Console.ReadLine();
        }
    }

    private  void Mix(int[] a)
    {
        int[] b = new int[card];
        int i = 0;
        int j = 0;
        while (i < card)
        {
            b[i] = a[j];
            i++;
            b[i] = a[j + card / 2];
            i++;
            j++;
        }
        for (int m = 0; m < card; m++)
        {
            a[m] = b[m];
        }
    }
}