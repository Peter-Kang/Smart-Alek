using GrammarNazi.App.HostedServices;
using GrammarNazi.Core;
using GrammarNazi.Core.Clients;
using GrammarNazi.Core.Repositories;
using GrammarNazi.Core.Services;
using GrammarNazi.Domain.Clients;
using GrammarNazi.Domain.Repositories;
using GrammarNazi.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Telegram.Bot;
using Tweetinvi;
using Tweetinvi.Models;

namespace GrammarNazi.App
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<GrammarNaziContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            // Hosted services
            services.AddHostedService<TelegramBotHostedService>();
            services.AddHostedService<TwitterBotHostedService>();

            ConfigureDependencies(services);
        }

        private static void ConfigureDependencies(IServiceCollection services)
        {
            // Repository
            services.AddTransient(typeof(IRepository<>), typeof(EFRepository<>));
            services.AddTransient<DbContext, GrammarNaziContext>();

            // Services
            services.AddSingleton<IFileService, FileService>();
            services.AddSingleton<IStringDiffService, StringDiffService>();
            services.AddTransient<ILanguageToolApiClient, LanguageToolApiClient>();
            services.AddTransient<IChatConfigurationService, ChatConfigurationService>();
            services.AddTransient<ILanguageService, NTextCatLanguageService>();
            services.AddTransient<IGrammarService, LanguageToolApiService>();
            services.AddTransient<IGrammarService, InternalFileGrammarService>();
            services.AddTransient<ITwitterLogService, TwitterLogService>();

            // Telegram client
            services.AddTransient<ITelegramBotClient>(_ =>
            {
                var apiKey = Environment.GetEnvironmentVariable("TELEGRAM_API_KEY");

                if (string.IsNullOrEmpty(apiKey))
                    throw new InvalidOperationException("Empty TELEGRAM_API_KEY");

                return new TelegramBotClient(apiKey);
            });

            // Twitter client
            services.AddSingleton<ITwitterClient>(_ =>
            {
                var consumerKey = Environment.GetEnvironmentVariable("TWITTER_CONSUMER_KEY");
                var consumerSecret = Environment.GetEnvironmentVariable("TWITTER_CONSUMER_SECRET");
                var accessToken = Environment.GetEnvironmentVariable("TWITTER_ACCESS_TOKEN");
                var accessTokenSecret = Environment.GetEnvironmentVariable("TWITTER_ACCESS_TOKEN_SECRET");

                return new TwitterClient(consumerKey, consumerSecret, accessToken, accessTokenSecret);
            });
        }

        private void EnsureDatabaseCreated(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetService<DbContext>();
            context.Database.EnsureCreated();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Create Database if not exist
            EnsureDatabaseCreated(app);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                // Return 200 if request is received
                endpoints.MapGet("/", async context =>
                {
                    context.Response.StatusCode = 200;
                    await context.Response.WriteAsync("App Running");
                });
            });
        }
    }
}