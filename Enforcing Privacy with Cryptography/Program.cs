using System;

namespace Enforcing_Privacy_with_Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 4 digit integer to encrypt: ");
            var encryptInput = Console.ReadLine();
            while (encryptInput.Length != 4)
            {
                Console.WriteLine("Please enter 4 digit number: ");
                encryptInput = Console.ReadLine();
            }
            var encr = new Encryption(Convert.ToInt32(encryptInput));
            Console.WriteLine("The encryupted value of {0} IServiceProvider {1}", encryptInput, encr.EncryptInput());

            Console.Write("enter a 4 digit integer to decrpyt: ");
            var decryptInput = Console.ReadLine();
            while (decryptInput.Length != 4)
            {
                Console.WriteLine("Please enter 4 digit number: ");
                decryptInput = Console.ReadLine();
            }

            var decr = new Decryption(Convert.ToInt32(decryptInput));
            Console.WriteLine("the decrypted value of {0} is {1}", decryptInput, decr.DecryptInput());

            


        }
    }
}
