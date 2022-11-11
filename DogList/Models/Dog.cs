using System.ComponentModel.DataAnnotations;

namespace DogList.Models
{
    public class Dog
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; } 
    }
}
