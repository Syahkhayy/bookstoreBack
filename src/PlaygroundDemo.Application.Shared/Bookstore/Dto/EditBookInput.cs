using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlaygroundDemo.Bookstore.Dto
{
    public class EditBookInput
    {
       public int Id { get; set; }
        [Required]
        [MaxLength(BookConsts.MaxTitleLength)]
        public string Title { get; set; }
        [Required]
        public string YearPublish { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public string Summary { get; set; }
        [Range(1, int.MaxValue)]
        public int AuthorId { get; set; }
        public List<int> CollaboratorsId { get; set; }
    }

    public class GetBookForEditOutput
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearPublish { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public string Summary { get; set; }
        public int AuthorId { get; set; }
        public List<int> CollaboratorsId { get; set; }
    }

    public class GetBookForEditInput
    {
        public int Id { get; set; }
    }
}
