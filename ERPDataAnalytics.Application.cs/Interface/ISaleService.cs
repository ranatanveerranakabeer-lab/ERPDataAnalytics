using ERPDataAnalytics.Application.cs.DTO.Sale;
using ERPDataAnalytics.Application.cs.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface ISaleService
    {
        Task<ResponseDataModel<SaleResponseDTO>> CreateSaleAsync(SaleCreateDTO dto);
        Task<ResponseDataModel<List<SaleResponseDTO>>> GetAllAsync();
        Task<ResponseDataModel<SaleResponseDTO>> GetByIdAsync(int id);
        Task<ResponseDataModel<SaleResponseDTO>> UpdateSaleAsync(SaleUpdateDTO dto);
        Task<ResponseDataModel<bool>> DeleteAsync(int id);
        Task<ResponseDataModel<List<SaleReportDTO>>> GetSaleReportAsync();
        Task<ResponseDataModel<List<SaleReportDTO>>> GetSaleReportByDateAsync(DateTime fromDate, DateTime toDate);
        Task<ResponseDataModel<List<SaleReportDTO>>> GetSaleReportByCustomerAsync(int customerId);
        Task<ResponseDataModel<SaleSummaryDTO>> GetSaleSummaryAsync();
    }
}