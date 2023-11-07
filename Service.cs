namespace Algorithms
{
    public class TreeNode
    {
        public TreeNode()  
        { 
            Left = null; 
            Right = null;
            value = 0;
        }
        public TreeNode? Left {  get; set; }
        public TreeNode? Right { get; set; }
        public int value;
    }

    public class Service
    {
        public static long MinPowN2(int[] nums)
        {
            if (nums.Length <= 1) throw new Exception("Array`s length is less than 1");

            long minPow = nums[0] * nums[1];
            long min;
            for (int i = 0; i < nums.Length; ++i)
            {
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    min = nums[i] * nums[j];
                    if (minPow > min) minPow = min;
                }
            }
            return minPow;
        }

        //[-7, -3, -2] -> 6 (2 самых маленьких по модулю)
        //[-7, -3, -2, 0] -> 0 (0)
        //[0, 1, 2, 3] -> 0 (0)
        //[1,2,3,4] -> 2 (2 самых маленьких по модулю)
        //[-7,-3,-1,0,1,2,3] -> -21 (2 самых больших по модулю)
        public static long MinPowN(int[] nums)
        {
            if (nums.Length <= 1) throw new Exception("Array`s length is less than 1");

            int min1 = nums[0], min2 = nums[1];
            int max1 = nums[0], max2 = nums[1];
            for (int i = 0; i < nums.Length; ++i)
            {
                if (Math.Abs(nums[i]) < Math.Abs(min1))
                {
                    if (min1 != nums[0]) min2 = min1;
                    min1 = nums[i];
                }
                if(Math.Abs(nums[i]) < Math.Abs(min2))
                {
                    if (Math.Abs(nums[i]) != min1) min2 = nums[i];
                }

                if (Math.Abs(nums[i]) > Math.Abs(max1))
                {
                    if (max1 != nums[0]) max2 = max1;
                    max1 = nums[i];
                }

                if (Math.Abs(nums[i]) > Math.Abs(max2))
                {
                    if (Math.Abs(nums[i]) != max1) max2 = nums[i];
                }
            }

            return min1 * min2 < max1 * max2 ? min1 * min2 : max1 * max2;
        }

        public static void SortWithSelection(ref int[] nums, bool desc=false)
        {
            List<int> numsList = new List<int>(nums);
            List<int> result = new List<int>(nums.Length);
            while(numsList.Count > 0)
            {
                 int max = numsList[0];
                for (int i = 1; i < numsList.Count; i++)
                {
                    if (numsList[i] > max)
                    {
                        max = numsList[i];
                    }
                }
                if (desc == false)
                {
                    result.Insert(0, max);
                }
                else
                {
                    result.Add(max);
                }
                numsList.Remove(max);
            }
            nums = result.ToArray();
        }

        public static bool BFSSearchBool(TreeNode root, int target)
        {
            Queue<TreeNode> nearNodes = new Queue<TreeNode>();

            nearNodes.Enqueue(root);

            while(nearNodes.Count > 0)
            {
                var node = nearNodes.Dequeue();
                if (node.value == target) return true;
                else
                {
                    if(node.Left != null) nearNodes.Enqueue(node.Left);
                    if(node.Right != null) nearNodes.Enqueue(node.Right);
                }
            }
            return false;
        }

        public static TreeNode? BFSSearchNode(TreeNode root, int target)
        {
            Queue<TreeNode> nearNodes = new Queue<TreeNode>();

            nearNodes.Enqueue(root);

            while (nearNodes.Count > 0)
            {
                var node = nearNodes.Dequeue();
                if (node.value == target) return node;
                else
                {
                    if (node.Left != null) nearNodes.Enqueue(node.Left);
                    if (node.Right != null) nearNodes.Enqueue(node.Right);
                }
            }
            return null;
        }
    }
}
