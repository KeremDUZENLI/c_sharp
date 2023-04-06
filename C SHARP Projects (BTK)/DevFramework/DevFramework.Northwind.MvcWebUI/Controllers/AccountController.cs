using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;

        // GET: Account
        public string Login(string userName, string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);

            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(), 
                    user.Username, 
                    user.Email, 
                    DateTime.Now.AddDays(15), 
                    _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray(),
                    false, 
                    user.FirstName, 
                    user.LastName);

                return "User authenticated!";
            }

            return "User is not authenticated!";
        }
    }
}