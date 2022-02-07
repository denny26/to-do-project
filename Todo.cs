using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Todo
    {
        public Todo(string description, string owner, bool isCompleted)
        {
            Description = description;
            Owner = owner;
            IsCompleted = isCompleted;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("owner")]
        public string Owner { get; set; }
        [BsonElement("isCompleted")]
        public bool IsCompleted { get; set; }
    }
}
