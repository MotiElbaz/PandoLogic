using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("Test_JobTitles")]
    public class JobTitle
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobTitleId { get; set; }

        [MaxLength]
        [Required]
        public string JobTitleName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public IEnumerable<Job> Jobs { get; set; }

    }
}
