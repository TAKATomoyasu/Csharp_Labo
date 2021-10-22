using System;
using System.Collections.Generic;

public class ListSort {

    public void Start () {

        List<string> takake = new List<string> ();

        takake.Add ("Asumi");
        takake.Add ("Marina");
        takake.Add ("haruna");
        takake.Add ("tobikun");

        takake[1] += "abc";

        //takake.Remove("Asumi");
        //takake.RemoveAt(1);
        takake.Sort ();

        foreach (string a in takake) {
            Console.WriteLine (a);
        }

        /*

        public static void kaku(string a){
                Console.WriteLine(a);
            }

        public static void kaku(int a){
                Console.WriteLine(a);
            }


            string output = "";
            output += "| ";


            kaku(13);


            */

        /*
        int[,] board = new int[8,8];
        int[,] d = { { -1, -1 }, { 0, -1 }, { 1, -1 }, { -1, 0 }, { 1, 0 }, { -1, 1 }, { 0, 1 }, { 1, 1 } };

        foreach(int i in d){
            Console.WriteLine(i);
            //Console.WriteLine(i);
            
        }
        */
    }
}