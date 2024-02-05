namespace SchoolApiService.Extensions
{
    public static class CorsExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "CorsPolicy",
                                  builder =>
                                  {
                                      builder
                                      .WithOrigins("" +
                                          "http://localhost:8080"
                                          )
                                      .AllowAnyHeader()
                                      .AllowAnyMethod()
                                      .AllowCredentials(); ;
                                  });
               
            });
        }
    }
}
