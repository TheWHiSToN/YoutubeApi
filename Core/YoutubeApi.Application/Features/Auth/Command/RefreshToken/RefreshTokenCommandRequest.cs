﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Application.Features.Auth.Command.RefreshToken
{
    public class RefreshTokenCommandRequest :IRequest<RefreshTokenCommandResponse>
    {
        public string AccesToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
