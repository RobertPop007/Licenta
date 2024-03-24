﻿using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace Disertatie_backend.DTO
{
    public class EmailMessage
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public EmailMessage(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress("test", x)));
            Subject = subject;
            Content = content;
        }
    }
}
