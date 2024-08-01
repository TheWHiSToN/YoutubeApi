using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpiredExceptions : BaseException
    {
        
        public RefreshTokenShouldNotBeExpiredExceptions() : base("Oturum süresi sona ermiştir. Lütfen tekrar giriş yapın.") { }
    }



}
