using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.skirnevskyBR.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            int x;
            if (value[0] == '0')
                return false;
            if (value[0] == '-')
                return false;
            if (value == "0")
                return false;
            return x = Convert.ToInt32(value);
            
        }
    }
}
