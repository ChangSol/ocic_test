using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Terran
{
    //유닛을 상속한 마린 객체
    public class Marine : Unit
    {
        public Marine()
        {
            int _TribeCode = (int)TribeCodeEnum.Terran;
            
            UnitCode = CommonEnum.UnitCode_Marine;
            TribeCode = _TribeCode;
            UnitName = CommonEnum.MarineName;
            HP = CommonEnum.MarineHP;
            Cost = CommonEnum.MarineCost;
            AttackSpeed = CommonEnum.MarineAttackSpeed;
            Power = CommonEnum.MarinePower;
            MoveSpeed = CommonEnum.MarineMoveSpeed;
            UnitSize = CommonEnum.MarineSize;
            AttackRangeCode = CommonEnum.MarineAttackRangeCode;
            FlyFlag = CommonEnum.MarineFlyFlag;
        }
    }
}
