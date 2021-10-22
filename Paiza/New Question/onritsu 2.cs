using System;

public class Onritsu2 {
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
		string[] pccs = { "pR", "R", "yR", "rO", "O", "yO", "rY", "Y", "gY", "YG", "yG", "G", "bG", "BG", "BG", "gB", "B", "B", "pB", "V", "bP", "P", "rP", "RP" };
		//16800 / divide = 半音のpccs値;
		//pccs値あ16800か、168か？

		Console.WriteLine ("特殊平均律プログラム（セント値表示）\r\n分割数を入力してね");
		float divide = int.Parse (Console.ReadLine ());
		float[] newScale = new float[(int) divide];
		float[] pccsScale = new float[(int) divide];
		float d = 1200 / divide;
		float dPccs = 16800 / divide;
		for (int i = 0; i < newScale.Length; i++) {
			newScale[i] = d * (float) i;
			//Console.WriteLine(i + " " + newScale[i]);
			pccsScale[i] = dPccs * (float) i;
		}

		for (int i = 0; i < 12; i++) {
			int im = (i + 10) % 12;
			Console.WriteLine (key[im]);
			for (int j = 0; j < newScale.Length; j++) {
				int jm = (j + newScale.Length - newScale.Length / 12 / 2) % newScale.Length;
				//Console.WriteLine(i * 100 - 50 + " , " + i + 100 + 50);

				if (1200 - 50 <= newScale[jm] && im == 0) {
					Console.WriteLine ("  " + (jm + 1) + " : " + (newScale[jm] - 1200).ToString ("0.00"));
				}
				if (im * 100 - 50 <= newScale[jm] && newScale[jm] < im * 100 + 50) {
					Console.WriteLine ("  " + (jm + 1) + " : " + (newScale[jm] - im * 100).ToString ("0.00"));
				}
			}
		}
	}
}