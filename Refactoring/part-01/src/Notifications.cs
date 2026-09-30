namespace RefactoringLab;

public interface INotification
{
    string Name { get; }
    void Send(string to, string message);
}

public class EmailNotification : INotification
{
    public string Name => "email";

    public void Send(string to, string message)
    {
        Console.WriteLine($"[email] {to}: {message}");
    }
}

public class SmsNotification : INotification
{
    public string Name => "sms";

    public void Send(string to, string message)
    {
        Console.WriteLine($"[sms] {to}: {message}");
    }
}

public class UrgentNotification : INotification
{
    private readonly INotification _notification;

    public UrgentNotification(INotification notification)
    {
        _notification = notification;
    }

    public string Name => _notification.Name;

    public void Send(string to, string message)
    {
        _notification.Send(to, $"[URGENT] {message}");
    }
}

public class ScheduledNotification : INotification
{
    private readonly INotification _notification;

    public ScheduledNotification(INotification notification,DateTime sendAt)
    {
        _notification = notification;
        SendAt = sendAt;
    }

    public DateTime SendAt { get; set; }

    public string Name => _notification.Name;

    public void Send(string to, string message)
    {
        Console.WriteLine($"[{Name} scheduled {SendAt:g}] {to}: {message}");
    }

}

public class WhatsAppNotification : INotification
{
    public string Name => "whatsapp";

    public void Send(string to, string message)
    {
        Console.WriteLine($"[whatsapp] {to}: {message}");
    }
}