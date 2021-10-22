using System;
public class Change {
	public void Start () {
		Random r = new Random ();
		int cost = r.Next (1000, 10000);
		Console.WriteLine ("{0}円になります", cost);
		int pay = 0;
		do {
			Console.WriteLine ("支払い金額を数値で入力してね");
			pay = int.Parse (Console.ReadLine ());
			if (cost > pay) {
				Console.WriteLine ("足りねぇぞオッラーン!!");
			} else {
				break;
			}
		}
		while (cost > pay);

		int money = pay - cost;
		Console.WriteLine ("{0}円のおつりです", money);
		int change = 0;
		int[] billscoins = { 10000, 5000, 1000, 500, 100, 50, 10, 5, 1 };

		foreach (int b in billscoins) {
			change = money / b;
			money -= change * b;
			if (0 < change) {
				if (1000 <= b) {
					Console.WriteLine ("{0}円札が{1}枚", b, change);
				} else {
					Console.WriteLine ("{0}円玉が{1}枚", b, change);
				}

			}
		}
	}
}