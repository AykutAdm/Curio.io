using Curio.Shared.Abstractions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Questions.Domain
{
    public class Question : BaseEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string SenderUserId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string RecipientUserId { get; set; }
        public string Content { get; set; }
        public bool IsAnonymous { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsDeleted { get; set; }
    }
}
