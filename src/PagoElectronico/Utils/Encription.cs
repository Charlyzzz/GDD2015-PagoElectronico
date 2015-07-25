using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PagoElectronico.Utils
{
    class Encription
    {
        public string encryptToSHA256(string toEncrypt) {
            var newHash = SHA256.Create();
            var bitArray = newHash.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt));
            var sBuilder = new StringBuilder();
            foreach (Byte b in bitArray) {
                sBuilder.Append(b.ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public string encryptToMD5(string toEncrypt) {
            var hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(toEncrypt));
            var sBuilder = new StringBuilder();
            hash.ToList().ForEach(i => sBuilder.Append(i.ToString("x2")));
            return sBuilder.ToString();
        }
    }
}
