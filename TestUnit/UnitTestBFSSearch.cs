using Algorithms;

namespace TestUnit
{
    public class UnitTestBFSSearch
    {
        [Test(Description = "{ 1,null,2,2,3,1,2,4,5 }")]
        public void TestBFSSearchBool()
        {
            TreeNode root = new() { 
                value = 1, 
                Left = null,
                Right = new() { 
                    value = 2,
                    Left = new() { 
                        value = 1,
                        Left = new() { value = 1 , Left = null, Right = null },
                        Right = new() { value = 2, Left = null, Right = null }
                    },
                    Right = new()
                    {
                        value = 3,
                        Left = new() { value = 4, Left = null, Right = null },
                        Right = new() { value = 5, Left = null, Right = null }
                    }
                },
            };

            Assert.True(Service.BFSSearchBool(root, 1));
        }

        [Test(Description = "{ 1,null,2,2,3,1,2,4,5 }")]
        public void TestBFSSearchNode()
        {
            TreeNode root = new()
            {
                value = 1,
                Left = null,
                Right = new()
                {
                    value = 2,
                    Left = new()
                    {
                        value = 1,
                        Left = new() { value = 1, Left = null, Right = null },
                        Right = new() { value = 2, Left = null, Right = null }
                    },
                    Right = new()
                    {
                        value = 3,
                        Left = new() { value = 4, Left = null, Right = null },
                        Right = new() { value = 5, Left = null, Right = null }
                    }
                },
            };

            Assert.True(Service.BFSSearchNode(root, 3)?.value == 3);
        }
    }
}