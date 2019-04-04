using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    class Program
    {
        public delegate void NotificationDelegate(string name, string message);
        public delegate void SendNotification(string message, User user );
        static void Main(string[] args)
        {
            NotificationDelegate notification = new NotificationDelegate(EmailMessage);
            notification += SmsMessage;
            notification += MmsMessage;

            notification("Zdravo", "Marija");

            notification -= SmsMessage;
            notification("Zdravo", "Marija1");

            SendNotification sendNotification = new SendNotification(EmailMessage);
            sendNotification += SmsMessage;
            sendNotification += MmsMessage;

            User marija = new User()
            {
                Name = "Marija",
                Email = "marija.rumenovska@hotmail.com",
                PhoneNum = "078462064"

            };

            sendNotification("Zdravo", marija);

            Console.ReadLine();

        }
        public static void EmailMessage(string name, string message)
        {
            Console.WriteLine($"Message: {message} to {name} send via email.");
        }
        public static void SmsMessage(string name, string message)
        {
            Console.WriteLine($"Message: {message} to {name} send via SMS.");
        }
        public static void MmsMessage(string name, string message)
        {
            Console.WriteLine($"Message: {message} to {name} send via MMS.");
        }

        public static void EmailMessage(string message, User user)
        {
            Console.WriteLine($"Message: {message} to {user.Name} {user.Email} send via email.");
        }
        public static void SmsMessage(string message, User user)
        {
            Console.WriteLine($"Message: {message} to {user.Name} {user.PhoneNum} send via SMS.");
        }
        public static void MmsMessage(string message, User user)
        {
            Console.WriteLine($"Message: {message} to {user.Name} {user.PhoneNum} send via MMS.");
        }
        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNum { get; set; }

            public User()
            {

            }
            public User(string name, string email, string phoneNum)
            {
                this.Name = name;
                this.Email = email;
                this.PhoneNum = phoneNum;
            }
        }

    }
}
