using System;

namespace Library
{
    public class Singleton<T> where T : class, new()
    {
        private Singleton()
        {
            // Intentionally left blank
        }

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }

        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
