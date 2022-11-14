using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class MinStack
    {
        Stack<int> Stack = new();

        Stack<int> MinValue = new(new[] { int.MaxValue});


        public MinStack()
        {

        }

        public void Push(int val)
        {
            if (MinValue.Peek() >= val)
            {
                MinValue.Push(val);
            }
            Stack.Push(val);
        }

        public void Pop()
        {
            var value = Stack.Pop();
            if (MinValue.Peek() == value)
            {
                MinValue.Pop();
            }
        }

        public int Top()
        {
            return Stack.Peek();
        }

        public int GetMin()
        {
            return MinValue.Peek();
        }
    }
}
