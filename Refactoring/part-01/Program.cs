using RefactoringLab;

var shipping1 = new AramexShippin();
var shipping2 = new FedExShipping();
var shipping3 = new PostaShipping();
Console.WriteLine($"Aramex 2kg → {shipping1.Calculate(2)}");
Console.WriteLine($"FedEx 2kg  → {shipping2.Calculate(2)}");
Console.WriteLine($"Posta 2kg  → {shipping3.Calculate(2)}");
Console.WriteLine();


IOrderRepository orderRepository = new SqlOrderRepository();
IEmailSender emailSender = new SmtpEmailSender();
var processor = new OrderProcessor(orderRepository, emailSender);
processor.Process(1001, "customer@example.com");
Console.WriteLine();




INotification email = new EmailNotification();
INotification scheduledEmail = new ScheduledNotification(email, DateTime.Today.AddHours(18));
INotification urgentScheduledEmail = new UrgentNotification(scheduledEmail);
urgentScheduledEmail.Send("customer@example.com", "Your order ships tomorrow");


INotification whatsapp = new WhatsAppNotification();
INotification urgentWhatsapp = new UrgentNotification(whatsapp);
urgentWhatsapp.Send("01546489513132", "Your order is ready");
