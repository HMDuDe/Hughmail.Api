using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hughmail.Api.Entities;

namespace Hughmail.Api.DTOs
{
    public class SendEmailDto
    {
        public string? EmailSubject { get; set; }

        public string? EmailBody { get; set; }

        public ICollection<Receipient>? Receipients { get; set; }
    }
}