using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Busıness
{
    public class DuplicateProductException:Exception
    {
        public DuplicateProductException(string message):base(message)
        {

        }
    }
}
