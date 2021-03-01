using Model.Base;
using Model.Zerg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    //추상클래스를 상속받아 저그 유닛 정의
    class Zerg : BaseService
    {
        //추상메서드 오버라이드
        public override void AddUnit(string p_UnitName)
        {
            switch (p_UnitName)
            {
                case CommonEnum.UltraRiskName:
                    UnitList.Add(new UltraRisk());
                    break;
                case CommonEnum.MutalName:
                    UnitList.Add(new Mutal());
                    break;
            }
        }
    }
}
