using Microsoft.EntityFrameworkCore;
using BlazorNotes.DataModels;

namespace BlazorNotes.DataModels
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes => Set<Note>();
        {
        }
    }
}
