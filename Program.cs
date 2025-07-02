using BlazorNotes.Components;
using BlazorNotes.DataModels;
using BlazorNotes.Services;
using Microsoft.EntityFrameworkCore;


namespace BlazorNotes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Razor Components 
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            // SQLite Database Context
            builder.Services.AddDbContext<NoteDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            // NoteService Interface
            builder.Services.AddScoped<INoteService, NoteService>();
            // DB Migrator - Not needed after migration
            //builder.Services.AddTransient<NoteDbMigrator>();
            // OLD SQL Server Database Context
            //builder.Services.AddDbContext<SQLServerDbContext>(options =>
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));

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

            // OLD initialization of database migration at startup
            //using (var scope = app.Services.CreateScope())
            //{
            //    var migrator = scope.ServiceProvider.GetRequiredService<NoteDbMigrator>();
            //    await migrator.MigrateAsync();
            //}

            app.Run();
        }
    }
}
