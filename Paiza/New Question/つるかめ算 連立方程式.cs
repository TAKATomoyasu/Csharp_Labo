using System;
public class TsuruKame2 {

	public void Start () {
		Random r = new Random ();
		string random = r.Next (10, 20) + " " + r.Next (10) + " " + r.Next (3) + " " + r.Next (5);
		string[] line2 = random.Split (' ');
		//↑ 本来は 
		//string [] line2 = Console.ReadLine().Split(' ');

		int legs = int.Parse (line2[0]);
		int heads = int.Parse (line2[1]);
		int xLegs = int.Parse (line2[2]);
		int yLegs = int.Parse (line2[3]);
		int x = 0;
		int y = 0;
		
        //連立方程式
        //y = heads - x …(1)
        //x * xLegs + y * yLegs = legs …(2)
        //(2)に(1)を代入して
        //→x * xLegs + (heads - x) * yLegs = legs
        //→x ( xLegs - yLegs) = legs - heads * yLegs
        if (xLegs != yLegs) {
			x = (legs - heads * yLegs) / (xLegs - yLegs);            
			y = heads - x;            
        }else {
            Start();
            return;
        }

        if (x <= 0 || y <= 0) {
            //失敗
            Start();
        } else if (x.ToString ("0.0").Substring (x.ToString ("0.0").Length - 1, 1) != "0") {
            //失敗
            Start();
        } else {
            Console.WriteLine("問題です！\r\n全部で足の数が{0}本、頭の数が{1}本あります。\r\nガメーヌの足の数は{2}本、ツルリーヌの足の数は{3}本です。\r\nさて、ガメーヌとツルリーヌはそれぞれ何匹ずついるでしょう？", legs, heads, xLegs, yLegs);
            Console.WriteLine (x + " " + y);
		}
		Console.ReadLine ();		
	}
}