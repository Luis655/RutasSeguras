using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuario.Data.Model;

namespace LoginJwToken.Data
{
    public class UserRepository
    {
        public IList<User> _oUsers = new List<User>();
        public UserRepository()
        {
            _oUsers = new List<User>()
            {
                //Lista de Usuarios Predefinidos (Puedes insertar mas).
                new User(){ UserName = "sdsddsa", Password = "1234"},
                new User(){ UserName = "IKR2", Password = "ABCD"},
                new User(){ UserName = "Hazael_Poot", Password = "123ABC"}
            };
        }

        public User GetUser(string username)
        {
            try
            {
                return _oUsers.FirstOrDefault(u => u.UserName == username);
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}