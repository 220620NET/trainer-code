using Xunit;
using Microsoft.EntityFrameworkCore;
using Services;
using Models;
using System.Threading.Tasks;
using DataAccess;
using System;
using Microsoft.AspNetCore.Mvc.Testing;


namespace IntegrationTest;

public class IntegrationTestClass
{
    private readonly WebApplicationFactory<Program> _factory;

    public IntegrationTestClass(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }
    [Fact]
    public async Task HelloWorld()
    {
        var application = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => {
            builder.ConfigureServices(services => 
            {
                services.

                using (var scope = serviceProvider.CreateScope())
                {
                    var scopedServices = scope.serviceProvider;
                    var db = scopedServices.GetRequiredService<PokeDbContext>();

                    try
                    {
                        Utilities.ReinitializeDbForTests(db);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Something bad happened");
                        Console.WriteLine(ex.Message);
                    }
                }
            });
            // builder.ConfigureServices(services => services.AddDbContext<PokeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EFCorePokeDB"))));

            // builder.ConfigureServices(services => services.AddScoped<IPokemonTrainerRepository, EFCPokeTrainerRepo>());
            // // builder.ConfigureServices.AddScoped<IPokemonRepository, EFCPokemonRepo>();

            // //----------ConfigureServices---------------
            // builder.ConfigureServices.AddScoped<AuthService>();
            // builder.ConfigureServices.AddScoped<PokeTrainerService>();
            // builder.ConfigureServices.AddScoped<PokemonService>();

            // builder.ConfigureServices.AddControllers();
        });

        var client = application.CreateClient();

    }
}