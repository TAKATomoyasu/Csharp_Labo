using System;

namespace Study_Csharp
{

    interface ICalculator
    {
        void Calc(float num);
    }

    class CalculatorForInterface
    {
        protected float value;
        protected void Say()
        {
            Console.WriteLine(value);
        }
    }

    class AddForInterface : CalculatorForInterface, ICalculator
    {
        public void Calc(float num)
        {
            value += num;
            Say();
        }
    }

    class SubForInterface : CalculatorForInterface, ICalculator
    {
        public void Calc(float num)
        {
            value -= num;
            Say();
        }
    }

    // 実行クラス
    class Interface : IStartable
    {
        public void Start()
        {

            // 継承していれば、親クラス型の変数に子クラスを格納することができる！！（＝ポリモーフィズム）
            AddForInterface c1 = new AddForInterface();
            SubForInterface c2 = new SubForInterface();
            //インターフェイスも配列にもまとめられる
            ICalculator[] cs = { c1, c2 };

            //foreachを使えば、関数もまとめて実行できて非常に便利！
            foreach (var c in cs)
            {
                c.Calc(10);
            }
        }
    }
}