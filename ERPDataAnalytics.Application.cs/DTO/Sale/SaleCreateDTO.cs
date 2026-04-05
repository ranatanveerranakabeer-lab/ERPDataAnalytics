using System;
using System.Collections.Generic;

namespace ERPDataAnalytics.Application.cs.DTO.Sale
{
   
    public class SaleBaseDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    
    public class SaleCreateDTO
    {
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public string InvoiceNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }

        public decimal DiscountAmount { get; set; }
        public decimal PaidAmount { get; set; }

        public List<SaleItemDTO> Items { get; set; } = new();
    }

    public class SaleUpdateDTO
    {
        public int Id { get; set; }

        public decimal DiscountAmount { get; set; }
        public decimal PaidAmount { get; set; }

        public List<SaleItemDTO> Items { get; set; } = new();
    }

    public class SaleResponseDTO : SaleBaseDTO
    {
        public string InvoiceNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal PaidAmount { get; set; }

        public List<SaleItemDTO> Items { get; set; }
    }

    public class SaleReportDTO
    {
        public string InvoiceNumber { get; set; }
        public DateTime SaleDate { get; set; }

        public string CustomerName { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }

        public int TotalItems { get; set; }
    }
    public class SaleSummaryDTO
    {
        public decimal TotalSales { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal NetSales { get; set; }

        public decimal TotalReceived { get; set; }
        public decimal TotalPending { get; set; }

        public int TotalInvoices { get; set; }
        public int TotalItemsSold { get; set; }

        public decimal TodaySales { get; set; }
        public decimal MonthlySales { get; set; }
        public decimal YearlySales { get; set; }

        public decimal AverageSaleValue { get; set; }
        public decimal HighestSale { get; set; }
    }
    public class SaleItemDTO
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; } 

        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Total => Quantity * UnitPrice; 
    }
}