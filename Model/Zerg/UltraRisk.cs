using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Zerg
{
    //유닛을 상속한 울트라리스크 객체
    public class UltraRisk : Unit
    {
        public UltraRisk()
        {
            int _TribeCode = (int)TribeCodeEnum.Zerg;

            UnitCode = CommonEnum.UnitCode_UltraRisk;
            TribeCode = _TribeCode;
            UnitName = CommonEnum.UltraRiskName;
            HP = CommonEnum.UltraRiskHP;
            Cost = CommonEnum.UltraRiskCost;
            AttackSpeed = CommonEnum.UltraRiskAttackSpeed;
            Power = CommonEnum.UltraRiskPower;
            MoveSpeed = CommonEnum.UltraRiskMoveSpeed;
            UnitSize = CommonEnum.UltraRiskSize;
            AttackRangeCode = CommonEnum.UltraRiskAttackRangeCode; 
            FlyFlag = CommonEnum.UltraRiskFlyFlag;
        }
    }
}
