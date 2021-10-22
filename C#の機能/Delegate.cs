using System;


class DelegateTest : IStartable
{
    delegate void SomeDelegate(); //デリゲート型をまず作る
    SomeDelegate delegates; //デリゲート

    public void Start()
    {

        // デリゲートは、+=で複数のメソッドを代入できる
        delegates += ShowMessage1;
        delegates += ShowMessage2;
        delegates += ShowMessage3;

        delegates();
    }

    void ShowMessage1() { Console.WriteLine("ぼくはとびちん"); }
    void ShowMessage2() { Console.WriteLine("おれはとびまる"); }
    void ShowMessage3() { Console.WriteLine("わいはとびぽこ"); }
}