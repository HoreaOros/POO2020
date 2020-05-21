using System;
using System.Collections.Generic;
namespace Curs1
{
    internal class World
    {
        private string id;
        private List<string> messages = new List<string>();
        public List<string> Messages
        {
            get
            {
                return messages;
            }
        }
        public World(string id)
        {
            this.id = id;
            Console.WriteLine($"{id} World created");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", id);
        }

        public void SendMessage(World w1, string message)
        {
            w1.Messages.Add(message);
        }
    }
}