using System;
using System.Collections.Generic;
using System.Linq;

namespace CaesarCipher
{
    public class Cipher
    {
        private IDictionary<int, char> Alphabet { get; set; }
        

        public Cipher()
        {
            Alphabet = new Dictionary<int, char>();

            for(var c = 'A'; c <= 'Z'; c++)
            {
                var key = c - 'A';
                Alphabet.Add(key, c);
            }
        }

        public string Encrypt(string value)
        {
            var result = "";
            foreach (var c in value)
            {
                var key = Alphabet.FirstOrDefault(x => x.Value == char.ToUpper(c)).Key;
                var keyEncrypted = ((key + 3) % 26 + 26) % 26;
                
                result = result.Insert(result.Length,  Alphabet[keyEncrypted].ToString());
            }
            return result;
        }
        public string Decrypt(string value)
        {
            var result = "";
            foreach (var c in value)
            {
                var key = Alphabet.FirstOrDefault(x => x.Value == char.ToUpper(c)).Key;
                var keyDecrypted = ((key - 3) % 26 + 26) % 26;
                
                result = result.Insert(result.Length,  Alphabet[keyDecrypted].ToString());
            }
            
            return result;
        }
    }
}