using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Binary_Tree
{
    public class Branch
    {

        List<Branch> branches;

        public Branch(List<Branch> branches = null)
        {
            this.branches = new List<Branch>();
            if (branches != null)
            {
                foreach (Branch branch in branches)
                {
                    this.branches.Add(branch);
                }
            }
        }

        public static int calculateDepth(Branch branch)
        {
            if(branch == null) return 0;

            int depth = 1;
            if(branch.branches != null) 
            { 
                foreach (Branch subBranch in branch.branches) 
                {
                    depth = Math.Max(depth, 1 + calculateDepth(subBranch));
                }
            }
            return depth;
        }
    }
}
