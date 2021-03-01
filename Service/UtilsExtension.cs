using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class UtilsExtension
    {

        //데이터가 없어 임의 메소드 
        public static string GetAttackRangeName(int AttackRangeCode)
        {
            switch (AttackRangeCode)
            {
                case 1:
                    return "지상";
                case 2:
                    return "공중";
                case 3:
                    return "지상/공중";
                case 4:
                    return "힐";
                default:
                    return "";
            }
        }

        public static string GetFlyFlagOX(bool FlyFlag)
        {
            if (FlyFlag) return "O";
            else return "X";
        }
    }
}
