using Model.Base;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocic_test
{
    public partial class MainForm : Form
    {
        Factory unitFactory = new Factory(); //공장객체
        //unitFactory[0] 인덱스가 사용자1
        //unitFactory[1] 인덱스가 사용자2 로 가정
        //사용자 테이블없이 진행

        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            //이벤트 선언
            btn_GameStart.Click += Btn_GameStart_Click;
            btn_GameEnd.Click += Btn_GameEnd_Click;

            btn_Player1Unit1.Click += Btn_Unit_Click;
            btn_Player1Unit2.Click += Btn_Unit_Click;
            btn_Player2Unit1.Click += Btn_Unit_Click;
            btn_Player2Unit2.Click += Btn_Unit_Click;

            btn_Player1Attack.Click += Btn_Player_Attack_Click;
            btn_Player2Attack.Click += Btn_Player_Attack_Click;
        }

        //로드
        private void Form1_Load(object sender, EventArgs e)
        {
            SetControlSetting();

            //종족 선택 콤보 바인드
            ComboTribeItemBind(cbo_Player1Tribe);
            ComboTribeItemBind(cbo_Player2Tribe);

            //컨트롤 활성화 "대기"
            SetControlEnable("wait"); 
            
        }

        //게임 시작 이벤트
        private void Btn_GameStart_Click(object sender, EventArgs e)
        {
            if (cbo_Player1Tribe.SelectedItem == null || cbo_Player2Tribe.SelectedItem == null)
            {
                MessageBox.Show("종족을 모두 선택해 주시기 바랍니다.", "경고");
            }
            else
            {
                unitFactory.ListClear();

                //게임시작 
                GameStart(cbo_Player1Tribe, btn_Player1Unit1, btn_Player1Unit2, rtb_Player1UnitInfo); //unitFactory[0]
                GameStart(cbo_Player2Tribe, btn_Player2Unit1, btn_Player2Unit2, rtb_Player2UnitInfo); //unitFactory[1]

                //컨트롤 활성화 "시작"
                SetControlEnable("start");
            }
        }

        //강제 종료 이벤트
        private void Btn_GameEnd_Click(object sender, EventArgs e)
        {
            //컨트롤 활성화 "대기"
            SetControlEnable("wait");
        }

        //종족 선택 콤보박스 바인딩
        private void ComboTribeItemBind(ComboBox combo)
        {
            combo.DataSource = new List<KeyValuePair<TribeCodeEnum, string>>()
            {
                new KeyValuePair<TribeCodeEnum, string>(TribeCodeEnum.Terran, "테란"),
                new KeyValuePair<TribeCodeEnum, string>(TribeCodeEnum.Zerg, "저그"),
                new KeyValuePair<TribeCodeEnum, string>(TribeCodeEnum.Protoss, "프로토스")
            };
        }

        //게임시작 메서드
        private void GameStart(ComboBox combo, Button p_Button1, Button p_Button2, RichTextBox p_RichBox)
        {
            try
            {                
                unitFactory.GameStart(((KeyValuePair<TribeCodeEnum, string>)combo.SelectedItem).Key, p_Button1, p_Button2, p_RichBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(combo.Name + " : " + ex.Message, "경고");
            }
        }

        //유닛 선택 이벤트
        private void Btn_Unit_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                unitFactory.AddPlayerUnit(btn);

                RtbPlayerSetting();
            }
        }

        //공격 버튼 이벤트
        private void Btn_Player_Attack_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                unitFactory.Attack(btn);

                RtbPlayerSetting();

                //게임결과체크
                var GameCheckMsg = unitFactory.GameFinishCheck();
                if (!string.IsNullOrEmpty(GameCheckMsg))
                {
                    MessageBox.Show(GameCheckMsg);
                    //컨트롤 활성화 "대기"
                    SetControlEnable("wait");
                }
            }
        }

        //진행상황 불러오기
        private void RtbPlayerSetting()
        {
            rtb_Player1.Text = unitFactory.GetCurrentPlayerUnit("Player1");
            rtb_Player2.Text = unitFactory.GetCurrentPlayerUnit("Player2");
        }

        private void SetControlEnable(string state)
        {
            bool enable = true;
            switch (state)
            {
                case "wait": //대기
                    btn_GameStart.Enabled = enable;
                    btn_GameEnd.Enabled = !enable;

                    cbo_Player1Tribe.Enabled = enable;
                    cbo_Player2Tribe.Enabled = enable;

                    btn_Player1Unit1.Enabled = !enable;
                    btn_Player1Unit2.Enabled = !enable;
                    btn_Player2Unit1.Enabled = !enable;
                    btn_Player2Unit2.Enabled = !enable;

                    rtb_Player1UnitInfo.Enabled = !enable;
                    rtb_Player2UnitInfo.Enabled = !enable;

                    rtb_Player1.Enabled = !enable;
                    rtb_Player2.Enabled = !enable;

                    btn_Player1Unit1.Text = string.Empty;
                    btn_Player1Unit2.Text = string.Empty;
                    btn_Player2Unit1.Text = string.Empty;
                    btn_Player2Unit2.Text = string.Empty;

                    rtb_Player1UnitInfo.Text = string.Empty;
                    rtb_Player2UnitInfo.Text = string.Empty;

                    rtb_Player1.Text = string.Empty;
                    rtb_Player2.Text = string.Empty;
                    break;

                case "start": //게임시작
                    btn_GameStart.Enabled = !enable;
                    btn_GameEnd.Enabled = enable;

                    cbo_Player1Tribe.Enabled = !enable;
                    cbo_Player2Tribe.Enabled = !enable;

                    btn_Player1Unit1.Enabled = enable;
                    btn_Player1Unit2.Enabled = enable;
                    btn_Player2Unit1.Enabled = enable;
                    btn_Player2Unit2.Enabled = enable;

                    rtb_Player1UnitInfo.Enabled = enable;
                    rtb_Player2UnitInfo.Enabled = enable;

                    rtb_Player1.Enabled = enable;
                    rtb_Player2.Enabled = enable;
                    break;
            }
        }

        private void SetControlSetting()
        {
            cbo_Player1Tribe.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Player1Tribe.DrawItem += new DrawItemEventHandler(ComboBox_DrawItem);
            cbo_Player2Tribe.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Player2Tribe.DrawItem += new DrawItemEventHandler(ComboBox_DrawItem);

            cbo_Player1Tribe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Player2Tribe.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //콤보박스 텍스트 정렬 (코어라이브러리로 가거나 커스텀 콤보박스만들어 사용함)
        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var combo = sender as ComboBox; 
            if (combo != null)
            {
                e.DrawBackground();             
                if (e.Index >= 0) 
                {
                    StringFormat format = new StringFormat(); 
                    format.LineAlignment = StringAlignment.Center;
                    format.Alignment = StringAlignment.Center;
                    Brush brush = new SolidBrush(combo.ForeColor);
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) 
                    {
                        brush = SystemBrushes.HighlightText;
                    }
                    e.Graphics.DrawString(combo.Items[e.Index].ToString(), combo.Font, brush, e.Bounds, format);
                }
            }
        }

    }
}
