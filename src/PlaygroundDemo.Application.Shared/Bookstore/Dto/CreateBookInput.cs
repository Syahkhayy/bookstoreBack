using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PlaygroundDemo.Bookstore;

namespace PlaygroundDemo.Bookstore.Dto
{
    public class CreateBookInput
    {
        [Required]
        [MaxLength(BookConsts.MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        public string YearPublish { get; set; }
        [Required]
        public ICollection<Genre> Genres { get; set; }
        public string Summary { get; set; }

        [Range(1, int.MaxValue)]
        public int AuthorId { get; set; }

        public List<int> CollaboratorsId { get; set; }
    }
}
