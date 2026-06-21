using Curio.Shared.Abstractions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Users.Domain
{
    public class Follow : BaseEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string FollowerUserId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string FollowedUserId { get; set; }
    }
}
