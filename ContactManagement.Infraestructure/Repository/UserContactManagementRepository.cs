using ContactManagement.Domain.Entities;
using ContactManagement.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Infraestructure.Repository
{
    public class UserContactManagementRepository : IUserContactManagementRepository
    {
        private readonly ApplicationContext _context;

        public UserContactManagementRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void CreateContact(UserContact contact)
        {
            _context.Contacts.Add(contact);
        }

        public void DeleteContact(int idContact)
        {
            var result = _context.Contacts.Where(c => c.Id == idContact).FirstOrDefault();
            if (result == null)
            {
                throw new Exception("Data not found!");
            }            
        }

        public async Task<UserContact> GetContactById(int id)
        {
            var result = await _context.Contacts.FindAsync(id);
            if (result == null)
            {
                throw new Exception("Data not found!");
            }
            return result;
        }

        public async Task<UserContact> UpdateContact(UserContact contact)
        {
            var existingContact = await _context.Contacts.FindAsync(contact.Id);
            if (existingContact == null)
            {
                throw new Exception("Data not found!");
            }
            _context.Entry(existingContact).CurrentValues.SetValues(contact);
            await _context.SaveChangesAsync();
            return existingContact;
        }
    }
}
