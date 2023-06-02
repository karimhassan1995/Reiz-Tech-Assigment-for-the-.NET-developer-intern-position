using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Binary_Tree
{
    public class MainPage
    {

        public static void Main(string[] args)
        {
            // Second question in REIZ TECH HOMEWORK ASSIGNMENT 
            List<Branch> subBranches = new List<Branch>();

            Branch b1 = new Branch();
            subBranches.Add(b1);

            Branch b2 = new Branch(subBranches);
            subBranches.Clear();

            Branch b3 = new Branch();
            subBranches.Add(b2);
            subBranches.Add(b3);

            Branch b4 = new Branch(subBranches);
            subBranches.Clear();

            Branch b5 = new Branch();
            subBranches.Add(b5);

            Branch b6 = new Branch(subBranches);
            subBranches.Clear();

            Branch b7 = new Branch();
            subBranches.Add(b4);
            subBranches.Add(b6);
            subBranches.Add(b7);

            Branch b8 = new Branch(subBranches);
            subBranches.Clear();

            Branch b9 = new Branch();
            subBranches.Add(b9);

            Branch b10 = new Branch(subBranches);
            subBranches.Clear();
            subBranches.Add(b10);
            subBranches.Add(b8);

            Branch root = new Branch(subBranches);
            subBranches.Clear();

            Console.WriteLine(Branch.calculateDepth(root));
            
        }
    }
}
