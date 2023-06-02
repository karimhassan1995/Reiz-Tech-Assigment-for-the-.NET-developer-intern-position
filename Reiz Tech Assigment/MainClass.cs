using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reiz_Tech_Assigment
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            // First question in REIZ TECH HOMEWORK ASSIGNMENT 
            Console.WriteLine("Enter Hour: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            Clock clock = new Clock(hour , minute);

            clock.CalculateAngle();

            // Second question in REIZ TECH HOMEWORK ASSIGNMENT 
            List<Branch> Nodes = new List<Branch>();

            Branch firstNode = new Branch();
            Nodes.Add(firstNode);
            Branch secondNode = new Branch(Nodes);
            Nodes.Clear();
            Branch thirdNode = new Branch();
            Nodes.Add(secondNode);
            Nodes.Add(thirdNode);
            Branch forthNode = new Branch(Nodes);
            Nodes.Clear();
            Branch fifthNode = new Branch();
            Nodes.Add(fifthNode);
            Branch sixthNode = new Branch(Nodes);
            Nodes.Clear();
            Branch seventhNode = new Branch();
            Nodes.Add(forthNode);
            Nodes.Add(sixthNode);
            Nodes.Add(seventhNode);
            Branch eighthNode = new Branch(Nodes);
            Nodes.Clear();
            Branch ninethNode = new Branch();
            Nodes.Add(ninethNode);
            Branch tenthNode = new Branch(Nodes);
            Nodes.Clear();  
            Nodes.Add(tenthNode);
            Nodes.Add(eighthNode);
            Branch root = new Branch(Nodes);
            Nodes.Clear();




            
            
            int x = root.calculateDepth(root);

            Console.WriteLine(x);


        }
    }
}
