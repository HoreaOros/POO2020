namespace Curs6
{
    internal class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {
            System.Console.WriteLine("Am creat un Singleton");
        }
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}