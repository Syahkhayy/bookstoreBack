using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace PlaygroundDemo.Bookstore
{
    [Table("PbAuthors")]
    public class Author : FullAuditedEntity
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

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Book> CollaboratedBooks { get; set; }
    }
}
