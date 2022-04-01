using System;
using System.Collections.Generic;

namespace Test 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            List<string> strList = new List<string>();
            strList.Add("Test");
            strList.Add("Test2");
            strList.Add("Test3");
            strList.Add("Test5");
            strList.Add("Test6");
            strList.Add("Test7");
            strList.Add("Test8");
            strList.Add("Test9");
            strList.Add("Test11");

            foreach(var str in strList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
