using System;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        //decryptedMsg = cryptedMsg^d mod N

        // cryptedMsg
        BigInteger encryptedText = new BigInteger(102341418);

        // private Key
        var d = 19;
        var n = 481;

        int[] secretMsg = { 102, 341, 418 };

        // dictionary for decrypting
        Dictionary<string, int> letterValues = new Dictionary<string, int>()
        {
            { "A", 11 },
            { "B", 12 },
            { "C", 13 },
            { "D", 14 },
            { "E", 15 },
            { "F", 16 },
            { "G", 17 },
            { "H", 18 },
            { "I", 19 },
            { "J", 20 },
            { "K", 21 },
            { "L", 22 },
            { "M", 23 },
            { "N", 24 },
            { "O", 25 },
            { "P", 26 },
            { "Q", 27 },
            { "R", 28 },
            { "S", 29 },
            { "T", 30 },
            { "U", 31 },
            { "V", 32 },
            { "W", 33 },
            { "X", 34 },
            { "Y", 35 },
            { "Z", 36 }
        };

        BigInteger result = BigInteger.ModPow(secretMsg[0], d, n);

        // msg decrypting


        // public Key calc


        // output
        Console.WriteLine(result);
        Console.WriteLine("Message decrypted: " );
        Console.WriteLine("public Key: " );
    }
}
