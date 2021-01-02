using System.ComponentModel.DataAnnotations;

namespace SHOPExercise.Models
{
    public class Product
    {
        public int ID { get; set; }


        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage ="The product can not be a free")]
        public double Price { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        public string Photo { get; set; }
    }
}
