using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    //유닛을 생성하기 위한 공장클래스 정의
    public class Factory
    {
        List<BaseService> BaseServiceList = new List<BaseService>();

        public Factory()
        {
        }

        /// <summary>
        /// 현재 게임 참가중인 사용자 수
        /// </summary>
        /// <returns></returns>
        public int GameUserCount()
        {
            return BaseServiceList.Count;
        }

        /// <summary>
        /// 게임 시작
        /// </summary>
        /// <param name="p_TribeCode">종족코드</param>
        public void GameStart(TribeCodeEnum p_TribeCode)
        {
            try
            {
                if (BaseServiceList.Count == 2)
                {
                    MessageBox.Show("두개의 종족이 이미 선택되었습니다.", "경고");
                }
                else
                {
                    switch (p_TribeCode)
                    {
                        case TribeCodeEnum.Terran:
                            BaseServiceList.Add(new Terran());
                            break;
                        case TribeCodeEnum.Zerg:
                            BaseServiceList.Add(new Zerg());
                            break;
                        case TribeCodeEnum.Protoss:
                            BaseServiceList.Add(new Protoss());
                            break;
                        default:
                            MessageBox.Show("정의되지 않은 종족코드입니다.", "경고");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "경고");
            }
        }

        /// <summary>
        /// 게임 시작
        /// </summary>
        /// <param name="p_TribeCode">종족코드</param>
        /// <param name="p_Button1">유닛1</param>
        /// <param name="p_Button2">유닛2</param>
        /// <returns>유닛정보</returns>
        public void GameStart(TribeCodeEnum p_TribeCode, Button p_Button1, Button p_Button2, RichTextBox p_RichBox)
        {
            try
            {
                string UnitInfoMsg = string.Empty;
                if (BaseServiceList.Count == 2)
                {
                    MessageBox.Show("두개의 종족이 이미 선택되었습니다.", "경고");
                }
                else
                {
                    switch (p_TribeCode)
                    {
                        case TribeCodeEnum.Terran:
                            BaseServiceList.Add(new Terran());
                            p_Button1.Text = CommonEnum.MarineName;
                            p_Button2.Text = CommonEnum.MedicName;
                            break;
                        case TribeCodeEnum.Zerg:
                            BaseServiceList.Add(new Zerg());
                            p_Button1.Text = CommonEnum.UltraRiskName;
                            p_Button2.Text = CommonEnum.MutalName;
                            break;
                        case TribeCodeEnum.Protoss:
                            BaseServiceList.Add(new Protoss());
                            p_Button1.Text = CommonEnum.ArchonName;
                            p_Button2.Text = CommonEnum.ScoutName;
                            break;
                        default:
                            MessageBox.Show("정의되지 않은 종족코드입니다.", "경고");
                            break;
                    }
                    p_RichBox.Text = GetUnitInfoMsg(p_TribeCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "경고");
            }
        }

        //유닛정보 메시지 하드코딩
        private string GetUnitInfoMsg(TribeCodeEnum p_TribeCode)
        {
            string returnValue = string.Empty;
            switch (p_TribeCode)
            {
                case TribeCodeEnum.Terran:
                    //유닛정보 메시지 하드코딩
                    returnValue += string.Format("[마린 HP:{0}, 비용:{1}, 공격속도:{2}, 공격력:{3}, 이동속도:{4}, 크기:{5}, 공격범위:{6}, 공중유닛:{7}]{8}"
                        , CommonEnum.MarineHP, CommonEnum.MarineCost, CommonEnum.MarineAttackSpeed, CommonEnum.MarinePower, CommonEnum.MarineMoveSpeed, CommonEnum.MarineSize
                        , UtilsExtension.GetAttackRangeName(CommonEnum.MarineAttackRangeCode), UtilsExtension.GetFlyFlagOX(CommonEnum.MarineFlyFlag), Environment.NewLine);
                    returnValue += string.Format("[메딕 HP:{0}, 비용:{1}, 치료횟수:{2}, 치료능력:{3}, 이동속도:{4}, 크기:{5}, 공격범위:{6}, 공중유닛:{7}]{8}"
                        , CommonEnum.MedicHP, CommonEnum.MedicCost, CommonEnum.MedicAttackSpeed, CommonEnum.MedicPower, CommonEnum.MedicMoveSpeed, CommonEnum.MedicSize
                        , UtilsExtension.GetAttackRangeName(CommonEnum.MedicAttackRangeCode), UtilsExtension.GetFlyFlagOX(CommonEnum.MedicFlyFlag), Environment.NewLine);
                    break;
                case TribeCodeEnum.Zerg:
                    returnValue += string.Format("[울트라리스크 HP:{0}, 비용:{1}, 공격속도:{2}, 공격력:{3}, 이동속도:{4}, 크기:{5}, 공격범위:{6}, 공중유닛:{7}]{8}"
                        , CommonEnum.UltraRiskHP, CommonEnum.UltraRiskCost, CommonEnum.UltraRiskAttackSpeed, CommonEnum.UltraRiskPower, CommonEnum.UltraRiskMoveSpeed, CommonEnum.UltraRiskSize
                        , UtilsExtension.GetAttackRangeName(CommonEnum.UltraRiskAttackRangeCode), UtilsExtension.GetFlyFlagOX(CommonEnum.UltraRiskFlyFlag), Environment.NewLine);
                    returnValue += string.Format("[뮤탈 HP:{0}, 비용:{1}, 공격속도:{2}, 공격력:{3}, 이동속도:{4}, 크기:{5}, 공격범위:{6}, 공중유닛:{7}]{8}"
                        , CommonEnum.MutalHP, CommonEnum.MutalCost, CommonEnum.MutalAttackSpeed, CommonEnum.MutalPower, CommonEnum.MutalMoveSpeed, CommonEnum.MutalSize
                        , UtilsExtension.GetAttackRangeName(CommonEnum.MutalAttackRangeCode), UtilsExtension.GetFlyFlagOX(CommonEnum.MutalFlyFlag), Environment.NewLine);
                    break;
                case TribeCodeEnum.Protoss:
                    returnValue += string.Format("[아칸 HP:{0}, 비용:{1}, 공격속도:{2}, 공격력:{3}, 이동속도:{4}, 크기:{5}, 공격범위:{6}, 공중유닛:{7}]{8}"
                        , CommonEnum.ArchonHP, CommonEnum.ArchonCost, CommonEnum.ArchonAttackSpeed, CommonEnum.ArchonPower, CommonEnum.ArchonMoveSpeed, CommonEnum.ArchonSize
                        , UtilsExtension.GetAttackRangeName(CommonEnum.ArchonAttackRangeCode), UtilsExtension.GetFlyFlagOX(CommonEnum.ArchonFlyFlag), Environment.NewLine);
                    returnValue += string.Format("[스카웃 HP:{0}, 비용:{1}, 공격속도:{2}, 공격력:{3}, 이동속도:{4}, 크기:{5}, 공격범위:{6}, 공중유닛:{7}]{8}"
                        , CommonEnum.ScoutHP, CommonEnum.ScoutCost, CommonEnum.ScoutAttackSpeed, CommonEnum.ScoutPower, CommonEnum.ScoutMoveSpeed, CommonEnum.ScoutSize
                        , UtilsExtension.GetAttackRangeName(CommonEnum.ScoutAttackRangeCode), UtilsExtension.GetFlyFlagOX(CommonEnum.ScoutFlyFlag), Environment.NewLine);
                    break;
            }
            return returnValue;
        }

        /// <summary>
        /// 종족 모두 지우기
        /// </summary>
        public void ListClear()
        {
            BaseServiceList.Clear();
        }

        /// <summary>
        /// 유닛 추가
        /// </summary>
        /// <param name="p_UnitButton">유닛</param>
        public void AddPlayerUnit(Button p_UnitButton)
        {
            try
            {
                if (p_UnitButton.Name.Contains("Player1"))
                {
                    BaseServiceList[0].AddUnit(p_UnitButton.Text);
                }
                else if (p_UnitButton.Name.Contains("Player2"))
                {
                    BaseServiceList[1].AddUnit(p_UnitButton.Text);
                }
                else
                {
                    MessageBox.Show("사용자가 없습니다.", "경고");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "경고");
            }
        }

        /// <summary>
        /// 현재 유닛 보여주기
        /// </summary>
        /// <param name="p_UnitButton">유닛</param>
        public string GetCurrentPlayerUnit(Button p_UnitButton)
        {
            try
            {
                List<Unit> UnitList = null;
                string Msg = string.Empty;

                if (p_UnitButton.Name.Contains("Player1"))
                {
                    UnitList = BaseServiceList[0].GetUnitList(p => p.HP > 0);
                }
                else if (p_UnitButton.Name.Contains("Player2"))
                {
                    UnitList = BaseServiceList[1].GetUnitList(p => p.HP > 0);
                }
                else
                {
                    MessageBox.Show("사용자가 없습니다.", "경고");
                }
                var GroupList = GetUnitCodeGroupList(UnitList);                ;

                return GetCurrentUnitStateMessge(UnitList, GroupList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "경고");
                return string.Empty;
            }
        }

        /// <summary>
        /// 현재 유닛 보여주기
        /// </summary>
        /// <param name="p_Player">사용자(ex:Player1)</param>
        public string GetCurrentPlayerUnit(string p_Player)
        {
            try
            {
                List<Unit> UnitList = null;
                string Msg = string.Empty;

                if (p_Player.Contains("Player1"))
                {
                    UnitList = BaseServiceList[0].GetUnitList(p => p.HP > 0);
                }
                else if (p_Player.Contains("Player2"))
                {
                    UnitList = BaseServiceList[1].GetUnitList(p => p.HP > 0);
                }
                else
                {
                    MessageBox.Show("사용자가 없습니다.", "경고");
                }
                var GroupList = GetUnitCodeGroupList(UnitList); ;

                return GetCurrentUnitStateMessge(UnitList, GroupList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "경고");
                return string.Empty;
            }
        }

        //유닛 그룹바이 함수
        private List<Unit> GetUnitCodeGroupList(List<Unit> units)
        {
            //그룹 유닛코드, 유닛명, 총HP 
            return units.GroupBy(p => new { p.UnitCode, p.UnitName })
                        .Select(p => new Unit() { UnitCode = p.Key.UnitCode, UnitName = p.Key.UnitName, HP = p.Sum(s => s.HP) }).ToList();
        }

        //유닛 메시지 함수
        private string GetCurrentUnitStateMessge(List<Unit> p_AllList, List<Unit> p_GroupList)
        {
            string Msg = string.Format("총 병력 : {0} 체력 : {1}{2}", p_AllList.Count, p_AllList.Sum(p=>p.HP), Environment.NewLine);
            foreach (var v in p_GroupList)
            {
                Msg += string.Format("{0} : {1} 체력 : {2}{3}", v.UnitName, p_AllList.Where(p => p.UnitCode == v.UnitCode).Count(), v.HP, Environment.NewLine);
            }

            return Msg;
        }

        /// <summary>
        /// 공격하기
        /// </summary>
        /// <param name="p_AttackButton"></param>
        public void Attack(Button p_AttackButton)
        {
            //공격은 단방향으로 공격력으로 진행하였습니다. 상대 1유닛이 죽지않으면 집중공격식으로 기술.
            try
            {
                if (p_AttackButton.Name.Contains("Player1"))
                {
                    AttackLogic(BaseServiceList[0].GetUnitList(p => p.HP > 0), BaseServiceList[1].GetUnitList(p => p.HP > 0));
                }
                else if (p_AttackButton.Name.Contains("Player2"))
                {
                    AttackLogic(BaseServiceList[1].GetUnitList(p => p.HP > 0), BaseServiceList[0].GetUnitList(p => p.HP > 0));
                }
                else
                {
                    MessageBox.Show("사용자가 없습니다.", "경고");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "경고");
            }
        }

        private void AttackLogic(List<Unit> AttackPlayerList, List<Unit> DefensePlayerList)
        {
            var Player1AttackPossibleCount = AttackPlayerList.Count;

            foreach (var v in DefensePlayerList)
            {
                if (Player1AttackPossibleCount > 0)
                {
                    foreach (var c in AttackPlayerList)
                    {
                        switch (c.AttackRangeCode)
                        {
                            case (int)AttackRangeCodeEnum.Ground: //지상공격
                                if (!v.FlyFlag)
                                    v.HP -= c.Power;
                                break;
                            case (int)AttackRangeCodeEnum.Air: //공중공격
                                if (v.FlyFlag)
                                    v.HP -= c.Power;
                                break;
                            case (int)AttackRangeCodeEnum.All: //지상 공중 모두
                                v.HP -= c.Power;
                                break;
                            case (int)AttackRangeCodeEnum.Cure: //힐
                                continue;
                        }

                        //상대방에 힐이 존재할 경우 자동 힐 발생 마린에게만
                        var obj = DefensePlayerList.Where(p => p.HP > 0 && p.AttackRangeCode == (int)AttackRangeCodeEnum.Cure && p.AttackSpeed > 0).FirstOrDefault();
                        if (obj != null)
                        {
                            if (v.UnitCode == CommonEnum.UnitCode_Marine)
                            {
                                obj.AttackSpeed--;
                                v.HP += obj.Power;
                                //HP가 기준보다 넘으면 MAX값으로 변경해줘야함
                                if (v.HP > CommonEnum.MarineHP)
                                    v.HP = CommonEnum.MarineHP;
                            }
                        }

                        Player1AttackPossibleCount--;
                        if (v.HP <= 0)
                        {
                            v.HP = 0;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 게임 종료 확인
        /// </summary>
        public string GameFinishCheck()
        {
            var Player1List = BaseServiceList[0].GetUnitList(p => p.HP > 0); //살아있는 유닛 검색
            var Player2List = BaseServiceList[1].GetUnitList(p => p.HP > 0); //살아있는 유닛 검색

            string Msg = string.Empty;

            if (Player1List.Count != 0 && Player2List.Count != 0)
                return Msg;
            else
            {
                if (Player1List.Count == 0)
                {
                    //사용자1패배
                    Msg = string.Format("[사용자2]가 승리하셨습니다. 남은 병력은 아래와 같습니다.{0}", Environment.NewLine);
                    var GroupList = GetUnitCodeGroupList(Player2List);
                    Msg += GetCurrentUnitStateMessge(Player2List, GroupList);
                }
                else
                {
                    //사용자2패배
                    Msg = string.Format("[사용자1]가 승리하셨습니다. 남은 병력은 아래와 같습니다.{0}", Environment.NewLine);
                    var GroupList = GetUnitCodeGroupList(Player1List);
                    Msg += GetCurrentUnitStateMessge(Player1List, GroupList);
                }

                return Msg;
            }
        }
    }
}
