public class Solution {
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

    public bool IsValid(string s) {
        string expression = s;
        Stack stack = new Stack();

        bool flag = false;

        for (int i = 0; i < expression.Length; i++)
        {
            char currentChar = expression[i];
            if (currentChar == '(' ||
                currentChar == '{' ||
                currentChar == '[' )
            {
                stack.Push(currentChar);
            }
            else if (currentChar == ')' ||
                     currentChar == '}' ||
                     currentChar == ']' )
            {
                if (stack.IsEmpty())   
                    return false;       
                
                if (currentChar == ')' &&
                    stack.Top.Data == '(')
                    {
                        stack.Pop();
                    }
                else if (currentChar == '}' &&
                    stack.Top.Data == '{')
                    {
                        stack.Pop();
                    }
                else if (currentChar == ']' &&
                    stack.Top.Data == '[')
                    {
                        stack.Pop();
                    }
                else
                    return false;
            }
        }

        if (stack.IsEmpty())
            return true;
        else
            return false;
    }
}