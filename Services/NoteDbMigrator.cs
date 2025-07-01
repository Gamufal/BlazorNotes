﻿using BlazorNotes.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorNotes.Services
{
    public class NoteDbMigrator
    {
        private readonly SQLServerDbContext _sourceDb;
        private readonly NoteDbContext _targetDb;

        public NoteDbMigrator(SQLServerDbContext sourceDb, NoteDbContext targetDb)
        {
            _sourceDb = sourceDb;
            _targetDb = targetDb;
        }

        public async Task MigrateAsync()
        {
            var existingData = await _targetDb.Notes.AnyAsync();

            if(existingData)
            {
                return;
            }

            var noteData = await _sourceDb.Notes.ToListAsync();
            await _targetDb.Notes.AddRangeAsync(noteData);
            await _targetDb.SaveChangesAsync();
        }
    }
}
