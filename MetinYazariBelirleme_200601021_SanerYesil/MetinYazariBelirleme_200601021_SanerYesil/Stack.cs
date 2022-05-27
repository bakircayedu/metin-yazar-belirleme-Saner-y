﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_200601021_SanerYesil
{
    internal class Stack
    {
        private class Node
        {
            public int data;
            public Node link;
        }
        Node top;
        public Stack()
        {
            this.top = null;
        }
        public void push(int x)
        {
            Node temp = new Node();
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }
            temp.data = x;
            temp.link = top;
            top = temp;
        }
        public bool isEmpty()
        {
            return top == null;
        }
        public int peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }
        public void pop() 
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            top = (top).link;
        }

        public void display()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.link;
                }
            }
        }
    }
}
