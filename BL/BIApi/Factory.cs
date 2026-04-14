using BIApi;
using BlImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIApi
{
    public  static class Factory
    {
        public static  IBl Get()
        {
            IBl bI = new Bl();
            return bI;
        }
    }
}

