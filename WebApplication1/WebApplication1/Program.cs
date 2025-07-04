using System.IO;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;

namespace WebApplication1
{
    public class Program
    {
       // Called when the app starts.

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //create the app
        // Builds the WebApplication instance using all the services registered above.
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //Checks if the current environment is Development.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //- Serves static content such as CSS, JavaScript, and images from the wwwroot directory.
            app.UseStaticFiles();
            
            //Enables endpoint routing to match incoming HTTP requests to routes.
            app.UseRouting();
            
            //Adds a step in the pipeline to authorize user access to secure parts of your app.
            app.UseAuthorization();

            // Defines the default routing pattern for incoming requests:
            // If no controller/action is specified, it goes to HomeController.Index()
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //This starts the web server and begins listening for requests.
            // Starts the HTTP server and begins processing incoming HTTP requests
            app.Run();
        }
    }
}
