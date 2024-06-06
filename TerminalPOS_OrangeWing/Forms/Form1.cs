using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TerminalPOS_Orangewing
{
    public partial class Form1 : Form
    {
        private string _device;
        private string _host;
        private string _port;
        private string _delay;

        private ServerRequest _serverRequest = new ServerRequest();
        private PHPServer _phpServer = new PHPServer();
        private DataListener _dataListener;

        Dictionary<RoundSwichButton, string> deviceSelected = new Dictionary<RoundSwichButton, string>();
        Dictionary<RoundSwichButton, string> timeDelays = new Dictionary<RoundSwichButton, string>();
        public static List<RoundSwichButton> DeviceSwitches = new List<RoundSwichButton>();
        public static List<RoundSwichButton> DelaySwitches = new List<RoundSwichButton>();

        public Form1()
        {
            InitializeComponent();

            PortConfigInput.TextChanged += new EventHandler(ConfigPort_Input);
            IPConfigInput.TextChanged += new EventHandler(ConfigIP_Input);
            ApplyButton.Click += new EventHandler(ApplyButton_Click);

            InjenicoSwich.Click += new EventHandler(DeviseSwitches_Click);
            Pax930Swich.Click += new EventHandler(DeviseSwitches_Click);
            TapXphoneSwich.Click += new EventHandler(DeviseSwitches_Click);
            VerifoneSwich.Click += new EventHandler(DeviseSwitches_Click);
            TapXphoneInitializeButton.Click += new EventHandler(TapXphoneInitialize_Click);

            Delay1SecSwich.Click += new EventHandler(DelaySwitches_Click);
            Delay3SecSwich.Click += new EventHandler(DelaySwitches_Click);
            Delay7SecSwich.Click += new EventHandler(DelaySwitches_Click);

            ConnectButton.Click += new EventHandler(ConnectButton_Click);
            CloseButton.Click += new EventHandler(CloseApplication);

            _phpServer.serverState += PhpServer_State;
            _dataListener = new DataListener(LogTextBox);
            _dataListener.ExternalAmount += DataListener_External;

            timeDelays = new Dictionary<RoundSwichButton, string>
            {
                [Delay1SecSwich] = "1000",
                [Delay3SecSwich] = "3000",
                [Delay7SecSwich] = "7000"
            };

            deviceSelected = new Dictionary<RoundSwichButton, string>
            {
                [VerifoneSwich] = "Verifone",
                [InjenicoSwich] = "Injenico",
                [Pax930Swich] = "Pax930",
                [TapXphoneSwich] = "TapXphone",
            };
        }

        #region ConfigInput
        private void ConfigIP_Input(object sender, EventArgs e)
        {
            if (sender is RoundTextBox tbx)
            {
                string[] parts = tbx.Text.Split('.');
                bool isCompleteIP = parts.Length == 4 && parts.All(part => !string.IsNullOrEmpty(part));

                bool isValidIP = isCompleteIP && parts.All(part =>
                {
                    int num;
                    return int.TryParse(part, out num) && num >= 0 && num <= 255;
                });

                if (isValidIP)
                {
                    tbx.BackColor = SystemColors.Window;
                    tbx.ValidInput = true;
                }
                else
                {
                    tbx.ValidInput = false;
                    tbx.BackColor = Color.LightPink;
                }
                tbx.KeyDown += ValidateInput;
            }
        }

        private void ConfigPort_Input(object sender, EventArgs e)
        {
            if (sender is RoundTextBox tbx)
            {
                if (tbx.Text.Length == 0 || int.TryParse(tbx.Text, out _))
                {
                    tbx.BackColor = SystemColors.Window;
                    tbx.ValidInput = true;
                }
                else
                {
                    tbx.ValidInput = false;
                    tbx.BackColor = Color.LightPink;
                }
                tbx.KeyDown += ValidateInput;
            }
        }

        private void ValidateInput(object sender, KeyEventArgs e)
        {
            RoundTextBox tbx = sender as RoundTextBox;
            if (e.KeyCode == Keys.Enter && tbx.ValidInput)
            {
                e.SuppressKeyPress = true;
                ApplyButton.Focus();
            }
        }

        bool _configIsApply;
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (IPConfigInput.ValidInput && PortConfigInput.ValidInput)
            {
                _host = IPConfigInput.Text;
                _port = PortConfigInput.Text;
                _configIsApply = true;
                WriteLog("   | Configuration ip address: " + _host + "  port: " + _port, sender, e);
            }
        }
        #endregion

        #region SelectDevice
        private void DeviseSwitches_Click(object sender, EventArgs e)
        {
            OneIsActive(DeviceSwitches, sender, e);
            RoundSwichButton activeSwich = sender as RoundSwichButton;
            _device = deviceSelected[activeSwich];
            if (_device == "TapXphone")
            {
                ActivateTapXphoneInitialization(sender,e);
            }
            else
            {
                WriteLog("   | Device Selected  ->  " + _device, sender, e);
                TapXphoneInitializeButton.Enabled = false;
            }
        }

        private void ActivateTapXphoneInitialization(object sender, EventArgs e)
        {
            TapXphoneInitializeButton.Enabled = true;
            WriteLog("   | Initialize TapXphone POS terminal!", sender, e);
        }

        private void TapXphoneInitialize_Click(object sender, EventArgs e)
        {
            WriteLog("   | Device Selected  ->  " + _device, sender, e);
        }

        private void DelaySwitches_Click(object sender, EventArgs e)
        {
            OneIsActive(DelaySwitches, sender, e);
            RoundSwichButton activeSwich = sender as RoundSwichButton;
            _delay = timeDelays[activeSwich];
            WriteLog("   | Network delay connection selected " + activeSwich.Text, sender, e);
        }

        private void OneIsActive(List<RoundSwichButton> switchButtons, object sender, EventArgs e)
        {
            if (sender is RoundSwichButton swich)
            {
                foreach (var button in switchButtons)
                {
                    if (button != swich)
                    {
                        button.SwichOn = false;
                        button.UpdateOnPaint();
                    }
                }
                swich.SwichOn = true;

                if (!switchButtons.Contains(swich))
                {
                    switchButtons.Add(swich);
                }
            }
        }
        #endregion

        #region Connect
        bool _isConnected = false;
        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_configIsApply)
                {
                    ConnectButton.Enabled = false;
                    ConnectionStatusOutputLabel.Visible = false;
                    LoadingGifPictureBox.Visible = true;

                    string responseMessage = await _serverRequest.ConnectRequest(_host, _port, _delay);
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseMessage);
                    bool isConnected = jsonResponse.is_conected;
                    _isConnected = isConnected;
                    Connected_Status(isConnected, sender, e);
                    WriteLog("   | Server response " + jsonResponse.is_conected, sender, e);
                    if (jsonResponse.errorCode == "payment_declined")
                    {
                        WriteLog("   | Оплата відхилена користувачем", sender, e);
                    }
                }
                else
                {
                    WriteLog("   | Apply configuration!", sender, e);
                }
            }
            catch
            {
                WriteLog("   | Not found PHP server", sender, e);
            }
        }

        private void Connected_Status(bool isConnected, object sender, EventArgs e)
        {
            if(isConnected)
            {
                LoadingGifPictureBox.Visible = false;
                ConnectionStatusOutputLabel.Visible = true;
                ConnectButton.Enabled = false;
                ConnectionStatusOutputLabel.ForeColor = Color.FromArgb(100, 148, 102);
                ConnectionStatusOutputLabel.Text = "Connect";
                WriteLog("   | Connection successful", sender, e);
            }
            else
            {
                LoadingGifPictureBox.Visible = false;
                ConnectionStatusOutputLabel.Visible = true;
                ConnectButton.Enabled = true;
                ConnectionStatusOutputLabel.ForeColor = Color.FromArgb(191, 59, 116);
                ConnectionStatusOutputLabel.Text = "Disconnect";
                WriteLog("   | Connection unsuccessful", sender, e);
            }
        }
        #endregion

        private void PhpServer_State(object sender, stringEventArgs e)
        {
            string message = e.Message;
            WriteLog(message, sender, e);
        }

        private async void DataListener_External(object sender, stringEventArgs e)
        {
            try
            {
                string _amount = e.Message;
                string responseMessage = await _serverRequest.PaymentRequest(_device, _host, _port, _amount, _delay);

                dynamic jsonResponse = JsonConvert.DeserializeObject(responseMessage);
                WriteLog(responseMessage, sender, e);
            }
            catch
            {
                WriteLog("   | Not found PHP server", sender, e);
            }

        }

        private void WriteLog(string message, object sender, EventArgs e)
        {
            LogTextBox.AppendText(Environment.NewLine + message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _phpServer.Start();
            _dataListener.StartServer();


            IPConfigInput.Text = "192.168.31.134";
            PortConfigInput.Text = "2000";
            
            DeviseSwitches_Click(VerifoneSwich, EventArgs.Empty);
            DelaySwitches_Click(Delay1SecSwich, EventArgs.Empty);

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ClientSize = new Size(960, 540);
            MaximizeBox = false;
            
            notifyIcon.BalloonTipTitle = "Airnur POS";
            notifyIcon.BalloonTipText = "Application minimized";
            notifyIcon.Text = "Airnur POS";
        }
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MaximizeAplication(sender, e);
            }
            else if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(Cursor.Position);
            }
        }

        public void MaximizeAplication(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           _phpServer.Stop();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            { notifyIcon.Visible = false; }
        }
    }
}
