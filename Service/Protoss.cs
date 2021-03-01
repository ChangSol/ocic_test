using Model.Base;
using Model.Protoss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    //추상클래스를 상속받아 프로토스 유닛 정의
    class Protoss : BaseService
    {
        //추상메서드 오버라이드
        public override void AddUnit(string p_UnitName)
        {
            switch (p_UnitName)
            {
                case CommonEnum.ArchonName:
                    UnitList.Add(new Archon());
                    break;
                case CommonEnum.ScoutName:
                    UnitList.Add(new Scout());
                    break;
            }
        }
    }
}
