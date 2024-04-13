using System.ComponentModel.DataAnnotations;
namespace RazorPagesQuiz.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
