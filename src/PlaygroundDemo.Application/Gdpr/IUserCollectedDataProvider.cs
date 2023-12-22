using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using PlaygroundDemo.Dto;

namespace PlaygroundDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
