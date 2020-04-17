using System.Collections.Generic;

namespace PracticeConsoleApp
{
    class Type2 : IGenericType
    {
        public Dictionary<int, string> GetData()
        {
            return new Dictionary<int, string>
            {
                {1, "Vinchhi"},
                {2, "Bhatt"},
                {3, "Tripathi"},
                {4, "Liya"},
                {5, "Parmar"},
                {7, "Savaliya"},
                {8, "Vasoya"}
            };
        }
    }
}
