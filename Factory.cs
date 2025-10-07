// public interface IPaymentFactory
// {
//     void Payment();
// }


// public class CreditCardPayment : IPaymentFactory
// {
//     public void Payment()
//     {
//         throw new NotImplementedException();
//     }
// }

// public class UpiPayment : IPaymentFactory
// {
//     public void Payment()
//     {
//         throw new NotImplementedException();
//     }
// }

// public class NetBankingPayment : IPaymentFactory
// {
//     public void Payment()
//     {
//         throw new NotImplementedException();
//     }
// }

// public class DebitCardPayment : IPaymentFactory
// {
//     public void Payment()
//     {
//         throw new NotImplementedException();
//     }
// }


// public class PaymentFactoryType
// {
//     public static IPaymentFactory GetPaymentMethod(string paymentType)
//     {
//         switch (paymentType)
//         {
//             case "UPI":
//                 return new UpiPayment();
//             case "Credit Card":
//                 return new CreditCardPayment();
//             case "Net Banking":
//                 return new NetBankingPayment();
//             case "Debit Card":
//                 return new DebitCardPayment();
//             default:
//                 throw new ArgumentException($"Unknown payment type: '{paymentType}'");
//         }
//     }
// }

