using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Protoss
{
    //유닛을 상속한 스카웃 객체
    public class Scout : Unit
    {
        public Scout()
        {
            int _TribeCode = (int)TribeCodeEnum.Protoss;

            UnitCode = CommonEnum.UnitCode_Scout;
            TribeCode = _TribeCode;
            UnitName = CommonEnum.ScoutName;
            HP = CommonEnum.ScoutHP;
            Cost = CommonEnum.ScoutCost;
            AttackSpeed = CommonEnum.ScoutAttackSpeed;
            Power = CommonEnum.ScoutPower;
            MoveSpeed = CommonEnum.ScoutMoveSpeed;
            UnitSize = CommonEnum.ScoutSize;
            AttackRangeCode = CommonEnum.ScoutAttackRangeCode;
            FlyFlag = CommonEnum.ScoutFlyFlag;
        }
    }
}
