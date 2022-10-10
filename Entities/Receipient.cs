using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hughmail.Api.Entities
{
    public class Receipient
    {
        public int Id { get; set; }

        public int? HeaderStatus { get; set; }

        public string? ReceipientEmailAddress { get; set; }
    }
}