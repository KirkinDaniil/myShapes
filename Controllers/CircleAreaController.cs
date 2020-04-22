using System;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CircleAreaController : ControllerBase
    {
        [HttpGet]
        public double GetCircleArea([FromQuery]double rad)
        {
            return Math.PI * rad * rad;
        }
    }
}
