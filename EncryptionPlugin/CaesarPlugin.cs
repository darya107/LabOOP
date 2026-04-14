using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstLab;

namespace EncryptionPlugin
{
    public class CaesarPlugin : IProcessingPlugin   
    {
        public string Name => "Caesar Cipher";

        public override string ToString() => Name;

        private int shift = 3;

        public string ProcessBeforeSave(string data)
        {
            return new string(data.Select(c => (char)(c + shift)).ToArray());
        }

        public string ProcessAfterLoad(string data)
        {
            return new string(data.Select(c => (char)(c - shift)).ToArray());
        }
    }
}
