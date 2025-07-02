using System.ComponentModel.DataAnnotations;

namespace BlazorNotes.DataModels
{
    public class Note
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany.")]
        [StringLength(100, ErrorMessage = "Tytuł może mieć maksymalnie 100 znaków.")]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000, ErrorMessage = "Treść może mieć maksymalnie 1000 znaków.")]
        public string Content { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
