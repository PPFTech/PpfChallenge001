using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level1
{
    public partial class FormQuiz : Form
    {
        // 問題設定
        string QuestionString = "大阪地名クイズ！" + "\n" + "「放出」はなんと読む？";
        string[] AnswerString = { "ほうてん", "はなてん", "はなで" };
        int AnswerIndex = 1;        // 0, 1, 2 のいずれか

        #region "イベント"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormQuiz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormQuiz_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        /// <summary>
        /// [答えへ]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            GoAnswer();
        }
        #endregion

        #region "メソッド"
        /// <summary>
        /// フォーム初期化
        /// </summary>
        private void InitForm()
        {
            // お題と選択肢の設定
            labelQuestion.Text = QuestionString;
            radioAnswer1.Text = AnswerString[0];
            radioAnswer2.Text = AnswerString[1];
            radioAnswer3.Text = AnswerString[2];
        }

        /// <summary>
        /// [答えへ]処理
        /// </summary>
        private void GoAnswer()
        {
            // ------------------------------------------------------------
            //   正解・不正解判定(正解インデックスと一致すれば正解と判定)
            // ------------------------------------------------------------
            bool ok = false;
            if (radioAnswer1.Checked)
            {
                if (AnswerIndex == 0) ok = true;
            }
            else if (radioAnswer2.Checked)
            {
                if (AnswerIndex == 1) ok = true;
            }
            else if (radioAnswer3.Checked)
            {
                if (AnswerIndex == 2) ok = true;
            }
            else 
            {
                // 何も選択されていなければ、選択を促す
                MessageBox.Show("A.の選択肢から、答えを選んでください", "入力確認", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // --------------------
            //    メッセージ表示
            // --------------------
            string answer = AnswerString[AnswerIndex];
            if (ok)
            {
                string msg = string.Format("正解！\n答えは {0} です！", answer);
                MessageBox.Show(msg, "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string msg = string.Format("不正解！\n答えは {0} です！", answer);
                MessageBox.Show(msg, "結果", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
