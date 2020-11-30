using Days.Models;
using Days.Models.Request;
using Days.Models.Response;
using Days.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Days.Services
{
    public class UserService : IUserService
    {
        UserResponse userResponse = new UserResponse();
        public UserResponse Auth(AuthRequest model)
        {
            using (var db = new AmaneContext())
            {
                string spassword = Encrypt.GetSHA256(model.Password);

                var usuario = db.UsuarioLogins.Where(d => d.Email == model.Email && d.Contraseña == spassword).FirstOrDefault();
                userResponse.Email = usuario.Email;
            }

            return userResponse;
        }
    }
}
