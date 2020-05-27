using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree b = new BinarySearchTree(); // Binary Search Tree

            b.Add(7, 4);
            b.Add(5, 20, 15, 25, 3, 2, 30, 10);
            b.Add(3, 3, 3);


            int n = 33;
            TreeNode node = b.Find(n);
            if (node != null)
            {
                Console.WriteLine("Found key {0} with sattelite data: {1}", n, node.Data);
            }
            else
                Console.WriteLine("Key {0} not found", n);

            b.Inorder();

            //Console.WriteLine(b);
        }
    }
}
