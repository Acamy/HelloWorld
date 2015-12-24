using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 石头剪刀布
{
    class Player
    {
        public int ShowFist(string str)
        {
            int number=0;
            switch (str)
            {
                case "石头":number=1;
                    break;
                case "剪刀":number=2;
                    break;
                case "布": number = 3;
                    break;
            }
            return number;
        }
    }
}
