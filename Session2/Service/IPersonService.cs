using Session2.Models;

namespace Session2.Service
{
    public interface IPersonService
    {
        List<PersonVM> GetPersons();
        Person GetPersonById(int personId);
        void CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int personId);
    }
}
