
using ERPDataAnalytics.Application.cs.Interface;
using ERPDataAnalytics.Application.cs.Services;
using ERPDataAnalytics.domain.cs.Interface;
using ERPDataAnalytics.Infrastructure.cs;
using ERPDataAnalytics.Infrastructure.cs.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));


builder.Services.AddScoped<ICompanyInterface, CompanyRepository>();
builder.Services.AddScoped<IBranchInterface, BranchRepository>();
builder.Services.AddScoped<IDepartmentInterface, DepartmentRepository>();
builder.Services.AddScoped<IDesignationInterface, DesignationRepository>();
builder.Services.AddScoped<IUserInterface, UserRepository>();
builder.Services.AddScoped<IEmployeeInterface, EmployeeRepository>();
builder.Services.AddScoped<IShiftInterface, ShiftRepository>();
builder.Services.AddScoped<IAttendanceInterface, AttendanceRepository>();
builder.Services.AddScoped<IPayrollInterface, PayrollRepository>();
builder.Services.AddScoped<ICustomerInterface, CustomerRepository>();
builder.Services.AddScoped<IVendorInterface, VendorRepository>();
builder.Services.AddScoped<ICategoryInterface, CategoryRepository>();
builder.Services.AddScoped<IProductInterface, ProductRepository>();
builder.Services.AddScoped<ISaleInterface, SaleRepository>();
builder.Services.AddScoped<ISaleItemInterface, SaleItemRepository>();
builder.Services.AddScoped<IPurchaseInterface, PurchaseRepository>();
builder.Services.AddScoped<IPurchaseItemInterface, PurchaseItemRepository>();
builder.Services.AddScoped<IExpenseInterface, ExpenseRepository>();
builder.Services.AddScoped<IStockTransactionInterface, StockTransanctionRepository>();

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IDesignationService, DesignationService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IShiftService, ShiftService>();
builder.Services.AddScoped<IAttendanceService, AttendanceService>();
builder.Services.AddScoped<IPayrollService, PayrollService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IVendorService, VendorService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddScoped<ISaleItemService, SaleItemService>();
builder.Services.AddScoped<IPurchaseService, PurchaseService>();
builder.Services.AddScoped<IPurchaseItemService, PurchaseItemService>();
builder.Services.AddScoped<IExpenseService, ExpenseService>();
builder.Services.AddScoped<IStockTransactionService, StockTransactionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
