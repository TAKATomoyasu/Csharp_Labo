using System;
using System.Collections.Generic;

public class ListSort
{

    public void Start()
    {

        List<string> takake = new List<string>();

        takake.Add("Asumi");
        takake.Add("Marina");
        takake.Add("haruna");
        takake.Add("tobikun");

        takake[1] += "abc";

        takake.Sort();

        foreach (string a in takake)
        {
            Console.WriteLine(a);
        }
    }
}