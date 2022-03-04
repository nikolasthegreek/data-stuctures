using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Node
    {
        public Node Next;
        public object Value;
        
        public Node(object value)
        {
            Next = null;
            Value = value;
        }

    }
    /*class Node_int : Node
    {
        public Node_int(int val)
        {
            value
        }

        public int value;
    }
    class Node_double : Node
    {
        public double value;
    }
    class Node_bool : Node
    {
        public bool value;
    }
    class Node_string : Node
    {
        public string value;
    }*/
}
