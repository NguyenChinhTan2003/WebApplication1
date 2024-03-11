using Microsoft.AspNetCore.Mvc;

namespace BaiTapVanDung1.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Show(List<string> categories)
        {
            String res = String.Empty;
            foreach(var category in categories)
            {
                res += category + " " ;
            }
            return Content(res);
        }
    }
}
