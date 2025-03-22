using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.ArrayListOperations
{
    public class ArrayListBase
    {
        protected  int[] array;
        protected int size;
        protected int capacity;

        public  ArrayListBase(int capacity = 4)
        {
            array = new int[capacity];
            size = 0;
        }

        protected  void Resize()
        {
            int newSize = array.Length * 2;
            int[] newArray = new int[newSize];
            Array.Copy(array, newArray, size);
            array = newArray;
        }

        public int Size => size;
        public int Capacity => array.Length;
    }
}
