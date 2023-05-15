using Domain.Interfaces.Generic;
using Domain.Servicos;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repositories.Generics;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Domain.Interfaces.ICategory;
using Domain.Interfaces.IExpense;
using Domain.Interfaces.IFinancialSystem;
using Domain.Interfaces.ServiceInterface;
using Domain.Interfaces.IUserFinancialSystem;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContextBase>(options =>
               options.UseSqlServer(
                   builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ContextBase>();



// INTERFACE E REPOSITORIO
builder.Services.AddSingleton(typeof(InterfaceGeneric<>), typeof(RepositoryGenerics<>));
builder.Services.AddSingleton<ICategory, RepositorioCategoria>();
builder.Services.AddSingleton<IExpense, RepositorioDespesa>();
builder.Services.AddSingleton<IFinancialSystem, RepositorioSistemaFinanceiro>();
builder.Services.AddSingleton<IUserFinancialService, RepositorioUsuarioSistemaFinanceiro>();


// SERVIÇO DOMINIO
builder.Services.AddSingleton<IServiceCategory, CategoriaServico>();
builder.Services.AddSingleton<IExpenseService, DespesaServico>();
builder.Services.AddSingleton<IFinancialSystemService, SistemaFinanceiroServico>();
builder.Services.AddSingleton<IUserFinancial, UsuarioSistemaFinanceiroServico>();

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
