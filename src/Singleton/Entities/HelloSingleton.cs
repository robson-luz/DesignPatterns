using Singleton.Interfaces;

namespace Singleton.Entities
{
    public class HelloSingleton : IHello
    {
        private static HelloSingleton _instance;

        private static readonly object _padlock = new object();

        private HelloSingleton()
        {

        }

        public static HelloSingleton Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_instance is null)
                    {
                        return new();
                    }

                    return _instance;
                }
            }
        }

        public void SayHello()
            => Console.WriteLine("Hello there!!");        
    }
}
