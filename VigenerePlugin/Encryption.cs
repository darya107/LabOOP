using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace VigenerePlugin
{
  

        public class Encryption
        {
            private string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private string _key = "POLINA";

            private readonly string _expression;

            public Encryption(string expression)
            {
                _expression = expression;
            }

            public string Vigener(bool encrypting)
            {
                if (string.IsNullOrEmpty(_key))
                    throw new Exception("Key is empty");

                var result = new StringBuilder();
                int keyIndex = 0;

                foreach (char c in _expression)
                {
                    int textIndex = _alphabet.IndexOf(char.ToUpper(c));

                    
                    if (textIndex < 0)
                    {
                        result.Append(c);
                        continue;
                    }

                    int k = _alphabet.IndexOf(_key[keyIndex % _key.Length]);

                    int newIndex = encrypting
                        ? (textIndex + k) % _alphabet.Length
                        : (textIndex - k + _alphabet.Length) % _alphabet.Length;

                    char newChar = _alphabet[newIndex];

                    result.Append(char.IsLower(c) ? char.ToLower(newChar) : newChar);

                    keyIndex++;
                }

                return result.ToString();
            }
        }
    }
