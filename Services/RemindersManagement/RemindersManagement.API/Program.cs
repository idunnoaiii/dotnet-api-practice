using Microsoft.EntityFrameworkCore;
using RemindersManagement.API.Domain.Interfaces;
using RemindersManagement.API.Domain.Services;
using RemindersManagement.API.Infrastructure.Data;
using RemindersManagement.API.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddScoped<IRemindersRepository, RemindersRepository>();
builder.Services.AddScoped<IRemindersService, RemindersService>();
builder.Services.AddDbContext<RemindersDbContext>(options => {
    options.UseSqlite("Data Source=FriendReminders.db");
});


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
