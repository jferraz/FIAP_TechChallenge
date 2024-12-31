using ContactManagement.Domain.Entities;
using ContactManagement.Infraestructure.Data.Context;

namespace ContactManagement.Infraestructure.Repository
{
    public interface IUserContactManagementRepository
    {
        void CreateContact(UserContact contact);
        void UpdateContact(UserContact contact);
        void DeleteContact(UserContact contact);
        UserContact GetContactById(int id);
    }
}
