using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeographyService.Controllers
{
    class Geography
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
    [Route("api/[Controller]")]
    public class GeoController : Controller
    {
        List<Geography> geographies = new List<Geography>();
        public IActionResult Index()
        {
            geographies.Add(new Geography() { ID = 1, Name = "Anji" });
            geographies.Add(new Geography() { ID = 2, Name = "Veer" });
            return new JsonResult(geographies);
        }
    }
}