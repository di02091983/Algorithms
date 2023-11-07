using Algorithms;
using NUnit.Framework;

namespace TestUnit
{
    public class UnitTestMinPowN2
    {
        //[-7, -3, -2] -> 6 (2 самых маленьких по модулю)
        //[-7, -3, -2, 0] -> 0 (0)
        //[0, 1, 2, 3] -> 0 (0)
        //[1,2,3,4] -> 2 (2 самых маленьких по модулю)
        //[-7,-3,-1,0,1,2,3] -> -21 (2 самых больших по модулю)

        [Test(Description = "{ -7, -3, -2 }", ExpectedResult = 6)]
        public long TestMinPowNOnlyLessZero()
        {
            int[] nums = { -7, -3, -2 };

            return Service.MinPowN2(nums);
        }

        [Test(Description = "{ -7, -3, -2, 0 }", ExpectedResult = 0)]
        public long TestMinPowNLessZeroAndZero()
        {
            int[] nums = { -7, -3, -2, 0 };

            return Service.MinPowN2(nums);
        }

        [Test(Description = "{ 0, 1, 2, 3 }", ExpectedResult = 0)]
        public long TestMinPowNZeroAndGreaterZero()
        {
            int[] nums = { 0, 1, 2, 3 };

            return Service.MinPowN2(nums);
        }

        [Test(Description = "{ 1, 2, 3, 4 }", ExpectedResult = 2)]
        public long TestMinPowNOnlyGreaterZero()
        {
            int[] nums = { 1, 2, 3, 4 };

            return Service.MinPowN2(nums);
        }

        [Test(Description = "{ -7, -3, -1, 0, 1, 2, 3 }", ExpectedResult = -21)]
        public long TestMinPowNLessZeroAndGreaterZero()
        {
            int[] nums = { -7, -3, -1, 0, 1, 2, 3 };

            return Service.MinPowN2(nums);
        }
    }
}