using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidExceptions : BaseException
    {
        public EmailOrPasswordShouldNotBeInvalidExceptions() : base("Kullanıcı Adı veya şifre yanlıştır!") { }
        
    }



}
