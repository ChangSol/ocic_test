using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Protoss
{
    //유닛을 상속한 아칸 객체
    public class Archon : Unit
    {
        public Archon()
        {
            int _TribeCode = (int)TribeCodeEnum.Protoss;

            UnitCode = CommonEnum.UnitCode_Archon;
            TribeCode = _TribeCode;
            UnitName = CommonEnum.ArchonName;
            HP = CommonEnum.ArchonHP;
            Cost = CommonEnum.ArchonCost;
            AttackSpeed = CommonEnum.ArchonAttackSpeed;
            Power = CommonEnum.ArchonPower;
            MoveSpeed = CommonEnum.ArchonMoveSpeed;
            UnitSize = CommonEnum.ArchonSize;
            AttackRangeCode = CommonEnum.ArchonAttackRangeCode;
            FlyFlag = CommonEnum.ArchonFlyFlag;
        }
    }
}
