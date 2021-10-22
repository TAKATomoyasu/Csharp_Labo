using System;


public class CleanArchitecture : IStartable
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
            input = CleanArchitecture.input;
            IUsecase u = new GameStarter();
            u.Handle();
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
                    u.Handle();
                    u = new ShowData();
                    u.Handle();
                }
                else if (phrase == "sub")
                {
                    IUsecase u = new SubtractNum();
                    u.Handle();
                    u = new ShowData();
                    u.Handle();
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
        void Handle();
    }


    public class GameStarter : IUsecase
    {
        public static GameState gameState;
        public void Handle()
        {
            gameState = new GameState();
        }
    }

    public class AddNum : IUsecase
    {
        public void Handle()
        {

            GameStarter.gameState.currentNum += 1;
        }
    }
    public class SubtractNum : IUsecase
    {
        public void Handle()
        {

            GameStarter.gameState.currentNum -= 1;
        }
    }
    public class ShowData : IUsecase
    {
        IView v;
        public void Handle()
        {
            v = CleanArchitecture.view;
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