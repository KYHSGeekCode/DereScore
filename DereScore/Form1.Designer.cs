using System.Collections.Generic;

namespace DereScore
{
    partial class FormMain
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
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.listViewSong = new System.Windows.Forms.ListView();
            this.textBoxSongs = new System.Windows.Forms.TextBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.dataGridViewCards = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelSong = new System.Windows.Forms.Label();
            this.textBoxSongName = new System.Windows.Forms.TextBox();
            this.IdolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rarity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Vocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Life = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenterSkill = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CenterCondition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Skill = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoolTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(796, 490);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(162, 59);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "계산";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Location = new System.Drawing.Point(797, 271);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(161, 54);
            this.buttonAddCard.TabIndex = 1;
            this.buttonAddCard.Text = "카드 추가";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // listViewSong
            // 
            this.listViewSong.Location = new System.Drawing.Point(17, 302);
            this.listViewSong.Name = "listViewSong";
            this.listViewSong.Size = new System.Drawing.Size(656, 254);
            this.listViewSong.TabIndex = 2;
            this.listViewSong.UseCompatibleStateImageBehavior = false;
            this.listViewSong.View = System.Windows.Forms.View.List;
            this.listViewSong.SelectedIndexChanged += new System.EventHandler(this.listViewSong_SelectedIndexChanged);
            // 
            // textBoxSongs
            // 
            this.textBoxSongs.Location = new System.Drawing.Point(17, 271);
            this.textBoxSongs.Name = "textBoxSongs";
            this.textBoxSongs.Size = new System.Drawing.Size(574, 25);
            this.textBoxSongs.TabIndex = 3;
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(679, 271);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(103, 26);
            this.buttonReload.TabIndex = 4;
            this.buttonReload.Text = "곡 다시 로드";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // dataGridViewCards
            // 
            this.dataGridViewCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdolName,
            this.Type,
            this.Rarity,
            this.Vocal,
            this.Dance,
            this.Visual,
            this.Life,
            this.CenterSkill,
            this.CenterCondition,
            this.Skill,
            this.Probability,
            this.CoolTime,
            this.Time});
            this.dataGridViewCards.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewCards.Name = "dataGridViewCards";
            this.dataGridViewCards.RowTemplate.Height = 27;
            this.dataGridViewCards.Size = new System.Drawing.Size(941, 219);
            this.dataGridViewCards.TabIndex = 5;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(597, 271);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 26);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "찾아보기";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Location = new System.Drawing.Point(699, 347);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(83, 15);
            this.labelSong.TabIndex = 7;
            this.labelSong.Text = "Song Name";
            // 
            // textBoxSongName
            // 
            this.textBoxSongName.Location = new System.Drawing.Point(702, 365);
            this.textBoxSongName.Name = "textBoxSongName";
            this.textBoxSongName.ReadOnly = true;
            this.textBoxSongName.Size = new System.Drawing.Size(256, 25);
            this.textBoxSongName.TabIndex = 8;
            // 
            // IdolName
            // 
            this.IdolName.HeaderText = "이름";
            this.IdolName.Name = "IdolName";
            // 
            // Type
            // 
            this.Type.HeaderText = "타입";
            this.Type.Items.AddRange(new object[] {
            "Cute",
            "Cool",
            "Passion"});
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Rarity
            // 
            this.Rarity.HeaderText = "등급";
            this.Rarity.Items.AddRange(new object[] {
            "N",
            "N+",
            "R",
            "R+",
            "SR",
            "SR+",
            "SSR",
            "SSR+"});
            this.Rarity.Name = "Rarity";
            this.Rarity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rarity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Vocal
            // 
            this.Vocal.HeaderText = "보컬";
            this.Vocal.Name = "Vocal";
            // 
            // Dance
            // 
            this.Dance.HeaderText = "댄스";
            this.Dance.Name = "Dance";
            // 
            // Visual
            // 
            this.Visual.HeaderText = "비쥬얼";
            this.Visual.Name = "Visual";
            // 
            // Life
            // 
            this.Life.HeaderText = "라이프";
            this.Life.Name = "Life";
            // 
            // CenterSkill
            // 
            this.CenterSkill.HeaderText = "센터스킬";
            this.CenterSkill.Items.AddRange(new object[] {
            "브릴리언스",
            "프린세스",
            "보컬",
            "댄스",
            "비쥬얼",
            "트리콜로로 보이스",
            "트리콜로로 스텝",
            "트리콜로로 메이크",
            "특기",
            "트리콜로로 어빌리티",
            "라이프",
            "치어",
            "포춘 프레젠트",
            "신데렐라 참",
            "쿨 크로스 패션",
            "패션 크로스 쿨"});
            this.CenterSkill.Name = "CenterSkill";
            this.CenterSkill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CenterSkill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CenterCondition
            // 
            this.CenterCondition.HeaderText = "센터조건";
            this.CenterCondition.Name = "CenterCondition";
            // 
            // Skill
            // 
            this.Skill.HeaderText = "스킬";
            this.Skill.Items.AddRange(new object[] {
            "스코어",
            "판강",
            "회복",
            "무적",
            "콤보 보너스",
            "오버로드",
            "스킬 부스트",
            "컨센트레이션",
            "포커스",
            "올라운드",
            "라이프 스파클",
            "앙코르",
            "트리콜로르 시너지",
            "코디네이트",
            "튜닝",
            "롱 액트",
            "플릭 액트",
            "슬라이드 액트"});
            this.Skill.Name = "Skill";
            this.Skill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Skill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Probability
            // 
            this.Probability.HeaderText = "확률";
            this.Probability.Name = "Probability";
            // 
            // CoolTime
            // 
            this.CoolTime.HeaderText = "주기";
            this.CoolTime.Name = "CoolTime";
            // 
            // Time
            // 
            this.Time.HeaderText = "지속시간";
            this.Time.Name = "Time";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 561);
            this.Controls.Add(this.textBoxSongName);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewCards);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.textBoxSongs);
            this.Controls.Add(this.listViewSong);
            this.Controls.Add(this.buttonAddCard);
            this.Controls.Add(this.buttonCalc);
            this.Name = "FormMain";
            this.Text = "DereScore";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.ListView listViewSong;
        private System.Windows.Forms.TextBox textBoxSongs;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.DataGridView dataGridViewCards;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.TextBox textBoxSongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdolName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn Rarity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Life;
        private System.Windows.Forms.DataGridViewComboBoxColumn CenterSkill;
        private System.Windows.Forms.DataGridViewComboBoxColumn CenterCondition;
        private System.Windows.Forms.DataGridViewComboBoxColumn Skill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoolTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}

