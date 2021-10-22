// vscode では，⌘ return で実行． [dotnet run]が呼び出される．（tasks.jsonを書き換えた）
// ⌘ delete で中止．
// （Visual Studioでも ⌘ return でデバッグ実行）

// 実験するスクリプトは Mainメソッドで new クラス名().Start(); で実行できるようにする．
// または，ProgramSelectorを使うと，IStartableを実装するクラスがリストアップして，コマンドラインから実行できる．


class Program
{
    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
            new ProgramSelector();
        }
    }
}