using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PlaygroundDemo.Bookstore.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundDemo.Bookstore
{
    public interface IBookAppService : IApplicationService
    {
        ListResultDto<BookListDto> GetBook(GetBookInput input);
        Task CreateBook(CreateBookInput input);
        Task DeleteBook(EntityDto input);
        Task<GetBookForEditOutput> GetBookForEdit(GetBookForEditInput input);
        Task EditBook(EditBookInput input);
    }
}