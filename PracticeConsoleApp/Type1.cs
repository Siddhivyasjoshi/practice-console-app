using System.Collections.Generic;

namespace PracticeConsoleApp
{
    class Type1 : IGenericType
    {
        public  Dictionary<int, string> GetData()
        {
            return new Dictionary<int, string>
            {
                {1, "Himanshu"},
                {2, "Rudresh"},
                {3, "Milan"},
                {4, "Nirav"},
                {5, "Jaydeep"},
                {6, "Shubham"},
                {7, "Snehal"},
                {8, "Jaydeep V"},
                {9, "Matsuuro"},
                {10, "Arai San"}
            };
        }
    }
}
