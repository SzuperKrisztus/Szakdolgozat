﻿namespace Szakdolgozat.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister request);

        Task<ServiceResponse<string>> Login(UserLogin request);

        Task<bool> IsUserAuthenticated();

        
    }
}

