using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyAkademi_ECommerce.Services.Catalog.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductImage { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]        
        
        public string CategoryId { get; set; }

        [BsonIgnore]

        public Category Category { get; set; }







    }
}