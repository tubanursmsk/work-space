using Days_20.Models;
using MongoDB.Driver;
using Days_20.Utils;

namespace Days_20.Services
{

    public class PersonServices
    {
        private readonly IMongoCollection<Person> _personCollection;

        public PersonServices()
        {
            DBMongo dBMongo = new DBMongo();
            _personCollection = dBMongo.GetCollection<Person>("persons");
        }


        // add person

        public int AddPerson(Person person)
        {
            try
            {
                _personCollection.InsertOne(person);
                Console.WriteLine($"PersonID: {person.PersonId} added successfully.");
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return 0;

        }

    }
}
