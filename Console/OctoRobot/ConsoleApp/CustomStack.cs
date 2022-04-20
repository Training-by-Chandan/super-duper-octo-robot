using System;

namespace Octo.Robot
{
    public class CustomStack
    {
        public CustomStack()
        {
            container = new string[5];
        }

        public CustomStack(int newSize)
        {
            container = new string[newSize];
        }

        //container of size n
        private string[] container;

        //counter
        private int counter = -1;

        //push functionality
        public void Push(string item)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = item;
            }
            else
            {
                System.Console.WriteLine("cannot add. Stack is full");
            }
        }

        //pop functionality
        public void Pop()
        {
            if (counter > -1)
            {
                container[counter] = string.Empty;
                counter--;
            }
            else
            {
                System.Console.WriteLine("Cannot pop, stack is empty");
            }
        }

        //peek functionality
        //display all functionality without pop
        public void DisplayAll()
        {
            System.Console.WriteLine("=====================================");
            System.Console.WriteLine("Item in stack is ");
            for (int i = counter; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

    public class CustomStackV2
    {
        //container of size n
        private string[] container = new string[0];

        //counter
        // private int counter = -1;

        //push functionality
        public void Push(string item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        //pop functionality
        public void Pop()
        {
            if (container.Length > 0)
            {
                Array.Resize(ref container, container.Length - 1);
            }
            else
            {
                Console.WriteLine("cannot pop from empty stack");
            }
        }

        //peek functionality
        //display all functionality without pop
        public void DisplayAll()
        {
            System.Console.WriteLine("=====================================");
            System.Console.WriteLine("Item in stack is ");
            for (int i = container.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

    public class CustomStackIntV2
    {
        //container of size n
        private int[] container = new int[0];

        //counter
        // private int counter = -1;

        //push functionality
        public void Push(int item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        //pop functionality
        public void Pop()
        {
            if (container.Length > 0)
            {
                Array.Resize(ref container, container.Length - 1);
            }
            else
            {
                Console.WriteLine("cannot pop from empty stack");
            }
        }

        //peek functionality
        //display all functionality without pop
        public void DisplayAll()
        {
            System.Console.WriteLine("=====================================");
            System.Console.WriteLine("Item in stack is ");
            for (int i = container.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }

    //templated
    public class CustomStackTemplatedV2<T>
    {
        //container of size n
        private T[] container = new T[0];

        //counter
        // private int counter = -1;

        //push functionality
        public void Push(T item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        //pop functionality
        public void Pop()
        {
            if (container.Length > 0)
            {
                Array.Resize(ref container, container.Length - 1);
            }
            else
            {
                Console.WriteLine("cannot pop from empty stack");
            }
        }

        //peek functionality
        //display all functionality without pop
        public void DisplayAll()
        {
            System.Console.WriteLine("=====================================");
            System.Console.WriteLine("Item in stack is ");
            for (int i = container.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(container[i]);
            }
            System.Console.WriteLine();
        }
    }
}