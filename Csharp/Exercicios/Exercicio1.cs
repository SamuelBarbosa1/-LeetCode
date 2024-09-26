using System;
using System.Collections.Generic;

class Program {
    public static int MostFrequent(int[] arr) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int mostFrequentElement = arr[0], maxCount = 0;

        foreach (int num in arr) {
            if (!frequency.ContainsKey(num))
                frequency[num] = 0;
            frequency[num]++;

            if (frequency[num] > maxCount) {
                maxCount = frequency[num];
                mostFrequentElement = num;
            }
        }

        return mostFrequentElement;
    }

    static void Main() {
        int[] array = { 1, 3, 2, 3, 4, 1, 3 };
        Console.WriteLine("Elemento que aparece mais vezes: " + MostFrequent(array));
    }
}
