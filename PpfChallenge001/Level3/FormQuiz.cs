using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level3
{
    public partial class FormQuiz : Form
    {
        // Q&Aデータ
        private QuestionFile Question = new QuestionFile();
        // 問題情報
        private int QuestionIndex = 0;      // 現在の問題インデックス
        private int CorrectCount = 0;       // 正解数
        private bool Finish = false;        // 完了フラグ
        // 音源再生
        private SoundWave Sound = new SoundWave();

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
            // QAファイルを読み込む
            if (!Question.Read())
            {
                // 読込失敗時、プログラム終了
                Application.Exit();
            }

            // 正解数をクリア
            CorrectCount = 0;
            
            // 設問設定
            InitForm();
        }

        /// <summary>
        /// [次へ]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // 次へ
            GoNext();
        }
        #endregion

        #region "メソッド"
        /// <summary>
        /// フォーム初期化
        /// </summary>
        private void InitForm()
        {
            // お題と選択肢の設定
            int q = QuestionIndex;
            Question qa = Question.Questions[q];
            labelQuestion.Text = qa.QuestionString;
            radioAnswer1.Text = qa.AnswerString[0];
            radioAnswer2.Text = qa.AnswerString[1];
            radioAnswer3.Text = qa.AnswerString[2];
            // 最初の選択肢を選んでおく
            radioAnswer1.Select();
        }

        /// <summary>
        /// [答えへ]処理
        /// </summary>
        private void GoNext()
        {
            // 既に終了していれば、メッセージを表示して抜ける
            if (Finish)
            {
                MessageBox.Show("クイズは終わっています。", "残念なお知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ------------------------------------------------------------
            //   正解・不正解判定(正解インデックスと一致すれば正解と判定)
            // ------------------------------------------------------------
            bool ok = false;
            int q = QuestionIndex;
            int a = Question.Questions[q].AnswerIndex;
            if (radioAnswer1.Checked)
            {
                if (a == 0) ok = true;
            }
            else if (radioAnswer2.Checked)
            {
                if (a == 1) ok = true;
            }
            else if (radioAnswer3.Checked)
            {
                if (a == 2) ok = true;
            }
            else 
            {
                // 何も選択されていなければ、選択を促す
                MessageBox.Show("A.の選択肢から、答えを選んでください", "入力確認", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 正解の場合、正解数をカウントアップ
            if (ok && !Finish)
            {
                CorrectCount += 1;
            }

            // -----------------------------
            //    次の問題設定 or 結果表示
            // -----------------------------
            if (QuestionIndex < Question.Count - 1 )
            {
                // 次の問題へ
                QuestionIndex += 1;
                InitForm();
            }
            else
            {
                // 正解率の計算
                double ratio = (double)CorrectCount / (double)Question.Count * 100.0;

                // 正解リスト作成
                string answer = "";
                for (int i = 0; i < Question.Count; i++)
                {
                    Question qa = Question.Questions[i];
                    int j = Question.Questions[i].AnswerIndex;
                    answer += string.Format("Q{0}. {1}\n", i+1, qa.AnswerString[j]);
                }

                // メッセージ表示
                if (ratio == 100.0)
                {
                    Sound.Play();       // 正解音の再生
                    string msg = string.Format("全問正解！\n正解率は {0:0.00}% です！\n\n{1}", ratio, answer);
                    MessageBox.Show(msg, "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sound.Stop();       // 停止   
                }
                else
                {
                    string msg = string.Format("不正解！\n正解率は {0:0.00}% です！\n\n{1}", ratio, answer);
                    MessageBox.Show(msg, "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 終了フラグを立てておく
                Finish = true;
            }
        }
        #endregion
    }
}
