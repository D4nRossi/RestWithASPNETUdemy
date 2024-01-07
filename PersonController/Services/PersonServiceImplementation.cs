using PersonController.Model;
using PersonController.Services.Implementations;
using System.Collections.Generic;

namespace PersonController.Services {
    public class PersonServiceImplementation : IPersonService {
        public Person Create(Person person) {
            return person;
        }

        public void Delete(long id) {
           
        }

        public List<Person> FindAll() {
            List<Person> persons = new List<Person>();
            for(int i = 0; i<8;i++) {
                Person person = null;
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long id) {
            throw new System.NotImplementedException();
        }

        public Person Update(Person person) {
            throw new System.NotImplementedException();
        }
    }
}
