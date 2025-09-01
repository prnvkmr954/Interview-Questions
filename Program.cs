
#region Delegates
// Step 3: Take input
using static DelegateProblem;

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Step 4: Assign delegates to methods
            MathOperation op;

            op = Add;
            Console.WriteLine($"Addition: {op(num1, num2)}");

            op = Subtract;
            Console.WriteLine($"Subtraction: {op(num1, num2)}");

            op = Multiply;
            Console.WriteLine($"Multiplication: {op(num1, num2)}");

            op = Divide;
            Console.WriteLine($"Division: {op(num1, num2)}");
#endregion



#region Constructor Problem
// ConstructorProblem ctor = new ConstructorProblem();
// ConstructorProblem ctor1 = new ConstructorProblem("Pranav", 33);

Book book = new Book("Harry Potter", "J.K Rowlings");
Book book1 = new Book(book);


Console.WriteLine($"Title {book.Title}, Author: {book.Author}");
Console.WriteLine($"Title {book1.Title}, Author: {book1.Author}");

#endregion

#region DSA Problem
StringProblem stringProblem = new StringProblem();
//stringProblem.CountStringCharacter("Pranav");

//stringProblem.CountEachCharatcerStringUsingDictionary("Loveleen Kaur");

//stringProblem.WordFrequencyCounter("this is a test this is fun");
//stringProblem.CountVowelsInString("Beautiful");

//stringProblem.StoreStudentMarks();
//stringProblem.CountandSortNumber(213242315236);

// var method = PaymentFactory.GetPaymentMethod("PayPal");
// method.Pay();


// var notification = NotificationFactory.SendNotification("push");

// notification.Send("pranav", "Hi Pranav");

#endregion
#region Notification Factory


public class EmailNotification : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"Sending Email to {to}: {message}");
    }
}
public class SMSNotification : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"Sending SMS to {to}: {message}");
    }
}

public class PushNotification : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"Sending Push to {to}: {message}");
    }
}



public class NotificationFactory
{
    public static INotification SendNotification(string notificationType)
    {
        switch (notificationType.ToLower())
        {
            case "email":
                return new EmailNotification();
            case "push":
                return new PushNotification();
            case "sms":
                return new SMSNotification();
            default:
                throw new Exception("Please check the type of notification ");
       }
    }
}


public interface INotification
{
    void Send(string to, string message);
} 
#endregion

#region Payment Factory


public class CreditCardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Credit Card Payment");
    }
}

public class PayPalPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Pay Pal Payment");
    }
}

public class UpiPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("UPI Payment");
    }
}

public class PaymentFactory
{
    public static IPayment GetPaymentMethod(string paymentType)
    {
        switch (paymentType)
        {
            case "UPI":
                return new UpiPayment();

            case "CreditCard":
                return new CreditCardPayment();

            case "PayPal":
                return new PayPalPayment();
            default:
                throw new ArgumentException($"Unknown payment type: '{paymentType}'");
        }
    }
}

public interface IPayment
{
    void Pay();
}

#endregion