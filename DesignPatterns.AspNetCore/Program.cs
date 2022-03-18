using DesignPatterns.AspNetCore.Configuration;
using DesignPatterns.Repository;
using DesignPatterns.Models.Data;
using DesignPatterns.Tools.FactoryMethod;
using DesignPatterns.Tools.Builder;

var builder = WebApplication.CreateBuilder(args);

var appSettings = builder.Configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection(nameof(AppSettings)));
builder.Services.AddTransient((factory) => new LocalEarnFactory(appSettings.LocalPercentage));
builder.Services.AddTransient((factory) => new ForeignEarnFactory(appSettings.ForeignPercentage, appSettings.Extra));
builder.Services.AddDbContext<DesignPatternsContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<GeneratorConcreteBuilder>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
