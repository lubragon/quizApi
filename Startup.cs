using Microsoft.EntityFrameworkCore;



namespace Elevate.QuizApi{
    
    public class Startup
    {

        public IConfiguration? Configuration {get;}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // public void ConfigureServices(IServiceCollection services)
        // {   
        //     services.AddDbContext<Context>(options => 
        //         options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
        //             new MySqlServerVersion(new Version(8, 0, 21))));

        // }
    }
}