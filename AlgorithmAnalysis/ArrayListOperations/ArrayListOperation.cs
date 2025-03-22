using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.ArrayListOperations
{
    public class ArrayListOperation : ArrayListBase
    {
        public ArrayListOperation(int capacity = 4) : base(capacity) { }

        public void Add(int item)
        {
            if (size == array.Length)
            {
                Resize();
            }
            array[size] = item;
            size++;
        }
        public int[] GetArray()
        {
            return array.Take(size).ToArray();
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("Invalid index!");
                return;
            }

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }

            size--;
        }
        public int Search(int item)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Update(int index, int newValue)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("Invalid index!");
                return;
            }

            array[index] = newValue;
        }


    }

}
