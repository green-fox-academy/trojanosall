using CalorieTableWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalorieTableWebApp.Controllers
{
    public class CalorieTableController : Controller
    {
        CalorieTableRepository CalorieTableRepository;

        public CalorieTableController(CalorieTableRepository calorieTableRepository)
        {
            CalorieTableRepository = calorieTableRepository;
        }

        [Route("/table")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(CalorieTableRepository.GetList());
        }
    }
}
