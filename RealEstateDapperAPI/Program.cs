using RealEstateDapperAPI.Hubs;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.BottomGridRepositories;
using RealEstateDapperAPI.Repositories.CategoryRepository;
using RealEstateDapperAPI.Repositories.ContactRepositories;
using RealEstateDapperAPI.Repositories.EmployeeRepositories;
using RealEstateDapperAPI.Repositories.EstateAgentRepositories.ChartRepositories;
using RealEstateDapperAPI.Repositories.PopularLocationRepositories;
using RealEstateDapperAPI.Repositories.ProductRepository;
using RealEstateDapperAPI.Repositories.ServiceRepository;
using RealEstateDapperAPI.Repositories.StatisticsRepositories;
using RealEstateDapperAPI.Repositories.TestimonialRepositories;
using RealEstateDapperAPI.Repositories.ToDoListRepositories;
using RealEstateDapperAPI.Repositories.WhoWeAreRepository;
using RealEstateDapperUI.Services;

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
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
builder.Services.AddTransient<RealEstateDapperAPI.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories.IStatisticsRepository, RealEstateDapperAPI.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories.StatisticsRepository>();
builder.Services.AddTransient<IChartRepository, ChartRepository>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});
builder.Services.AddHttpClient();

builder.Services.AddSignalR();

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

app.UseCors("CorsPolicy");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();
