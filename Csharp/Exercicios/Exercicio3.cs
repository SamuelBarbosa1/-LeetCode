using System;

namespace Exercicios {
    public class Exercicio3 {
        public static bool IsPalindrome(string str) {
            int left = 0, right = str.Length - 1;

            while (left < right) {
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }

        public static void Run() {
            string word = "radar";
            Console.WriteLine("É palíndromo? " + IsPalindrome(word));
        }
    }
}
