using System;
using System.Collections;
using System.Linq;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bArray = { 0x31, 0xff, 0x90 };
            string strHex = BitConverter.ToString(bArray).Replace("-", string.Empty);
            Console.WriteLine(strHex);
            
            byte[] bytes = new byte[strHex.Length / 2];
            for (int i = 0; i < strHex.Length; i += 2)
                Console.WriteLine(bytes[i / 2] = Convert.ToByte(strHex.Substring(i, 2), 16));
            
            // Store integer 182
            int intValue = 49;
            // Convert integer 182 as a hex in a string variable
            Console.WriteLine( intValue.ToString("X"));
            // Convert the hex string back to the number
            //int intAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
        }
    }
}