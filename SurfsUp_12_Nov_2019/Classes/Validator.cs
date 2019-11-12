using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurfsUp_12_Nov_2019.Classes;
using System.IO;

namespace SurfsUp_12_Nov_2019.Classes
{
    class Validator
    {
        static public bool ValidateFile()
        {
            bool valid = false;
            string archive = @"C:\Users\mtorr\source\repos\SurfsUp_12_Nov_2019\results.txt";
            if (File.Exists(archive))
            {
                valid = true;
            }
            return valid; //return  a boolean (valid), for further usage in the DisplayScores() method from the ScoreSorting class
        }
    }
}
