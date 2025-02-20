using System.ComponentModel.DataAnnotations;

namespace LeadsApi.Domain.Entities
{
    public class Lead
    {
        public Lead(string name, string phone, string email, DateTime dateCreated, string suburb, string category, string description, decimal price, bool? accepted)
        {
            Name = name;
            Phone = phone;
            Email = email;
            DateCreated = dateCreated;
            Suburb = suburb;
            Category = category;
            Description = description;
            Price = price;
            Accepted = accepted;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool? Accepted { get; set; }
    }
}
