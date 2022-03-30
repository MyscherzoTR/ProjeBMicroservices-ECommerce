using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Course.Services.Catalog.Models
{
    public class Coursee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]  /*mongoDB'de ID "Object" olarak tutulacak kod yazarken bu sayede otomatik olarak string �evirecek. Bizim kodla string 
                                         * yollad���mz� veri ise otomatik olarak mongoDB giderken Object olarak gidecek. */
        public string Id { get; set; }

        public string Name { get; set; }

        [BsonRepresentation(BsonType.Decimal128)] //MongoDb taraf�ndan verisini belirliyoruz.
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }

        public string Picture { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }

        public Feature Feature { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        [BsonIgnore]
        public Category Category { get; set; } /* Her kursun ba�l� oldu�u bir kategori var. �r�nleri d�nerken kategorilerinede d�nece�iz. 
                                                Fakat sadece kodlama esnas�nda kullan�lacak bu propertie. Yani MongoDB'de bir kar��l��� olmayacak. Haliyle
                                                MongoDB'de bu k�s�m olmayacak */
    }
}