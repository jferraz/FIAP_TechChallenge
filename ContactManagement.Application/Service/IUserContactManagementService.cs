using ContactManagement.Domain.Entities;

namespace ContactManagement.Application.Service
{
    public interface IUserContactManagementService
    {
        void CreateContact(UserContact contact);
        void DeleteContact(int idContact);
        Task<UserContact> GetContactById(int id);
        Task<UserContact> UpdateContact(UserContact contact);
    }
}