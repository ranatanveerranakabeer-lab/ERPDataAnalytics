using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Entities
{
    public class StockTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public string? TransactionType { get; set; } //in or out
        public decimal Quantity { get; set; }
        public DateTime TransactionDate { get; set; }= DateTime.Now;
    }
}
