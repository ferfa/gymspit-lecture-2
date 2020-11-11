using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArrayPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputA = new int();
            int inputB = new int();
            bool inputIsInt;

            do
            {
                inputIsInt = true;
                try
                {
                    Console.Write("Napis cislo a (0-128): ");
                    inputA = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    inputIsInt = false;
                }

                if (inputIsInt && inputA >= 0 && inputA <= 128) {
                    break;
                }

                inputIsInt = false;
                Console.WriteLine("Chyba! Zkus to znovu.");
            }
            while (inputIsInt == false);

            do
            {
                inputIsInt = true;
                try
                {
                    Console.Write("Napis cislo b (0-128): ");
                    inputB = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    inputIsInt = false;
                }

                if (inputIsInt && inputB >= 0 && inputB <= 128)
                {
                    break;
                }

                inputIsInt = false;
                Console.WriteLine("Chyba! Zkus to znovu.");
            }
            while (inputIsInt == false);

            var BArrayA = new BitArray(new byte[] { (byte)inputA });
            var BArrayB = new BitArray(new byte[] { (byte)inputB });

            Console.WriteLine();
            Console.WriteLine($"            a: { BitsToString(BArrayA) } <- { inputA }");
            Console.WriteLine($"            b: { BitsToString(BArrayB) } <- { inputB }");
            Console.WriteLine();
            Console.WriteLine($"        NOT a: { BitsToString(new BitArray(BArrayA).Not()) }");
            Console.WriteLine($"        NOT b: { BitsToString(new BitArray(BArrayB).Not()) }");
            Console.WriteLine();
            Console.WriteLine($"           OR: { BitsToString(new BitArray(BArrayA).Or(BArrayB)) }");
            Console.WriteLine($"          XOR: { BitsToString(new BitArray(BArrayA).Xor(BArrayB)) }");
            Console.WriteLine();
            BArrayA.SetAll(false);
            Console.WriteLine($"SetAll(false): { BitsToString(BArrayA) }");
            BArrayA.SetAll(true);
            Console.WriteLine($" SetAll(true): { BitsToString(BArrayA) }");
            Console.WriteLine();
            Console.WriteLine("fin");
            Console.ReadKey();
        }

        public static string BitsToString(BitArray bitArray)
        {
            string output = "";

            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                output += (bitArray[i] ? "1" : "0");
            }

            return output;
        }
    }
}
