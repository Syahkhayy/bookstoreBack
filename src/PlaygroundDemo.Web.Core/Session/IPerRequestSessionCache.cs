using System.Threading.Tasks;
using PlaygroundDemo.Sessions.Dto;

namespace PlaygroundDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
