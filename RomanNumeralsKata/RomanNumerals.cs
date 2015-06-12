using System.Text;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public static string arabicToRoman(int arabic)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arabic; i++)
            {
                sb.Append("I");
            }
            return sb.ToString();
        }
    }
}
