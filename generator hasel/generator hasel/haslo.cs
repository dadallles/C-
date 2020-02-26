using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generator_hasel
{
    public class haslo
    {
        private string pass;
        private int length;
        private bool[] array = new bool[6];

        public haslo(int length_, bool[] array_)
        {
            length = length_;
            pass = "";
            array = array_;
        }

        public string get_pass()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            char sign;
            pass = "";

            for (int i = 0; i < length; i++)
            {
                while (true)
                {
                    sign = (char)(rnd.Next() % 128);

                    if (array[5] && (sign == 73 || sign == 105 || sign == 124 || sign == 79 || sign == 111 || sign == 48)) continue;
                    else if (array[0] && sign >= 97 && sign <= 122) break;
                    else if (array[1] && sign >= 65 && sign <= 90) break;
                    else if (array[2] && sign >= 48 && sign <= 57) break;
                    else if (array[3] && (sign == 33 || sign == 34 || sign == 39 || sign == 40 || sign == 41 || sign == 44 || sign == 45 || sign == 46 || sign == 58 || sign == 59 || sign == 63 || sign == 91 || sign == 93 || sign == 123 || sign == 124 || sign == 125)) break;
                    else if (array[4] && (sign >= 35 && sign <= 38 || sign == 42 || sign == 43 || sign == 45 || sign == 47 || sign == 60 || sign == 61 || sign == 62 || sign == 64 || sign == 92 || sign == 94)) break;
                }
                pass += sign;
            }

            return pass;
        }
    }
}
