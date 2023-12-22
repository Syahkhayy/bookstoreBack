using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaygroundDemo.Bookstore.Dto
{
    public class AuthorListDto : FullAuditedEntityDto
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
    }

}
