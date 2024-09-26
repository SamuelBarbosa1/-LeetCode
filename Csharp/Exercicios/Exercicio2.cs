using System;

namespace Exercicios {
    public class Exercicio2 {
        public static int BinarySearch(int[] arr, int target) {
            int low = 0, high = arr.Length - 1;

            while (low <= high) {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1; // Não encontrado
        }

        public static void Run() {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int target = 5;
            Console.WriteLine("Índice do elemento: " + BinarySearch(array, target));
        }
    }
}
