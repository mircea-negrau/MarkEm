﻿using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Contracts
{
    public interface IAuthService
    {
        AccountContext Authenticate(string username, string password);
        AccountContext Register(string userType, string username, string password, string email, string firstName, string lastName);
    }
}
