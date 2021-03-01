using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    //하드코딩 데이터 공통코드관리로 이용할 데이터
    public static class CommonEnum
    {
        public const string UnitCode_Marine = "Unit_0001";
        public const string UnitCode_Medic = "Unit_0002";
        public const string UnitCode_UltraRisk = "Unit_0003";
        public const string UnitCode_Mutal = "Unit_0004";
        public const string UnitCode_Archon = "Unit_0005";
        public const string UnitCode_Scout = "Unit_0006";
        
        public const string MarineName = "마린";
        public const string MedicName = "메딕";
        public const string UltraRiskName = "울트라리스크";
        public const string MutalName = "뮤탈";
        public const string ArchonName = "아칸";
        public const string ScoutName = "스카웃";

        //HP
        public const int MarineHP = 40;
        public const int MedicHP = 60;
        public const int UltraRiskHP = 300;
        public const int MutalHP = 120;
        public const int ArchonHP = 100;
        public const int ScoutHP = 100;

        //Cost
        public const int MarineCost = 50;
        public const int MedicCost = 60;
        public const int UltraRiskCost = 200;
        public const int MutalCost = 150;
        public const int ArchonCost = 100;
        public const int ScoutCost = 120;

        //AttackSpeed
        public const int MarineAttackSpeed = 2;
        public const int MedicAttackSpeed = 3; //힐 횟수
        public const int UltraRiskAttackSpeed = 2;
        public const int MutalAttackSpeed = 2;
        public const int ArchonAttackSpeed = 1;
        public const int ScoutAttackSpeed = 1;

        //Power
        public const int MarinePower = 6;
        public const int MedicPower = 10;
        public const int UltraRiskPower = 20;
        public const int MutalPower = 9;
        public const int ArchonPower = 13;
        public const int ScoutPower = 10;

        //MoveSpeed
        public const int MarineMoveSpeed = 1;
        public const int MedicMoveSpeed = 1;
        public const int UltraRiskMoveSpeed = 2;
        public const int MutalMoveSpeed = 3;
        public const int ArchonMoveSpeed = 1;
        public const int ScoutMoveSpeed = 3;

        //Size
        public const double MarineSize = 10.25;
        public const double MedicSize = 9.25;
        public const double UltraRiskSize = 20.25;
        public const double MutalSize = 10.4;
        public const double ArchonSize = 13;
        public const double ScoutSize = 9.25;

        //AttackRange
        public const int MarineAttackRangeCode = (int)AttackRangeCodeEnum.All;
        public const int MedicAttackRangeCode = (int)AttackRangeCodeEnum.Cure;
        public const int UltraRiskAttackRangeCode = (int)AttackRangeCodeEnum.Ground;
        public const int MutalAttackRangeCode = (int)AttackRangeCodeEnum.All;
        public const int ArchonAttackRangeCode = (int)AttackRangeCodeEnum.All;
        public const int ScoutAttackRangeCode = (int)AttackRangeCodeEnum.Ground;

        //FlyFlag
        public const bool MarineFlyFlag = false;
        public const bool MedicFlyFlag = false;
        public const bool UltraRiskFlyFlag = false;
        public const bool MutalFlyFlag = true;
        public const bool ArchonFlyFlag = false;
        public const bool ScoutFlyFlag = true;
    }
}
