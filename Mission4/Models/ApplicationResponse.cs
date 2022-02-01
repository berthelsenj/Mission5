using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        //Build Foreign Key Relationship for Category
        [Required(ErrorMessage ="Select a movie category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public string Title { get; set; }
        public short Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
