using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level3
{
    class Question
    {
        // プロパティ
        public string QuestionString = "";
        public string[] AnswerString = { "", "", "" };
        public int AnswerIndex = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Question()
        {
            // 形だけ用意
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="q">お題</param>
        /// <param name="a1">回答1</param>
        /// <param name="a2">回答2</param>
        /// <param name="a3">回答3</param>
        /// <param name="index">正解インデックス</param>
        public Question(string q, string a1, string a2, string a3, int index)
        {
            QuestionString = q;
            AnswerString[0] = a1;
            AnswerString[1] = a2;
            AnswerString[2] = a3;
            AnswerIndex = index;
        }
    }
}
