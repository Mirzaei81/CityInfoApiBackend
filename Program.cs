using CityInfoApi.Models_new;
using CityInfoApi.Repositories;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.SwaggerGen;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers()
     .AddJsonOptions(options =>
     {
         options.JsonSerializerOptions.PropertyNamingPolicy = null;
         options.JsonSerializerOptions.IncludeFields = true;
         options.JsonSerializerOptions.WriteIndented = true;
     });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<iCityInfoReposit, CityInfoRepository>();
builder.Services.AddScoped<IAuth,AuthRepository>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddDbContext<AlmasMainContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AlmasMain")!)
    );
builder.Services.AddDbContext<AlmasACC14031Context>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
