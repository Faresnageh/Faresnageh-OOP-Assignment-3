# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
The calculator used a switch statement to choose the shipping carrier.
Every time a new carrier was added, ShippingCostCalculator had to be modified.

- What did you change?
I created an IShipping interface and a separate class for each shipping carrier.
ShippingCostCalculator now depends on IShipping.
This allows adding new carriers without modifying the existing calculator.

---

## OrderProcessor

- What was the problem?
OrderProcessor was directly creating SqlOrderRepository and SmtpEmailSender,
so it was tightly coupled to concrete classes.

- What did you change?
I created IOrderRepository and IEmailSender interfaces.
OrderProcessor now depends on these abstractions and receives them through
constructor injection.

---

## Notifications

- What was the problem?
The notification system used inheritance and needed a separate class for each combination,
such as urgent email, urgent SMS, and urgent scheduled email.
Adding new notification channels would create even more classes.

- What did you change?
I created an INotification interface and used composition instead of inheritance.
UrgentNotification and ScheduledNotification can wrap any notification channel.
This allows urgent, scheduled, or both behaviors without creating a separate class for every combination.


---

## Proof

- New carrier file(s): PostaShipping.cs
- New notification channel file(s): WhatsAppNotification.cs
- Existing classes left unchanged? (yes/no): yes