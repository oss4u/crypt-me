using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptMe.utils
{
    class Base64
    {
        public static Stream EncodeBase64(Stream streamToEncode)
        {
            byte[] bytesToEncode;
            using (var msToEncode = new MemoryStream())
            {
                streamToEncode.CopyTo(msToEncode);
                bytesToEncode = msToEncode.ToArray();
            }
            string encodedString = Convert.ToBase64String(bytesToEncode);
            return new MemoryStream(Encoding.UTF8.GetBytes(encodedString));
        }

        public static Stream DecodeBase64(Stream streamToDecode)
        {
            string stringToDecode;
            using (var msToDecode = new MemoryStream())
            {
                streamToDecode.CopyTo(msToDecode);
                stringToDecode = msToDecode.ToString();
            }

            byte[] decodedBytes = Convert.FromBase64String(stringToDecode);
            return new MemoryStream(decodedBytes);
        }

    }
}
