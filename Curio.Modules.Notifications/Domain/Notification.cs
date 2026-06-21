using Curio.Shared.Abstractions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curio.Modules.Notifications.Domain
{
    public class Notification : BaseEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        public string Type { get; set; } // "QuestionReceived", "AnswerLiked", "NewFollower" //

        [BsonRepresentation(BsonType.ObjectId)]
        public string ReferenceId { get; set; } //soru sorulunca, cevap beğenilirse, takip edilirsek //

        public bool IsRead { get; set; }
    }
}
