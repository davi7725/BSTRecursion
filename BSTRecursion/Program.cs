using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            BST tree = new BST();

            tree.InsertRecursively(5);
            tree.InsertRecursively(25);
            tree.InsertRecursively(7);
            tree.InsertRecursively(10);
            tree.InsertRecursively(11);
            tree.InsertRecursively(2);
            tree.InsertRecursively(4);
            tree.InsertRecursively(12);

            Console.WriteLine(tree.Search(2));
            Console.WriteLine(tree.Search(11));

            Console.WriteLine(tree.SearchRecursively(2));
            Console.WriteLine(tree.SearchRecursively(11));

            Console.WriteLine(tree.HighestValue());
            Console.WriteLine(tree.HighestValueRecursive());

            List<int> list = tree.LevelOrder();

            foreach(int nr in list)
            {
                Console.Write(nr + " ");
            }


            Console.ReadKey();
        }
    }
}
