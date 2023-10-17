using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.BottomGridRepositories;
using RealEstateDapperAPI.Repositories.CategoryRepository;
using RealEstateDapperAPI.Repositories.EmployeeRepositories;
using RealEstateDapperAPI.Repositories.PopularLocationRepositories;
using RealEstateDapperAPI.Repositories.ProductRepository;
using RealEstateDapperAPI.Repositories.ServiceRepository;
using RealEstateDapperAPI.Repositories.StatisticsRepositories;
using RealEstateDapperAPI.Repositories.TestimonialRepositories;
using RealEstateDapperAPI.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
