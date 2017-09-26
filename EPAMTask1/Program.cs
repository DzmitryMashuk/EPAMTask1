using System;

namespace EPAMTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskActivator activator = new TaskActivator();
            var messenger = (Messenger)activator.Run();

            messenger.SendMessage("Hello");
            messenger.SendMessage("world");
            messenger.SendMessage("!");

            Console.WriteLine(messenger.GetFirstMessage());
            Console.WriteLine(messenger.GetFirstMessage());
            Console.WriteLine(messenger.GetFirstMessage());
            Console.WriteLine(messenger.GetFirstMessage());

            Console.WriteLine(messenger.GetLastMessage());
            Console.WriteLine(messenger.GetLastMessage());
            Console.WriteLine(messenger.GetLastMessage());
            Console.WriteLine(messenger.GetLastMessage());

            Console.ReadKey();
        }
    }
}
