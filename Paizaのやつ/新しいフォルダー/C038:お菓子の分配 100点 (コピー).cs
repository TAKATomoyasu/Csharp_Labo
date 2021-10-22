/*
コメントアウトしてるところを有効にして、ReadLineをコメントアウトすると、乱数で動くよ

*/

using System;
public class Snack {
	public void Start () {
		// 自分の得意な言語で
		// Let's チャレンジ！！

		Random r = new Random ();

		string[] line = System.Console.ReadLine ().Split (' ');
		int loop = int.Parse (line[0]);
		int candy = int.Parse (line[1]);

		//乱数で設定
		//loop = 10;
		//candy = r.Next(loop,100);

		int bestRest = candy;
		int bestPack = -1;
		int bestCase = -1;

		//System.Console.WriteLine(loop + " " + candy + "\r\n");

		for (int i = 0; i < loop; i++) {
			int pack = int.Parse (System.Console.ReadLine ());
			//pack = r.Next(1, candy + 1);
			if (candy % pack < bestRest) {
				bestRest = candy % pack;
				bestPack = pack;
				bestCase = i + 1;
				//System.Console.WriteLine(pack + "..." + candy % pack + "☆");
			} else if (candy % pack == bestRest) {
				if (bestPack <= pack) {
					bestRest = candy % pack;
					bestPack = pack;
					bestCase = i + 1;
					//System.Console.WriteLine(pack + "..." + candy % pack + "★");
				} else {
					//System.Console.WriteLine(pack + "..." + candy % pack);
				}

			} else {
				//System.Console.WriteLine(pack + "..." + candy % pack);
			}
		}
		//System.Console.WriteLine("");
		System.Console.WriteLine (bestCase);
	}
}