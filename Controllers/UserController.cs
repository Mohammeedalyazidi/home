using homework1.Models;
using Microsoft.AspNetCore.Mvc;

namespace homework1.Controllers
{
    public class UserController : Controller
    {
        private readonly List<User> _users = new List<User>();

        public IActionResult lop()
        {
            return View(_users);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // تحديد معرف المستخدم
                int newUserId = _users.Count + 1;

                // تعيين معرف المستخدم وإضافته إلى القائمة
                user.Id = newUserId;
                _users.Add(user);


                // إعادة التوجيه إلى صفحة عرض القائمة
                return RedirectToAction("lop");
            }
                {
                    var users = _users.ToList();
                    return View(users);
                }

            }
    }
}
