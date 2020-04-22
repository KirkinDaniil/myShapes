using System;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleController : ControllerBase
    {
        [HttpGet]
        public double GetTriangleArea(Triangle triangle)
        {
            double halfPerim = triangle.GetPerim() / 2;
            return Math.Sqrt(halfPerim * (halfPerim - triangle.firstSide) * (halfPerim - triangle.secondSide) * (halfPerim - triangle.thirdSide));
        }
    }
}