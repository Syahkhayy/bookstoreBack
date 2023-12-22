using System.Collections.Generic;
using PlaygroundDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace PlaygroundDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
