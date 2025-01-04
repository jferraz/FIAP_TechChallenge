using ContactManagement.Application.Service;
using ContactManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactManagementController : Controller
    {
        private readonly IUserContactManagementService _contactService;

        public ContactManagementController(IUserContactManagementService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult GetContactById(int id)
        {
            var contact = _contactService.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }                

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserContact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.CreateContact(contact);
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var contact = _contactService.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        
        [HttpPost]
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
            return View(contact);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _contactService.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _contactService.DeleteContact(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
