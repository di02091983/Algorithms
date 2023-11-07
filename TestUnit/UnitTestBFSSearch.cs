using Algorithms;

namespace TestUnit
{
    public class UnitTestBFSSearch
    {
        [Test(Description = "{ 1,null,2,2,3,1,2,4,5 }")]
        public void TestBFSSearchBool()
        {
            TreeNode root = new() { 
                Value = 1, 
                Left = null,
                Right = new() { 
                    Value = 2,
                    Left = new() { 
                        Value = 1,
                        Left = new() { Value = 1 , Left = null, Right = null },
                        Right = new() { Value = 2, Left = null, Right = null }
                    },
                    Right = new()
                    {
                        Value = 3,
                        Left = new() { Value = 4, Left = null, Right = null },
                        Right = new() { Value = 5, Left = null, Right = null }
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
                Value = 1,
                Left = null,
                Right = new()
                {
                    Value = 2,
                    Left = new()
                    {
                        Value = 1,
                        Left = new() { Value = 1, Left = null, Right = null },
                        Right = new() { Value = 2, Left = null, Right = null }
                    },
                    Right = new()
                    {
                        Value = 3,
                        Left = new() { Value = 4, Left = null, Right = null },
                        Right = new() { Value = 5, Left = null, Right = null }
                    }
                },
            };

            Assert.True(Service.BFSSearchNode(root, 3)?.Value == 3);
        }
    }
}