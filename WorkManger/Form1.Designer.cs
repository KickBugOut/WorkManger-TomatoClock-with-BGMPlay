namespace WorkManger
{
    partial class Tomata
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            this.SaveConfig();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tomata));
            this.ProcessWave = new HZH_Controls.Controls.UCProcessWave();
            this.volumeTrackBar = new HZH_Controls.Controls.UCTrackBar();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_foward = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SystemTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Playmode = new System.Windows.Forms.Button();
            this.ucBtnsGroup1 = new HZH_Controls.Controls.UCBtnsGroup();
            this.ucRadioButton3 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton2 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton1 = new HZH_Controls.Controls.UCRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ucCheckBox_CloseTime = new HZH_Controls.Controls.UCCheckBox();
            this.ucCheckBox_OpenStart = new HZH_Controls.Controls.UCCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.WorkingState = new System.Windows.Forms.Label();
            this.LeftTimeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessWave
            // 
            this.ProcessWave.AutoSize = true;
            this.ProcessWave.BackColor = System.Drawing.Color.Black;
            this.ProcessWave.CausesValidation = false;
            this.ProcessWave.ConerRadius = 0;
            this.ProcessWave.FillColor = System.Drawing.Color.Empty;
            this.ProcessWave.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessWave.ForeColor = System.Drawing.Color.LightSalmon;
            this.ProcessWave.IsRadius = false;
            this.ProcessWave.IsRectangle = false;
            this.ProcessWave.IsShowRect = false;
            this.ProcessWave.Location = new System.Drawing.Point(68, 83);
            this.ProcessWave.Margin = new System.Windows.Forms.Padding(0);
            this.ProcessWave.MaxValue = 100;
            this.ProcessWave.Name = "ProcessWave";
            this.ProcessWave.RectColor = System.Drawing.Color.White;
            this.ProcessWave.RectWidth = 4;
            this.ProcessWave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProcessWave.Size = new System.Drawing.Size(210, 210);
            this.ProcessWave.TabIndex = 2;
            this.ProcessWave.TabStop = false;
            this.ProcessWave.Value = 16;
            this.ProcessWave.ValueColor = System.Drawing.Color.Aqua;
            this.ProcessWave.Load += new System.EventHandler(this.ProcessWave_Load);
            this.ProcessWave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseClick);
            this.ProcessWave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseDown);
            this.ProcessWave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseMove);
            this.ProcessWave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseUp);
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackBar.DcimalDigits = 0;
            this.volumeTrackBar.IsShowTips = true;
            this.volumeTrackBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.volumeTrackBar.LineWidth = 10F;
            this.volumeTrackBar.Location = new System.Drawing.Point(273, 350);
            this.volumeTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volumeTrackBar.MaxValue = 100F;
            this.volumeTrackBar.MinValue = 0F;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(72, 40);
            this.volumeTrackBar.TabIndex = 1;
            this.volumeTrackBar.Text = "ucTrackBar1";
            this.volumeTrackBar.TipsFormat = null;
            this.volumeTrackBar.Value = 50F;
            this.volumeTrackBar.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.volumeTrackBar.ValueChanged += new System.EventHandler(this.ucTrackBar1_ValueChanged);
            this.volumeTrackBar.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.volumeTrackBar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(333, 66);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(1, 4);
            this.checkedListBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WorkManger.Properties.Resources.speaker;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(231, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_foward
            // 
            this.btn_foward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_foward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_foward.BackColor = System.Drawing.Color.Transparent;
            this.btn_foward.BackgroundImage = global::WorkManger.Properties.Resources.forward;
            this.btn_foward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_foward.FlatAppearance.BorderSize = 0;
            this.btn_foward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_foward.Location = new System.Drawing.Point(71, 350);
            this.btn_foward.Margin = new System.Windows.Forms.Padding(4);
            this.btn_foward.Name = "btn_foward";
            this.btn_foward.Size = new System.Drawing.Size(40, 40);
            this.btn_foward.TabIndex = 11;
            this.btn_foward.UseVisualStyleBackColor = false;
            this.btn_foward.Click += new System.EventHandler(this.btn_foward_Click);
            this.btn_foward.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_foward.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_restart
            // 
            this.btn_restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_restart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_restart.BackColor = System.Drawing.Color.Transparent;
            this.btn_restart.BackgroundImage = global::WorkManger.Properties.Resources.restart_;
            this.btn_restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_restart.FlatAppearance.BorderSize = 0;
            this.btn_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restart.Image = global::WorkManger.Properties.Resources.restart_;
            this.btn_restart.Location = new System.Drawing.Point(125, 350);
            this.btn_restart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(40, 40);
            this.btn_restart.TabIndex = 10;
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            this.btn_restart.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_restart.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.BackgroundImage = global::WorkManger.Properties.Resources.play;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Location = new System.Drawing.Point(19, 350);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(40, 40);
            this.btn_Play.TabIndex = 5;
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CausesValidation = false;
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(68, 83);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(210, 210);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.Visible = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // SystemTimer
            // 
            this.SystemTimer.Interval = 1000;
            this.SystemTimer.Tick += new System.EventHandler(this.SystemTimer_Tick);
            // 
            // btn_Playmode
            // 
            this.btn_Playmode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Playmode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Playmode.BackColor = System.Drawing.Color.Transparent;
            this.btn_Playmode.BackgroundImage = global::WorkManger.Properties.Resources.PLayListCircle;
            this.btn_Playmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Playmode.FlatAppearance.BorderSize = 0;
            this.btn_Playmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Playmode.Font = new System.Drawing.Font("宋体", 5F);
            this.btn_Playmode.ForeColor = System.Drawing.Color.Red;
            this.btn_Playmode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Playmode.Location = new System.Drawing.Point(179, 350);
            this.btn_Playmode.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Playmode.Name = "btn_Playmode";
            this.btn_Playmode.Size = new System.Drawing.Size(40, 40);
            this.btn_Playmode.TabIndex = 30;
            this.btn_Playmode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Playmode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Playmode.UseVisualStyleBackColor = false;
            this.btn_Playmode.Click += new System.EventHandler(this.btn_Playmode_Click);
            // 
            // ucBtnsGroup1
            // 
            this.ucBtnsGroup1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnsGroup1.DataSource = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("ucBtnsGroup1.DataSource")));
            this.ucBtnsGroup1.IsMultiple = false;
            this.ucBtnsGroup1.Location = new System.Drawing.Point(7, 298);
            this.ucBtnsGroup1.MinimumSize = new System.Drawing.Size(0, 50);
            this.ucBtnsGroup1.Name = "ucBtnsGroup1";
            this.ucBtnsGroup1.SelectItem = ((System.Collections.Generic.List<string>)(resources.GetObject("ucBtnsGroup1.SelectItem")));
            this.ucBtnsGroup1.Size = new System.Drawing.Size(340, 50);
            this.ucBtnsGroup1.TabIndex = 32;
            // 
            // ucRadioButton3
            // 
            this.ucRadioButton3.BackColor = System.Drawing.Color.Transparent;
            this.ucRadioButton3.Checked = false;
            this.ucRadioButton3.GroupName = null;
            this.ucRadioButton3.Location = new System.Drawing.Point(192, 323);
            this.ucRadioButton3.Name = "ucRadioButton3";
            this.ucRadioButton3.Size = new System.Drawing.Size(17, 17);
            this.ucRadioButton3.TabIndex = 38;
            this.ucRadioButton3.TextValue = "";
            this.ucRadioButton3.CheckedChangeEvent += new System.EventHandler(this.UcRadioButton3_CheckedChangeEvent);
            // 
            // ucRadioButton2
            // 
            this.ucRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.ucRadioButton2.Checked = true;
            this.ucRadioButton2.GroupName = null;
            this.ucRadioButton2.Location = new System.Drawing.Point(165, 323);
            this.ucRadioButton2.Name = "ucRadioButton2";
            this.ucRadioButton2.Size = new System.Drawing.Size(17, 17);
            this.ucRadioButton2.TabIndex = 37;
            this.ucRadioButton2.TextValue = "";
            this.ucRadioButton2.CheckedChangeEvent += new System.EventHandler(this.ucRadioButton2_CheckedChangeEvent);
            // 
            // ucRadioButton1
            // 
            this.ucRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucRadioButton1.Checked = false;
            this.ucRadioButton1.GroupName = null;
            this.ucRadioButton1.Location = new System.Drawing.Point(137, 323);
            this.ucRadioButton1.Name = "ucRadioButton1";
            this.ucRadioButton1.Size = new System.Drawing.Size(17, 17);
            this.ucRadioButton1.TabIndex = 36;
            this.ucRadioButton1.TextValue = "";
            this.ucRadioButton1.CheckedChangeEvent += new System.EventHandler(this.ucRadioButton1_CheckedChangeEvent);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.ucCheckBox_CloseTime);
            this.panel1.Controls.Add(this.ucCheckBox_OpenStart);
            this.panel1.Location = new System.Drawing.Point(68, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 213);
            this.panel1.TabIndex = 39;
            this.panel1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Coral;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Bisque;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FloralWhite;
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 31);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // ucCheckBox_CloseTime
            // 
            this.ucCheckBox_CloseTime.BackColor = System.Drawing.Color.Transparent;
            this.ucCheckBox_CloseTime.Checked = false;
            this.ucCheckBox_CloseTime.ForeColor = System.Drawing.Color.White;
            this.ucCheckBox_CloseTime.Location = new System.Drawing.Point(6, 69);
            this.ucCheckBox_CloseTime.Name = "ucCheckBox_CloseTime";
            this.ucCheckBox_CloseTime.Padding = new System.Windows.Forms.Padding(1);
            this.ucCheckBox_CloseTime.Size = new System.Drawing.Size(201, 30);
            this.ucCheckBox_CloseTime.TabIndex = 1;
            this.ucCheckBox_CloseTime.TextValue = "定时关机";
            this.ucCheckBox_CloseTime.CheckedChangeEvent += new System.EventHandler(this.UcCheckBox_CloseTime_CheckedChangeEvent);
            // 
            // ucCheckBox_OpenStart
            // 
            this.ucCheckBox_OpenStart.BackColor = System.Drawing.Color.Transparent;
            this.ucCheckBox_OpenStart.Checked = false;
            this.ucCheckBox_OpenStart.ForeColor = System.Drawing.Color.White;
            this.ucCheckBox_OpenStart.Location = new System.Drawing.Point(5, 33);
            this.ucCheckBox_OpenStart.Name = "ucCheckBox_OpenStart";
            this.ucCheckBox_OpenStart.Padding = new System.Windows.Forms.Padding(1);
            this.ucCheckBox_OpenStart.Size = new System.Drawing.Size(202, 30);
            this.ucCheckBox_OpenStart.TabIndex = 0;
            this.ucCheckBox_OpenStart.TextValue = "开机自启动";
            this.ucCheckBox_OpenStart.CheckedChangeEvent += new System.EventHandler(this.UcCheckBox_OpenStart_CheckedChangeEvent);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(0, 441);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "2010/00/00 00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseUp);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = global::WorkManger.Properties.Resources.closepng;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(0, 399);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(347, 42);
            this.btn_Exit.TabIndex = 41;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // WorkingState
            // 
            this.WorkingState.BackColor = System.Drawing.Color.Transparent;
            this.WorkingState.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkingState.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.WorkingState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WorkingState.Location = new System.Drawing.Point(0, 0);
            this.WorkingState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkingState.Name = "WorkingState";
            this.WorkingState.Size = new System.Drawing.Size(347, 32);
            this.WorkingState.TabIndex = 42;
            this.WorkingState.Text = "努力工作吧，精神小伙";
            this.WorkingState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WorkingState.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseDown);
            this.WorkingState.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseMove);
            this.WorkingState.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseUp);
            // 
            // LeftTimeLabel
            // 
            this.LeftTimeLabel.AutoEllipsis = true;
            this.LeftTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeftTimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftTimeLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.LeftTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LeftTimeLabel.Location = new System.Drawing.Point(0, 32);
            this.LeftTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LeftTimeLabel.Name = "LeftTimeLabel";
            this.LeftTimeLabel.Size = new System.Drawing.Size(347, 34);
            this.LeftTimeLabel.TabIndex = 43;
            this.LeftTimeLabel.Text = "0s";
            this.LeftTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeftTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseDown);
            this.LeftTimeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseMove);
            this.LeftTimeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProcessWave_MouseUp);
            // 
            // Tomata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(347, 475);
            this.Controls.Add(this.LeftTimeLabel);
            this.Controls.Add(this.WorkingState);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucRadioButton3);
            this.Controls.Add(this.ucRadioButton2);
            this.Controls.Add(this.ucRadioButton1);
            this.Controls.Add(this.btn_Playmode);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_foward);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.ucBtnsGroup1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ProcessWave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tomata";
            this.Text = "Tomato";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Tomata_LocationChanged);
            this.MouseLeave += new System.EventHandler(this.Tomata_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCProcessWave ProcessWave;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_foward;
        private System.Windows.Forms.Button button2;
        private HZH_Controls.Controls.UCTrackBar volumeTrackBar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer SystemTimer;
        private System.Windows.Forms.Button btn_Playmode;
        private HZH_Controls.Controls.UCBtnsGroup ucBtnsGroup1;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton3;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton2;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton1;
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCCheckBox ucCheckBox_OpenStart;
        private HZH_Controls.Controls.UCCheckBox ucCheckBox_CloseTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label WorkingState;
        private System.Windows.Forms.Label LeftTimeLabel;
    }
}

