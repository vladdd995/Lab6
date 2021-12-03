using System.Security.Cryptography;

namespace Lab6
{
    internal class PassWordGen
    {
        private readonly string passWord;
        private readonly int myLength;
        private const int myIterations = 1000; 

        private readonly byte[] salt0 = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }; 
        private byte[] _result;

        public PassWordGen(string usageText, string usageLen) 
        {
            passWord = usageText; 
            myLength = int.Parse(usageLen); 
        }

        public byte[] Result
        {
            get
            {
                _result = Calculations(passWord, myLength);
                return _result;
            }
            set
            {

            }
        }

        private byte[] Calculations(string passWord, int len)
        {
            Rfc2898DeriveBytes k0 = new Rfc2898DeriveBytes(passWord, salt0);
            byte[] key = k0.GetBytes(len);
            return key;
        }

    }
}
