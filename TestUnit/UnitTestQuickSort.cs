using Algorithms;

namespace TestUnit
{
    public class QuickSort
    {
        [Test(Description = "{ -2, 0, 4, 3, 7 }")]
        public void TestQuickSort()
        {
            int[] nums = { -2, 0, 4, 3, 7 };

            var result = Service.QuickSort(nums);

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] > result[i+1])
                {
                    Assert.Fail("Array was sorted not right");
                    break;
                }
            }
        }
    }
}