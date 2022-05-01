using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("Test_Jobs")]
    public class Job
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobId { get; set; }

        [Required]
        public int JobTitleId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [MaxLength]
        public string City { get; set; }

        [MaxLength(3)]
        public string State { get; set; }

        public int? DescriptionLength { get; set; }

        public int? EducationLevel { get; set; }

        [Required]
        public int Clicks { get; set; }

        [Required]
        public int Applicants { get; set; }

        public JobTitle JobTitle { get; set; }

    }
}
