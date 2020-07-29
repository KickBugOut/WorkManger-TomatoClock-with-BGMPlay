using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;

namespace SpeechUtils
{
    public class TTSUtils
    {
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        #region 只能读数字和英文
        //public void SayC
        //string text = textBox1.Text;

        //if (text.Trim().Length != 0)
        //{
        // speech.Rate = 5;//语速
        // speech.SelectVoice("Microsoft Lili");//设置播音员（中文）
        // //speech.SelectVoice("Microsoft Anna"); //英文
        // speech.Volume = 100; //音量
        // speech.SpeakAsync(textBox1.Text);//语音阅读方法
        //} 
        #endregion

        #region 可以读取中文
        public static void SayChinese(string phrase)
        { 
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Rate = 2;//语速 
            speech.Volume = 100; //音量
            CultureInfo keyboardCulture = System.Windows.Forms.InputLanguage.CurrentInputLanguage.Culture;
            InstalledVoice neededVoice = speech.GetInstalledVoices(keyboardCulture).FirstOrDefault();
            if (neededVoice == null)
            {
                phrase = "Unsupported Language";
            }
            else if (!neededVoice.Enabled)
            {
                phrase = "Voice Disabled";
            }
            else
            {
                speech.SelectVoice(neededVoice.VoiceInfo.Name);
            } 
            speech.Speak(phrase); 
        }
            #endregion
    } 
}
