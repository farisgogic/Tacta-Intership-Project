using System;
using System.Collections.Generic;
using System.Text;

namespace TactaIntershipProject.Model
{
    public class ShopperException : Exception
    {
        public ShopperException(string poruka) : base(poruka)
        {

        }
    }
}
