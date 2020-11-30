using Days.Models.Request;
using Days.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Days.Services
{
    interface IUserService
    {
        UserResponse Auth(AuthRequest model);
    }
}
