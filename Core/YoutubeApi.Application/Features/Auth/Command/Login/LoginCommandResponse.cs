﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Application.Features.Auth.Command.Login
{
    public class LoginCommandResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiraton { get; set; }
    }
}
