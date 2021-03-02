using Jewelry_Store_App.Models;

namespace Jewelry_Store_App.Services
{
    public interface ILoginService
    {
        public User LoginUser(string email, string password);

    }

    public class LoginService : ILoginService
    {
        public User LoginUser(string email, string password)
        {
            if(email == "abc@gmail.com" && password == "abc"){
                return new User{
                    Id=1,
                    Name="ABC",
                    IsPrivilagedCustomer=true
                };
            }

            if(email== "xyz@gmail.com" && password == "xyz"){
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
