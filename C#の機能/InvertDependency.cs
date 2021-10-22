using System;


public class InvertDependency : IStartable
{
    public static Entity.IView view;
    public static Controller.IInputProvider input;
    public void Start()
    {
        view = new Device.Output();
        input = new Device.Input();
        new Controller.Controller();

    }
}

namespace Device
{
    using Controller;
    using Entity;
    public class Input : IInputProvider
    {
        public string GetInput()
        {
            Console.WriteLine("テキストを入れてね");
            var line = Console.ReadLine();
            return line;
        }
    }
    public class Output : IView
    {
        public void Show(string data)
        {
            Console.WriteLine(data);
        }
    }
}

namespace Controller
{
    using Usecase;
    public interface IInputProvider
    {
        string GetInput();
    }

    public class Controller
    {
        IInputProvider input;

        public Controller()
        {
            input = InvertDependency.input;
            IUsecase u = new GameStarter();
            u.Func();
            GameLoop();
        }

        public void GameLoop()
        {
            while (true)
            {
                var phrase = input.GetInput();
                if (phrase == "add")
                {
                    IUsecase u = new AddNum();
                    u.Func();
                    u = new ShowData();
                    u.Func();
                }
                else if (phrase == "sub")
                {
                    IUsecase u = new SubtractNum();
                    u.Func();
                    u = new ShowData();
                    u.Func();
                }
            }
        }
    }
}

namespace Usecase
{
    using Entity;
    interface IUsecase
    {
        void Func();
    }


    public class GameStarter : IUsecase
    {
        public static GameState gameState;
        public void Func()
        {
            gameState = new GameState();
        }
    }

    public class AddNum : IUsecase
    {
        public void Func()
        {

            GameStarter.gameState.currentNum += 1;
        }
    }
    public class SubtractNum : IUsecase
    {
        public void Func()
        {

            GameStarter.gameState.currentNum -= 1;
        }
    }
    public class ShowData : IUsecase
    {
        IView v;
        public void Func()
        {
            v = InvertDependency.view;
            v.Show(GameStarter.gameState.currentNum.ToString());
        }
    }
}

namespace Entity
{
    public class GameState
    {
        public int currentNum;

        public GameState()
        {
            currentNum = 0;
        }
    }

    public interface IView
    {
        void Show(string data);
    }
}