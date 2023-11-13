using Algorithms;

namespace TestUnit
{
    public class UnitTestPascalTriangle
    {
        [Test]
        public void TestPascalTriangle()
        {
            var result = Service.PascalTriangle(5);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}