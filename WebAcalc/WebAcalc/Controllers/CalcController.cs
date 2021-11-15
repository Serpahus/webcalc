using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAcalc.Serivces;
using WebAcalc.Models;


namespace WebAcalc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly ICalcServices _services;

        public CalcController(ICalcServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("Sum")]
        public ActionResult<float> SumItems(ArgumentModels items)
        {
            var result = _services.sum(items);

            return result;
        }

        [HttpPost]
        [Route("Sub")]
        public ActionResult<float> SubItems(ArgumentModels items)
        {
            var result = _services.sub(items);

            return result;
        }

        [HttpPost]
        [Route("Mult")]
        public ActionResult<float> MultItems(ArgumentModels items)
        {
            var result = _services.mult(items);

            return result;
        }

        [HttpPost]
        [Route("Div")]
        public ActionResult<float> DivItems(ArgumentModels items)
        {
            var result = _services.div(items);

            return result;
        }
    }
}
