using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level3
{
    class SoundWave
    {
        #region "Private変数"
        private SoundPlayer Player = new SoundPlayer();   // サウンドプレーヤー
        private string WavFileCorrect = "Correct.wav";    // 正解音
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
        #endregion

        /// <summary>
        /// 音源の再生
        /// </summary>
        public void Play()
        {
            // WAVファイル
            string wavdir = ProgramDirectory;     // プログラムディレクトリ
            string wavfile = System.IO.Path.Combine(wavdir, WavFileCorrect);
            Player = new SoundPlayer(wavfile);
            // 再生
            Player.Play();
        }

        /// <summary>
        /// 再生停止
        /// </summary>
        public void Stop()
        {
            if (Player != null)
            {
                // 停止
                Player.Stop();
                // 破棄
                Player.Dispose();
                Player = null;
            }
        }

    }
}
