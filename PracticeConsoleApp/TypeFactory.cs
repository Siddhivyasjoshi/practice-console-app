using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class TypeFactory
    {
        public IGenericType GetType(TypeEnum type)
        {
            switch (type)
            {
                case TypeEnum.one:
                    return new Type1();
                case TypeEnum.two:
                    return new Type2();
                case TypeEnum.three:
                    return new Type3();
                default:
                    // type not found. implement the new type and add it here. 
                    return null;
            }
        }
    }
}
