using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Node
    {
        int? val;
        int? left;
        int? right;
        public Node()
        {
            this.val = null;
            this.left = null;
            this.right = null;
        }
        
        }
    }

    class Btree
    {
        int?[] stack;
        int? lastNodeValue;

        public void StackController()
        {
            while (stack != null)
            {
                lastNodeValue = stack[stack.Length - 1];
                stack[stack.Length - 1] = null;
                Console.WriteLine(lastNodeValue);
            }
        }

    }

