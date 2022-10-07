using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hughmail.Api.Entities
{
    public class Email
    {
        public int Id { get; set; }

        public int SenderUserId { get; set; }

        public int StatusId { get; set; }

        public string? Subject { get; set; }

        public string? Body { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}