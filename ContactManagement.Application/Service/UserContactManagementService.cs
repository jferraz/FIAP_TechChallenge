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

        public void CreateContact(UserContact contact)
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

        public Task<UserContact> GetContactById(int id)
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

        public Task<UserContact> UpdateContact(UserContact contact)
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
