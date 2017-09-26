using System.Collections.Generic;
using System.Linq;

namespace EPAMTask1
{
    class Messenger : IMessenger
    {
        List<string> messages = new List<string>();
        int countFirstElement = 0;
        int countLastElement = 0;

        public void SendMessage(string message)
        {
            messages.Add(message);
        }
        public string GetFirstMessage()
        {
            if (messages.Count() == countFirstElement)
                return "null";
            countFirstElement++;
            return messages[countFirstElement - 1];
        }
        public string GetLastMessage()
        {
            if (messages.Count() == countLastElement)
                return "null";
            countLastElement++;
            return messages[messages.Count() - countLastElement];
        }
    }
}
