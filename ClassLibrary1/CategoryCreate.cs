using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [MinLength(2,ErrorMessage ="Category must be at least 2 characters")]
        [MaxLength(20)]
        public string CategoryName { get; set; }
    }
}
