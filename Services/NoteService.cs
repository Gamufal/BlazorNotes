using BlazorNotes.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorNotes.Services
{
    public class NoteService : INoteService
    {
        private readonly NoteDbContext _context;

        public NoteService(NoteDbContext context)
        {
            _context = context;
        }

        public async Task<List<Note>> GetAllAsync()
        {
            return await _context.Notes.OrderByDescending(x => x.ModifiedDate).ToListAsync();
        }

        public async Task<Note?> GetByIdAsync(int id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public async Task AddAsync(Note note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Note note)
        {
            _context.Notes.Update(note);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }
        //--- end of class marker ---
    }
}
