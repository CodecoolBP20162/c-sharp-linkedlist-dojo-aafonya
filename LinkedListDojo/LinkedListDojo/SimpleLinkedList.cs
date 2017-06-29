using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    class SimpleLinkedList : LinkedListInterface
    {
        int NumberOfNodes = 0;
        Node firstNode;
        Node lastNode;

        public SimpleLinkedList()
        {

        }

        public Node searching(int Element)
        {
            Node actualNode = firstNode;
            while(actualNode.Element != lastNode.Element)
            {
                if(actualNode.Element == Element)
                {
                    return actualNode;
                }
                actualNode = actualNode.next;
            }
            Console.WriteLine("No such node found.");
            return null;
        }

        public Node stepping(int index)
        {
            Node actualNode = firstNode;
            if (index == 0)
            {
                return firstNode;
            }
            int step = 0;
            while(step < index)
            {
                actualNode = actualNode.next;
                step++;
            }
            return actualNode;
        }

        public void add(int Element)
        {
            Node node = new Node();
            node.Element = Element;
            if(lastNode != null)
            {
                lastNode.next = node;
            } else
            {
                firstNode = node;
            }
            lastNode = node;
        }

        void insert(int Element, int Index)
        {

        }



    }
}
