using System;

namespace _33_ler_numeros_usando_generic.Services
{
    class PrintService<T>
    {
        private readonly T[] Values = new T[10];
        private int Count = 0;
        public void AddValue(T value)
        {
            if(Count == 10)
            {
                throw new InvalidOperationException("PrintService is already full");
            }

            Values[Count] = value;
            Count++;
        }
        public T First()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("No numbers to print");
            }

            return Values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < Count - 1; i++)
            {
                Console.Write(Values[i] + ", ");
            }
            if(Count > 0)
            {
                Console.Write(Values[Count - 1]);
            }

            Console.WriteLine("]");
        }
    }
}
