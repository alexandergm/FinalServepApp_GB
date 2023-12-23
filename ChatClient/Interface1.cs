public interface IMessageSourceClient
{
    void Connect(string address);
    void Disconnect();
    void SendMessage(string message);
    event EventHandler<string> MessageReceived;
}
