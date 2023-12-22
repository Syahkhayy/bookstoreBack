using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PlaygroundDemo.Bookstore.Dto
{
    public class BookListDto : FullAuditedEntityDto
    {
        public string Title { get; set; }
        public string YearPublish { get; set; }
        public List<string> Genres { get; set; }
        public string Summary { get; set; }
        public AuthorInBookListDto Author { get; set; }
        public ICollection<AuthorInBookListDto> Collaborators { get; set; }
    }

    public class AuthorInBookListDto : FullAuditedEntityDto
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
    }
}
