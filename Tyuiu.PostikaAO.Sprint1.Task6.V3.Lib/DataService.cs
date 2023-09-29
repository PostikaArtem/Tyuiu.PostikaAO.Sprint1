using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PostikaAO.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] temp = value.Split(' ');  
            string res = "";
            foreach (string item in temp) 
            {
                res += item[item.Length - 1];
            }

            return res;
        }
    }
}
