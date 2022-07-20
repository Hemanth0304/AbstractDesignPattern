using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.AbstractFactory;

namespace AbstractFactoryPattern.AbstractFactory.Factory
{
    class AssetFactory
    {
        public static Assets GetAssets(string employeeType)
        {
            Assets asset;
            switch (employeeType)
                {
                case "FullTime": asset = new ExecutiveAsset();
                    break;
                case "Contract":
                    asset = new ExecutiveAsset();
                    break;
                case "Trainee":
                    asset = new JuniorAsset();
                    break;
                default:
                    asset = new JuniorAsset();
                    break;



            }
            return asset;
        }
    }
}
