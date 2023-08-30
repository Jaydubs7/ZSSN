using ZSSN_Octoco_technical_assessment.Handles;
using ZSSN_Octoco_technical_assessment.IRepository;
using ZSSN_Octoco_technical_assessment.Repository;
using ZSSN_Octoco_technical_assessment.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDB"));

builder.Services.AddTransient<ISurvivorContext, SurvivorContext>();
builder.Services.AddTransient<ISurvivorRepository, SurvivorRepository>();
builder.Services.AddSingleton<SurvivorService>();
// Add services to the container.

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
