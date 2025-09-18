using System.Web.Mvc;

namespace YourNamespace.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string role)
        {
            if (username == "admin" && password == "123")
            {
                if (role == "Admin")
                    return RedirectToAction("Index", "Admin");
                else if (role == "GiangVien")
                    return RedirectToAction("Index", "GiangVien");
                else
                    return RedirectToAction("Index", "SinhVien");
            }

            ViewBag.Error = "Tên đăng nhập hoặc mật khẩu sai!";
            return View();
        }
    }
}
