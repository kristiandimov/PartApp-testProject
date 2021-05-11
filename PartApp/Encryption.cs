using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PartApp
{
    public class Encryption
    {
      
        public String Encrypt(string pass)
        {
            byte[] val = Encoding.UTF8.GetBytes(pass.ToString());           
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);

            }
        }

        //public String Dencrypt(string pass)
        //{
        //    byte[] val = Convert.FromBase64String(pass);
        //    using (SHA1Managed sha1 = new SHA1Managed())
        //    {
        //        var hash = sha1.ComputeHash(val);
        //        return Encoding.UTF8.GetBytes(hash.ToString());

        //    }
        //}

    }
}
