using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.ViewComponents
{
    public class GetWriterInfoOnDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var userinfo = wm.GetWriterAccountByID(1);
            return View(userinfo);
        }
    }
}
