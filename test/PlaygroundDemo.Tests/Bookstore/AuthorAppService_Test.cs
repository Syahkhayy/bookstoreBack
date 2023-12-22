using PlaygroundDemo.Bookstore;
using PlaygroundDemo.Bookstore.Dto;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PlaygroundDemo.Tests.Bookstore
{
    public class AuthorAppService_Test : AppTestBase
    {
        private readonly IAuthorAppService _authorAppService;

        public AuthorAppService_Test()
        {
            // Resolve = resolve to get back the real IPersonAppService
            _authorAppService = Resolve<IAuthorAppService>();
        }

        [Fact]
        // FOR TASK, NEED TO USE ASYNC AND AWAIT
        public async Task Should_Create_Person_With_Valid_Arguments()
        {
            //Act
            await _authorAppService.CreateAuthor(
                new CreateAuthorInput
                {
                    FullName = "John Cena",
                    Age = 43,
                    EmailAddress = "johncena123@gmail.com"
                });

            //Assert
            UsingDbContext(
                context =>
                {
                    var john = context.Authors.FirstOrDefault(p => p.EmailAddress == "johncena123@gmail.com");
                    john.ShouldNotBe(null);
                    john.FullName.ShouldBe("John Cena");
                });
        }
    }
}
