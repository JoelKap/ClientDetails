using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClientDetailManagement.Models;

namespace ClientDetailManagement.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User 
        public UserModel GetUsedToUpdate()
        {
            var userBll = new BLL.UserBll();
            return userBll.GetUserToUpdate();
        }

         
        // POST: api/User
        [HttpPost]
        public bool SaveUser(UserModel user)
        {
            bool isSaved = false;
            var userBll = new BLL.UserBll();
            return isSaved = userBll.SaveUser(user);
        }

        // PUT: api/User/5
        [HttpPut]
        public bool UpdateUser(UserModel user)
        {
            bool isUpdated = false;
            var userBll = new BLL.UserBll();
            return isUpdated = userBll.UpdateUser(user);
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
