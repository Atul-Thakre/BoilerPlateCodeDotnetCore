using Session2.Context;
using Session2.Models;

namespace Session2.Repository
{
    public interface IPersonRepository
    {
        IList<Person> GetPersons();
        Person GetPersonById(int personId);
        void CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int persontId);

    }
}
