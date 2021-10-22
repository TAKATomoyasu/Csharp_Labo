using System;
public class Something {
    public void Start () {
        while (true) {

            string[] line2 = Console.ReadLine ().Split (' ');
            int k = int.Parse (line2[0]);
            int s = int.Parse (line2[0]);
            int t = int.Parse (line2[0]);

            string result = "";
            for (int i = 0; i < k; i++) {
                result = "a" + result.ToUpper () + "b" + result.ToUpper () + "c";
            }

            Console.WriteLine (result);
            //Console.WriteLine(result.Substring(s - 1, t - s + 1));
            //Console.WriteLine(result.Length);
        }
    }
}