using System.Threading.Tasks;

namespace PlaygroundDemo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}