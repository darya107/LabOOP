using firstLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VigenerePlugin
{
    public class VigenereAdapter : IProcessingPlugin
    {
        public string Name => "Vigenere Cipher";

        public string ProcessBeforeSave(string data)
        {
            var enc = new Encryption(data);
            return enc.Vigener(true);
        }

        public string ProcessAfterLoad(string data)
        {
            var enc = new Encryption(data);
            return enc.Vigener(false);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}