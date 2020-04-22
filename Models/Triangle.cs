
namespace Test.Models
{
    public class Triangle
    {
        public Side firstSide { get; set; }
        public Side secondSide { get; set; }
        public Side thirdSide { get; set; }

        public double GetPerim()
        {
            return firstSide + secondSide + thirdSide;
        }
    }
}
