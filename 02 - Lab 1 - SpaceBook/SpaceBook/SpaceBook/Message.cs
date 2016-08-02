using System;

namespace SpaceBook
{
    public class Message
    {
        public DateTime Date { get; set; }
        public Person Sender { get; set; }
        public string Body { get; set; }

        public Message(Person sender, string body)
        {
            Sender = sender;
            Body = body;
            Date = new DateTime();
        }
    }
}