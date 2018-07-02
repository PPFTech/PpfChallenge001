using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level3
{
    class QuestionFile
    {
        #region "Private変数"
        // プロパティ
        private string FileName = "QA.csv";

        // 読み込みデータ
        private List<Question> QuestionList = new List<Question>();
        #endregion

        #region "プロパティ"
        /// <summary>
        /// プログラムの階層のパス(読み取り専用)
        /// </summary>
        /// <returns></returns>
        public string ProgramDirectory
        {
            get
            {
                // プログラムと同じ階層のディレクトリを取得
                string execpath = Application.ExecutablePath;                           // 実行パス
                string execdir = System.IO.Directory.GetParent(execpath).ToString();    // 親ディレクトリ
                //string progdir = System.IO.Path.GetFullPath(execdir + "\\..\\..\\");    // 2つ上の階層へ

                return execdir;
            }
        }

        /// <summary>
        /// Q&Aデータ(読み取り専用)
        /// </summary>
        public List<Question> Questions
        {
            get
            { 
                return QuestionList;
            }
        }

        /// <summary>
        /// Q&Aデータ数(読み取り専用)
        /// </summary>
        public int Count
        {
            get
            {
                return QuestionList.Count();
            }
        }
        #endregion

        #region "コンストラクタ"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public QuestionFile()
        {
            Clear();
        }
        #endregion

        #region "メソッド"
        /// <summary>
        /// データクリア
        /// </summary>
        private void Clear()
        {
            QuestionList.Clear();
        }

        /// <summary>
        /// ファイル読み込み
        /// </summary>
        public bool Read()
        {
            // プログラムと同じ階層にある定義ファイルのパスを取得する
            string filepath = System.IO.Path.Combine(ProgramDirectory, FileName);  

            // ファイル読み込み
            try
            {
                StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding("SHIFT_JIS"));
                ReadData(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message + "\nQ&A定義ファイルの読み込みに失敗しました。\nプログラムを終了します。";
                MessageBox.Show(msg, "ファイル読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// ファイル内のデータを読み込む
        /// </summary>
        /// <param name="sr">入力ストリーム</param>
        private void ReadData(StreamReader sr)
        {
            // Questionリストをクリア
            QuestionList.Clear();

            // 1行ずつ読み込み(行がなくなれば終了)
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                // 最初の行が Question から始まっていれば、処理を飛ばす
                if (line.StartsWith("Question")) continue;

                // カンマ区切りで分割する
                string[] ary = line.Split(',');
                if (ary.Length < 5) continue;   // 要素数が足りない場合は処理を飛ばす

                // Questionクラスにデータを設定
                Question q = new Question();
                q.QuestionString = ary[0].Trim();
                q.AnswerString[0] = ary[1].Trim();
                q.AnswerString[1] = ary[2].Trim();
                q.AnswerString[2] = ary[3].Trim();
                q.AnswerIndex = int.Parse(ary[4].Trim());

                // お題に改行コードが入っていれば置き換える
                q.QuestionString = q.QuestionString.Replace("<CR>", "\n");

                // Questionリストに読み込みデータを追加
                QuestionList.Add(q);
            }
        }
        #endregion

    }
}
