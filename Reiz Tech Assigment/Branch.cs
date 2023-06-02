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

       
    }
}
