using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Validations
{
    public static class IsIsraelIdentity
    {
        // Extintion method to valedate the geven id whether isrel id number or not
        public static bool IsIsraelIdentityNumber(this string id)
        {
            int sum = 0;
            int counter = 1;
            string temp;
            string ch;
            if (id.Length == 9)
            {
                foreach (char cha in id)
                {
                    ch = Convert.ToString(cha);
                    if (counter % 2 == 0)
                    {
                        if (Convert.ToInt32(ch) * 2 > 9)
                        {
                            temp = Convert.ToString(Convert.ToInt32(ch) * 2);
                            sum += Convert.ToInt32(Convert.ToString(temp[0])) + Convert.ToInt32(Convert.ToString(temp[1]));
                        }
                        else
                        {
                            sum += Convert.ToInt32(ch) * 2;
                        }
                    }
                    else
                    {
                        sum += Convert.ToInt32(ch);
                    }
                    counter++;
                }
                if (sum % 10 == 0)
                    return true;
            }
            return false;
        }
    }
}
