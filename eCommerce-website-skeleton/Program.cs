using eCommerce_website_skeleton.Data;
using eCommerce_website_skeleton.Data.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//IActorServices included from sect 8.
builder.Services.AddScoped<IActorsService, ActorsService>();
builder.Services.AddScoped <IProducersServices, ProducersServices>();
builder.Services.AddScoped<ICinemaservice, CinemaService>();
builder.Services.AddScoped<IMoviesService, MoviesService>();

// added at section 4.13 
var connectionString = builder.Configuration.GetConnectionString("DefaultconnectionString");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));



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

// initialise database of the app.
AppDbInitialiser.Seed(app);

app.Run();
