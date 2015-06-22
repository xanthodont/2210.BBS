using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2210.BBS.Controllers {
    public class UserController : Controller {

        private UserService userService = new UserService();

        public ActionResult Login() {
            return View();
        }

        public ActionResult Register() {
            return View();
        }

        public ActionResult Edit(Guid? id) {
            User result = new User();
            if (id.HasValue) {
                result = userService.GetByID<User>(id.Value);
            }
            else {
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(Guid? id, FormCollection collection) {
            User user = new User();
            TryUpdateModel(user);

            if (id.HasValue) {
                user.LastModifyTime = DateTime.Now;
                userService.Edit<User>(user);
            }
            else {
                user.ID = Guid.NewGuid();
                user.CreateTime = DateTime.Now;
                user.LastLoginTime = DateTime.Now;
                user.LastModifyTime = DateTime.Now;

                userService.Add<User>(user);
            }


            return View();
        }
    }
}
