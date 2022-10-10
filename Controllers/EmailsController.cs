using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hughmail.Api.Data;
using Hughmail.Api.DTOs;
using Hughmail.Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hughmail.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmailsController : ControllerBase
    {
        private readonly DataContext _context;

        public EmailsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Email>>> GetEmails() => await _context.Emails.ToListAsync();

        [HttpPost("send")]
        public async Task<ActionResult<Email>> Send(SendEmailDto emailDto) 
        {
            var email = _context.Emails.Add(new Email() {
                SenderUserId = 0, // TO DO - must add real sender ID here
                StatusId = 1,
                Subject = emailDto.EmailSubject,
                Body = emailDto.EmailBody,
                CreatedOn = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                IsDeleted = false,
                Receipients = emailDto.Receipients
            }).Entity;

            await _context.SaveChangesAsync();

            return email;
        }

        [HttpPut("delete/{id}")]
        public async Task<ActionResult<Email>> Delete(int id) 
        {
            var emailToDelete = _context.Emails.Find(id);

            emailToDelete.IsDeleted = true;

            _context.Emails.Update(emailToDelete);

            await _context.SaveChangesAsync();

            return emailToDelete;
        }

        [HttpPut("delete/undo/{id}")]
        public async Task<ActionResult<Email>> Recover(int id) 
        {
            var emailToRecover = _context.Emails.Find(id);

            if (emailToRecover == null || emailToRecover.IsDeleted == false) throw new BadHttpRequestException("Deleted email not found. Check that you have the right ID specified.");
            
            // update to change email IsDeleted to false
            emailToRecover.IsDeleted = false;

            _context.Emails.Update(emailToRecover);

            await _context.SaveChangesAsync();

            return emailToRecover;
        }
    }
}