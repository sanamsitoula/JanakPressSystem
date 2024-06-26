﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class P2M
    {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; }
        public string ?P2M_Code { get; set; }// 
     
        public int ?ProductId { get; set; }
        public Product ?Product { get; set; }
        [Required]
        public int ClassId { get; set; }
        public Class ?Class { get; set; }
        public DateTime? P2MDate { get; set; }
        public DateTime? ReportDate { get; set; }


        public int? JobTicketId { get; set; }
        public JobTicket? JobTicket { get; set; }
        
        public int? FormaNumber { get; set; }


        public int? PerPokaSize { get; set; }
        public DropdownV? DropdownV { get; set; }
        public int? PokaNumber { get; set; }
        public int? ProductQuantity { get; set; }

        public int? PiecesQuantity { get; set; } //khaudra
        public int? TotalProductQuantity { get; set; }

       
        public string? JobStepId { get; set; }
        public JobStep? JobStep { get; set; }
        
        public bool? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string? Desc { get; set; } // 
        public string? Remarks { get; set; }
        public int? CheckedById { get; set; }
        public int? VerifiedById { get; set; }
        public int? ReceivedById { get; set; }
        public int? FiscalYear { get; set; }

        public int? SubjectId { get; set; }
        public Subject? Subject { get; set; }

    }

    public class PaginatedViewModel<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);
        //public IEnumerable<T> sItems { get; set; }

    }
}
