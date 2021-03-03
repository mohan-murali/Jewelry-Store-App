using System.Threading.Tasks;
using Jewelry_Store_App.Models;

namespace Jewelry_Store_App.Services
{
    public interface ILoginService
    {
        public Task<User> LoginUser(Login login);
    }

    public class LoginService : ILoginService
    {
        public async Task<User> LoginUser(Login login)
        {
            if(login.Email == "abc@gmail.com" && login.Password == "abc"){
                return new User{
                    Id=1,
                    Name="ABC",
                    IsPrivilagedCustomer=true
                };
            }

            if(login.Email== "xyz@gmail.com" && login.Password == "xyz"){
                return new User{
                    Id=1,
                    Name="XYZ",
                    IsPrivilagedCustomer=false
                };
            }

            return null;
        }
    }
}
