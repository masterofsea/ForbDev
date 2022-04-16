using ForbexBAL.MailBox.MessageBuilding.Contracts;
using ForbexBAL.MailBox.MessageBuilding.Implementations;
using ForbexDAL.DbContexts;
using ForbexDAL.Repositories.Contracts;
using ForbexDAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ForbexDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("MainConnection"), 
        assembly => assembly.MigrationsAssembly(typeof(ForbexDbContext).Assembly.FullName)));

builder.Services.AddSingleton<IContractsRepository, MockContractsRepository>();
builder.Services.AddTransient<ITemplatesRepository, TemplatesRepository>();
builder.Services.AddTransient<IMessageBuilder, MessageBuilder>();
builder.Services.AddSingleton<ICorrespondenceRepository, MockCorrespondenceRepository>();
builder.Services.AddSingleton<IPartnersRepository, MockPartnerRepository>();

builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddScoped<DialogService>();

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();