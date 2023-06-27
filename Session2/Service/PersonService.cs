using AutoMapper;
using Session2.Models;
using Session2.Repository;

namespace Session2.Service
{
    public class PersonService:IPersonService
    {
        private readonly IPersonRepository _personRepository;
        readonly IMapper _mapper;
        public PersonService(IPersonRepository personRepository,IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public List<PersonVM> GetPersons()
        {
          //  return _personRepository.GetPersons();
            var persons = _personRepository.GetPersons();
            return _mapper.Map<List<PersonVM>>(persons);
        }

        public Person GetPersonById(int personId)
        {
            return _personRepository.GetPersonById(personId);
        }

        public void CreatePerson(Person person)
        {
            _personRepository.CreatePerson(person);
        }

        public void UpdatePerson(Person person)
        {
            _personRepository.UpdatePerson(person);
        }

        public void DeletePerson(int personId)
        {
            _personRepository.DeletePerson(personId);
        }
    }
}
