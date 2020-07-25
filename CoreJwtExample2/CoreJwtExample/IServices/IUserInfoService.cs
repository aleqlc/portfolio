using CoreJwtExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreJwtExample.IServices
{
    public interface IUserInfoService
    {
        UserInfo Authenticate(string username, string password);
    }
}
