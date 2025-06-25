﻿namespace BlazorNotes.DataModels
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
