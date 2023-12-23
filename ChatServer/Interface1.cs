public interface IMessageSource
{
    void Start();
    void Stop();
    void SendMessage(string message);
}
