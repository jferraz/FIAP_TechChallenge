using ContactManagement.Domain.DTO;
using ContactManagement.Domain.Entities;

namespace ContactManagement.Domain.Adapter
{
    public static class PhoneDDDAdapter
    {
        public static IEnumerable<PhoneDDDDto> ToPhoneDDDDto(this IEnumerable<PhoneDDD> lista)
        {
            return lista.Select(p => p.ToPhoneDDDDto()).ToList();
        }

        public static PhoneDDDDto ToPhoneDDDDto(this PhoneDDD obj)
        {
            if (obj == null)
                return null;

            var model = new PhoneDDDDto()
            {
                Id = obj.Id,
                DDD = obj.DDD,
                Area = obj.Area
            };
            return model;
        }

        public static IEnumerable<PhoneDDD> ToPhoneDDD(this IEnumerable<PhoneDDDDto> lista)
        {
            return lista.Select(p => p.ToPhoneDDD()).ToList();
        }

        public static PhoneDDD ToPhoneDDD(this PhoneDDDDto dto)
        {
            if (dto == null)
                return null;

            var model = new PhoneDDD()
            {
                Id = dto.Id,
                DDD = dto.DDD,
                Area = dto.Area,
                Users = new List<UserContact>()
            };
            return model;
        }
    }    
}
