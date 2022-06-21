/* A stack is a data structure for storing a list of elements in a LIFA (Last In, First Out) fashion. Design a class called Stack with three methods:
 * void Push (object obj)
 * object Pop()
 * void Clear()
 * The Push() method stores the given object on top of the stcak. We use the 'object' type here so we can store any objects inside the stack. Remember
 * the 'object' classis the base of all classes in the .Net framework. So any types can be automatically upcast to the object. Make sure to take into 
 * account the scenario that null is passed to this object. We should not store null references in the stack. So if null is passed to their method, you 
 * should throw an InvalidOperationException. Remember when coding every method, you should think of all possibilities and make sute the method behaves
 * properly in all these edge cases. The Pop() method removes the object on top of the stack and returns it. Make sure to take into account teh scenario 
 * that we call Pop() method on an empty stack. In this case, this method should show an InvalidOperationException. Remember your classes should always
 * be in a valid state and used properly. The Clear() method removes all objects from the stack. */


using System;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());            
            stack.Push(1);
            stack.Push("Mosh");
            Console.WriteLine(stack.Pop());
            stack.Push(2);
            stack.Push(3);
            stack.Clear();
            Console.WriteLine(stack.Pop());
        }
    }
}
