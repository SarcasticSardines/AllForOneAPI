using AllForOneAPI.Services.Alligator;
using AllForOneAPI.Services.FeedMe;
using AllForOneAPI.Services.MadLibs;
using AllForOneAPI.Services.Magic8;
using AllForOneAPI.Services.MakeSentence;
using AllForOneAPI.Services.OddorEven;
using AllForOneAPI.Services.ReverseAlpha;
using AllForOneAPI.Services.ReverseNum;
using AllForOneAPI.Services.SayHello;
using AllForOneAPI.Services.Sums;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy",
    builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISayHelloService, SayHelloService>();
builder.Services.AddScoped<ISumsService, SumsService>();
builder.Services.AddScoped<IMakeSentenceService, MakeSentenceService>();
builder.Services.AddScoped<IAlligatorService, AlligatorService>();
builder.Services.AddScoped<IMadLibsService, MadLibsService>();
builder.Services.AddScoped<IOddorEvenService, OddorEvenService>();
builder.Services.AddScoped<IReverseAlphaService, ReverseAlphaService>();
builder.Services.AddScoped<IReverseNumService, ReverseNumService>();
builder.Services.AddScoped<IMagic8Service, Magic8Service>();
builder.Services.AddScoped<IFeedMeService, FeedMeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CORSPolicy");

app.MapControllers();

app.Run();
