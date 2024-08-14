﻿
namespace ClienteManager.Core.Services
{
    public interface IAuthService
    {
        string GenerateJwToken(string email, string role);
        string ComputeSha256Hash(string password);
    }
}
