using System.Collections.Generic;

namespace PracticeConsoleApp
{
    class Type3 : IGenericType
    {
        public Dictionary<int, string> GetData()
        {
            return new Dictionary<int, string>
            {
                {1, "Tieto"},
                {2, "Citius Tech"},
                {3, "Acty"},
                {4, "Accenture"},
                {5, "Rakuten"},
                {5, "Rakuten"},
                {6, "ITC"},
                {7, "Snehal"},
                {10, "Consultant"}
            };
        }
    }
}
