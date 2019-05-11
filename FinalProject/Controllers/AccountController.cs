using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using FinalProject.BusinessLogic.Services;
using FinalProject.DataLayer.Repositories;
using FinalProject.EFLayer.DataModels;
using FinalProject.Models;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;

namespace FinalProject.Controllers
{
    [Authorize]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {

        //post
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserVM model)
        {
            if (!ModelState.IsValid)
            {
                return CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }

            var authRepository = new UserService();
            var user = new User
            {
                Login = model.Login,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            authRepository.Add(user, "Студент");

            return CreateResponse(HttpStatusCode.Created);
        }

        // POST api/Account/Logout
        [Route("Logout")]
        public IHttpActionResult Logout()
        {
            Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            return CreateResponse(HttpStatusCode.OK, "Logout successful.");
        }

        //method only for test
        [AllowAnonymous]
        [Route("Getall")]
        public IHttpActionResult Getall()
        {
            var authRepository = new UserService();
            var usersDB = authRepository.GetUserList();
            List<UserVM> users = new List<UserVM>();
            foreach (var u in usersDB)
            {
                users.Add(new UserVM
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Password = u.Password,
                    Login = u.Login
                });
            }
            return users != null && users.Any()
                ? CreateResponse(HttpStatusCode.OK, users)
                : CreateErrorResponse(HttpStatusCode.NoContent, "No contacts found");
        }

        private IHttpActionResult CreateResponse(HttpStatusCode statusCode)
        {
            HttpResponseMessage responseMsg = Request.CreateResponse(statusCode);
            return ResponseMessage(responseMsg);
        }

        private IHttpActionResult CreateResponse<T>(HttpStatusCode statusCode, T value)
        {
            HttpResponseMessage responseMsg = Request.CreateResponse(statusCode, value);
            return ResponseMessage(responseMsg);
        }

        private IHttpActionResult CreateErrorResponse(HttpStatusCode statusCode, string message)
        {
            HttpResponseMessage responseMsg = Request.CreateErrorResponse(statusCode, message);
            return ResponseMessage(responseMsg);
        }

        private IAuthenticationManager Authentication => Request.GetOwinContext().Authentication;
    }
}
