using System;

namespace IntroOOP_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ACoder ac = new ACoder();
            BCoder bc = new BCoder();

            string encoded = ac.Encode("ALEXANDER starodubtsev");
            string decoded = ac.Decode(encoded);

            Console.WriteLine($"{encoded}\n{decoded}");

            Console.Write("\n");

            string encoded2 = bc.Encode("The quick brown fox jumps over the lazy dog.");
            string decoded2 = bc.Decode(encoded2);

            Console.WriteLine($"{encoded2}\n{decoded2}");
        }
    }
}
