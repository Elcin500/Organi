using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Organi.WebUI.Models.DataContext;
using Organi.WebUI.Models.Entity;

namespace Organi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactsController : Controller
    {
        private readonly OrganiDbContext _context;
        readonly IConfiguration config;
        public ContactsController(OrganiDbContext context, IConfiguration config)
        {
            _context = context;
            this.config = config;
        }

        // GET: Admin/Contacts
        public async Task<IActionResult> Index(int? typeId)
        {
            var query = _context.Contacts.AsQueryable();

            if (typeId.HasValue && typeId.Value==1)
            {
                query = query.Where(c => c.Answer == null);

            }

            return View(await query.ToListAsync());
        }

        // GET: Admin/Contacts/Details/5
        public async Task<IActionResult> Answer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            if (contact.Answer != null)
            {
                return BadRequest();
            }
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Answer(int id,[Bind("Id,Answer")]Contact contact)
        {
            try
            {
                if (id != contact.Id)
                {
                    return NotFound();
                }

                var entity = await _context.Contacts
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (entity == null)
                {
                    return NotFound();
                }
                if (entity.Answer != null)
                {
                    return BadRequest();
                }
                entity.Answer = contact.Answer;
                entity.AnswerDate = DateTime.UtcNow.AddHours(4);

                var host = config.GetValue<string>("emailAccount:smtpServer");
                var port = config.GetValue<int>("emailAccount:smtpPort");
                var userName = config.GetValue<string>("emailAccount:userName");
                var password = config.GetValue<string>("emailAccount:password");
                var cc = config.GetValue<string>("emailAccount:cc")
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);


                SmtpClient client = new SmtpClient(host, port);
                client.Credentials = new NetworkCredential(userName, password);
                client.EnableSsl = true;

                MailMessage message = new MailMessage(userName, entity.Email);

                foreach (var item in cc)
                {
                    message.CC.Add(item);
                }

                message.Subject = "Organi Musteri Servisi";
                message.Body = entity.Answer;
                message.IsBodyHtml = true;

                client.Send(message);
    
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                TempData["Message"] = "Cavablandirildi";

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ;
            }
        }


    }
}
