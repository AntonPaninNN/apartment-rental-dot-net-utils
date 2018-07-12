using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUtils.Encryption.Enums;
using WebUtils.Encryption.Impl;

namespace WebUtils.Encryption.Factory
{
    public class EncrypterFactory
    {
        public static IEncrypter CreateEncrypter(EncrypterType eType)
        {
            if (eType == EncrypterType.MD5)
                return new MD5Encrypter();
            else
                return null;
        }
    }
}
