
using secondapi.Controllers;
using secondapi.Service;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<ReverseAlphabetService>();
builder.Services.AddScoped<ReverseIntService>();
builder.Services.AddOpenApi();
  

var app = builder.Build();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI();}

app.UseHttpsRedirection();





app.Run();