using System;
using System.Collections.Generic;
using System.Linq;

public class Collection 
{
    public void Start()
    {

        //List型
        var team = new List<string>();
        team.Add("First");
        for (int i = 0; i < 3; i++) team.Add(Console.ReadLine());

        List<string> result = team; //他の変数にまるごと代入もできる．実際は，同じインスタンスを参照している

        if (team.Contains("abc"))
        { //要素が存在するかをboolで
            int count = team.Count; // 要素数をカウント
        }
        foreach (string e in team) Console.WriteLine(e);
        Console.WriteLine(team[1]); //変数のように要素番号を指定
        team.RemoveAt(1); //削除（要素番号で）はRemoveAt()
        team.Remove("なんちゃら"); //要素内容で指定
        team.Clear(); //全て破棄


        //Dictionary型…必ずKeyとValueの２つセット
        var dic = new Dictionary<string, string>();

        dic.Add("01", "Miku");
        dic.Add("02", "Lin");
        dic.Add("03", "Len");
        //↓配列みたいに取得できる
        string name = dic["02"];
        //tryも使える
        string name2;
        bool b = dic.TryGetValue("02", out name2);

        foreach (KeyValuePair<string, string> e in dic)
        {
            Console.WriteLine(e);
            Console.WriteLine(e.Key);
            Console.WriteLine(e.Value);
        }


        //Stack型……細い筒に物を入れていき、手前から出す。取り出す感じ
        var s = new Stack<int>();
        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push(4);
        s.Push(5);
        Console.WriteLine(s.Peek()); //Peekでは、手前から1つだけ削除せず確認するだけ
        Console.WriteLine("残り{0}個だよ！", s.Count);
        Console.WriteLine(s.Pop()); //Popは、1つだけ削除して取り出す
        Console.WriteLine("残り{0}個だよ！", s.Count);

        foreach (int e in s) Console.WriteLine(e); //これも後ろから取得していく


        //Queue型……吹き矢のように、ドンドン筒の向こうへ押し出していく感じ
        var q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);

        int first;
        first = q.Dequeue(); // Dequeueは向こう側へ１つ押し出すイメージ
        first = q.Peek(); //確認するだけ


        //Hashset……重複しないようなリスト
        string text =
            "government of the people by the people for the people";

        // HashSetクラスによる単語テーブル
        var hs = new HashSet<string>();
        Console.WriteLine(text + "\r\nこのテキストに出てくる単語を一覧表示する\r\n");

        foreach (string word in text.Split(' '))
        { // Splitを使って、要素ごとを区切ったものをforeachに使える


            // 単語を追加。未登録なら表示
            if (hs.Add(word))
            { // hs.Addは重複がない場合にはtrueを返した上で、リストに追加する
                Console.WriteLine(word);
            }
        }

    }
}