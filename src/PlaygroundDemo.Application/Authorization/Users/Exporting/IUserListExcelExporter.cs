using System.Collections.Generic;
using PlaygroundDemo.Authorization.Users.Dto;
using PlaygroundDemo.Dto;

namespace PlaygroundDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}