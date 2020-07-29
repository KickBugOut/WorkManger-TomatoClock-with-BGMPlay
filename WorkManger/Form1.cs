using Exercise;
using HZH_Controls;
using HZH_Controls.Controls;
using SpeechUtils;
using Station;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;
using System.Xml.Serialization;
using WorkManger.Properties;
using static WorkManger.SystemSetting;

namespace WorkManger
{
    public partial class Tomata : Form
    {
        public Tomata()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            CheckForIllegalCrossThreadCalls = false;
            this.ProcessWave.Value = 0;
            this.WorkingState.Visible = true;
            player.MediaEnded += Player_MediaEnded;
            DirectoryInfo dir = new DirectoryInfo(SongFilePath);
            songfileInfo = dir.GetFiles("*.wav", SearchOption.TopDirectoryOnly);
            this.listView1.Items.Add("无");
            foreach (FileInfo f in songfileInfo)
            {
                int count = this.listView1.Items.Count;
                string space = "";
                if (count == 0) space = "    ";
                if (f.Extension.ToLower() == ".wav")
                    this.listView1.Items.Add(space + (this.listView1.Items.Count).ToString() + "." + f.Name.Replace(f.Extension, ""));
            }
            SystemTimer.Start();
            this.LoadConfig();
        }
        private string ConfigXmlPath = Application.StartupPath + "\\setting.Config";
        private XmlDocument setDoc = new XmlDocument();
        private DateTime CloseTime;
        private void Check()
        {
            if (File.Exists(ConfigXmlPath) == false)
            {
                MakeDefaultSetting();
            }

        }
        private void MakeDefaultSetting()
        {
            XmlNode Declare = setDoc.CreateNode(XmlNodeType.XmlDeclaration, "PlaySetting", "");
            setDoc.AppendChild(Declare);
            XmlNode root = setDoc.CreateElement("", "Root", "");

            XmlElement VolumeElement = setDoc.CreateElement("Volume");
            XmlAttribute VolumeValue = setDoc.CreateAttribute("Value");
            VolumeValue.Value = this.volumeTrackBar.Value.ToString();
            VolumeElement.SetAttributeNode(VolumeValue);
            root.AppendChild(VolumeElement);



            XmlElement ModeElement = setDoc.CreateElement("PlayMode");
            XmlAttribute ModeValue = setDoc.CreateAttribute("Value");


            ModeValue.Value = ((int)(this.PlayMode)).ToString();
            ModeElement.SetAttributeNode(ModeValue);
            root.AppendChild(ModeElement);

            XmlElement OpenStartElement = setDoc.CreateElement("OpenStart");
            XmlAttribute OpenStartValue = setDoc.CreateAttribute("CheckValue");
            OpenStartValue.Value = this.ucCheckBox_OpenStart.Checked.ToString();
            OpenStartElement.SetAttributeNode(OpenStartValue);
            root.AppendChild(OpenStartElement);

            XmlElement TimeCloseElement = setDoc.CreateElement("TimeClose"); 
            XmlAttribute CheckValue = setDoc.CreateAttribute("CheckValue");
            CheckValue.Value = this.ucCheckBox_OpenStart.Checked.ToString();

            XmlAttribute TimeCloseValue = setDoc.CreateAttribute("TimeValue");
            TimeCloseValue.Value = this.CloseTime.ToString();

            TimeCloseElement.SetAttributeNode(CheckValue); 
            TimeCloseElement.SetAttributeNode(TimeCloseValue);

            root.AppendChild(TimeCloseElement);

            setDoc.AppendChild(root);

            setDoc.Save(ConfigXmlPath);


        }
        private PlayModes playMode = PlayModes.PlayListRepeat;
        private PlayModes PlayMode
        {
            get
            {
                return this.playMode;
            }
            set
            {
                if (this.playMode.Equals(value) == true) return;
                this.playMode = value;
                switch (value)
                {
                    case PlayModes.PlayListRepeat: this.btn_Playmode.BackgroundImage = Resources.PLayListCircle;
                        this.btn_Playmode.Text = "列表循环";
                        break;
                    case PlayModes.Random: this.btn_Playmode.BackgroundImage = Resources.random;
                        this.btn_Playmode.Text = "随机播放";
                        break;
                    case PlayModes.Sequence: this.btn_Playmode.BackgroundImage = Resources.Sequncespng;
                        this.btn_Playmode.Text = "顺序播放";
                        break;
                    case PlayModes.Single: this.btn_Playmode.BackgroundImage = Resources.singlePlay;
                        this.btn_Playmode.Text = "单曲播放";
                        break;
                    case PlayModes.SingleRepeat: this.btn_Playmode.BackgroundImage = Resources.singleRepeat;
                        this.btn_Playmode.Text = "单曲循环";
                        break;
                }
                this.btn_Playmode.Text = "";
            }
        }
        private enum PlayModes
        {
            PlayListRepeat = 0,
            Random = 1,
            Sequence = 2,
            SingleRepeat = 3,
            Single = 4
        }

        private void LoadConfig()
        {
            Check();
            try
            {
                XmlDocument readDoc = new XmlDocument();
                readDoc.Load(this.ConfigXmlPath);
                XmlNode rootNode = readDoc.SelectSingleNode("Root");

                XmlElement ValueElement = (XmlElement)rootNode.SelectSingleNode("Volume");
                string valueStr = ValueElement.Attributes["Value"].Value;
                this.volumeTrackBar.Value = float.Parse(valueStr);


                XmlElement PlayModeElement = (XmlElement)rootNode.SelectSingleNode("PlayMode");
                this.PlayMode = (PlayModes)int.Parse(PlayModeElement.Attributes["Value"].Value);

                XmlElement OpenStartElement = (XmlElement)rootNode.SelectSingleNode("OpenStart");
                this.ucCheckBox_OpenStart.Checked = bool.Parse(OpenStartElement.Attributes["CheckValue"].Value);


                XmlElement CloseTimeElement = (XmlElement)rootNode.SelectSingleNode("TimeClose");
                this.ucCheckBox_CloseTime.Checked = bool.Parse(CloseTimeElement.Attributes["CheckValue"].Value);
                this.dateTimePicker1.Value = DateTime.Parse(CloseTimeElement.Attributes["TimeValue"].Value);

            }
            catch (Exception ex)
            {
                if (File.Exists(this.ConfigXmlPath)) File.Delete(this.ConfigXmlPath);
                Check();
                MessageBox.Show(ex.Message);
            }

        }
        private void SaveConfig()
        {
            Check();
            try
            {
                XmlDocument readDoc = new XmlDocument();
                readDoc.Load(this.ConfigXmlPath);
                XmlNode rootNode = readDoc.SelectSingleNode("Root");

                XmlElement ValueElement = (XmlElement)rootNode.SelectSingleNode("Volume");
                ValueElement.Attributes["Value"].Value = this.volumeTrackBar.Value.ToString();


                XmlElement PlayModeElement = (XmlElement)rootNode.SelectSingleNode("PlayMode");
                PlayModeElement.Attributes["Value"].Value = ((int)(this.PlayMode)).ToString();


                XmlElement OpenStartElement = (XmlElement)rootNode.SelectSingleNode("OpenStart");
                OpenStartElement.Attributes["CheckValue"].Value = (this.ucCheckBox_OpenStart.Checked).ToString();


                XmlElement CloseTimeElement = (XmlElement)rootNode.SelectSingleNode("TimeClose");
                CloseTimeElement.Attributes["CheckValue"].Value = (this.ucCheckBox_CloseTime.Checked).ToString();
                CloseTimeElement.Attributes["TimeValue"].Value = (this.CloseTime).ToString();

                readDoc.Save(this.ConfigXmlPath);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void Set(XmlNode node, string innerText)
        {

        }
        private string SongFilePath = Application.StartupPath + "\\songs";
        private FileInfo[] songfileInfo;
        private void Player_MediaEnded(object sender, EventArgs e)
        {
            //if(Cirlcle)
            //player.Position = new TimeSpan(0); 
            //else
            //{
            //    this.listView1_DoubleClick(null, null);
            //}
            if(this.listView1.SelectedItems.Count>0)
            PlaySong(PlayIndex = this.listView1.SelectedItems[0].Index);
        }
        int PlayIndex = 0;
        private void PlaySong(int index)
        {
            if (this.listView1.Items.Count == 0 || index==0) return;
            switch (this.PlayMode)
            {
                case PlayModes.PlayListRepeat:
                    PlayIndex = PlayIndex < this.listView1.Items.Count - 1 ? ++PlayIndex : 1;
                    break;
                case PlayModes.Random:
                    Random rmd = new Random();
                    PlayIndex = rmd.Next(0, this.listView1.Items.Count - 1);
                    break;
                case PlayModes.Sequence:
                    PlayIndex = PlayIndex < this.listView1.Items.Count - 1 ? ++PlayIndex : -1;
                    if (PlayIndex == -1)
                    {
                        this.player.Stop();
                        return;
                    }
                    break;
                case PlayModes.Single:
                    this.player.Stop();
                    return;
                case PlayModes.SingleRepeat:
                    ;
                    break;
            }
            if (PlayIndex == 0)
            {
                this.player.Stop();
                return;
            }

            this.listView1.Items[this.listView1.SelectedItems[0].Index].Selected = false;
            this.listView1.Items[PlayIndex].Selected = true;
            this.listView1.EnsureVisible(PlayIndex);
            this.listView1.Update();
            this.CurrentFile = new Uri(this.songfileInfo[PlayIndex - 1].FullName);
            this.player.Open(this.CurrentFile);
            this.player.Play();
        }


        bool Cirlcle = false;
        public int WorkingTime = 30;
        public int RelaxTime = 5;

        private MediaPlayer player = new MediaPlayer();
        private Uri CurrentFile;
        //SoundPlayer player = new SoundPlayer();
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (this.ProcessWave.Value > 0)
            {
                this.ProcessWave.Value--;
                this.LeftTimeLabel.Text = this.LeftTimeString(this.ProcessWave.Value);
                if (isWorking) this.WorkingState.Text = "精神小伙工作中…";
                else this.WorkingState.Text = "精神小伙休息中…";
            }
            else if (this.ProcessWave.Value == 0)
            {
                if (isWorking)
                {
                    new Thread(() => { 
                        TTSUtils.SayChinese("休息时间到");
                    }).Start();
                        player.Stop();
                        player.Open(CurrentFile = new Uri(Application.StartupPath + "\\alarms\\Helium.wav"));
                        player.Play(); //启用新线程播放  
                        this.WorkingState.Text = "精神小伙休息中…";
                        isWorking = false;
                        isWaiting = true;
                        this.ProcessWave.MaxValue = RelaxTime * 60;
                        this.ProcessWave.Value = this.ProcessWave.MaxValue;
                }
                else
                { 
                    new Thread(() =>
                    {
                        TTSUtils.SayChinese("工作时间到");
                    }).Start();
                        player.Stop();
                        player.Open(CurrentFile = new Uri(Application.StartupPath + "\\ringtones\\Callisto.wav"));
                        player.Play(); //启用新线程播放 ));    
                        this.WorkingState.Text = "精神小伙要工作了…";

                        isWorking = true;
                        isWaiting = false;
                        this.ProcessWave.MaxValue = WorkingTime * 60;
                        this.ProcessWave.Value = this.ProcessWave.MaxValue;
                }
                this.Cirlcle = false;
            }
        }
        private string LeftTimeString(int value)
        {
            int leftH, LeftM, LeftS;

            leftH = value / (60 * 60);
            LeftM = (value - leftH * 60 * 60) / (60);
            LeftS = (value - leftH * 60 * 60 - LeftM * 60);

            if (leftH > 0)
            {
                return leftH + "小时" + LeftM + " 分钟" + LeftS + "秒";
            }
            else if (LeftM > 0)
            {
                return LeftM + " 分钟" + LeftS + "秒";
            }
            else
            {
                return LeftS + "秒";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Bitmap bg = new Bitmap(this.listView1.Width, this.listView1.Height);
            Graphics g = Graphics.FromImage(Resources.BG_Cir_s);
            g.DrawImage(bg, this.listView1.Width, this.listView1.Height);
            this.listView1.BackgroundImage = bg;   
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("精神小伙，要退出吗？", "精神小伙不玩了", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                player.Stop();
                Application.Exit();
            }
        }

        bool isWorking = false;
        bool isWaiting = false;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private void btn_Play_Click(object sender, EventArgs e)
        {
            this.WorkingState.Visible = true;
            timer.Enabled = !timer.Enabled;
            if (!timer.Enabled)
            {
                this.WorkingState.Text = "精神小伙暂停中";
                this.player.Pause();
            }
            else
            {
                this.player.Play();
            }
            btn_Play.BackgroundImage = timer.Enabled ? Resources.pause : Resources.play;
        }

        private void ProcessWave_Load(object sender, EventArgs e)
        {
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).Focus();
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }
        bool isDown;
        float currentEx;
        float currentEy;

        float offsetX;
        float offsetY;
        private void ProcessWave_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            currentEx = e.X;
            currentEy = e.Y; 
        }

        private void ProcessWave_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void ProcessWave_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                offsetX = e.X - currentEx;
                offsetY = e.Y - currentEy;

                this.Location = new Point(this.Location.X + (int)offsetX, this.Location.Y + (int)offsetY);
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            this.WorkingState.Text = "精神小伙要重启";
            this.LeftTimeLabel.Text = "";
            isWorking = false;
            isWaiting = false;
            this.ProcessWave.Value = 0;
            timer.Enabled = false;
            timer.Enabled = true;
        }

        private void ucTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.player.Volume = this.volumeTrackBar.Value / 100.0f;
        }
        double volumeBefoMute = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.player.IsMuted)
                volumeBefoMute = this.player.Volume;
            this.player.IsMuted = !this.player.IsMuted;
            this.button2.BackgroundImage = this.player.IsMuted ? Resources.mute : Resources.speaker;
            this.volumeTrackBar.Value = this.player.IsMuted ? 0f : (float)volumeBefoMute * 100;
        }

        private void btn_foward_Click(object sender, EventArgs e)
        {
            this.ProcessWave.Value = 0;
            if (this.player.Source != null)
                this.player.Position = this.player.NaturalDuration.TimeSpan;
        }
        bool Inlist = false;

        [Obsolete]
        private void ucHorizontalList1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).Left = this.ProcessWave.Left;
            Inlist = true;
            if (ListViewWait != null && ListViewWait.IsAlive)
            {
                ListViewWait.Suspend();
            }
        }
        Thread ListViewWait;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0) return;
            int index = this.listView1.Items.IndexOf(this.listView1.SelectedItems[0]);
            if (index == 0) {
                this.player.Stop();
                return;
            }
            this.CurrentFile = new Uri(this.songfileInfo[index - 1].FullName);
            this.player.Open(this.CurrentFile);
            this.player.Play();
            Cirlcle = true;
        }

        [Obsolete]
        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            if (this.ListViewWait == null || this.ListViewWait.ThreadState == System.Threading.ThreadState.Aborted || this.ListViewWait.IsAlive == false)
            {
                (this.ListViewWait = new Thread(() =>
                {
                    Thread.Sleep(1000);
                    this.listView1.Left = this.Width - 1;
                })).Start();
            } else
            {
                if (ListViewWait.ThreadState == System.Threading.ThreadState.Suspended)
                {
                    ListViewWait.Resume();
                    ListViewWait.Abort();
                }
            }
        }

        private void WorkingState_LocationChanged(object sender, EventArgs e)
        {
        }
        bool MOVE = false;
        Thread MainFormToTheBound;
        private void Tomata_LocationChanged(object sender, EventArgs e)
        {
            if (MOVE) return;
            if (MainFormToTheBound == null || MainFormToTheBound.IsAlive == false)
                Move();

        }
        private void Move()
        {

            (MainFormToTheBound = new Thread(() =>
            {
                Thread.Sleep(1000);
                while (isDown) ;
                int difLeft = Screen.PrimaryScreen.WorkingArea.Width - this.Left;
                int difTop = Screen.PrimaryScreen.WorkingArea.Height - this.Top;

                if (Math.Abs(difLeft) > Math.Abs(difTop))
                {
                    MOVE = true;
                    isDown = false;
                    int plus = difTop > Screen.PrimaryScreen.WorkingArea.Height ? 1 : -1;
                    while (this.Top != 0)
                    {
                        this.Top += plus;
                        Thread.Sleep(new TimeSpan(10));
                    }
                    MOVE = false;
                }
                else
                {
                    MOVE = true;
                    isDown = false;
                    int plus = difLeft > this.Width ? 1 : -1;

                    while (this.Left != (Screen.PrimaryScreen.WorkingArea.Width - this.Width))
                    {
                        this.Left += plus;
                        Thread.Sleep(new TimeSpan(10));
                    }
                    MOVE = false;
                }

            })).Start();
        }
        private void WorkingState_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.listView1.SendToBack();
            }
        }

        private void ProcessWave_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                this.ProcessWave.SendToBack();
            }
        }

        private void UcRadioButton3_CheckedChangeEvent(object sender, EventArgs e)
        {
            if (this.ucRadioButton3.Checked)
            {

                this.panel1.Visible = true;
                this.listView1.Visible = false;
                this.ProcessWave.Visible = false;
            }
        }

        private void ucRadioButton2_CheckedChangeEvent(object sender, EventArgs e)
        { 
            if (ucRadioButton2.Checked)
            {
                this.ProcessWave.Visible = true;
                this.listView1.Visible = false;
                this.panel1.Visible = false;
            }
        }

        private void ucRadioButton1_CheckedChangeEvent(object sender, EventArgs e)
        {
             
            if (ucRadioButton1.Checked)
            {
                this.listView1.Visible = true;
                this.panel1.Visible = false;
                this.ProcessWave.Visible = false;
            }
        }
        CancellationTokenSource CancelShutDown;
        private void SystemTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now; 
            if (this.ucCheckBox_CloseTime.Checked && ((int)(now.TimeOfDay.TotalSeconds)).Equals((int)this.CloseTime.TimeOfDay.TotalSeconds))
            {
                MessageBox.Show("系统将于60s后自动关机，请及时关闭保存文件！", "番茄钟", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CancelShutDown = new CancellationTokenSource();
                new Thread(() => {
                    int count = 0;
                    this.Invoke(new Action(() =>
                    {
                        this.timer.Enabled = true;
                        this.btn_Play_Click(null, null);
                        this.player.Stop();
                    }));
                    while(count<60)
                    {
                        count++;
                        if (CancelShutDown.IsCancellationRequested == true)
                        {
                            return;
                        }
                        this.WorkingState.Text = String.Format("{0}S后关闭系统", 60 - count);
                        Thread.Sleep(1000);
                    }

                    if(MessageBox.Show("系统即将关机，请确认文件是否全部保存确定立即关机，取消进入休眠模式！", "番茄钟", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
                    {
                        WindowsController.ExitWindows(RestartOptions.PowerOff, false);
                    }
                    else
                    {

                        WindowsController.ExitWindows(RestartOptions.Hibernate, false);
                    }

                }).Start();
            }
            string flag = "";
            if (now.Hour > 0 && now.Hour <= 5) flag = "凌晨";
            else if (now.Hour > 5 && now.Hour <= 7) flag = "早晨";
            else if (now.Hour > 7 && now.Hour <= 11) flag = "上午";
            else if (now.Hour > 11 && now.Hour <= 13) flag = "中午";
            else if (now.Hour > 13 && now.Hour <= 17) flag = "下午";
            else if (now.Hour > 17 && now.Hour <= 19) flag = "傍晚";
            else if (now.Hour > 19 && now.Hour <= 23) flag = "晚上";
            else if (now.Hour > 23 && now.Hour <= 0) flag = "子夜";
            this.label1.Text = now.Year.ToString() + "/" + now.Month.ToString() + "/" + now.Day.ToString() + " " + flag + now.Hour.ToString("D2") + ":" + now.Minute.ToString("D2") + ":" + now.Second.ToString("D2");
            if ((now.Minute==0||now.Minute == 30) && now.Second == 20) {
                new Thread(() => {
                    string minutes = "";
                    if (now.Minute == 30) minutes = "半";
                    TTSUtils.SayChinese("现在是："+flag + (now.Hour%12).ToString() + "点" + minutes);
                }).Start();
            }
        }

        private void Tomata_MouseLeave(object sender, EventArgs e)
        {
            isDown = false;
        }

        private void LeftTimeLabel_MouseLeave(object sender, EventArgs e)
        {
            this.isDown = false;
        }

        private void btn_Playmode_Click(object sender, EventArgs e)
        {  
            this.PlayMode = (PlayModes)((int)this.PlayMode < (int)PlayModes.Single ? ++this.PlayMode : 0);
        }
         
        private void UcCheckBox_OpenStart_CheckedChangeEvent(object sender, EventArgs e)
        {
            if (ucCheckBox_OpenStart.Checked)
            {
                SystemSetting.SetMeAutoStart(true);
            }
            else
            { 
                SystemSetting.SetMeAutoStart(false);
            }
        }

        private void UcCheckBox_CloseTime_CheckedChangeEvent(object sender, EventArgs e)
        {
            this.dateTimePicker1.Visible = this.ucCheckBox_CloseTime.Checked;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.CloseTime = this.dateTimePicker1.Value;
        }
    }
}
