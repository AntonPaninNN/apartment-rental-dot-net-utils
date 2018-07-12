using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUtils.Encryption
{
    public interface IEncrypter
    {
        string GetHash(string input);
    }
}
