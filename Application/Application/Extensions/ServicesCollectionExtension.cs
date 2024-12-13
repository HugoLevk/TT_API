using Application.Services;
using Application.Settings;
using Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;

public static class ServicesCollectionExtension
{
    public static void AddApplication(this IServiceCollection services, ConfigurationManager configuration)
    {

        services.Configure<SmtpSettings>(configuration.GetSection("Smtp"));
        services.AddTransient<IEmailSender<User>, EmailSender>();

    }
}
