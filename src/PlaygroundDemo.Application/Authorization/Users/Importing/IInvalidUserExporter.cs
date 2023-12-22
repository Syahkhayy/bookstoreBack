using System.Collections.Generic;
using PlaygroundDemo.Authorization.Users.Importing.Dto;
using PlaygroundDemo.Dto;

namespace PlaygroundDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
