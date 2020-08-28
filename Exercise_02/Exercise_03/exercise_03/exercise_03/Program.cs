using System;

namespace exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerValues = new [] { 1, 2, 3 };
            var integersValuesName = nameof(integerValues);

            for (var i = 0; i < integerValues.Length; i++)
            {
                var name = nameof(integerValues);
                var value = integerValues[i];

                Console.WriteLine($"Index {i} i arrayen {nameof(integerValues)} har vardet: {integerValues[i]}");
            }

            var doWhileIndex = 0;

            do
            {
                int value = integerValues[doWhileIndex];

                Console.WriteLine($"Index {doWhileIndex} i arrayen {integersValuesName} har vardet: {value}");

                doWhileIndex++;
            }
            while (doWhileIndex < integerValues.Length);

            var whileIndex = 0;

            while whileIndex
                < integerValues.Length)
            {
                var value = integerValues[whileIndex];

                Console.WriteLine($"While Index {whileIndex} i arrayen {integersValuesName} har vardet: {value}");
            }


        }
    }
}
