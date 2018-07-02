using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpfChallenge001.Level2
{
    public partial class FormQuiz : Form
    {
        // 問題設定
        private string[] QuestionString = { "大阪地名クイズ！" + "\n" + "「喜連瓜破」はなんと読む？",
                                            "大阪地名クイズ！" + "\n" + "「杭全」はなんと読む？",
                                            "大阪地名クイズ！" + "\n" + "「弥刀」はなんと読む？"
                                          };
        private string[,] AnswerString = { { "きれんうりは", "きれうりわり", "よれうは" },
                                           { "くまた", "くいぜん", "こうま"},
                                           { "やとう", "やと", "みと" }
                                         };
        private int[] AnswerIndex = { 1,
                                      0,
                                      2
                                    };        // 0, 1, 2 のいずれか
        // 問題情報
        private int QuestionIndex = 0;      // 現在の問題インデックス
        private int QuestionCount = 3;      // 問題数
        private int CorrectCount = 0;       // 正解数
        private bool Finish = false;

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
            labelQuestion.Text = QuestionString[q];
            radioAnswer1.Text = AnswerString[q, 0];
            radioAnswer2.Text = AnswerString[q, 1];
            radioAnswer3.Text = AnswerString[q, 2];
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
            int a = AnswerIndex[q];
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
            if (QuestionIndex < QuestionCount - 1 )
            {
                // 次の問題へ
                QuestionIndex += 1;
                InitForm();
            }
            else
            {
                // 正解率の計算
                double ratio = (double)CorrectCount / (double)QuestionCount * 100.0;

                // 正解リスト作成
                string answer = "";
                for (int i = 0; i < QuestionCount; i++)
                {
                    int j = AnswerIndex[i];
                    answer += string.Format("Q{0}. {1}\n", i+1, AnswerString[i, j]);
                }

                // メッセージ表示
                if (ratio == 100.0)
                {
                    string msg = string.Format("全問正解！\n正解率は {0:0.00}% です！\n\n{1}", ratio, answer);
                    MessageBox.Show(msg, "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
