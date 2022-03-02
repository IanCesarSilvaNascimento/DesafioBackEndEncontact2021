
using Notebook.Domain.Handlers;
using Notebook.Domain.Infra.Contexts;
using Notebook.Domain.Infra.Repositories;
using Notebook.Domain.Repositories;

namespace Notebook.Domain.Api;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddDbContext<DataContext>();
        services.AddTransient<ICompanyRepository, CompanyRepository>();
        services.AddTransient<CompanyHandler, CompanyHandler>();

        
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();

        app.UseHttpsRedirection();

        app.UseRouting();
        app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());


        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}


