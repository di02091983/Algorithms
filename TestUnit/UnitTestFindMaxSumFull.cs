using Algorithms;

namespace TestUnit
{
    public class UnitTestFindMaxSum
    {
        [Test]
        public void TestFindMaxSumFull()
        {
            var sum = Service.FindMaxSumFull(new int[][] { new int[] { 1, 1500 }, 
                new int[] { 3, 2000 }, 
                new int[] { 4, 3000 },
                new int[] { 5, 2000 },
                new int[] { 7, 1000 },
                new int[] { 2, 1200 }
            }, 
                7);

            Assert.That(sum == 5700);
        }
    }
}