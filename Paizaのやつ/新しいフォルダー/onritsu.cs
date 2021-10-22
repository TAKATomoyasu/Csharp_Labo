using System;

	public class Onritsu {
		public void Start () {
			float[] twelveScale = new float[12];
			for (int i = 0; i < 12; i++) {
				twelveScale[i] = i * 100;
				// -200 100 0 100...
			}
			float[] actualScale = new float[12];
			// actualScale[0] が Dだよ！
			// actualScale[10] が C
			// actualScale[11] がC#;
			string[] key = { "D", "Es", "E", "F", "Fis", "G", "Gis", "A", "B", "H", "C", "Cis" };

			Console.WriteLine ("特殊平均律プログラム（セント値表示）\r\n分割数を入力してね");
			float divide = int.Parse (Console.ReadLine ());
			float[] newScale = new float[(int) divide + 1];
			float d = 1200 / divide;
			for (int i = 0; i < newScale.Length; i++) {
				newScale[i] = d * i;
				//Console.WriteLine(i + " " + newScale[i]);
			}

			int j = 0;
			for (int i = 0; i < 12; i++) {
				if (Math.Abs (newScale[j] - twelveScale[i]) > d / 2) {
					j++;
				}
				actualScale[i] = newScale[j] - twelveScale[i];
			}

			Console.WriteLine (key[10] + " " + actualScale[10]);
			Console.WriteLine (key[11] + " " + actualScale[11]);
			for (int i = 0; i < 10; i++) {
				Console.WriteLine (key[i] + " " + actualScale[i]);
			}
		}
	}
