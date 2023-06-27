using Session2.Context;
using Session2.Models;

namespace Session2.Repository
{
    public class PersonRepository:IPersonRepository
    {
        readonly PersonApplicationDbContext _context;
        public PersonRepository (PersonApplicationDbContext context) 
        {
        _context = context;
        }

        public void CreatePerson(Person person)
        {
           _context.persons.Add(person);
            _context.SaveChanges();
        }

        public void DeletePerson(int persontId)
        {
            var person = _context.persons.Find(persontId);
            if (person != null)
            {
                _context.persons.Remove(person);
                _context.SaveChanges();
            }
          
        }

        public IList<Person> GetPersons()
        {
           return  _context.persons.ToList();            
        }

        public Person GetPersonById(int personId)
        {
            return _context.persons.Find(personId);
        }

        public void UpdatePerson(Person person)
        {
            var existingPerson = _context.persons.Find(person.Id);
            if (existingPerson != null) 
            {
            existingPerson.Name=person.Name;
            existingPerson.Age=person.Age;
                _context.SaveChanges();
            }
        }
    }
}
