using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Universell.DomainsInit;
using Universell.ServicesInit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.
    AddDatabaseAndIdentityService(builder.Configuration)
    .AddMetier()
    .ConfigureApplicationCookie(options =>
    {
        options.LoginPath = "/Account/Login"; // Chemin de la page de connexion
        options.AccessDeniedPath = "/Account/AccessDenied"; // (Facultatif) Page d'accès interdit
    })
    .AddControllersWithViews(options =>
    {
        var policy = new AuthorizationPolicyBuilder()
            .RequireAuthenticatedUser()
            .Build();
        options.Filters.Add(new AuthorizeFilter(policy));
    });


var app = builder.Build();

// Créer les rôles au démarrage (si nécessaires)
using (var scope = app.Services.CreateScope())
{
    await scope.MigrationsAndSeedingAsync();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
