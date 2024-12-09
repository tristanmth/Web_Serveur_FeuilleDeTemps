using Universell.Metier.Services;

namespace Universell.ServicesInit
{
    public static class MetierInit
    {
        public static IServiceCollection AddMetier(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();

            return services;
        }
    }
}
