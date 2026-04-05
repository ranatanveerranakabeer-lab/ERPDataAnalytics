using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Entities
{
   
        public class Sale
        {
            public int Id { get; set; }
            public int CompanyId { get; set; }
            public int BranchId { get; set; }
            public string InvoiceNumber { get; set; }
            public int CustomerId { get; set; }
            public DateTime SaleDate { get; set; }
            public decimal TotalAmount { get; set; }
            public decimal DiscountAmount { get; set; }
            public decimal NetAmount { get; set; }
            public decimal PaidAmount { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        }
    }

