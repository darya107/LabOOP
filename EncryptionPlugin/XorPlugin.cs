using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstLab;

namespace EncryptionPlugin
{
    public class XorPlugin : IProcessingPlugin
    {
        public string Name => "XOR Cipher";

        public override string ToString() => Name;

        private char key = 'K';

        public string ProcessBeforeSave(string data)
        {
            return new string(data.Select(c => (char)(c ^ key)).ToArray());
        }

        public string ProcessAfterLoad(string data)
        {
            return new string(data.Select(c => (char)(c ^ key)).ToArray());
        }
    }
}
