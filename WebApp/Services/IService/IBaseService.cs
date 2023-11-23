using WebApp.Models;

namespace WebApp.Services.IService
{
    public interface IBaseService
    {
        Task<ResponseDto> SendAsync(RequestDto requestDto);
    }
}
