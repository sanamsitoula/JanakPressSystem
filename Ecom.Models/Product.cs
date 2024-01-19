using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string ?Description { get; set; }
      
        public string ?ISBN { get; set; }
     
        public string ?Author { get; set; }
        public double ?BasePrice { get; set; }
        public double ?CostPrice { get; set; }
        public bool? Status { get; set; }
      
        public string? CreatedBy { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string ?ImageURL { get; set; }
        public int ?FiscalYear { get; set; }
        public int ?PageNumber { get; set; }

        [Required]
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }


        [Required]
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }


        [Required]
        public int FormaId { get; set; }
        [ForeignKey("FormaId")]
        public Forma Forma{ get; set; }

        public string ?FormaAssociation { get; set; }


        public SubjectLanguage ?SubjectLanguageId { get; set; }
        public SubjectType ?SubjectTypeId { get; set; }

        public enum SubjectLanguage
        {
            Nepali,
            English,
            Newari,
            Sanskrit
        }
        public enum SubjectType
        {
            Compulsary,
            Optional
        }

    }

}
