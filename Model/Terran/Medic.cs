using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Terran
{
    //유닛을 상속한 메딕 객체
    public class Medic : Unit
    {
        public Medic()
        {
            int _TribeCode = (int)TribeCodeEnum.Terran;
            
            UnitCode = CommonEnum.UnitCode_Medic;
            TribeCode = _TribeCode;
            UnitName = CommonEnum.MedicName;
            HP = CommonEnum.MedicHP;
            Cost = CommonEnum.MedicCost;
            AttackSpeed = CommonEnum.MedicAttackSpeed;
            Power = CommonEnum.MedicPower;
            MoveSpeed = CommonEnum.MedicMoveSpeed;
            UnitSize = CommonEnum.MedicSize;
            AttackRangeCode = CommonEnum.MedicAttackRangeCode;
            FlyFlag = CommonEnum.MedicFlyFlag;
        }
    }
}