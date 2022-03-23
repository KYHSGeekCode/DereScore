using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DereScore
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("입력을 시작하면 새로운 줄이 추가됩니다.");
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            string path = textBoxSongs.Text;
            string directory = Path.GetDirectoryName(path);
            string [] folders = Directory.GetDirectories(path);
            listViewSong.Items.Clear();
            foreach(string s in folders)
                listViewSong.Items.Add(Path.GetFileName(s));
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBoxSongs.Text = fbd.SelectedPath;
                    string[] files = Directory.GetDirectories(fbd.SelectedPath);
                    listViewSong.Items.Clear();
                    foreach (string s in files)
                        listViewSong.Items.Add(Path.GetFileName(s));
                }
            }
        }

        private void listViewSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewSong.SelectedItems.Count > 0)
                textBoxSongName.Text = listViewSong.SelectedItems[0].Text;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            //일단은 다 해볼건데

        }

        private int CalcOne(Card [] cards)
        {
            int score = 0;
            int appeal = 0;
            if(cards[2].isCenterSkillAppliable(cards))
            {
                appeal = cards[2].ApplyCenterSkill(cards);
            } else
            {
                foreach(Card card in cards)
                {
                    appeal += card.TotalAppeal;
                }
            }
        }
    }
}
