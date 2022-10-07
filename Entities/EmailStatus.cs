using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hughmail.Api.Entities
{
    public class EmailStatus
    {
        public int id { get; set; }

        public int EmailId { get; set; }

        public string? StatusName { get; set; }
    }
}