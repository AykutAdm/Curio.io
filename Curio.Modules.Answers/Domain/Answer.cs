using Curio.Shared.Abstractions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Answers.Domain
{
    public class Answer : BaseEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string QuestionId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        public string Content { get; set; }
        public int LikeCount { get; set; }
        public bool IsDeleted { get; set; }
    }
}
