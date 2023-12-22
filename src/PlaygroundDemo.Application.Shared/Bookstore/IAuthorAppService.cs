using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PlaygroundDemo.Bookstore.Dto;

namespace PlaygroundDemo.Bookstore
{
    public interface IAuthorAppService : IApplicationService
    {
        ListResultDto<AuthorListDto> GetAuthor(GetAuthorInput input);
        Task CreateAuthor(CreateAuthorInput input);
        Task DeleteAuthor(EntityDto input);
        Task<GetAuthorForEditOutput> GetAuthorForEdit(GetAuthorForEditInput input);
        Task EditAuthor(EditAuthorInput input);
    }
}
