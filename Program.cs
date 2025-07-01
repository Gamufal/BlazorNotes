using BlazorNotes.Components;
using BlazorNotes.DataModels;
using BlazorNotes.Services;
using Microsoft.EntityFrameworkCore;


namespace BlazorNotes
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            // 2 Context needed to execute migration 
            builder.Services.AddDbContext<SQLServerDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));
            builder.Services.AddDbContext<NoteDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

            builder.Services.AddScoped<INoteService, NoteService>();

            // DB Migrator 
            builder.Services.AddTransient<NoteDbMigrator>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            using (var scope = app.Services.CreateScope())
            {
                var migrator = scope.ServiceProvider.GetRequiredService<NoteDbMigrator>();
                await migrator.MigrateAsync();
            }

            app.Run();
        }
    }
}
