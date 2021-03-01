
namespace ocic_test
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Player1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Player1_TribeSelect = new System.Windows.Forms.Label();
            this.lbl_Player2_TribeSelect = new System.Windows.Forms.Label();
            this.cbo_Player1Tribe = new System.Windows.Forms.ComboBox();
            this.cbo_Player2Tribe = new System.Windows.Forms.ComboBox();
            this.btn_GameStart = new System.Windows.Forms.Button();
            this.btn_Player1Unit1 = new System.Windows.Forms.Button();
            this.btn_Player1Unit2 = new System.Windows.Forms.Button();
            this.btn_Player2Unit1 = new System.Windows.Forms.Button();
            this.btn_Player2Unit2 = new System.Windows.Forms.Button();
            this.btn_GameEnd = new System.Windows.Forms.Button();
            this.rtb_Player1 = new System.Windows.Forms.RichTextBox();
            this.rtb_Player2 = new System.Windows.Forms.RichTextBox();
            this.btn_Player1Attack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Player1UnitInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Player2Attack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_Player2UnitInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Player1
            // 
            this.lbl_Player1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Player1.Location = new System.Drawing.Point(130, 17);
            this.lbl_Player1.Name = "lbl_Player1";
            this.lbl_Player1.Size = new System.Drawing.Size(241, 64);
            this.lbl_Player1.TabIndex = 0;
            this.lbl_Player1.Text = "사용자1";
            this.lbl_Player1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(158, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "사용자2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Player1_TribeSelect
            // 
            this.lbl_Player1_TribeSelect.AutoSize = true;
            this.lbl_Player1_TribeSelect.Location = new System.Drawing.Point(82, 98);
            this.lbl_Player1_TribeSelect.Name = "lbl_Player1_TribeSelect";
            this.lbl_Player1_TribeSelect.Size = new System.Drawing.Size(53, 12);
            this.lbl_Player1_TribeSelect.TabIndex = 2;
            this.lbl_Player1_TribeSelect.Text = "종족선택";
            // 
            // lbl_Player2_TribeSelect
            // 
            this.lbl_Player2_TribeSelect.AutoSize = true;
            this.lbl_Player2_TribeSelect.Location = new System.Drawing.Point(108, 93);
            this.lbl_Player2_TribeSelect.Name = "lbl_Player2_TribeSelect";
            this.lbl_Player2_TribeSelect.Size = new System.Drawing.Size(53, 12);
            this.lbl_Player2_TribeSelect.TabIndex = 3;
            this.lbl_Player2_TribeSelect.Text = "종족선택";
            // 
            // cbo_Player1Tribe
            // 
            this.cbo_Player1Tribe.FormattingEnabled = true;
            this.cbo_Player1Tribe.Location = new System.Drawing.Point(195, 90);
            this.cbo_Player1Tribe.Name = "cbo_Player1Tribe";
            this.cbo_Player1Tribe.Size = new System.Drawing.Size(166, 20);
            this.cbo_Player1Tribe.TabIndex = 4;
            // 
            // cbo_Player2Tribe
            // 
            this.cbo_Player2Tribe.FormattingEnabled = true;
            this.cbo_Player2Tribe.Location = new System.Drawing.Point(209, 85);
            this.cbo_Player2Tribe.Name = "cbo_Player2Tribe";
            this.cbo_Player2Tribe.Size = new System.Drawing.Size(177, 20);
            this.cbo_Player2Tribe.TabIndex = 5;
            // 
            // btn_GameStart
            // 
            this.btn_GameStart.Location = new System.Drawing.Point(536, 33);
            this.btn_GameStart.Name = "btn_GameStart";
            this.btn_GameStart.Size = new System.Drawing.Size(143, 54);
            this.btn_GameStart.TabIndex = 6;
            this.btn_GameStart.Text = "게임 시작";
            this.btn_GameStart.UseVisualStyleBackColor = true;
            // 
            // btn_Player1Unit1
            // 
            this.btn_Player1Unit1.Location = new System.Drawing.Point(19, 132);
            this.btn_Player1Unit1.Name = "btn_Player1Unit1";
            this.btn_Player1Unit1.Size = new System.Drawing.Size(160, 69);
            this.btn_Player1Unit1.TabIndex = 7;
            this.btn_Player1Unit1.Text = "button1";
            this.btn_Player1Unit1.UseVisualStyleBackColor = true;
            // 
            // btn_Player1Unit2
            // 
            this.btn_Player1Unit2.Location = new System.Drawing.Point(311, 132);
            this.btn_Player1Unit2.Name = "btn_Player1Unit2";
            this.btn_Player1Unit2.Size = new System.Drawing.Size(160, 69);
            this.btn_Player1Unit2.TabIndex = 8;
            this.btn_Player1Unit2.Text = "button2";
            this.btn_Player1Unit2.UseVisualStyleBackColor = true;
            // 
            // btn_Player2Unit1
            // 
            this.btn_Player2Unit1.Location = new System.Drawing.Point(32, 132);
            this.btn_Player2Unit1.Name = "btn_Player2Unit1";
            this.btn_Player2Unit1.Size = new System.Drawing.Size(160, 69);
            this.btn_Player2Unit1.TabIndex = 9;
            this.btn_Player2Unit1.Text = "button3";
            this.btn_Player2Unit1.UseVisualStyleBackColor = true;
            // 
            // btn_Player2Unit2
            // 
            this.btn_Player2Unit2.Location = new System.Drawing.Point(324, 132);
            this.btn_Player2Unit2.Name = "btn_Player2Unit2";
            this.btn_Player2Unit2.Size = new System.Drawing.Size(160, 69);
            this.btn_Player2Unit2.TabIndex = 10;
            this.btn_Player2Unit2.Text = "button4";
            this.btn_Player2Unit2.UseVisualStyleBackColor = true;
            // 
            // btn_GameEnd
            // 
            this.btn_GameEnd.Location = new System.Drawing.Point(536, 110);
            this.btn_GameEnd.Name = "btn_GameEnd";
            this.btn_GameEnd.Size = new System.Drawing.Size(143, 54);
            this.btn_GameEnd.TabIndex = 11;
            this.btn_GameEnd.Text = "강제 종료";
            this.btn_GameEnd.UseVisualStyleBackColor = true;
            // 
            // rtb_Player1
            // 
            this.rtb_Player1.Location = new System.Drawing.Point(19, 335);
            this.rtb_Player1.Name = "rtb_Player1";
            this.rtb_Player1.Size = new System.Drawing.Size(452, 83);
            this.rtb_Player1.TabIndex = 12;
            this.rtb_Player1.Text = "";
            // 
            // rtb_Player2
            // 
            this.rtb_Player2.Location = new System.Drawing.Point(32, 335);
            this.rtb_Player2.Name = "rtb_Player2";
            this.rtb_Player2.Size = new System.Drawing.Size(452, 83);
            this.rtb_Player2.TabIndex = 13;
            this.rtb_Player2.Text = "";
            // 
            // btn_Player1Attack
            // 
            this.btn_Player1Attack.Location = new System.Drawing.Point(64, 436);
            this.btn_Player1Attack.Name = "btn_Player1Attack";
            this.btn_Player1Attack.Size = new System.Drawing.Size(362, 59);
            this.btn_Player1Attack.TabIndex = 14;
            this.btn_Player1Attack.Text = "공격";
            this.btn_Player1Attack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtb_Player1UnitInfo);
            this.groupBox1.Controls.Add(this.lbl_Player1);
            this.groupBox1.Controls.Add(this.cbo_Player1Tribe);
            this.groupBox1.Controls.Add(this.btn_Player1Attack);
            this.groupBox1.Controls.Add(this.lbl_Player1_TribeSelect);
            this.groupBox1.Controls.Add(this.btn_Player1Unit1);
            this.groupBox1.Controls.Add(this.rtb_Player1);
            this.groupBox1.Controls.Add(this.btn_Player1Unit2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 518);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "유닛 정보";
            // 
            // rtb_Player1UnitInfo
            // 
            this.rtb_Player1UnitInfo.Location = new System.Drawing.Point(19, 235);
            this.rtb_Player1UnitInfo.Name = "rtb_Player1UnitInfo";
            this.rtb_Player1UnitInfo.Size = new System.Drawing.Size(452, 79);
            this.rtb_Player1UnitInfo.TabIndex = 15;
            this.rtb_Player1UnitInfo.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Player2Attack);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rtb_Player2UnitInfo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_Player2Tribe);
            this.groupBox2.Controls.Add(this.rtb_Player2);
            this.groupBox2.Controls.Add(this.lbl_Player2_TribeSelect);
            this.groupBox2.Controls.Add(this.btn_Player2Unit1);
            this.groupBox2.Controls.Add(this.btn_Player2Unit2);
            this.groupBox2.Location = new System.Drawing.Point(685, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 518);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사용자2";
            // 
            // btn_Player2Attack
            // 
            this.btn_Player2Attack.Location = new System.Drawing.Point(79, 436);
            this.btn_Player2Attack.Name = "btn_Player2Attack";
            this.btn_Player2Attack.Size = new System.Drawing.Size(362, 59);
            this.btn_Player2Attack.TabIndex = 18;
            this.btn_Player2Attack.Text = "공격";
            this.btn_Player2Attack.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "유닛 정보";
            // 
            // rtb_Player2UnitInfo
            // 
            this.rtb_Player2UnitInfo.Location = new System.Drawing.Point(32, 235);
            this.rtb_Player2UnitInfo.Name = "rtb_Player2UnitInfo";
            this.rtb_Player2UnitInfo.Size = new System.Drawing.Size(452, 79);
            this.rtb_Player2UnitInfo.TabIndex = 16;
            this.rtb_Player2UnitInfo.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_GameEnd);
            this.Controls.Add(this.btn_GameStart);
            this.Name = "MainForm";
            this.Text = "OCIC 정보통신 TEST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Player1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Player2Tribe;
        private System.Windows.Forms.Label lbl_Player1_TribeSelect;
        private System.Windows.Forms.Label lbl_Player2_TribeSelect;
        private System.Windows.Forms.ComboBox cbo_Player1Tribe;
        private System.Windows.Forms.Button btn_GameStart;
        private System.Windows.Forms.Button btn_Player1Unit1;
        private System.Windows.Forms.Button btn_Player1Unit2;
        private System.Windows.Forms.Button btn_Player2Unit1;
        private System.Windows.Forms.Button btn_Player2Unit2;
        private System.Windows.Forms.Button btn_GameEnd;
        private System.Windows.Forms.RichTextBox rtb_Player1;
        private System.Windows.Forms.RichTextBox rtb_Player2;
        private System.Windows.Forms.Button btn_Player1Attack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Player1UnitInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_Player2UnitInfo;
        private System.Windows.Forms.Button btn_Player2Attack;
    }
}

