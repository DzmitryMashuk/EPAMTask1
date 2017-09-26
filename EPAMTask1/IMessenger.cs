namespace EPAMTask1
{
    interface IMessenger
    {
        void SendMessage(string message);
        string GetLastMessage();
        string GetFirstMessage();
    }
}
