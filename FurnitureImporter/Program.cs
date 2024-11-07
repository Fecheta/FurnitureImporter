using FurnitureImporter.Root;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add CORS policy to allow any origin, method, and header
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll",
                policy => policy
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });

        // Add services to the container
        builder.Services.AddControllers();

        // Swagger configuration (for development)
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Custom modules (like FurnitureImporter)
        builder.Services.ConfigureFurnitureImporterModule();

        var app = builder.Build();

        // Serve default files and static files
        app.UseDefaultFiles();
        app.UseStaticFiles();

        // Configure the HTTP request pipeline
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        // Apply CORS policy (AllowAll) before Authorization
        app.UseCors("AllowAll");

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}