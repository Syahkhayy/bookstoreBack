using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Abp.Domain.Entities.Auditing;


namespace PlaygroundDemo.Bookstore
{
    [Table("PbBooks")]
    public class Book : FullAuditedEntity
    {
        [Required]
        [MaxLength(BookConsts.MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        public string YearPublish { get; set; }

        [Required]
        public string GenresString { get; set; }

        [NotMapped]
        public ICollection<Genre> Genres
        {
            get
            {
                return GenresString?.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(s => Enum.Parse<Genre>(s))
                                    .ToList() ?? new List<Genre>();
            }
            set
            {
                GenresString = string.Join(',', value);
            }
        }

        public string Summary { get; set; }

        // Primary Author
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        public virtual int AuthorId { get; set; }

        // Collaborating Authors
        public ICollection<Author> Collaborators { get; set; }
    }

}
