using EmployeeApp.Service;

using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(await _employeeService.Get());
        }

        //[HttpPost]
        //public async Task<IActionResult> Post()
        //{
        //    return Json(await _employeeService.Create());
        //}

        //[HttpPut]
        //public async Task<IActionResult> Put()
        //{
        //    return Json(await _employeeService.Update());
        //}

        //[HttpDelete]
        //public async Task<IActionResult> Delete()
        //{
        //    return Json(await _employeeService.Delete());
        //}
    }
}
