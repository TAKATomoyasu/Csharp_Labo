using System;

namespace Study_Csharp
{

    //抽象クラス！計算機
    abstract class Calculator
    {
        // 子クラスでフィールドを使えるように、protectedにする
        protected float value;

        // コンスタクタで初期値を設定
        // ●コンストラクタはpublicである必要がある
        public Calculator(float initialValue)
        {
            this.value = initialValue;
        }

        //普通のメソッド。外部から呼び出せるようにpublicにする
        public void Say()
        {
            Console.WriteLine(value);
        }

        //抽象メソッド。外部から呼び出せるようpublicにした
        //子クラスでオーバーライドできるよう、protectedかpublicである必要がある
        abstract public void Calc(float num);
    }

    //抽象クラスを継承
    class Add : Calculator
    {
        // 親クラスのコンストラクタを呼び出し、Addの仮引数も渡す。
        // 書式が独特。base()が親のコンストラクタ
        public Add(float value) : base(value) { }

        // 抽象メソッドをオーバーライド
        override public void Calc(float num)
        {
            value += num;
        }
    }
    // 別の子クラス
    class Sub : Calculator
    {
        public Sub(float value) : base(value) { }

        override public void Calc(float num)
        {
            value -= num;
        }
    }

    // 実行クラス
    class Abstract : IStartable
    {
        public void Start()
        {

            // 継承していれば、親クラス型の変数に子クラスを格納することができる！！（＝ポリモーフィズム）
            Calculator c1 = new Add(0);
            Calculator c2 = new Sub(0);
            //配列にもまとめられる
            Calculator[] cs = { c1, c2 };

            //foreachを使えば、関数もまとめて実行できて非常に便利！
            foreach (var c in cs)
            {
                c.Calc(10);
                c.Say();
            }
        }
    }
}