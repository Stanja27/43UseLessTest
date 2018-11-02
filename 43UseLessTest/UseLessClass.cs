using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43UseLessTest
{
    public class UseLessClass
    {
        //en ny kommentar
        
        public string GetOutput(int number)
        {

            if ((number % 3 == 0) && (number % 5 == 0))

                return "Absurd Nonsense";
         
            if (number % 3 == 0)

                return "Absurd";


            if (number % 5 == 0)

                return "Nonsense";


            return number.ToString();

        }
    }
}
