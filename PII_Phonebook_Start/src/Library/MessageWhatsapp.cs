using System;

namespace Library{

    public class MessageWhatsapp : IMessageChannel
    {
        public void Send(string phone, string message)
        {
            const string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
            const string authToken = "fdcaac12dc7e5b031908429ee402e7a4";
            
            var whats =new WhatsAppApi( accountSid, authToken);
            string sid = whats.Send(phone, message);
            Console.WriteLine(sid);
        }


    }
}