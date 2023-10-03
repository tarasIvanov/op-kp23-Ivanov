using System;
using System.Numerics;

namespace ForAll.task3
{
    class Vector
    {
        private List<double> _vectors = new List<double>();

        public Vector(params double[] vectors)
        {
            foreach (var item in vectors)
            {
                _vectors.Add(item);
            }
        }

        public static double operator <(Vector vector1, int num)
        {
            double sum = 0;

            foreach (var item in vector1._vectors)
            {
                if (item < num)
                {
                    sum += item;
                }
            }

            return sum;
        }

        public static double operator %(Vector vector1, int num)
        {
            double sum = 1;

            for (int i = 0; i < vector1._vectors.Capacity; i += num)
            {
                if (i < vector1._vectors.Capacity)
                {
                    sum *= vector1._vectors[i];
                }
            }

            return sum;
        }

        public static int operator ==(Vector vector, int num)
        {
            int counter = 0;

            foreach (var item in vector._vectors)
            {
                if (item == num)
                {
                    counter++;
                }
            }

            return counter;
        }


        public static double operator >(Vector vector1, int num)
        {
            double sum = 0;

            foreach (var item in vector1._vectors)
            {
                if (item > num)
                {
                    sum += item;
                }
            }

            return sum;
        }

        public static int operator !=(Vector vector, int num)
        {
            int counter = 0;

            foreach (var item in vector._vectors)
            {
                if (item != num)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}

