using ContactManagement.Domain.DTO;

namespace ContactManagement.Application.Service
{
    public interface IUserContactManagementService
    {
        void CreateContact(UserContactDto contact);
        void DeleteContact(int idContact);
        Task<UserContactDto> GetContactById(int id);
        Task<UserContactDto> UpdateContact(UserContactDto contact);
    }
}