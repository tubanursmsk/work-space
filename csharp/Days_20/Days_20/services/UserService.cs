using MongoDB.Driver;
using Days_20.Models;
using Days_20.Utils;

namespace Days_20.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _usersCollection;
        public UserService()
        {
            DBMongo dbMongo = new();
            _usersCollection = dbMongo.GetCollection<User>("users");
        }
        
        // sayfalama 
        public UserPage GetAllUsersPage(int pageNumber, int pageSize)
        {
            var filter = Builders<User>.Filter.Empty;
            var totalCount = _usersCollection.CountDocuments(filter);
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
           
            var users = _usersCollection.Find(filter)
                .Skip((pageNumber - 1) * pageSize)
                .Limit(pageSize)
                .SortByDescending(x => x.Age)          
                .ToList();
            
            UserPage userPage = new()
            {
                TotalCount = (int)totalCount,
                TotalPage = totalPages,
                Users = users
            };
            return userPage;

        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        // Add your methods and properties here
    }
}