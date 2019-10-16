using System;
using System.Collections.Generic;
using System.Text;

namespace Enforcing_Privacy_with_Cryptography
{
    class Encryption : Encrypt_Decrypt_Base
    {
        public Encryption(int input) : base(input) { }

        public string EncryptInput()
        {
            GetEncryptedValues();
            SwapDigits();

            return GetFinalOutput();
        }

        private void GetEncryptedValues()
        {
            Digit1 = EncryptValueFormula(Digit1);
            Digit2 = EncryptValueFormula(Digit2);
            Digit3 = EncryptValueFormula(Digit3);
            Digit4 = EncryptValueFormula(Digit4);
        }

        private int EncryptValueFormula(int digit)
        {
            digit = (digit + 7) % 10;

            return digit;

        }
    }
}
