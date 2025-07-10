using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL; 
using HotChocolate;
using NailPressApi.Data; 
using NailPressApi.GraphQL.Queries; 
using NailPressApi.GraphQL.Mutations; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NailPressDb>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("NailPressDb")));

// Add GraphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

// Add CORS policy (allow requests from Next.js dev/prod URLs)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowNextJS",
        policy => policy
            .WithOrigins(
                "http://localhost:3000"  // Next.js dev server
                // "https://your-production-nextjs-app.com"  // Production URL
            )
            .AllowAnyMethod()
            .AllowAnyHeader()
    );
});

var app = builder.Build();

// Enable CORS middleware
app.UseCors("AllowNextJS");

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

app.Run();
