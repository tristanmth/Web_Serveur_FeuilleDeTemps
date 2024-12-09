using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Universell.Domain;
using Universell.Domain.Entities;
using Universell.Utils.Constants;

namespace Universell.DomainsInit
{
    public static class DatabaseServiceInit
    {

        public static IServiceCollection AddDatabaseAndIdentityService(this IServiceCollection services, ConfigurationManager configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<UniversellDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<Utilisateur>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = true;
                options.SignIn.RequireConfirmedAccount = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<UniversellDbContext>();

            return services;
        }

        public async static Task MigrationsAndSeedingAsync(this IServiceScope serviceScope)
        {
            var services = serviceScope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<UniversellDbContext>();
                context.Database.Migrate(); // Applique toutes les migrations non appliquées
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                await roleManager.SeedRolesAsync(); // Fonction pour ajouter les rôles

                var userManager = services.GetRequiredService<UserManager<Utilisateur>>();
                await roleManager.SeedAdminUserAsync(userManager); // Fonction pour ajouter un admin par défaut
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'initialisation des rôles : {ex.Message}");
            }
        }

        private async static Task SeedRolesAsync(this RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync(Constants.Roles.Administrateur))
            {
                await roleManager.CreateAsync(new IdentityRole(Constants.Roles.Administrateur));
            }

            if (!await roleManager.RoleExistsAsync(Constants.Roles.Utilisateur))
            {
                await roleManager.CreateAsync(new IdentityRole(Constants.Roles.Utilisateur));
            }

        }

        private async static Task SeedAdminUserAsync(this RoleManager<IdentityRole> roleManager, UserManager<Utilisateur> userManager)
        {
            var adminUsername = "admin";
            var adminEmail = "admin@universell.com"; // Email de l'admin par défaut
            var adminPassword = "Z;nklkaezd61654azdZK*";      // Mot de passe sécurisé

            var adminUser = await userManager.FindByNameAsync(adminUsername);
            if (adminUser == null)
            {
                adminUser = new Utilisateur { Nom = adminUsername, Email = adminEmail };
                var result = await userManager.CreateAsync(adminUser, adminPassword);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, Constants.Roles.Administrateur);
                }
            }
        }
    }
}
