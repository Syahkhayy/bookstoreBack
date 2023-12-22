using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using PlaygroundDemo.Bookstore;
using PlaygroundDemo.Bookstore.Dto;
using Stripe;

namespace PlaygroundDemo.Bookstore
{
    public class AuthorAppService : PlaygroundDemoAppServiceBase, IAuthorAppService
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorAppService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public ListResultDto<AuthorListDto> GetAuthor(GetAuthorInput input)
        {
            var authors = _authorRepository
            .GetAll()
            .WhereIf(
                !input.AuthorFilter.IsNullOrEmpty(),
                p => p.FullName.Contains(input.AuthorFilter) ||
                     (int.TryParse(input.AuthorFilter, out int filterAge) && p.Age == filterAge) ||
                     p.EmailAddress.Contains(input.AuthorFilter) ||
                     (!string.IsNullOrEmpty(p.Phone) && p.Phone.Contains(input.AuthorFilter))
            )
            .OrderBy(p => p.FullName)
            .ThenBy(p => p.Age)
            .ToList();

            return new ListResultDto<AuthorListDto>(ObjectMapper.Map<List<AuthorListDto>>(authors));
        }

        public async Task CreateAuthor(CreateAuthorInput input)
        {
            var author = ObjectMapper.Map<Author>(input);
            await _authorRepository.InsertAsync(author);
        }

        public async Task DeleteAuthor(EntityDto input)
        {
            await _authorRepository.DeleteAsync(input.Id);
        }

        public async Task<GetAuthorForEditOutput> GetAuthorForEdit(GetAuthorForEditInput input)
        {
            var author = await _authorRepository.GetAsync(input.Id);

            return ObjectMapper.Map<GetAuthorForEditOutput>(author);
        }

        public async Task EditAuthor(EditAuthorInput input)
        {
            var author = await _authorRepository.GetAsync(input.Id);
            author.FullName = input.FullName;
            author.Age = input.Age;
            author.EmailAddress = input.EmailAddress;
            author.Phone = input.Phone;
            await _authorRepository.UpdateAsync(author);
        }
    }
}
