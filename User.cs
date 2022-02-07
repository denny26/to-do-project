using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class User
    {
    public User(string email, string username, string password)
    {
        Email = email;
        Username = username;
        Password = password;
    }

    [BsonId]
    public ObjectId Id { get; set; }
    [BsonElement ("username")]
    public string Username { get; set; }
    [BsonElement ("email")]
    public string Email { get; set; }
    [BsonElement ("password")]
    public string Password { get; set; }

    }
}
