using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlaygroundDemo.Bookstore.Dto
{
    public class EditAuthorInput
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(AuthorConsts.MaxNameLength)]
        public virtual string FullName { get; set; }

        [Required]
        public virtual int Age { get; set; }

        [EmailAddress]
        [MaxLength(AuthorConsts.MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual string Phone { get; set; }
    }

    public class GetAuthorForEditOutput
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
    }

    public class GetAuthorForEditInput
    {
        public int Id { get; set; }
    }
}
