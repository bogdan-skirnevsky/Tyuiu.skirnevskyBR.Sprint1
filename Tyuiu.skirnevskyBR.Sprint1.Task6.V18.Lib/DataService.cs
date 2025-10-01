﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.skirnevskyBR.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            return string.Join(" "value.Split(' ', StringSplitOptions.RemoveEmptyEntries.Where(w => w.IndexOf("нн", StringComparison.OrdinalIgnoreCase) >= 0));
        }
    }
}