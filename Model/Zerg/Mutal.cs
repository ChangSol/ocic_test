using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Zerg
{
    //유닛을 상속한 뮤탈 객체
    public class Mutal : Unit
    {
        public Mutal()
        {
            int _TribeCode = (int)TribeCodeEnum.Zerg;

            UnitCode = CommonEnum.UnitCode_Mutal;
            TribeCode = _TribeCode;
            UnitName = CommonEnum.MutalName;
            HP = CommonEnum.MutalHP;
            Cost = CommonEnum.MutalCost;
            AttackSpeed = CommonEnum.MutalAttackSpeed;
            Power = CommonEnum.MutalPower;
            MoveSpeed = CommonEnum.MutalMoveSpeed;
            UnitSize = CommonEnum.MutalSize;
            AttackRangeCode = CommonEnum.MutalAttackRangeCode;
            FlyFlag = CommonEnum.MutalFlyFlag;
        }
    }
}
