using FileApiLesson.Application.Service.UserProfilService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApiLesson.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {

            services.AddScoped<IUserProfilService, UserProfileService>();

            return services;
        }
    }
}
