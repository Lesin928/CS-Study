using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, (char left, char right)> tree = new Dictionary<char, (char left, char right)>();

    // 전위 순회
    static void PreOrder(char node)
    {
        if (node == '.') 
            return;  
        Console.Write(node);
        PreOrder(tree[node].left);
        PreOrder(tree[node].right);
    }

    // 중위 순회
    static void InOrder(char node)
    {
        if (node == '.') 
            return;  
        InOrder(tree[node].left);
        Console.Write(node);
        InOrder(tree[node].right);
    }

    // 후위 순회
    static void PostOrder(char node)
    {
        if (node == '.') 
            return;  
        PostOrder(tree[node].left);
        PostOrder(tree[node].right);
        Console.Write(node);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());  
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            char parent = input[0];
            char left = input[2];
            char right = input[4];

            tree[parent] = (left, right);
        } 

        PreOrder('A');
        Console.WriteLine();
        InOrder('A');
        Console.WriteLine();
        PostOrder('A');
    }
}
