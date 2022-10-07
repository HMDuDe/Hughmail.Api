using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hughmail.Api.Entities
{
    public class Receipient
    {
        public int Id { get; set; }

        public int EmailId { get; set; }

        public string? HeaderStatus { get; set; }
    }
}