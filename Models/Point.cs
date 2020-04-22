
using Microsoft.AspNetCore.Mvc;

namespace Test.Models
{
    public class Point
    {
        [BindProperty(Name = "x", SupportsGet = true)]
        public double x { get; set; }
        [BindProperty(Name = "y", SupportsGet = true)]
        public double y { get; set; }

        public override string ToString()
        {
            return $"X:{x} Y:{y}";
        }
    }
}
