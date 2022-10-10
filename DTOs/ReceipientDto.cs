using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hughmail.Api.DTOs
{
    public class ReceipientDto
    {
        [Required]
        public int HeaderStatus { get; set; }

        [Required]
        public string? ReceipientEmailAddress { get; set; }
    }
}