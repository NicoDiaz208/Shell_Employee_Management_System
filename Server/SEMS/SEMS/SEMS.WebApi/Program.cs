using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SEMS.Logic.Controllers;
using SEMS.Logic.Controllers.JWT;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//JWT Authentication                               //ND
builder.Services.AddAuthentication(x =>
{
	x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
	var Key = Encoding.UTF8.GetBytes(builder.Configuration["User:JWTKey"]);
	o.SaveToken = true;
	o.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuer = false,
		ValidateAudience = false,
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
		ValidIssuer = builder.Configuration["JWT:Issuer"],
		ValidAudience = builder.Configuration["JWT:Audience"],
		IssuerSigningKey = new SymmetricSecurityKey(Key)
	};
});

//builder.Services.AddSingleton<IJWTManagerController, JWTManagerController>();

// Add Controllers

builder.Services.AddControllers();

//Dependency Injection                            //ND
builder.Services.AddTransient<PersonController>();
builder.Services.AddTransient<UserController>();
//builder.Services.AddTransient<JWTManagerController>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var devCorsPolicy = "devCorsPolicy";
builder.Services.AddCors(options =>
{
	options.AddPolicy(devCorsPolicy, builder => {
		//builder.WithOrigins("http://localhost:800").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
		builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
		//builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
		//builder.SetIsOriginAllowed(origin => true);
	});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
	app.UseCors(devCorsPolicy);
}

app.UseHttpsRedirection();

app.UseAuthentication();	//For JWT

app.UseAuthorization();

app.MapControllers();

app.Run();
