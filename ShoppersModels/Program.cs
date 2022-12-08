namespace ShoppersModels
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}"));

            app.Run();
        }
    }
}