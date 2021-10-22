using System;
public class Table {
	public void Start () {
		int columnN = int.Parse (Console.ReadLine ());
		string[] columnName = Console.ReadLine ().Split (' ');
		int rowN = int.Parse (Console.ReadLine ()) + 1; // 2行目の分

		int[] columnW = new int[columnN];
		string[, ] table = new string[rowN, columnN];
		string output = "";
		for (int j = 0; j < columnN; j++) {
			table[0, j] = columnName[j];
			if (columnW[j] < table[0, j].Length) {
				columnW[j] = table[0, j].Length;
			}
		}

		for (int i = 2; i < rowN; i++) {
			string[] row = Console.ReadLine ().Split (' ');
			for (int j = 0; j < columnN; j++) {
				table[i, j] = row[j];
				if (columnW[j] < row[j].Length) {
					columnW[j] = row[j].Length;
				}
				//    Console.WriteLine(columnW[j] + " " + row[j].Length);
			}
		}
		for (int i = 0; i < rowN + 1; i++) {
			output = "";

			for (int j = 0; j < columnN; j++) {
				if (i == 1) {
					output += "|" + new string ('-', columnW[j] + 2);
				} else {
					output += "| " + table[i, j];
					//Console.WriteLine(output + "," + columnW[j] + "," + output.Length);
					output += new string (' ', columnW[j] - table[i, j].Length + 1);
				}
			}
			output += "|";
			Console.WriteLine (output);
		}
	}
}