using ERPDataAnalytics.Application.cs.DTO.Sale;
using ERPDataAnalytics.Application.cs.Interface;
using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleInterface _repo;

        public SaleService(ISaleInterface repo)
        {
            _repo = repo;
        }

        public async Task<ResponseDataModel<SaleResponseDTO>> CreateSaleAsync(SaleCreateDTO dto)
        {
            try
            {
                if (dto.Items == null || !dto.Items.Any())
                    return ResponseDataModel<SaleResponseDTO>.FailureResponse("Items required");
                var sale = new Sale
                {
                    CompanyId = dto.CompanyId,
                    BranchId = dto.BranchId,
                    InvoiceNumber = dto.InvoiceNumber,
                    CustomerId = dto.CustomerId,
                    SaleDate = dto.SaleDate,
                    DiscountAmount = dto.DiscountAmount,
                    PaidAmount = dto.PaidAmount,
                    SaleItems = dto.Items.Select(x => new SaleItem
                    {
                        ProductId = x.ProductId,
                        Quantity = x.Quantity,
                        UnitPrice = x.UnitPrice,
                        Total = x.Quantity * x.UnitPrice
                    }).ToList()
                };

                var total = sale.SaleItems.Sum(x => x.Total);
                sale.TotalAmount = total;
                sale.NetAmount = total - sale.DiscountAmount;

                var result = await _repo.CreateSale(sale);

                return ResponseDataModel<SaleResponseDTO>.SuccessResponse(MapToResponse(result), "Sale Created Successfully");
            }
            catch (Exception ex)
            {
                return ResponseDataModel<SaleResponseDTO>.FailureResponse(ex.Message);
            }
        }

        public async Task<ResponseDataModel<List<SaleResponseDTO>>> GetAllAsync()
        {
            var data = await _repo.GetSaleList();
            var response = data.Select(MapToResponse).ToList();
            return ResponseDataModel<List<SaleResponseDTO>>.SuccessResponse(response);
        }

        public async Task<ResponseDataModel<SaleResponseDTO>> GetByIdAsync(int id)
        {
            var data = await _repo.GetSaleById(id);
            if (data == null)
                return ResponseDataModel<SaleResponseDTO>.FailureResponse("Sale not found");

            return ResponseDataModel<SaleResponseDTO>.SuccessResponse(MapToResponse(data));
        }

        public async Task<ResponseDataModel<bool>> DeleteAsync(int id)
        {
            var result = await _repo.DeleteSale(id);
            if (!result)
                return ResponseDataModel<bool>.FailureResponse("Sale not found");

            return ResponseDataModel<bool>.SuccessResponse(true, "Deleted Successfully");
        }

        public async Task<ResponseDataModel<SaleResponseDTO>> UpdateSaleAsync(SaleUpdateDTO dto)
        {
            try
            {

                var existing = await _repo.GetSaleById(dto.Id);
                if (existing == null)
                    return ResponseDataModel<SaleResponseDTO>.FailureResponse("Sale not found");

                existing.DiscountAmount = dto.DiscountAmount;
                existing.PaidAmount = dto.PaidAmount;
                existing.SaleItems.Clear();

                foreach (var item in dto.Items)
                {
                    existing.SaleItems.Add(new SaleItem
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                        Total = item.Quantity * item.UnitPrice
                    });
                }

                var total = existing.SaleItems.Sum(x => x.Total);
                existing.TotalAmount = total;
                existing.NetAmount = total - existing.DiscountAmount;

                var updated = await _repo.UpdateSale(existing);

                return ResponseDataModel<SaleResponseDTO>.SuccessResponse(MapToResponse(updated), "Updated Successfully");
            }
            catch (Exception ex)
            {
                return ResponseDataModel<SaleResponseDTO>.FailureResponse(ex.Message);
            }
        }

        public async Task<ResponseDataModel<List<SaleReportDTO>>> GetSaleReportAsync()
        {
            var data = await _repo.GetSaleList();
            var report = data.Select(x => new SaleReportDTO
            {
                InvoiceNumber = x.InvoiceNumber,
                SaleDate = x.SaleDate,
                CustomerName = "",
                TotalAmount = x.TotalAmount,
                DiscountAmount = x.DiscountAmount,
                NetAmount = x.NetAmount,
                TotalItems = x.SaleItems.Count
            }).ToList();

            return ResponseDataModel<List<SaleReportDTO>>.SuccessResponse(report);
        }

        public async Task<ResponseDataModel<List<SaleReportDTO>>> GetSaleReportByDateAsync(DateTime fromDate, DateTime toDate)
        {
            var data = await _repo.GetSaleList();
            var report = data
                .Where(x => x.SaleDate >= fromDate && x.SaleDate <= toDate)
                .Select(x => new SaleReportDTO
                {
                    InvoiceNumber = x.InvoiceNumber,
                    SaleDate = x.SaleDate,
                    CustomerName = "",
                    TotalAmount = x.TotalAmount,
                    DiscountAmount = x.DiscountAmount,
                    NetAmount = x.NetAmount,
                    TotalItems = x.SaleItems.Count
                }).ToList();

            return ResponseDataModel<List<SaleReportDTO>>.SuccessResponse(report);
        }

        public async Task<ResponseDataModel<List<SaleReportDTO>>> GetSaleReportByCustomerAsync(int customerId)
        {
            var data = await _repo.GetSaleList();
            var report = data
                .Where(x => x.CustomerId == customerId)
                .Select(x => new SaleReportDTO
                {
                    InvoiceNumber = x.InvoiceNumber,
                    SaleDate = x.SaleDate,
                    CustomerName = "",
                    TotalAmount = x.TotalAmount,
                    DiscountAmount = x.DiscountAmount,
                    NetAmount = x.NetAmount,
                    TotalItems = x.SaleItems.Count
                }).ToList();

            return ResponseDataModel<List<SaleReportDTO>>.SuccessResponse(report);
        }

        public async Task<ResponseDataModel<SaleSummaryDTO>> GetSaleSummaryAsync()
        {
            var data = await _repo.GetSaleList();

            var summary = new SaleSummaryDTO
            {
                TotalSales = data.Sum(x => x.TotalAmount),
                TotalDiscount = data.Sum(x => x.DiscountAmount),
                NetSales = data.Sum(x => x.NetAmount),
                TotalReceived = data.Sum(x => x.PaidAmount),
                TotalPending = data.Sum(x => x.NetAmount - x.PaidAmount),
                TotalInvoices = data.Count,
                TotalItemsSold = data.SelectMany(x => x.SaleItems).Sum(i => (int)i.Quantity),
                TodaySales = data.Where(x => x.SaleDate.Date == DateTime.Today).Sum(x => x.NetAmount),
                MonthlySales = data.Where(x => x.SaleDate.Month == DateTime.Today.Month && x.SaleDate.Year == DateTime.Today.Year).Sum(x => x.NetAmount),
                YearlySales = data.Where(x => x.SaleDate.Year == DateTime.Today.Year).Sum(x => x.NetAmount),
                AverageSaleValue = data.Any() ? data.Average(x => x.NetAmount) : 0,
                HighestSale = data.Any() ? data.Max(x => x.NetAmount) : 0
            };

            return ResponseDataModel<SaleSummaryDTO>.SuccessResponse(summary);
        }

        private SaleResponseDTO MapToResponse(Sale x)
        {
            return new SaleResponseDTO
            {
                Id = x.Id,
                InvoiceNumber = x.InvoiceNumber,
                CustomerId = x.CustomerId,
                SaleDate = x.SaleDate,
                TotalAmount = x.TotalAmount,
                DiscountAmount = x.DiscountAmount,
                NetAmount = x.NetAmount,
                PaidAmount = x.PaidAmount,
                Items = x.SaleItems.Select(i => new SaleItemDTO
                {
                    ProductId = x.Id,
                    Quantity = i.Quantity,
                    UnitPrice = i.UnitPrice
                }).ToList()
            };
        }
    }
}