using System;
using System.Collections.Generic;
using System.Text;

namespace Enforcing_Privacy_with_Cryptography
{
    class Encrypt_Decrypt_Base
    {
        public Encrypt_Decrypt_Base(int input)
        {
            Input = input;
            Digit4 = GetDigits();
            Digit3 = GetDigits();
            Digit2 = GetDigits();
            Digit1 = GetDigits();
        }

        public int Input { get; set; }
        public int Encrypt { get; set; }
        public int Digit1 { get; set; }
        public int Digit2 { get; set; }
        public int Digit3 { get; set; }
        public int Digit4 { get; set; }

        public int GetDigits()
        {
            int digit = Input % 10;
            Input /= 10;

            return digit;
        }

        public void SwapDigits()
        {
            int temp = 0;
            temp = Digit1;
            Digit1 = Digit3;
            Digit3 = Digit1;

            temp = Digit2;
            Digit2 = Digit4;
            Digit4 = temp;
        }

        public string GetFinalOutput()
        {
            return Digit1.ToString() + Digit2.ToString() + Digit3.ToString() +
                Digit4.ToString();
        }
    }
}
