// vscode では，⌘ return で実行． [dotnet run]が呼び出される．（tasks.jsonを書き換えた）
// ⌘ delete で中止．

using System;
using System.Linq;

public class ProgramSelector
{
    public ProgramSelector()
    {

        var skillTypes = System.Reflection.Assembly
            .GetAssembly(typeof(IStartable))
            .GetTypes()
            .Where(c =>
                c.GetInterfaces().Any(t => t == typeof(IStartable))
            ).ToArray();


        int index = 0;
        bool flag = true;
        while (flag)
        {
            Console.Clear();
            Console.WriteLine("↑↓で移動，Returnで決定");
            Console.WriteLine();
            for (int i = 0; i < skillTypes.Length; i++)
            {
                var text = "";
                if (i == index)
                    text = ">" + skillTypes[i].Name;
                else
                    text = " " + skillTypes[i].Name;
                Console.WriteLine(text);
            }
            var k = Console.ReadKey().Key;
            switch (k)
            {
                case ConsoleKey.DownArrow:
                    index = Math.Min(index + 1, skillTypes.Length - 1);
                    break;
                case ConsoleKey.UpArrow:
                    index = Math.Max(index - 1, 0);
                    break;
                case ConsoleKey.Enter:
                    Console.WriteLine("\n" + skillTypes[index] + "を実行します……");
                    flag = false;
                    break;
                default:
                    break;
            }
        }
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        IStartable start = (IStartable) Activator.CreateInstance(skillTypes[index]);
        start.Start();


        System.Threading.Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("何かキーを押して選択画面に戻ります。");
        Console.ReadKey();
    }
}