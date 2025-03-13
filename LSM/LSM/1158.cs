using System;

namespace LSM
{
    public class Node 
    {
        public int Data;   
        public Node Next;  

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }


    public class CLinkedList
    {
        public Node tail;

        public bool IsEmpty()
        {
            return tail == null;
        }

        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                tail = newNode;
                tail.Next = tail;
            }
            else
            {
                newNode.Next = tail.Next;  
                tail.Next = newNode; 
                tail = newNode;
            }
        }

        public int RemoveNode(ref Node current, int k)
        {
            if (k == 1)  
            {
                Node toDelete = current;
                int removedData = toDelete.Data;
                 
                if (current.Next == current)
                {
                    tail = null;
                    current = null;
                }
                else
                {
                    tail.Next = current.Next;  
                    current = current.Next;   
                }

                return removedData;
            }
             
            for (int i = 1; i < k - 1; i++)
            {
                current = current.Next;
            }

            Node toDeleteK = current.Next;
            int rData = toDeleteK.Data;

            current.Next = toDeleteK.Next;

            if (toDeleteK == tail)
            {
                tail = current;
            }

            current = current.Next;

            return rData;
        }

    }

    class _1158
    {
        static void PrintOutput(int n, int k)
        {
            CLinkedList list = new CLinkedList();
            List<int> result = new List<int>();
             
            for (int i = 1; i <= n; i++)
            {
                list.AddNode(i);
            }

            Node current = list.tail.Next;  
             
            for (int i = 0; i < n; i++)
            {
                int removed = list.RemoveNode(ref current, k);
                result.Add(removed);
            }
             
            Console.WriteLine($"<{string.Join(", ", result)}>");
        }

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            int N = Convert.ToInt32(words[0]);
            int K = Convert.ToInt32(words[1]);

            PrintOutput(N, K);

        }
    }
}


