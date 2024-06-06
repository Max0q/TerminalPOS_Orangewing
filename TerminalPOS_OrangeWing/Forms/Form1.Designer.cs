namespace TerminalPOS_Orangewing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomButtonGroupBox = new TerminalPOS_Orangewing.RoundGroupBox();
            this.InsertPHPFileButton = new TerminalPOS_Orangewing.RoundButton();
            this.ResponseFileButton = new TerminalPOS_Orangewing.RoundButton();
            this.CloseButton = new TerminalPOS_Orangewing.RoundButton();
            this.LogTextBox = new TerminalPOS_Orangewing.RoundTextBox();
            this.ConnectionDelayGroupBox = new TerminalPOS_Orangewing.RoundGroupBox();
            this.Delay7SecSwich = new TerminalPOS_Orangewing.RoundSwichButton();
            this.Delay3SecSwich = new TerminalPOS_Orangewing.RoundSwichButton();
            this.Delay1SecSwich = new TerminalPOS_Orangewing.RoundSwichButton();
            this.ConnectionDelayLabel = new System.Windows.Forms.Label();
            this.POSDeviceGroupBox = new TerminalPOS_Orangewing.RoundGroupBox();
            this.TapXphoneSwich = new TerminalPOS_Orangewing.RoundSwichButton();
            this.Pax930Swich = new TerminalPOS_Orangewing.RoundSwichButton();
            this.InjenicoSwich = new TerminalPOS_Orangewing.RoundSwichButton();
            this.VerifoneSwich = new TerminalPOS_Orangewing.RoundSwichButton();
            this.TapXphoneInitializeButton = new TerminalPOS_Orangewing.RoundButton();
            this.PosDevicelabel = new System.Windows.Forms.Label();
            this.ConfigGroupBox = new TerminalPOS_Orangewing.RoundGroupBox();
            this.PortConfigInput = new TerminalPOS_Orangewing.RoundTextBox();
            this.IPConfigInput = new TerminalPOS_Orangewing.RoundTextBox();
            this.ApplyButton = new TerminalPOS_Orangewing.RoundButton();
            this.ConfiguratiobLabel = new System.Windows.Forms.Label();
            this.ConnectionStatusGroupBox = new TerminalPOS_Orangewing.RoundGroupBox();
            this.ConnectButton = new TerminalPOS_Orangewing.RoundButton();
            this.LoadingGifPictureBox = new System.Windows.Forms.PictureBox();
            this.ConnectionStatusOutputLabel = new System.Windows.Forms.Label();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.BottomButtonGroupBox.SuspendLayout();
            this.ConnectionDelayGroupBox.SuspendLayout();
            this.POSDeviceGroupBox.SuspendLayout();
            this.ConfigGroupBox.SuspendLayout();
            this.ConnectionStatusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGifPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("e-Ukraine Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.TitleLabel.Location = new System.Drawing.Point(417, 23);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(437, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "TERMINAL POS PAYMENT";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(115, 52);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.closeToolStripMenuItem.Text = "Open";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.MaximizeAplication);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.CloseApplication);
            // 
            // BottomButtonGroupBox
            // 
            this.BottomButtonGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BottomButtonGroupBox.BackColor = System.Drawing.Color.White;
            this.BottomButtonGroupBox.Controls.Add(this.InsertPHPFileButton);
            this.BottomButtonGroupBox.Controls.Add(this.ResponseFileButton);
            this.BottomButtonGroupBox.Controls.Add(this.CloseButton);
            this.BottomButtonGroupBox.Location = new System.Drawing.Point(43, 498);
            this.BottomButtonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BottomButtonGroupBox.Name = "BottomButtonGroupBox";
            this.BottomButtonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BottomButtonGroupBox.Radious = 9;
            this.BottomButtonGroupBox.Size = new System.Drawing.Size(344, 171);
            this.BottomButtonGroupBox.TabIndex = 16;
            this.BottomButtonGroupBox.TabStop = false;
            this.BottomButtonGroupBox.Text = "roundGroupBox3";
            // 
            // InsertPHPFileButton
            // 
            this.InsertPHPFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertPHPFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.InsertPHPFileButton.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.InsertPHPFileButton.ButtonNoActiveColor = System.Drawing.Color.Orange;
            this.InsertPHPFileButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.InsertPHPFileButton.ButtonRoundRadius = 10;
            this.InsertPHPFileButton.Font = new System.Drawing.Font("e-Ukraine Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertPHPFileButton.ForeColor = System.Drawing.Color.White;
            this.InsertPHPFileButton.Location = new System.Drawing.Point(0, 0);
            this.InsertPHPFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertPHPFileButton.Name = "InsertPHPFileButton";
            this.InsertPHPFileButton.Size = new System.Drawing.Size(344, 54);
            this.InsertPHPFileButton.TabIndex = 13;
            this.InsertPHPFileButton.Text = "Insert index.php file ";
            // 
            // ResponseFileButton
            // 
            this.ResponseFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResponseFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.ResponseFileButton.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.ResponseFileButton.ButtonNoActiveColor = System.Drawing.Color.Orange;
            this.ResponseFileButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.ResponseFileButton.ButtonRoundRadius = 10;
            this.ResponseFileButton.Font = new System.Drawing.Font("e-Ukraine Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseFileButton.ForeColor = System.Drawing.Color.White;
            this.ResponseFileButton.Location = new System.Drawing.Point(0, 58);
            this.ResponseFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResponseFileButton.Name = "ResponseFileButton";
            this.ResponseFileButton.Size = new System.Drawing.Size(344, 54);
            this.ResponseFileButton.TabIndex = 14;
            this.ResponseFileButton.Text = "Response file";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseButton.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.ButtonNoActiveColor = System.Drawing.Color.Orange;
            this.CloseButton.ButtonPressedColor = System.Drawing.Color.Maroon;
            this.CloseButton.ButtonRoundRadius = 10;
            this.CloseButton.Font = new System.Drawing.Font("e-Ukraine Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(0, 114);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(344, 54);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.LogTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogTextBox.Font = new System.Drawing.Font("e-Ukraine", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTextBox.Location = new System.Drawing.Point(425, 186);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Radius = 9;
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(819, 484);
            this.LogTextBox.TabIndex = 1;
            this.LogTextBox.Text = "   ";
            // 
            // ConnectionDelayGroupBox
            // 
            this.ConnectionDelayGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectionDelayGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ConnectionDelayGroupBox.Controls.Add(this.Delay7SecSwich);
            this.ConnectionDelayGroupBox.Controls.Add(this.Delay3SecSwich);
            this.ConnectionDelayGroupBox.Controls.Add(this.Delay1SecSwich);
            this.ConnectionDelayGroupBox.Controls.Add(this.ConnectionDelayLabel);
            this.ConnectionDelayGroupBox.Location = new System.Drawing.Point(43, 385);
            this.ConnectionDelayGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectionDelayGroupBox.Name = "ConnectionDelayGroupBox";
            this.ConnectionDelayGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectionDelayGroupBox.Radious = 9;
            this.ConnectionDelayGroupBox.Size = new System.Drawing.Size(344, 110);
            this.ConnectionDelayGroupBox.TabIndex = 13;
            this.ConnectionDelayGroupBox.TabStop = false;
            this.ConnectionDelayGroupBox.Text = "roundGroupBox5";
            // 
            // Delay7SecSwich
            // 
            this.Delay7SecSwich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Delay7SecSwich.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.Delay7SecSwich.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.Delay7SecSwich.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Delay7SecSwich.ButtonRoundRadius = 10;
            this.Delay7SecSwich.Font = new System.Drawing.Font("e-Ukraine", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delay7SecSwich.Location = new System.Drawing.Point(231, 48);
            this.Delay7SecSwich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delay7SecSwich.Name = "Delay7SecSwich";
            this.Delay7SecSwich.Size = new System.Drawing.Size(105, 50);
            this.Delay7SecSwich.TabIndex = 26;
            this.Delay7SecSwich.Text = "7 second";
            // 
            // Delay3SecSwich
            // 
            this.Delay3SecSwich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Delay3SecSwich.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.Delay3SecSwich.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.Delay3SecSwich.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Delay3SecSwich.ButtonRoundRadius = 10;
            this.Delay3SecSwich.Font = new System.Drawing.Font("e-Ukraine", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delay3SecSwich.Location = new System.Drawing.Point(120, 48);
            this.Delay3SecSwich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delay3SecSwich.Name = "Delay3SecSwich";
            this.Delay3SecSwich.Size = new System.Drawing.Size(105, 50);
            this.Delay3SecSwich.TabIndex = 25;
            this.Delay3SecSwich.Text = "3 second";
            // 
            // Delay1SecSwich
            // 
            this.Delay1SecSwich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Delay1SecSwich.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.Delay1SecSwich.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.Delay1SecSwich.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Delay1SecSwich.ButtonRoundRadius = 10;
            this.Delay1SecSwich.Font = new System.Drawing.Font("e-Ukraine", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delay1SecSwich.Location = new System.Drawing.Point(9, 48);
            this.Delay1SecSwich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delay1SecSwich.Name = "Delay1SecSwich";
            this.Delay1SecSwich.Size = new System.Drawing.Size(105, 50);
            this.Delay1SecSwich.TabIndex = 24;
            this.Delay1SecSwich.Text = "1 second";
            // 
            // ConnectionDelayLabel
            // 
            this.ConnectionDelayLabel.AutoSize = true;
            this.ConnectionDelayLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionDelayLabel.Font = new System.Drawing.Font("e-Ukraine Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionDelayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.ConnectionDelayLabel.Location = new System.Drawing.Point(5, 12);
            this.ConnectionDelayLabel.Name = "ConnectionDelayLabel";
            this.ConnectionDelayLabel.Size = new System.Drawing.Size(281, 20);
            this.ConnectionDelayLabel.TabIndex = 2;
            this.ConnectionDelayLabel.Text = "Selectable connection delay:";
            this.ConnectionDelayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // POSDeviceGroupBox
            // 
            this.POSDeviceGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.POSDeviceGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.POSDeviceGroupBox.Controls.Add(this.TapXphoneSwich);
            this.POSDeviceGroupBox.Controls.Add(this.Pax930Swich);
            this.POSDeviceGroupBox.Controls.Add(this.InjenicoSwich);
            this.POSDeviceGroupBox.Controls.Add(this.VerifoneSwich);
            this.POSDeviceGroupBox.Controls.Add(this.TapXphoneInitializeButton);
            this.POSDeviceGroupBox.Controls.Add(this.PosDevicelabel);
            this.POSDeviceGroupBox.Location = new System.Drawing.Point(43, 225);
            this.POSDeviceGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.POSDeviceGroupBox.Name = "POSDeviceGroupBox";
            this.POSDeviceGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.POSDeviceGroupBox.Radious = 9;
            this.POSDeviceGroupBox.Size = new System.Drawing.Size(344, 156);
            this.POSDeviceGroupBox.TabIndex = 7;
            this.POSDeviceGroupBox.TabStop = false;
            this.POSDeviceGroupBox.Text = "roundGroupBox4";
            // 
            // TapXphoneSwich
            // 
            this.TapXphoneSwich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.TapXphoneSwich.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.TapXphoneSwich.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.TapXphoneSwich.ButtonPressedForeColor = System.Drawing.Color.White;
            this.TapXphoneSwich.ButtonRoundRadius = 10;
            this.TapXphoneSwich.Font = new System.Drawing.Font("e-Ukraine", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TapXphoneSwich.Location = new System.Drawing.Point(253, 46);
            this.TapXphoneSwich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TapXphoneSwich.Name = "TapXphoneSwich";
            this.TapXphoneSwich.Size = new System.Drawing.Size(83, 50);
            this.TapXphoneSwich.TabIndex = 23;
            this.TapXphoneSwich.Text = "TapXphone";
            // 
            // Pax930Swich
            // 
            this.Pax930Swich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Pax930Swich.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.Pax930Swich.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.Pax930Swich.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Pax930Swich.ButtonRoundRadius = 10;
            this.Pax930Swich.Font = new System.Drawing.Font("e-Ukraine", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pax930Swich.Location = new System.Drawing.Point(171, 46);
            this.Pax930Swich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pax930Swich.Name = "Pax930Swich";
            this.Pax930Swich.Size = new System.Drawing.Size(80, 50);
            this.Pax930Swich.TabIndex = 22;
            this.Pax930Swich.Text = "PAX 930";
            // 
            // InjenicoSwich
            // 
            this.InjenicoSwich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.InjenicoSwich.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.InjenicoSwich.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.InjenicoSwich.ButtonPressedForeColor = System.Drawing.Color.White;
            this.InjenicoSwich.ButtonRoundRadius = 10;
            this.InjenicoSwich.Font = new System.Drawing.Font("e-Ukraine", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InjenicoSwich.Location = new System.Drawing.Point(88, 46);
            this.InjenicoSwich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InjenicoSwich.Name = "InjenicoSwich";
            this.InjenicoSwich.Size = new System.Drawing.Size(80, 50);
            this.InjenicoSwich.TabIndex = 19;
            this.InjenicoSwich.Text = "Injenico";
            // 
            // VerifoneSwich
            // 
            this.VerifoneSwich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.VerifoneSwich.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.VerifoneSwich.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.VerifoneSwich.ButtonPressedForeColor = System.Drawing.Color.White;
            this.VerifoneSwich.ButtonRoundRadius = 10;
            this.VerifoneSwich.Font = new System.Drawing.Font("e-Ukraine", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VerifoneSwich.Location = new System.Drawing.Point(5, 46);
            this.VerifoneSwich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VerifoneSwich.Name = "VerifoneSwich";
            this.VerifoneSwich.Size = new System.Drawing.Size(80, 50);
            this.VerifoneSwich.TabIndex = 17;
            this.VerifoneSwich.Text = "Verifone";
            // 
            // TapXphoneInitializeButton
            // 
            this.TapXphoneInitializeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.TapXphoneInitializeButton.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.TapXphoneInitializeButton.ButtonNoActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.TapXphoneInitializeButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.TapXphoneInitializeButton.ButtonRoundRadius = 10;
            this.TapXphoneInitializeButton.Font = new System.Drawing.Font("e-Ukraine Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapXphoneInitializeButton.ForeColor = System.Drawing.Color.White;
            this.TapXphoneInitializeButton.Location = new System.Drawing.Point(5, 105);
            this.TapXphoneInitializeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TapXphoneInitializeButton.Name = "TapXphoneInitializeButton";
            this.TapXphoneInitializeButton.Size = new System.Drawing.Size(331, 39);
            this.TapXphoneInitializeButton.TabIndex = 4;
            this.TapXphoneInitializeButton.Text = "TapXphone initialization";
            // 
            // PosDevicelabel
            // 
            this.PosDevicelabel.AutoSize = true;
            this.PosDevicelabel.BackColor = System.Drawing.Color.Transparent;
            this.PosDevicelabel.Font = new System.Drawing.Font("e-Ukraine Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosDevicelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.PosDevicelabel.Location = new System.Drawing.Point(5, 12);
            this.PosDevicelabel.Name = "PosDevicelabel";
            this.PosDevicelabel.Size = new System.Drawing.Size(122, 20);
            this.PosDevicelabel.TabIndex = 2;
            this.PosDevicelabel.Text = "POS Device:";
            this.PosDevicelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfigGroupBox
            // 
            this.ConfigGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfigGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ConfigGroupBox.Controls.Add(this.PortConfigInput);
            this.ConfigGroupBox.Controls.Add(this.IPConfigInput);
            this.ConfigGroupBox.Controls.Add(this.ApplyButton);
            this.ConfigGroupBox.Controls.Add(this.ConfiguratiobLabel);
            this.ConfigGroupBox.Location = new System.Drawing.Point(43, 82);
            this.ConfigGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfigGroupBox.Name = "ConfigGroupBox";
            this.ConfigGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfigGroupBox.Radious = 9;
            this.ConfigGroupBox.Size = new System.Drawing.Size(344, 139);
            this.ConfigGroupBox.TabIndex = 1;
            this.ConfigGroupBox.TabStop = false;
            this.ConfigGroupBox.Text = "roundGroupBox1";
            // 
            // PortConfigInput
            // 
            this.PortConfigInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortConfigInput.Location = new System.Drawing.Point(231, 46);
            this.PortConfigInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PortConfigInput.MaxLength = 4;
            this.PortConfigInput.Name = "PortConfigInput";
            this.PortConfigInput.Radius = 9;
            this.PortConfigInput.Size = new System.Drawing.Size(103, 27);
            this.PortConfigInput.TabIndex = 17;
            this.PortConfigInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IPConfigInput
            // 
            this.IPConfigInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPConfigInput.Location = new System.Drawing.Point(9, 46);
            this.IPConfigInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPConfigInput.MaxLength = 16;
            this.IPConfigInput.Name = "IPConfigInput";
            this.IPConfigInput.Radius = 9;
            this.IPConfigInput.Size = new System.Drawing.Size(216, 27);
            this.IPConfigInput.TabIndex = 16;
            this.IPConfigInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.ApplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ApplyButton.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.ApplyButton.ButtonNoActiveColor = System.Drawing.Color.Orange;
            this.ApplyButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.ApplyButton.ButtonRoundRadius = 10;
            this.ApplyButton.Font = new System.Drawing.Font("e-Ukraine Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.ForeColor = System.Drawing.Color.White;
            this.ApplyButton.Location = new System.Drawing.Point(5, 89);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(331, 39);
            this.ApplyButton.TabIndex = 4;
            this.ApplyButton.Text = "Apply";
            // 
            // ConfiguratiobLabel
            // 
            this.ConfiguratiobLabel.AutoSize = true;
            this.ConfiguratiobLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfiguratiobLabel.Font = new System.Drawing.Font("e-Ukraine Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfiguratiobLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.ConfiguratiobLabel.Location = new System.Drawing.Point(5, 12);
            this.ConfiguratiobLabel.Name = "ConfiguratiobLabel";
            this.ConfiguratiobLabel.Size = new System.Drawing.Size(148, 20);
            this.ConfiguratiobLabel.TabIndex = 2;
            this.ConfiguratiobLabel.Text = "Configuration:";
            this.ConfiguratiobLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConnectionStatusGroupBox
            // 
            this.ConnectionStatusGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectionStatusGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ConnectionStatusGroupBox.Controls.Add(this.ConnectButton);
            this.ConnectionStatusGroupBox.Controls.Add(this.LoadingGifPictureBox);
            this.ConnectionStatusGroupBox.Controls.Add(this.ConnectionStatusOutputLabel);
            this.ConnectionStatusGroupBox.Controls.Add(this.ConnectionStatusLabel);
            this.ConnectionStatusGroupBox.Location = new System.Drawing.Point(425, 82);
            this.ConnectionStatusGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectionStatusGroupBox.Name = "ConnectionStatusGroupBox";
            this.ConnectionStatusGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectionStatusGroupBox.Radious = 9;
            this.ConnectionStatusGroupBox.Size = new System.Drawing.Size(819, 86);
            this.ConnectionStatusGroupBox.TabIndex = 3;
            this.ConnectionStatusGroupBox.TabStop = false;
            this.ConnectionStatusGroupBox.Text = "roundGroupBox2";
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(142)))));
            this.ConnectButton.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.ConnectButton.ButtonNoActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(139)))), ((int)(((byte)(172)))));
            this.ConnectButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.ConnectButton.ButtonRoundRadius = 10;
            this.ConnectButton.Font = new System.Drawing.Font("e-Ukraine Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Location = new System.Drawing.Point(637, 14);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(168, 60);
            this.ConnectButton.TabIndex = 7;
            this.ConnectButton.Text = "Connect";
            // 
            // LoadingGifPictureBox
            // 
            this.LoadingGifPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LoadingGifPictureBox.ErrorImage = null;
            this.LoadingGifPictureBox.Image = global::TerminalPOS_Orangewing.Properties.Resources._34338d26023e5515f6cc8969aa027bca;
            this.LoadingGifPictureBox.Location = new System.Drawing.Point(245, 30);
            this.LoadingGifPictureBox.Name = "LoadingGifPictureBox";
            this.LoadingGifPictureBox.Size = new System.Drawing.Size(25, 25);
            this.LoadingGifPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingGifPictureBox.TabIndex = 17;
            this.LoadingGifPictureBox.TabStop = false;
            this.LoadingGifPictureBox.Visible = false;
            // 
            // ConnectionStatusOutputLabel
            // 
            this.ConnectionStatusOutputLabel.AutoSize = true;
            this.ConnectionStatusOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionStatusOutputLabel.Font = new System.Drawing.Font("e-Ukraine Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(59)))), ((int)(((byte)(116)))));
            this.ConnectionStatusOutputLabel.Location = new System.Drawing.Point(229, 31);
            this.ConnectionStatusOutputLabel.Name = "ConnectionStatusOutputLabel";
            this.ConnectionStatusOutputLabel.Size = new System.Drawing.Size(117, 20);
            this.ConnectionStatusOutputLabel.TabIndex = 3;
            this.ConnectionStatusOutputLabel.Text = "Disconnect";
            this.ConnectionStatusOutputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("e-Ukraine Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(25, 31);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(191, 20);
            this.ConnectionStatusLabel.TabIndex = 2;
            this.ConnectionStatusLabel.Text = "Connection status:";
            this.ConnectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 704);
            this.Controls.Add(this.BottomButtonGroupBox);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.ConnectionDelayGroupBox);
            this.Controls.Add(this.POSDeviceGroupBox);
            this.Controls.Add(this.ConfigGroupBox);
            this.Controls.Add(this.ConnectionStatusGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "POS Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.BottomButtonGroupBox.ResumeLayout(false);
            this.ConnectionDelayGroupBox.ResumeLayout(false);
            this.ConnectionDelayGroupBox.PerformLayout();
            this.POSDeviceGroupBox.ResumeLayout(false);
            this.POSDeviceGroupBox.PerformLayout();
            this.ConfigGroupBox.ResumeLayout(false);
            this.ConfigGroupBox.PerformLayout();
            this.ConnectionStatusGroupBox.ResumeLayout(false);
            this.ConnectionStatusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGifPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ConfiguratiobLabel;
        private RoundGroupBox ConnectionStatusGroupBox;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Label ConnectionStatusOutputLabel;
        private RoundButton ApplyButton;
        private RoundGroupBox ConfigGroupBox;
        private RoundButton ConnectButton;
        private RoundGroupBox POSDeviceGroupBox;
        private RoundButton TapXphoneInitializeButton;
        private System.Windows.Forms.Label PosDevicelabel;
        private RoundGroupBox ConnectionDelayGroupBox;
        private System.Windows.Forms.Label ConnectionDelayLabel;
        private RoundButton InsertPHPFileButton;
        private RoundButton ResponseFileButton;
        private RoundButton CloseButton;
        private RoundTextBox LogTextBox;
        private RoundTextBox PortConfigInput;
        private RoundTextBox IPConfigInput;
        private RoundGroupBox BottomButtonGroupBox;
        private RoundSwichButton VerifoneSwich;
        private RoundSwichButton TapXphoneSwich;
        private RoundSwichButton Pax930Swich;
        private RoundSwichButton InjenicoSwich;
        private RoundSwichButton Delay1SecSwich;
        private RoundSwichButton Delay7SecSwich;
        private RoundSwichButton Delay3SecSwich;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.PictureBox LoadingGifPictureBox;
    }
}

