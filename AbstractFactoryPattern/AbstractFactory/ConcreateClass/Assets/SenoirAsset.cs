using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    class SenoirAsset : Assets
    {
        public SenoirAsset()
        {
            Mobile = new IOS();
            Laptop = new Windows();

            Console.WriteLine("Senior Gets Apple Phone and Windows Laptop");
        }
    }
}
