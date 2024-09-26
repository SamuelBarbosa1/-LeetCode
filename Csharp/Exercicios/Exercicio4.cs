using System;

namespace Exercicios {
    public class Exercicio4 {
        public static string ReverseString(string str) {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Run() {
            string word = "Golang";
            Console.WriteLine("String invertida: " + ReverseString(word));
        }
    }
}
