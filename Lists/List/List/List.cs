using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
        private Node Start;
        private Node Pointer;
        public int Length;

        public List()
        {
            Start = null;
            Pointer = null;
            Length = -1;
        }
        public List(object[] array)
        {
            Start = null;
            Pointer = null;
            Length = -1;

            foreach(var value in array)
            {
                AddNode(value);
                
            }
        }

        bool NextNode()
        {
            if (Pointer.Next!=null)
            {
                Pointer = Pointer.Next;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        void GoTo(int pos)
        {
            Pointer = Start;
            for (int i = 0; i < pos; i++)
            {
                NextNode();
            }
        }

        /*Node FechNode(object Value)
        {
            if (Value.Equals(typeof(int)))
            {
                return new Node_int();
            }
            else if (Value.Equals(typeof(double)))
            {
                return new Node_double();
            }
            else if (Value.Equals(typeof(bool)))
            {
                return new Node_bool();
            }
            else if (Value.Equals(typeof(string)))
            {
                return new Node_string();
            }
            return null;
        }*/  

        void ListInit(Node node)
        {
            Start = node;
            Length++;
        }

        void Extend(Node node)
        {
            GoTo(Length);
            Pointer.Next = node;
            Length++;
        }

        void Insert(Node node,int pos)
        {
            Console.WriteLine("-"+pos+" "+node.Value);
            if (pos<=0)
            {
                node.Next = Start;
                Start = node;
            }
            else
            {
                GoTo(pos - 1);
                node.Next = Pointer.Next;
                Pointer.Next = node;
            }
            Length++;
        }

        public void Print()
        {
            if (Start==null){return;}
            Pointer = Start;
            int count = 0;
            do
            {
                Console.WriteLine(count +" ~ "+Pointer.Value);
                count++;
            } while (NextNode());
        }

        public object Get(int pos)
        {
            GoTo(pos);
            return Pointer.Value;
        }

        public void AddNode(object Value , int? pos=null)
        {
            Node node = new Node(Value);
            if (node == null){return;}
            
            if (Start==null)
            {
                ListInit(node);

            }
            else if (pos==null||pos>Length)
            {
                Extend(node);
            }
            else
            {
                Insert(node, (int)pos);
            }
            
        }


    }
}
