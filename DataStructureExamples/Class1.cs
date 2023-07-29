using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExamples
{
    internal class Class1
    {
        public static void States()
        {
            Dictionary<int, string> ArmStates = new Dictionary<int, string>();
            ArmStates.Add(1, "Armavir");
            ArmStates.Add(2, "Ararat");
            ArmStates.Add(3, "Vayoc Dzor");
            ArmStates.Add(4, "Yerevan");
            ArmStates.Add(5, "Shirak");
            ArmStates.Add(6, "Kotayq");
            ArmStates.Add(7, "Shirak");
            ArmStates.Add(8, "Lori");
            ArmStates.Add(9, "Syuniq");
            ArmStates.Add(10, "Aragacotni");
            ArmStates.Add(11, "Gexarquniq");

            foreach (var state in ArmStates)
            {
                Console.WriteLine("{0} and {1}", state.Key, state.Value);
            }
        }

        public static void ListExample()
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(56);
            myList.Add(14);
            myList.Add(1211);
            myList.Add(134);
            int max = myList.Max();
            int maxVal = myList.Select(x => x).Max();
            Console.WriteLine("List example ---{0}", max);
            Console.WriteLine("List example ---{0}", maxVal);
        }

        public static void QueueExample()
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(323);
            numbers.Enqueue(54);
            numbers.Enqueue(45);
            int max = numbers.Select(x => x).Max();
            Console.WriteLine("Queue example - {0}", max);

        }

        public static void DictionaryExample()
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            numbers.Add(1, 13);
            numbers.Add(2, 41);
            numbers.Add(3, 21);
            numbers.Add(4, 154);
            numbers.Add(5, 21);
            numbers.Add(6, 121);
            numbers.Add(7, 11);
            int max = numbers.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
            Console.WriteLine("Dictionary max is --- {0}", max);
        }

        public static void StackExample()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(10);
            numbers.Push(67);
            numbers.Push(12);
            numbers.Push(78);
            numbers.Push(13);
            int max = numbers.Select(x => x).Max();
            int max2 = numbers.Aggregate((x, y) => x > y ? x : y);
            Console.WriteLine("Stack max value is {0}", max);
            Console.WriteLine("Stack max value2 is {0}", max2);
        }

        public static void LinkedListExample()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(10);
            numbers.AddLast(1000);
            numbers.AddLast(103);
            numbers.AddLast(230);
            numbers.AddLast(1);
            var max = numbers.Select(a => a).Max();
            Console.WriteLine("LinkedList max value is {0}", max);
        }
    }
}
