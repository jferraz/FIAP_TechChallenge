using ContactManagement.Domain.DTO;
using ContactManagement.Domain.Entities;
using ContactManagement.Infraestructure.Repository;

namespace ContactManagement.Application.Service
{
    public class UserContactManagementService : IUserContactManagementService
    {
        private readonly IUserContactManagementRepository _repository;

        public UserContactManagementService(IUserContactManagementRepository repository)
        {
            _repository = repository;
        }

        public void CreateContact(UserContactDto contact)
        {
            try
            {
                _repository.CreateContact(contact);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteContact(int idContact)
        {
            try
            {
                _repository.DeleteContact(idContact);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<UserContactDto> GetContactById(int id)
        {
            try
            {
                var result = _repository.GetContactById(id);
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<UserContact> UpdateContact(UserContactDto contact)
        {
            try
            {
                var result = _repository.UpdateContact(contact);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
