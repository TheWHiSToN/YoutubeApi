using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
    public class UserAlreadyException :BaseException
    {
        public UserAlreadyException() : base("Böyle bir Kullanıcı zaten var!") {}
    }
}
