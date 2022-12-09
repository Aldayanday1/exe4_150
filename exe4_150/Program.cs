﻿using System;

namespace StackImplementation
{
    internal class Stack
    {
        static readonly int aldi = 610;
        int top;
        int[] stack = new int[aldi];

        bool isEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        internal bool Push(int data)
        {
            if (top >= aldi)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }
        internal int Pop()
        {
            if (top < 610)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }
    }
}