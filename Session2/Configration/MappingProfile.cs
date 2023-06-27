using AutoMapper;
using Session2.Models;

namespace Session2.Configration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonVM>();
        }
    }
}
