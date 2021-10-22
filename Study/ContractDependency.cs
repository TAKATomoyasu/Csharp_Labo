//お互いにインターフェイスを参照するが，互いに相手が実装しているので，実質相互に参照できている

using System;

public class ContractDependency : IStartable
{
    public void Start()
    {
        var s = new PersonServer();
        var c = new PersonClient();
        s.p = c;
        c.p = s;
        s.YourAction();
    }
}

public interface Person
{
    void MyAction();
    void YourAction();
    Person GetFriend();
}

public class PersonServer : Person
{
    public Person p;
    public Person GetFriend() => p;
    public void MyAction() => Console.WriteLine("私はサーバー");
    public void YourAction() => p.MyAction();
}

public class PersonClient : Person
{
    public Person p;
    public Person GetFriend() => p;
    public void MyAction() => Console.WriteLine("私はクライアント");
    public void YourAction() => p.MyAction();
}