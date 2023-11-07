using Algorithms;

namespace TestUnit
{
    public class SortWithSelection
    {
        [Test(Description = "{ 4, 3, 7 }")]
        public void TestSortWithSelectionAsc()
        {
            int[] nums = { -2, 0, 4, 3, 7 };

            Service.SortWithSelection(ref nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i+1])
                {
                    Assert.Fail("Array was sorted not right");
                    break;
                }
            }
        }

        [Test(Description = "{ 4, 3, 7 }")]
        public void TestSortWithSelectionDesc()
        {
            int[] nums = { -5, 0, 4, 3, 7 };

            Service.SortWithSelection(ref nums,true);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    Assert.Fail("Array was sorted not right");
                    break;
                }
            }
        }
    }
}