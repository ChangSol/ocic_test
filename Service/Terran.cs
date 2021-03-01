using Model.Base;
using Model.Terran;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    //추상클래스를 상속받아 테란 유닛 정의
    class Terran : BaseService
    {
        //추상메서드 오버라이드
        public override void AddUnit(string p_UnitName)
        {    
            switch (p_UnitName)
            {
                case CommonEnum.MarineName:
                    UnitList.Add(new Marine());
                    break;
                case CommonEnum.MedicName:
                    UnitList.Add(new Medic());
                    break;
            }
        }

    }
}
