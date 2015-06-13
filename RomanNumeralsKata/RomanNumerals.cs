using System.Text;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public static string arabicToRoman(int arabic)
        {
            StringBuilder sb = new StringBuilder();
            if (arabic == 4)
                return "IV";
            for (int i = 0; i < arabic; i++)
            {
                sb.Append("I");
            }
            string output = sb.ToString();
            return output.Replace("IIIII", "V");
        }
    }
}
