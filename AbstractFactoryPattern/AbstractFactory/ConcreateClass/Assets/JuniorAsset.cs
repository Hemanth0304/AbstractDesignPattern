using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    class JuniorAsset : Assets
    {
        public JuniorAsset()
        {
            Mobile = new Android();
            Laptop = new Windows();

            Console.WriteLine("Junior Gets Android Phone and Windows Laptop");
        }
    }
}
