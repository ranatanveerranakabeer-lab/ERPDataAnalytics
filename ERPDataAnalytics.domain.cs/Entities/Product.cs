using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        public int BranchId { get; set; }
        public int CategoryId { get; set; }
        public string? ProductName { get; set; }
        public string? SKU { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal StockQuantity { get; set; }
        public bool IsActive { get; set; }
    }
}
