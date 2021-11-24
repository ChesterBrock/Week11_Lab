using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Lab
{
    class Email : Document
    {
        private string sender;
        private string recipient;
        private string title;

        public string Sender { get => sender; set => sender = value; }
        public string Recipient { get => recipient; set => recipient = value; }
        public string Title { get => title; set => title = value; }

        // constuctor 
        public Email(string sender, string recipient, string title, string anyText) : base(anyText)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.title = title;
        }

        public string toString()
        {
            return "Sender [" + this.sender + "] Recipient [" + this.recipient + "] \nTitle [" + this.title + "] \nMessage: " + AnyText; 
        }
    }
}
