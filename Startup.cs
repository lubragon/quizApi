using Microsoft.EntityFrameworkCore;



namespace Elevate.QuizApi{
    
    public class Startup
    {

        public IConfiguration? Configuration {get;}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}