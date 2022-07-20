using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    class ExecutiveAsset : Assets
    { 
        public ExecutiveAsset()
        {
            Mobile = new IOS();
            Laptop = new Mac();

            Console.WriteLine("Executive Gets Apple Phone and Laptop");
        }

    }
}
