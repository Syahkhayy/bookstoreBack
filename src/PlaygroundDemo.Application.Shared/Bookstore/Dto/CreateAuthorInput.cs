using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlaygroundDemo.Bookstore.Dto
{
    public class CreateAuthorInput
    {
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
}
