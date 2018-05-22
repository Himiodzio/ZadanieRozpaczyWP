using System;

namespace FactoryDesignPattern
{
    public interface gamedev
    {
        string GamePlatform
        {
            get;
        }
        void GetGame();
    }
    class AlanWake : gamedev
    {
        public string GamePlatform
        {
            get { return "PC"; }
        }

        public void GetGame()
        {
            Console.WriteLine("Alan Wake is the newest released game");
        }
    }
    class MassEffect : gamedev
    {
        public string GamePlatform
        {
            get { return "Xbox One"; }
        }
        public void GetGame()
        {
            Console.WriteLine("Mass Effect is the newest released game");
        }
    }

    class Battlefield : gamedev
    {
        public string GamePlatform
        {
            get { return "PlayStation 4"; }
        }
        public void GetGame()
        {
            Console.WriteLine("Battlefield is the newest released game");
        }
    }
    class PokemonSilver : gamedev
    {
        public string GamePlatform
        {
            get { return "Nintendo Switch"; }
        }
        public void GetGame()
        {
            Console.WriteLine("Pokemon Silver is the newest released game");
        }
    }

    static class CarFactory
    {
        public static gamedev GetCarInstance(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new AlanWake();
                case 1:
                    return new MassEffect();
                case 2:
                    return new Battlefield();
                case 3:
                    return new PokemonSilver();
                default:
                    return null;
            }
        }
    }
    class ClientProgram
    {
        static void Main(string[] args)
        {

            gamedev objCarSupplier = CarFactory.GetCarInstance(3);
            objCarSupplier.GetGame();
            Console.WriteLine("on " + objCarSupplier.GamePlatform);

            Console.ReadLine();
        }

    }
}
