using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ecom.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public string? Author { get; set; }
        public double? BasePrice { get; set; }
        public double? CostPrice { get; set; }
        public bool? Status { get; set; }
        public string? CreatedBy { get; set; }
        public  int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public  Category? Category { get; set; }
        public string? ImageURL { get; set; }
        public int? FiscalYear { get; set; }
        public int? PageNumber { get; set; }
        [ForeignKey("SubjectId")]
        public  int? SubjectId { get; set; }
        public  Subject? Subject { get; set; }
        [ForeignKey("ClassId")]
        public  int? ClassId { get; set; }
        public Class? Class { get; set; }
        public string? FormaAssociation { get; set; }    
        public string FormaListId { get; set; }

        public List<Forma>? Forma { get; set; }
        public string? FormaNames { get; set; }

        public string? SubjectLanguageId { get; set; }
        public SubjectLanguage? SubjectLanguages { get; set; }

        public string? SubjectTypeId { get; set; }
        public SubjectType? SubjectTypes { get; set; }

        [NotMapped]
        public List<int>? FormaIds { get; set; }

    }

}
