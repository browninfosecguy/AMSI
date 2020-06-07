using System;

namespace base64
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText;
            string encodedText;
            string base64ToPlainText;

            Console.WriteLine("Enter Text to Encode!");
            plainText = Console.ReadLine();

            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(plainText);

            encodedText = System.Convert.ToBase64String(data);

            Console.WriteLine("Encoded text " + encodedText);

            byte[] data2 = System.Convert.FromBase64String(encodedText);


            base64ToPlainText = System.Text.ASCIIEncoding.ASCII.GetString(data2);

            Console.WriteLine("Decoded String " + base64ToPlainText);


        }
    }
}
