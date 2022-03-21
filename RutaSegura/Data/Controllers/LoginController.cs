/*using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace LoginJwToken.Data
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] User user)
        {
        TokenClass tokenClass = new TokenClass();
            User userObj = new UserRepository().GetUser(user.UserName);
            if (userObj == null)
            {
                tokenClass.TokenOrMessage = "Usuario no Autorizado";
                return Ok(tokenClass);
            }

            bool credentials =userObj.Password.Equals(user.Password);
            if ()
            {
                
            }

        }
    }
}*/