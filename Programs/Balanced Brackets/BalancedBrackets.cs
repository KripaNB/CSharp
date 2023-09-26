/*
* Output1:
  Enter a string of brackets : {[({})]}
  True

  Output2:
  Enter a string of brackets : ((}[]
  False
*/

using System;
using System.Collections.Generic;

namespace BalancedBrackets
{
    internal class Program
    {
        public int top = -1;
        public char[] item = new char[100];
        
        //public void push(char x)
        //{
        //    if (top == 99)
        //        Console.WriteLine("Stack Overflow");
        //    else
        //        item[++top] = x;
        //}

        //public char pop()
        //{
        //    if (top == -1)
        //    {
        //        Console.WriteLine("Stack Underflow");
        //        return '\0';
        //    }
        //    else
        //    {
        //        char element = item[top];
        //        top--;
        //        return element;
        //    }
        //}

        public static bool isMatching(char a, char b)
        {
            if (a == '(' && b == ')')
                return true;
            else if (a == '{' && b == '}')
                return true;
            else if (a == '[' && b == ']')
                return true;
            else
                return false;
        }

        public static Boolean isValid(string s)
        {
            char[] exp = s.ToCharArray();
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '[' || exp[i] == '(')
                {
                    st.Push(exp[i]);
                }
                if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    else if (!isMatching(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }
            if (st.Count == 0)
                return true;
            else
                return false;

        }

        public static void Main(String[] args)
        {
            Console.Write("Enter a string of brackets : ");
            var brackets = Console.ReadLine();
            
            if (isValid(brackets))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}
