using System.ComponentModel.DataAnnotations;

namespace backend_v1.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        [Required]
        public string List { get; set; } = string.Empty ;
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course() ;

    }
}
