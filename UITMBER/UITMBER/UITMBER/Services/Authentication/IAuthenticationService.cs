﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Authentication;

namespace UITMBER.Services.Authentication
{
    public  interface IUFLocationService
    {
        Task<bool> Authenticate(AuthenticationRequest input);
    }
}
