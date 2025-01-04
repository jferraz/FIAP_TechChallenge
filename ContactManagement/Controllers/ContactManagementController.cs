using ContactManagement.Application.Service;
using ContactManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactManagementController : Controller
    {
        private readonly IUserContactManagementService _contactService;

        public ContactManagementController(IUserContactManagementService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public IActionResult GetContactById(int id)
        {
            var contact = _contactService.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }                

        
        [HttpPost("Create/{contact}")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserContact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.CreateContact(contact);
                return RedirectToAction(nameof(Index));
            }
            return Ok(contact);
        }

        
        [HttpPost("Edit/{contact}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UserContact contact)
        {
            if (contact.Id < 0)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _contactService.UpdateContact(contact);
                return RedirectToAction(nameof(Index));
            }
            return Ok(contact);
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var contact = _contactService.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }
    }
}
