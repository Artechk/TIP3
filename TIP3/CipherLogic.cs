using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIP3
{
    public static class CipherLogic
    {
        public static string Encrypt(string text, int key, string alphabet)
        {
            return ProcessCaesarCipher(text, key, alphabet, true);
        }

        public static string Decrypt(string text, int key, string alphabet)
        {
            return ProcessCaesarCipher(text, key, alphabet, false);
        }

        private static string ProcessCaesarCipher(string text, int key, string alphabet, bool isEncrypt)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (alphabet.Contains(c))
                {
                    int oldIndex = alphabet.IndexOf(c);
                    int newIndex = isEncrypt
                        ? (oldIndex + key) % alphabet.Length
                        : (oldIndex - key + alphabet.Length) % alphabet.Length;
                    result[i] = alphabet[newIndex];
                }
                else
                {
                    result[i] = c; // Keep non-alphabetic characters as is
                }
            }

            return new string(result);
        }
    }
}
