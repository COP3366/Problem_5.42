using System;
using System.Collections.Generic;
using System.Text;

namespace Enforcing_Privacy_with_Cryptography
{
    class Decryption : Encrypt_Decrypt_Base
    {
        public Decryption(int input) : base(input) { }

        public string DecryptInput()
        {
            GetDecryptedValues();
            SwapDigits();

            return GetFinalOutput();
        }

        private void GetDecryptedValues()
        {
            Digit1 = DecryptValueFormula(Digit1);
            Digit2 = DecryptValueFormula(Digit2);
            Digit3 = DecryptValueFormula(Digit3);
            Digit4 = DecryptValueFormula(Digit4);
        }

        private int DecryptValueFormula(int digit)
        {
            digit = ((digit - 7) + 10) % 10;
            return digit;
        }
    }
}
