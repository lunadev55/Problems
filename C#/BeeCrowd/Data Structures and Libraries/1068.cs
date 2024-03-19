using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

class URI
{
    public class Node
    {
        public char Data;
        public Node Next;
        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Stack
    {
        public Node Top;
        public Stack()
        {
            Top = null;
        }

        public void Push(char value)
        {
            Node newNode = new Node(value);
            newNode.Next = Top;
            Top = newNode;
        }

        public void Pop()
        {
            Top = Top.Next;
        }        

        public bool IsEmpty()
        {
            return Top == null;
        }
    }
    public static void Main(string[] args) 
    {
        // ascii
        // ( -> 40
        // ) -> 41

        string expression;

        // reads input till end of file (EOF)
        while ((expression = Console.ReadLine()) != null)
        {
            Stack stack = new Stack();
            bool flag = true;

            // loops the expression looking for parentheses
            // if it's opening we push, otherwise we pop
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                    stack.Push('(');
                else if (expression[i] == ')')
                {
                    // if we have a closing parentheses and the stack is empty
                    // (does not have an opening one to match with the closing)
                    // that means the expression is incorrect
                    if (stack.IsEmpty())
                    {                       
                        flag = false;
                        break;
                    }
                    // if we have a closing parentheses matching with an opening one
                    // we pop the top element from the stack
                    if (stack.Top.Data == (')' - 1))
                        stack.Pop();
                }
            }

            // if the stack is empty that means the parentheses matching 
            // are correct
            if (stack.IsEmpty() && flag)
                Console.WriteLine("correct");
            else
                Console.WriteLine("incorrect");
        }
    }       
}
