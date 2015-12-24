using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 石头剪刀布
{
    public enum Result
        {
            玩家赢,
            电脑赢,
            平手
        }
    class Judge
    {
        public static Result Judging(int playerNumber,int computerNumber)
        {
            if (playerNumber - computerNumber == -1 || playerNumber - computerNumber == 2)
            {
                return Result.玩家赢;
            }
            else if (playerNumber-computerNumber==0)
            {
                return Result.平手;
            }
            else
            {
                return Result.电脑赢;
            }
        }
    }
}
