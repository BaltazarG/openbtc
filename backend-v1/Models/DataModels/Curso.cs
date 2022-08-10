using backend_v1.enums;
using System.ComponentModel.DataAnnotations;

namespace backend_v1.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string LongDescription { get; set; } = string.Empty;

        [Required]
        public string TargetAudiences { get; set; } = string.Empty;

        [Required]
        public string Objectives { get; set; } = string.Empty;

        [Required]
        public string Requirements { get; set; } = string.Empty;

        [Required]
        public Level Level { get; set; }

        
    }
}
