using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_Tech_Assigment
{
    public class Branch
    {

        List<Branch> branches;

        public Branch(List<Branch> smallBranches = null)
        {
            branches = new List<Branch>();
            if (smallBranches != null)
            {
                foreach (Branch branch in smallBranches)
                {
                    this.branches.Add(branch);
                }
            }
        }

        public int calculateDepth(Branch root)
        {
            if(root == null) { return 0; }
            int depth = 1;
            if(root.branches != null) 
            { 
                List<int> list = new List<int>();

                foreach (Branch branch in root.branches) 
                {
                    int MaxDepth = calculateDepth(branch);
                    list.Add(MaxDepth);
                }
                int max = 0; 
                foreach (int i in list)
                {
                    if(i > max)
                    {
                        max = i;
                    }

                }
                depth += max;
            }
            return depth;
        }
    }
}
