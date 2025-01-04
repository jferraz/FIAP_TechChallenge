using ContactManagement.Domain.Entities;
using ContactManagement.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Infraestructure.Repository
{
    public interface IUserContactManagementRepository
    {
       void CreateContact(UserContact contact);
       void DeleteContact(int idContact);
       Task<UserContact> GetContactById(int id);
       Task<UserContact> UpdateContact(UserContact contact);        
    }
}
