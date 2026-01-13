using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.skirnevskyBR.sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r' };
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            bool containsHello = words.Any(word => word == "Hello");

            return containsHello;
        }
    }
}