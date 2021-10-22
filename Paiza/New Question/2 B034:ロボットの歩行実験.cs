//三角関数を使ってプログラムを３分の２程度い小さくしたもの！！
using System;
public class Robot {
	public void Start () {
		string[] xy = Console.ReadLine ().Split (' ');
		double x = int.Parse (xy[0]);
		double y = int.Parse (xy[1]);
		string[] stepUnit = Console.ReadLine ().Split (' ');
		int Fs = int.Parse (stepUnit[0]);
		int Rs = int.Parse (stepUnit[1]);
		int Bs = int.Parse (stepUnit[2]);
		int Ls = int.Parse (stepUnit[3]);
		int loop = int.Parse (Console.ReadLine ());
		int moveAngle = 0;
		int angle = 90;
		int step = 1;
		for (int i = 0; i < loop; i++) {
			string[] command = Console.ReadLine ().Split (' ');
			string move = command[0];
			string dir = command[1];
			switch (dir) {
				case "F":
					moveAngle = 0;
					step = Fs;
					break;
				case "L":
					moveAngle = 90;
					step = Ls;
					break;
				case "B":
					moveAngle = 180;
					step = Bs;
					break;
				case "R":
					moveAngle = 270;
					step = Rs;
					break;
			}
			if (move == "t") {
				angle += moveAngle;
			} else if (move == "m") {
				y += Math.Sin ((moveAngle + angle) * Math.PI / 180) * step;
				x += Math.Cos ((moveAngle + angle) * Math.PI / 180) * step;
			}
		}
		Console.WriteLine (x + " " + y);
	}
}