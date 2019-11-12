using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SurfsUp_12_Nov_2019.Classes
{
    class FileReader
    {
        static public string[] ReadFile()
        {
            string[] readyFile = File.ReadAllLines(@"C:\Users\mtorr\source\repos\SurfsUp_12_Nov_2019\results.txt");
            return readyFile;   //An array with these names and numbers both is returned for the SortScores method.
        }
    }
}
